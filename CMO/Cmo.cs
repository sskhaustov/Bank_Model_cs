using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMO
{
    class Cmo
    {
        delegate bool in_queue(Client _cl);
        private new Operator[] kasses; //кассы
        private new Queue[] clients; //очереди
        private int all_clients; //число пришедших клиентов
        private int refused_clients; //число отказов
        private int tot_xchg; //всего хсhg
        private int tot_acnt; //всего acnt
        private int tot_cred; //всего cred
        private int tot_card; //всего card
        private int day_time; //рабочий день
        private new int[] tot_info; //время работы каждой кассы 
        private bool is_working; //True - система принимает заявки, False - нет
        Random rnd = new Random();
        public int ID; //ID заявки/клиента
        private int time; //время работы с заявкой
        public int creating_time; //случайные промежутки времени, через которые появляются клиенты
        request_type RT; //тип заявки
        public Cmo()
        {
            ID = 0;
            time = 0;
            creating_time = 0;
            all_clients = 0;
            tot_xchg = 0;
            tot_acnt = 0;
            tot_cred = 0;
            tot_card = 0;
            day_time = 0;
            is_working = true;
            refused_clients = 0;
            RT = request_type.NONE;
        }
        public Cmo(int _max_count)
        {
            set_start_id();
            time = 0;
            all_clients = 0;
            refused_clients = 0;
            tot_xchg = 0;
            tot_acnt = 0;
            tot_cred = 0;
            tot_card = 0;
            is_working = true;
            day_time = 300; //рабочий день - 5 минут))
            set_random_creatime();
            RT = request_type.NONE;
            clients = new Queue[2];
            clients[0] = new Queue(_max_count); //очередь на 1-2 кассы (обмен)
            clients[1] = new Queue(_max_count); //очередь на 3-7 кассы (остальные операции)
            kasses = new Operator[7];
            for (int i = 0; i < 7; i++)
            {
                if (i < 2)
                    kasses[i] = new Operator(kassa_type.N12);
                else
                    kasses[i] = new Operator(kassa_type.N37);
            }
        }
        public Queue get_queue(int i) //просмотреть очередь
        {
            return clients[i % 2];
        }
        public void dec_day_time()
        {
            if (day_time > 0) day_time--;
            if ((day_time == 60) && (is_working == true))
            {
                is_working = false; //окончен прием заявок
            }
        }
        public Operator get_kassa(int i) //просмотреть обслуживающее устройство
        {
            return kasses[i % 7];
        }
        public Operator[] get_kasses() //просмотреть все кассы
        {
            return kasses;
        }
        private void set_start_id() //начальное значеение id
        {
            ID = rnd.Next(5000);
        }
        public void set_random_creatime() //задает случайные промежутки времени
        {
            creating_time = rnd.Next(15)+1; //макс. интервал - 15 сек.
        }
        private Request create_request() //генерация заявки
        {
            int caser;
            caser = rnd.Next(4); //тип заявки выбирается случайным образом
            switch (caser)
            {
                case 0:
                    RT = request_type.ACNT;
                    time = 30;
                    tot_acnt++;
                    break;
                case 1:
                    RT = request_type.CARD;
                    time = 80;
                    tot_card++;
                    break;
                case 2:
                    RT = request_type.CRED;
                    time = 60;
                    tot_cred++;
                    break;
                case 3:
                    RT = request_type.XCHG;
                    time = 50;
                    tot_xchg++;
                    break;
            }
            Request r = new Request(ID++, time, true, RT);
            return r;
        }
        private Client create_client() //создание клиента автоматически
        {
            int max;
            max = rnd.Next(2) + 2;
            Client cl = new Client(ID++, max);
            for (int i = 0; i < max; i++)
                cl.add_request(create_request());
            set_random_creatime(); //время до следующего клиента
            return cl;
        }
        public void create_client(int _max, Request[] _rec) //создание клиента вручную
        {
            Client cl = new Client(ID++, _max);
            for (int i = 0; i < _max; i++)
            {
                cl.add_request(_rec[i]);
            }
            into_queue(cl);
        }
        public void into_queue(Client cl)
        {
            bool flag;
            int check = 0; //проверка на наличие заявок, отличных от типа XCHG
            all_clients++; //клиент +1
            for (int i = 0; i < cl.req_max_count; i++)
                if (cl.get_request(i).operation != request_type.XCHG)
                    check++;
            //определяем, в какую очередь поставить клиента
            if (check == 0)
            {
                cl.state = client_state.Queued; //клиент поставлен в очередь
                in_queue q = clients[0].enqueue; //вызов функции с использованием делегата
                flag = q(cl);
                //flag = clients[0].enqueue(cl); //обмен
            }
            else
            {
                cl.state = client_state.Queued;
                in_queue q = clients[1].enqueue; //вызов функции с использованием делегата
                flag = q(cl);
                //flag = clients[1].enqueue(cl); //прочее
            }
            if (!flag)
            {
                cl.state = client_state.Refused; //не поставлен
                refused_clients++; //отказано в обслуживании (все очереди переполнены)
            }
        }
        public void check_kassa()
        {
            bool flag;
            Client r = new Client();
            for (int i = 0; i < 7; i++)
            {
                if (kasses[i].state == operator_state.NotReady) //касса отработала
                {
                    //сначала убираем клиента
                    if (!kasses[i].is_empty())
                        if (i >= 2) //если в кассах 3-7 есть клиенты с заявкими ХСНG, то переносим их в 1-ю очередь
                        {
                            r = kasses[i].remove_client(); //убираем клиента
                            r.state = client_state.Checked;
                            if (r.get_req_done() != r.req_max_count) //если у клиента еще остались заявки ХСНG
                            {
                                r.state = client_state.Queued;
                                flag = clients[0].enqueue(r); //ставим его в очередь на 1-2 кассы
                            }
                        }
                        else
                        {
                            r = kasses[i].remove_client(); //иначе просто убираем клиента
                            r.state = client_state.Finalized;
                        }
                    if (i < 2)
                        flag = kasses[i].add_client(clients[0].dequeue()); //если обменные кассы, то добавляем клиента из обменной очереди
                    else
                        flag = kasses[i].add_client(clients[1].dequeue()); //иначе - из другой
                }
            }
        }
        public void creating() //появление нового клиента
        {
            if (creating_time > 0) creating_time--; //чтобы время не улетело в минус
            if ((creating_time == 0) && (is_working == true)) //минута до конца - прекратить прием заявок
                into_queue(create_client()); //пришел новый клиент
        }
        public void working() //работа операторов с клиентами
        {
            for (int i = 0; i < 7; i++)
                kasses[i].working();
        }
        public bool is_empty_all() //проверка, все ли обслужены
        {
            int no_queue = 0; //пустые очереди
            int no_kasses = 0; //пустые кассы
            for (int i = 0; i < 2; i++)
                if (clients[i].is_empty())
                    no_queue++;
            for (int i = 0; i < 7; i++)
                if (kasses[0].is_empty())
                    no_kasses++;
            return no_queue==2 && no_kasses==7;
        }
        //статистика
        public void set_xchg()
        {
            tot_xchg++;
        }
        public void set_card()
        {
            tot_card++;
        }
        public void set_cred()
        {
            tot_cred++;
        }
        public void set_acnt()
        {
            tot_acnt++;
        }
        public int get_day_time()
        {
            return day_time;
        }
        public int[] get_information()
        {
            tot_info = new int[13];
            tot_info[0] = all_clients;
            tot_info[1] = refused_clients;
            tot_info[2] = tot_card;
            tot_info[3] = tot_cred;
            tot_info[4] = tot_acnt;
            tot_info[5] = tot_xchg;
            for (int i = 6; i < 13; i++)
                tot_info[i] = kasses[i-6].get_total_work_time();
            return tot_info;
        }
    }
}
