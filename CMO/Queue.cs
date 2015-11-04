using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CMO
{
    class OnAddReq: EventArgs
    {
        public string msg;
        public string ReqText;
        public OnAddReq(string _ReqText)
        {
            ReqText = _ReqText;
        }
    }
    class Queue
    {
        public event EventHandler<OnAddReq> RaiseRequestEvent; //событие добавления заявки в очередь
        public event EventHandler<OnAddReq> DecreaseRequestEvent; //событие извлечения заявки из очереди
        private new Client[] pool;
        public readonly int max_count;
        private int count;
        private int head;
        private int tail;
        public Queue()
        {
            max_count = 0;
            count = 0;
            head = 0;
            tail = 0;
        }
        public Queue(int _max_count)
        {
            max_count = _max_count;
            count = 0;
            head = 0;
            tail = 0;
            pool = new Client[max_count];
        }
        public Queue(Queue _other)
        {
            max_count = _other.max_count;
            count = _other.count;
            head = _other.head;
            tail = _other.tail;
            pool = new Client[max_count];
            for (int i = head; i < head + count; i++)
                pool[i % max_count] = _other.pool[i % max_count];
        }
        public void OnRaiseRequestEvent(OnAddReq e)
        {
            EventHandler<OnAddReq> handler = RaiseRequestEvent; //создание копии события (для предотвращения возможности гонок)
            if (handler != null)
            {
                e.msg +=  String.Format("RaiseRequestEvent at {0}", DateTime.Now.ToString());
                handler(this, e); //вызов события
            }
        }
        public void OnDecreaseRequestEvent(OnAddReq e)
        {
            EventHandler<OnAddReq> handler = DecreaseRequestEvent;
            if (handler != null)
            {
                e.msg += String.Format("RaiseRequestEvent at {0}", DateTime.Now.ToString());
                handler(this, e);
            }
        }
        public bool is_full()
        {
            return (count == max_count);
        }
        public bool is_empty()
        {
            return (count == 0);
        }
        public int get_all_time() //общее время, необходимое на обработку очереди
        {
            int tot = 0;
            if (is_empty()) return tot;
            for (int i = 0; i < count; i++)
                if (pool[i] != null)
                    for (int j = 0; j < pool[i].req_max_count; j++) //просматриваем все заявки клиента
                        tot += pool[i].get_request(j).service_time;
            return tot;
        }
        public bool enqueue(Client new_client)
        {
            if (is_full()) return false;
            if (is_empty()) //по умолчанию, если очередь пуста
            {
                head = 0;
                tail = 0;
                pool[tail] = new_client; //хвост не сдвигаем
            }
            else
            {
                tail = (tail + 1) % max_count; //новое значение хвоста (голова - на прежнем месте)
                pool[tail] = new_client;
                //остаток от деления на MaxSize - верный способ избежать вылета за диапазон и 'зациклить' массив
                //т.е, в случае, если последний элемент занят, а место перед головой свободно, то хвост переместится туда
            }
            OnRaiseRequestEvent(new OnAddReq(new_client.ID.ToString())); //вызов события
            count++;
            return true;
        }
        public Client dequeue()
        {
            if (is_empty()) return null;
            Client deq_client = new Client();
            deq_client = pool[head];
            pool[head] = null; //снимаем с рассмотрения
            head = (head + 1) % max_count; //сдвинули голову (хвост остался на месте) - по аналогии с добавлением
            count--; //-1 элемент
            OnDecreaseRequestEvent(new OnAddReq(deq_client.ID.ToString()));
            return deq_client;
        }
        public Client select(int i)
        {
            return pool[i % max_count]; //получили элемент    
        }
        public int get_count() //получить число элементов
        {
            return count;
        }
        public int peak() //индекс головы
        {
            return head;
        }
        public bool is_empty_req(int i) //проверить наличие заявки
        {
            return (pool[i % max_count] == null);
        }
    }
}
