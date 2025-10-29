using DesignPatterns.Behavioral.Visitor.I;

namespace DesignPatterns.Behavioral.Visitor.II
{
    internal interface IElement
    {
        void Accept(IVisitor visitor);
    }
}
