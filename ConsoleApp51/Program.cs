using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp51
{
    public interface IFigure
    {
        double Area();
        double Perimeter();
    }

    public class Circle : IFigure
    {
        public double Radius { get; set; } 

        public Circle(double radius)
        {
            Radius = radius;
        }

        public double Area()
        {
            return Math.PI * Radius * Radius;
        }

        public double Perimeter()
        {
            return 2 * Math.PI * Radius;
        }
    }

    public class Rectangle : IFigure
    {
        public double Width { get; set; }
        public double Height { get; set; }

        public Rectangle(double width, double height)
        {
            Width = width;
            Height = height;
        }

        public double Area()
        {
            return Width * Height;
        }

        public double Perimeter()
        {
            return 2 * (Width * Height);
        }
    }

    public class Triangle : IFigure
    {
        public double Base { get; set; }
        public double Height { get; set; }
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }

        public Triangle(double baseLength, double height, double sideA, double sideB, double sideC)
        {
            Base = baseLength;
            Height = height;
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }

        public double Area()
        {
            return 0.5 * Base * Height; 
        }

        public double Perimeter()
        {
            return SideA + SideB + SideC; 
        }
    }

    public interface IMusicalInstrument
    {
        void Play(); 
    }

    public class Guitar : IMusicalInstrument
    {
        public void Play()
        {
            Console.WriteLine("Играть на гитаре.");
        }
    }

    public class Violin : IMusicalInstrument
    {
        public void Play()
        {
            Console.WriteLine("Играть на скрипке.");
        }
    }

    public class Flute : IMusicalInstrument
    {
        public void Play()
        {
            Console.WriteLine("Играть на флейте.");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            IFigure circle = new Circle(5);
            Console.WriteLine($"Круг: Площадь = {circle.Area()}, Периметр = {circle.Perimeter()}");

            IFigure rectangle = new Rectangle(4, 6);
            Console.WriteLine($"Прямоугольник: Площадь = {rectangle.Area()}, Периметр = {rectangle.Perimeter()}");

            IFigure triangle = new Triangle(4, 5, 3, 4, 5);
            Console.WriteLine($"Треугольник: Площадь = {triangle.Area()}, Периметр = {triangle.Perimeter()}");

            IMusicalInstrument guitar = new Guitar();
            guitar.Play();

            IMusicalInstrument violin = new Violin();
            violin.Play();

            IMusicalInstrument flute = new Flute();
            flute.Play();
        }
    }
}

