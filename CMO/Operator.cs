using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMO
{
    enum kassa_type
    {
        N12, //кассы ХСНG
        N37, //кассы ACNT, CRED, CARD
        N    //  
    }
    enum operator_state //состояние кассы
    {
        Vacant, //свободна
        Occuped, //занята
        NotReady //завершила работу, но еще не освободилась
    }
    class Operator //обслуживающее устройство
    {
        kassa_type k_type; //тип кассы
        public operator_state state; //состояние
        private int client_id; //id клиента
        private new Client cl; //клиент
        private int work_time; //время работы с клиентом
        public int total_work_time; //общее время работы оператора
        //private bool state; //состояние устройства (true - свободно, false - занято)
        public Operator(kassa_type _k_type)
        {
            k_type = _k_type;
            work_time = 0;
            total_work_time = 0;
            state = operator_state.Vacant;
        }
        public int Test()
        {
            return 1;
        }
        public Operator(int _work_time, operator_state _state)
        {
            total_work_time = 0;
            work_time = _work_time;
            state = _state;
            cl = new Client();
            cl = null;
        }
        public bool add_client(Client new_cl)
        {
            if (state == operator_state.Occuped || new_cl == null) return false;
            cl = new_cl;
            cl.state = client_state.Started; //обслуживание начато
            client_id = cl.ID;
            set_work_time(cl);
            state = operator_state.Occuped;
            return true;
        }
        public int get_client_id()
        {
            return client_id;
        }
        public Client remove_client() //обслуженный клиент
        {
            Client served_cl = new Client();
            served_cl = cl;
            served_cl.state = client_state.Finalized; //обслуживание завершено
            cl = null;
            state = operator_state.Vacant;
            return served_cl;
        }
        private void set_work_time(Client _cl) //определяем время, необходимое на обработку клиента
        {
            work_time = 0;
            for (int i = 0; i < _cl.req_max_count; i++)
            {
                if (k_type == kassa_type.N37) //если касса 3-7, то исключаем операции обмена
                    if (cl.get_request(i).operation != request_type.XCHG)
                    {
                        work_time += cl.get_request(i).service_time;
                        cl.inc_req_done(); //увеличиваем число обработанных заявок
                    }
                if (k_type == kassa_type.N12) //если 1-2, то исключаем все операции, кроме обмена
                    if (cl.get_request(i).operation == request_type.XCHG)
                    {
                        work_time += cl.get_request(i).service_time;
                        cl.inc_req_done(); //увеличиваем число обработанных заявок
                    }
            }
            total_work_time += work_time; //общее время работы
        }
        public int get_total_work_time()
        {
            return total_work_time;
        }
        public void working() //работа с клиентом
        {
            if (work_time == 0) //работа завершена
            {
                state = operator_state.NotReady;
                return;
            }
            if (work_time > 0) work_time--;
        }
        public operator_state is_ready()
        {
            return state;
        }
        public bool is_empty()
        {
            return (cl == null); //есть ли клиент
        }
    }
}
