using InterfaceExample.Model.Enums;

namespace InterfaceExample.Model.Entities
{
    abstract class AbstractShape : IShape
    {
        public Color Color { get; set; }

        public abstract double Area();
    }
}
