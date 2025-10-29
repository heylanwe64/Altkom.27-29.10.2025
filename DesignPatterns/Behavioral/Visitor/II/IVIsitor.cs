namespace DesignPatterns.Behavioral.Visitor.II
{
    internal interface IVisitor
    {
        void Visit(Product product);
        void Visit(BoxedProduct boxedProduct);
    }
}
