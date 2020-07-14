using Shapes.Entities.Enums;

namespace Shapes.Entities
{
    abstract class Shape
    {
        public Color Color { get; set; }

        
        public Shape(Color color)
        {
            Color = color;
        }

        //Declaro que o método é abstrato
        public abstract double Area();

    }
}
