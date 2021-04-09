using System;

namespace RECCIRTRI
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape s = new Square(2);
            Console.WriteLine(s.GetArea());
            Console.WriteLine(s.GetPerimeter());

            Circle testCircle = new Circle(2);
            testCircle.SetColor("Green");
            Console.WriteLine("TestCircle color is " + testCircle.GetColor());

            Square testSquare = new Square(3);
            testSquare.SetColor("Blue");
            Console.WriteLine("TestSquare color is " + testSquare.GetColor());

            Rectangle testRectangle = new Rectangle(12,7);
            testRectangle.SetColor("Yellow");
            Console.WriteLine("TestRectangle color is " + testRectangle.GetColor());

            Triangle testTriangle = new Triangle(3, 12,7);
            testTriangle.SetColor("Black");
            Console.WriteLine("TestTriangle color is " + testTriangle.GetColor());
            
            
            
            
            
            
            
            
            
            Square s1 = new Square(1);
            
             double area1 = s1.GetArea();
             Console.WriteLine(area1);
            
             double per1 = s1.GetPerimeter();
             Console.WriteLine(per1);
            
             s1.SetSide(7);
             s1.GetSide();



             double area2 = s1.GetArea();
             Console.WriteLine(area2);
             double per2 = s1.GetPerimeter();
             Console.WriteLine(per2);



            Circle c1 = new Circle(7);



            double area = c1.GetArea();
            Console.WriteLine(area1);
            double cer1 = c1.GetCircumference();
            Console.WriteLine(cer1);
            c1.SetRadius(3);
            c1.GetRadius();



             Triangle t1 = new Triangle(1, 2, 3);
           
             double area3 = t1.GetArea();
             Console.WriteLine(area1);
             double per = t1.GetPerimeter();
             Console.WriteLine(per1);
            
             t1.SetSideA(7);
             t1.SetSideB(3);
             t1.SetSideC(7);
            
             t1.GetSideA();
             t1.GetSideB();
             t1.GetSideC();
            
             


        }






    }
}
