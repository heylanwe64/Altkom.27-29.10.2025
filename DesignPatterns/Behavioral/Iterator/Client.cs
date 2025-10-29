using System.Reactive.Linq;

namespace DesignPatterns.Behavioral.Iterator
{
    internal class Client
    {
        public static void Execute()
        {
            IEnumerable<string> list = new List<string>() { "1", "2", "3", "4", "5", "6" };

            IEnumerator<string> iterator = list.GetEnumerator();

            if(iterator.MoveNext())
            {
                var item = iterator.Current;

                while (iterator.MoveNext())
                {
                    Console.WriteLine(item + iterator.Current); //operacja na parze elementów
                    item = iterator.Current;
                }
            }

            Console.WriteLine("---");

            IEnumerator<(string?, string?)> bufferIterator = new BufferIterator<string>(list.GetEnumerator());
            while(bufferIterator.MoveNext())
            {
                Console.WriteLine(bufferIterator.Current.Item1 + bufferIterator.Current.Item2);
            }


            Console.WriteLine("---");

            var bufferCollection = new BufferCollection<string>(list);
            bufferIterator = bufferCollection.GetEnumerator();
            while (bufferIterator.MoveNext())
            {
                Console.WriteLine(bufferIterator.Current.Item1 + bufferIterator.Current.Item2);
            }

            Console.WriteLine("---");

            foreach (var pair in new BufferCollection<string>(list))
            {
                Console.WriteLine(pair.Item1 + pair.Item2);
            }

            Console.WriteLine("---");

            list.ToObservable()
                .Buffer(3,2)
                .Where(x => x.Count == 2)
                /*.ToEnumerable()
                .ToList()*/
                .Subscribe(x => Console.WriteLine(x[0] + x[1]));

        }
    }
}
