namespace DesignPatterns.Behavioral.Visitor.I
{
    internal class HtmlVisitor : IVisitor
    {
        public string Visit(PlainText plainText)
        {
            return plainText.Text;
        }

        public string Visit(BoldText boldText)
        {
            return $"<b>{boldText.Text}</b>";
        }

        public string Visit(HyperLink hyperlink)
        {
            return $"<a href=\"{hyperlink.Url}\">{hyperlink.Text}</a>";
        }
    }
}
