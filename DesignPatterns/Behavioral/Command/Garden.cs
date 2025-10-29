using System.Text;

namespace DesignPatterns.Behavioral.Command
{
    internal class Garden
    {
        public int Size { get; }
        List<string> Plants { get; } = [];

        public Garden(int size)
        {
            Size = size;
        }

        public bool Add(string name)
        {
            if (Plants.Count < Size)
            {
                Plants.Add(name);
                Console.WriteLine($"Roślina {name} została zasadzona w ogrodzie");
                return true;
            }

            Console.WriteLine($"Brak miejsca w ogodzie na {name}");
            return false;
        }

        public bool Remove(string name)
        {
            var result = Plants.Remove(name);
            if (result)
                Console.WriteLine($"Roślina {name} usunięta z ogrodu");
            else
                Console.WriteLine($"W ogrodzie nie ma rośliny {name}");
            return result;
        }

        public override string ToString()
        {
            var builder = new StringBuilder();
            builder.AppendLine($"W ogrodzie jest {Plants.Count} roślin:");

            foreach (var item in Plants)
            {
                builder.AppendLine(item);
            }
            return builder.ToString();
        }
    }
}
