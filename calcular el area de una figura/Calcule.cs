namespace calcular_el_area_de_una_figura
{
    //base class
    public abstract class geometric_figure
    {
        public abstract double area();
    }



    //derived class for triangle
    public class Triangle : geometric_figure
    {
        protected double height;
        protected double _base;
        public double Base
        {
            get { return _base; }
            set { _base = value; }

        }
        public double Height
        {
            get { return height; }
            set { height = value; }

        }

        public Triangle(double Base, double Height)
        {
            _base = Base;
            height = Height;
        }

        public override double area()
        {
            return (_base * height) / 2;
        }
    }



    //derived Class for square
    public class Square : geometric_figure
    {
        protected double side;
        public double Side
        {
            get { return side; }
            set {  side = value; }
        }

        public Square(double sid)
        {
            side = sid;
        }

        public override double area()
        {
            return side * side;
        }
    }




    //derived Class for circle
    public class Circle : geometric_figure
    {
        public double radius;

        public double Radius
        {
            get { return radius; }
            set { radius = value; }
        }

        public Circle(double radio)
        {
            radius = radio;
        }

        public override double area()
        {
            return Math.PI * Math.Pow(radius, 2);
        }
    }
}
