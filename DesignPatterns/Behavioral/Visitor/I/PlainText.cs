namespace DesignPatterns.Behavioral.Visitor.I
{
    internal class PlainText : IElement
    {
        public string Text { get; set; }

        public virtual string ToHtml()
        {
            return Text;
        }
    }
}
