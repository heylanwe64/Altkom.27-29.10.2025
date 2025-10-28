namespace DesignPatterns.Behavioral.ChainOfResponsibility.II
{
    internal class TextBox : Container
    {
        private string _text = string.Empty;

        public string Text
        {
            get { return _text; }
            set
            {
                _text = value;
                Console.WriteLine($"{Name} changed text to {_text}");
            }
        }

        protected override void Click(bool handled)
        {
            if(!handled)
                Console.WriteLine($"{Name} has focus.");
            base.Click(true);
        }
    }
}
