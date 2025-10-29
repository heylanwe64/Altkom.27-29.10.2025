namespace DesignPatterns.Behavioral.Visitor.I
{
    internal interface IVisitor
    {
        string Visit(PlainText plainText);
        string Visit(BoldText boldText);
        string Visit(HyperLink hyperlink);
    }
}
