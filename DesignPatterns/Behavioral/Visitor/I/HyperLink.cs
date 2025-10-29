namespace DesignPatterns.Behavioral.Visitor.I
{
    internal class HyperLink : PlainText
    {
        public string Url { get; set; }
        public override string ToHtml()
        {
            return $"<a href=\"{Url}\">{Text}</a>";
        }
    }
}
