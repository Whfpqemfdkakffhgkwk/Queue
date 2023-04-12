namespace Queue
{
    class Program
    {
        static void Main()
        {
            Queue<int> queue = new Queue<int>();

            //값 넣어주기
            queue.EnQueue(1);
            queue.EnQueue(2);
            queue.EnQueue(3);

            //제일 처음 넣은 값 출력
            Console.WriteLine(queue.First());
            //제일 마지막 넣은 값 출력
            Console.WriteLine(queue.Last());
            
            //처음 넣은 값부터 뺀 뒤 출력
            Console.WriteLine(queue.DeQueue());
            Console.WriteLine(queue.DeQueue());
            Console.WriteLine(queue.DeQueue());

            //다시 값 넣어주기
            queue.EnQueue(5);
            queue.EnQueue(6);

            Console.WriteLine(queue.Last()); queue.Last();
            //모든 값 비우기
            queue.Clear();

            //비어있는지 확인하는 bool 값
            Console.WriteLine(queue.IsEmpty());
            //남아있는 카운트 출력
            Console.WriteLine("카운트 : " + queue.Count());

        }
    }

    class Queue<T>
    {
        public List<T> items = new List<T>();

        //값을 넣어주는 기능
        public void EnQueue(T item)
        {
            items.Add(item);
        }

        //값을 넣은 값부터 꺼내주는 기능
        public T DeQueue()
        {
            //아무것도 없는데 빼려고 하면
            if (items.Count == 0)
                throw new ApplicationException("QueueEmptyException");

            //item에 첫번째 원소를 넣는다
            T item = items[0];
            //items 첫번째 원소를 지운다
            items.RemoveAt(0);
            //item을 반환해준다
            return item;
        }

        //맨 아래에 깔려있는 값을 반환해주는 기능
        public T First()
        {
            return items[0];
        }

        //맨 위에 있는 값을 반환해주는 기능
        public T Last()
        {
            //마지막 원소에 있는 값을 반환
            return items[items.Count - 1];
        }

        //비워주는 기능
        public void Clear()
        {
            items.Clear();
        }

        //다 차 있는지 확인하는 bool 값
        public bool IsEmpty()
        {
            return items.Count == 0;
        }
        
        //값이 얼만큼 들어있는지 알려주는 값
        public int Count()
        {
            return items.Count;
        }
    }
}