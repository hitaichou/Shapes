using Shapes.Entities.Enums;
namespace Shapes.Entities
{
    class Rectangle : Shape
    {
        public double Width { get; set; }
        public double Height { get; set; }

        //É necessário instanciar a cor, pois, caso contrário
        //não é possível instanciar a classe abstrata.
        //Ou a classe também é abstrata ou deve-se criar o
        //construtor.
        //No exemplo abaixo, está passando para a superclasse a cor
        public Rectangle (double width, double height, Color color) : base(color)
        {
            Width = width;
            Height = height;
        }

        //Sobrescria do método abstrato Area na superclasse
        public override double Area()
        {
            return Width * Height;
        }
    }
}
