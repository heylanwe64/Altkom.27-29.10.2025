namespace DesignPatterns.Behavioral.Visitor.I
{
    internal interface IElement
    {
        string Accept(IVisitor visitor);
    }
}
