using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMO
{
    enum request_type //перечисляем типы операций
    {
        ACNT, //узнать счет
        XCHG, //обмен валюты
        CRED, //выдать кредит
        CARD, //сделать карту
        NONE  //
    };
    class Request
    {
        public readonly int ID; //номер заявки
        public int service_time; //время обслуживания заявки
        public bool request_state; //состояние заявки
        public readonly request_type operation; //тип операции
        private Random dec; //отклонение от среднего времени обработки заявки
        public Request()
        {
            ID = 0;
            service_time = 0;
            request_state = false;
            operation = request_type.NONE;
        }
        public Request(int _ID, int _service_time, bool _request_state, request_type _operation)
        {
            ID = _ID;
            service_time = _service_time;
            request_state = _request_state;
            operation = _operation;
        }
        public Request(Request _other)
        {
            ID = _other.ID;
            service_time = _other.service_time;
            request_state = _other.request_state;
            operation = _other.operation;
        }
        public void set_serv_time()
        {
            dec = new Random();
            int dec_time = dec.Next(10); //случайное отклонение по времени
            double znak = Math.Pow(-1.0, Convert.ToDouble(dec.Next(2)+1)); //отклонение может быть как в плюс, так и в минус
            switch (operation)
            {
                case request_type.ACNT:
                    service_time = 30 + (dec_time * Convert.ToInt16(znak));
                    break;
                case request_type.XCHG:
                    service_time = 50 + (dec_time * Convert.ToInt16(znak));
                    break;
                case request_type.CARD:
                    service_time = 80 + (dec_time * Convert.ToInt16(znak));
                    break;
                case request_type.CRED:
                    service_time = 60 + (dec_time * Convert.ToInt16(znak));
                    break;
            }
        }
        public request_type get_operation()
        {
            return operation;
        }
    }
}
