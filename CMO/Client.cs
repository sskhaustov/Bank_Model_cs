using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMO
{
    enum client_state //состояние клиента
    {
        Undefined, //поступил в систему
        Queued, //поставлен в очередь
        Started, //начал обслуживаться (извлечен из очереди)
        Finalized, //завершил обслуживаться (извлечен из кассы - обслужен)
        Checked, //проверяется наличие заявок после обслуживания
        Refused //отказано в обслуживании (очередь переполнена)
    }
    class Client
    {
        public readonly int ID; //имя клиента
        private new Request[] req; //заявки клиента
        public readonly int req_max_count; //максимальное количество заявок
        public client_state state;
        private int req_count; //количество заявок
        private int req_done; //количество обработанных заявок
        public Client()
        {
            ID = 0;
            req_count = 0;
            req_max_count = 0;
            req_done = 0;
            state = client_state.Undefined;
        }
        public Client(int _ID, int _req_max_count)
        {
            ID = _ID;
            req_max_count = _req_max_count;
            req = new Request[req_max_count];
            req_done = 0;
            state = client_state.Undefined;
        }
        public Client(Client _other)
        {
            ID = _other.ID;
            req_max_count = _other.req_max_count;
            req_count = _other.req_count;
            req_done = _other.req_done;
            for (int i = 0; i < req_count; i++)
                req[i] = _other.req[i];
            state = _other.state;
        }
        public int get_req_done()
        {
            return req_done;
        }
        public void inc_req_done()
        {
            req_done++;
        }
        public bool add_request(Request r)
        {
            if (req_count == req_max_count) return false;
            req[req_count] = r;
            req_count++;
            return true;
        }
        public Request get_request(int i)
        {
            return req[i % req_max_count];
        }
    }
}
