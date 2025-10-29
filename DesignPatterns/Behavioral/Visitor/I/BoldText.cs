namespace DesignPatterns.Behavioral.Visitor.I
{
    internal class BoldText : PlainText
    {
        public override string Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
