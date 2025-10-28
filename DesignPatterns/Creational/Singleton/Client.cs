namespace DesignPatterns.Creational.Singleton
{
    internal class Client
    {
        public static void Execute()
        {
            Task.Run(() =>
            {
                var context = Context.Instance;
                Console.WriteLine(context.GetSettings("1"));
            });
            Task.Run(() =>
            {
                Console.WriteLine(Context.Instance.GetSettings("2"));
                Context.Instance.SetSettings("3", "changed value");
            });

            Task.Run(() =>
            {
                Console.WriteLine(Context.Instance.GetSettings("3"));
            });
            Console.ReadLine();
        }
    }
}