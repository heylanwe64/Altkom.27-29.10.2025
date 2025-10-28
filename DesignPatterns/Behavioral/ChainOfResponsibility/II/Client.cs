namespace DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    internal class Client
    {
        public static void Execute()
        {
            var textBox = new TextBox { Name = "TextBox" };
            var textBoxFrame = new Frame { Name = "TextBox Frame" };

            textBoxFrame.Add(textBox);

            var button = new Button
            {
                Name = "Button",
                OnClick = () =>
                {
                    if (string.IsNullOrEmpty(textBox.Text))
                        return false;
                    textBox.Text = string.Empty;
                    return true;
                }
            };
            var buttonFrame = new Frame { Name = "Button Frame" };
            buttonFrame.Add(button);

            textBox.Add(buttonFrame);

            // Simulate user interactions
            Console.WriteLine("---");
            textBoxFrame.Click();
            Console.WriteLine("---");
            buttonFrame.Click();
            Console.WriteLine("---");
            button.Click();
            Console.WriteLine("---");
            textBox.Click();
            Console.WriteLine("---");
            textBox.Text = "Hello, World!";
            Console.WriteLine("---");
            button.Click();
            Console.WriteLine("---");
            button.Click();


        }
    }
}
