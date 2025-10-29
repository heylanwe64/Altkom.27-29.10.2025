namespace DesignPatterns.Behavioral.Visitor.I
{
    internal class BoldText : PlainText
    {
        public override string ToHtml()
        {
            return $"<b>{Text}</b>";
        }
    }
}
