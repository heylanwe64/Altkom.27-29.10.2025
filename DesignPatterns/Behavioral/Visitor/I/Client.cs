namespace DesignPatterns.Behavioral.Visitor.I
{
    internal class Client
    {
        public static void Execute()
        {
            var collection = new IElement[]{
                new PlainText() { Text = "Plain" },
                new PlainText() { Text = "\n" },
                new BoldText() { Text = "Bold" },
                new PlainText() { Text = "\n" },
                new HyperLink() { Text = "Hyperlink", Url = @"https:\\some.url.pl" }};


            var htmlVisitor = new HtmlVisitor();
            foreach (var item in collection)
            {
                Console.Write(item.Accept(htmlVisitor));
            }
        }
    }
}
