using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace CMO
{
    public partial class Form1 : Form
    {
        //Queue p;
        //int ID;
        Cmo BANK;
        //public on_change tick;
        private Request[] n;
        private int max;
        request_type _type;
        public Form Parent;
        //ClientChangedEventHandler m;
        public Form1(int _max_client)
        {
            InitializeComponent();
            k1_max.Text = Convert.ToString(_max_client);
            k3_max.Text = Convert.ToString(_max_client);
            k1_cur.Text = "0";
            k3_cur.Text = "0";
            BANK = new Cmo(_max_client);
            BANK.get_queue(0).RaiseRequestEvent += on_change_queue1; //подписка на событие добавления заявки (1-я очередь)
            BANK.get_queue(1).RaiseRequestEvent += on_change_queue2; //подписка на событие добавления заявки (2-я очередь)
            BANK.get_queue(0).DecreaseRequestEvent += on_change_queue1; //подписка на события удаления заявки (1-я очередь)
            BANK.get_queue(1).DecreaseRequestEvent += on_change_queue2; //подписка на события удаления заявки (2-я очередь)
            Random rnd = new Random();
        }
        //обработчик события 1-я очередь
        void on_change_queue1(object sender, OnAddReq e)
        {
            this.print();
            this.print_cur();
        }
        //обработчик события 2-я очередь
        void on_change_queue2(object sender, OnAddReq e)
        {
            this.print2();
            this.print_cur();
        }
        private void print_id()
        {
            if (BANK.get_kassa(0).is_empty()) k1_state.Text = "Нет";
            else
                k1_state.Text = Convert.ToString(BANK.get_kassa(0).get_client_id());
            if (BANK.get_kassa(1).is_empty()) k2_state.Text = "Нет";
            else
                k2_state.Text = Convert.ToString(BANK.get_kassa(1).get_client_id());
            if (BANK.get_kassa(2).is_empty()) k3_state.Text = "Нет";
            else
                k3_state.Text = Convert.ToString(BANK.get_kassa(2).get_client_id());
            if (BANK.get_kassa(3).is_empty()) k4_state.Text = "Нет";
            else
                k4_state.Text = Convert.ToString(BANK.get_kassa(3).get_client_id());
            if (BANK.get_kassa(4).is_empty()) k5_state.Text = "Нет";
            else
                k5_state.Text = Convert.ToString(BANK.get_kassa(4).get_client_id());
            if (BANK.get_kassa(5).is_empty()) k6_state.Text = "Нет";
            else
                k6_state.Text = Convert.ToString(BANK.get_kassa(5).get_client_id());
            if (BANK.get_kassa(6).is_empty()) k7_state.Text = "Нет";
            else
                k7_state.Text = Convert.ToString(BANK.get_kassa(6).get_client_id());
        }
        private void print_cur()
        {
            k1_cur.Text = Convert.ToString(BANK.get_queue(0).get_count());
            k3_cur.Text = Convert.ToString(BANK.get_queue(1).get_count());
        }
        private void print() //вывод заявок в пул 1
        {
            pool.Clear(); //очистили поле
            //выводим поэлементно
            int i = BANK.get_queue(0).peak(); //начиная с первого элемента
            while (i < BANK.get_queue(0).peak() + BANK.get_queue(0).get_count())
            {
                if (!BANK.get_queue(0).is_empty_req(i)) //пропускаем, если заявки нет
                {
                    pool.AppendText(Convert.ToString(BANK.get_queue(0).select(i).ID) + "\n");
                    for (int j = 0; j < BANK.get_queue(0).select(i).req_max_count; j++)
                        pool.AppendText(Convert.ToString(BANK.get_queue(0).select(i).get_request(j).operation) + ", ");
                    pool.AppendText("\n");
                }
                i++;
            }
        }

        private void print2() //вывод заявок в пул 2
        {
            pool2.Clear(); //очистили поле
            //выводим поэлементно
            int i = BANK.get_queue(1).peak(); //начиная с первого элемента
            while (i < BANK.get_queue(1).peak() + BANK.get_queue(1).get_count())
            {
                if (!BANK.get_queue(1).is_empty_req(i)) //пропускаем, если заявки нет
                {
                    pool2.AppendText(Convert.ToString(BANK.get_queue(1).select(i).ID) + "\n");
                    for (int j = 0; j < BANK.get_queue(1).select(i).req_max_count; j++)
                        pool2.AppendText(Convert.ToString(BANK.get_queue(1).select(i).get_request(j).operation) + ", ");
                    pool2.AppendText("\n");
                }
                i++;
            }
        }

        private void ADD_Click(object sender, EventArgs e)
        {
            int id = 1;
            try
            {
                if (max_num.Text == "")
                    throw new ArgumentNullException("Число заявок");
                max = Convert.ToInt16(max_num.Text);
                n = new Request[max];
                id += BANK.ID;
                switch (max)
                {
                    case 1:
                        if (type_req.Text != "ACNT" && type_req.Text != "CARD" && type_req.Text != "CRED" && type_req.Text != "XCHG")
                            throw new ArgumentNullException("Тип заявки");
                        n[0] = new Request(id++, 0, true, type_operation(type_req.Text));
                        n[0].set_serv_time();
                        break;
                    case 2:
                        if (type_req.Text != "ACNT" && type_req.Text != "CARD" && type_req.Text != "CRED" && type_req.Text != "XCHG")
                            throw new ArgumentNullException("Тип заявки");
                        n[0] = new Request(id++, 0, true, type_operation(type_req.Text));
                        n[0].set_serv_time();
                        if (type_req2.Text != "ACNT" && type_req2.Text != "CARD" && type_req2.Text != "CRED" && type_req2.Text != "XCHG")
                            throw new ArgumentNullException("Тип заявки");
                        n[1] = new Request(id++, 0, true, type_operation(type_req2.Text));
                        n[1].set_serv_time();
                        break;
                    case 3:
                        if (type_req.Text != "ACNT" && type_req.Text != "CARD" && type_req.Text != "CRED" && type_req.Text != "XCHG")
                            throw new ArgumentNullException("Тип заявки");
                        n[0] = new Request(id++, 0, true, type_operation(type_req.Text));
                        n[0].set_serv_time();
                        if (type_req2.Text != "ACNT" && type_req2.Text != "CARD" && type_req2.Text != "CRED" && type_req2.Text != "XCHG")
                            throw new ArgumentNullException("Тип заявки");
                        n[1] = new Request(id++, 0, true, type_operation(type_req2.Text));
                        n[1].set_serv_time();
                        if (type_req3.Text != "ACNT" && type_req3.Text != "CARD" && type_req3.Text != "CRED" && type_req3.Text != "XCHG")
                            throw new ArgumentNullException("Тип заявки");
                        n[2] = new Request(id++, 0, true, type_operation(type_req3.Text));
                        n[2].set_serv_time();
                        break;
                }
                BANK.create_client(max, n);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Warning " + ex.GetType().Name + " " + ex.Message);
            }
        }

        private request_type type_operation(string s)
        {
            switch (s)
            {
                case "ACNT":
                    _type = request_type.ACNT;
                    BANK.set_acnt();
                    break;
                case "CARD":
                    _type = request_type.CARD;
                    BANK.set_card();
                    break;
                case "CRED":
                    _type = request_type.CRED;
                    BANK.set_cred();
                    break;
                case "XCHG":
                    _type = request_type.XCHG;
                    BANK.set_xchg();
                    break;
            }
            return _type;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (BANK.get_day_time() == 60 && ADD.Visible)
            {
                ADD.Hide();
                MessageBox.Show("Прием заявок окончен", "Внимание");
            }
            if (BANK.get_day_time() == 0 && BANK.is_empty_all())
            {
                ending();
            }
            else
            {
                BANK.check_kassa();
                BANK.creating();
                BANK.working();
                BANK.dec_day_time();
                //tick = print;
                //print();
                //print2();
                //print_cur();
                print_id();
                label10.Text = "До конца рабочего дня: " + Convert.ToString(BANK.get_day_time() / 60) + ":" + Convert.ToString(BANK.get_day_time() % 60);
                if (BANK.get_day_time() == 0) label10.Text = "Работа до последнего клиента";
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            Parent.Close();
        }

        private void DEL_Click(object sender, EventArgs e)
        {
            ending();
        }

        private void ending()
        {
            timer1.Stop();
            Form3 w = new Form3(BANK.get_information());
            w.Parent = this;
            w.Show();
            this.Hide();
        }
    }
}
