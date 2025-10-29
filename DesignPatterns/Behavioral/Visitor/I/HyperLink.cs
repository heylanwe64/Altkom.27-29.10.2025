namespace DesignPatterns.Behavioral.Visitor.I
{
    internal class HyperLink : PlainText
    {
        public string Url { get; set; }
    
        public override string Accept(IVisitor visitor)
        {
            return visitor.Visit(this);
        }
    }
}
