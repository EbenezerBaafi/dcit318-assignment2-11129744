// See https://aka.ms/new-console-template for more information
using AbstractClassesAndMethods;

Console.WriteLine("----------------------------");
Console.WriteLine("----Abstract Classes And Methods----");

// Computes the area of the circle
Circle circle = new Circle(5);
Console.WriteLine($"The are of the circle is: {circle.GetArea():F2}");

// get the area of the rectangle
Rectangle rectangle = new Rectangle(4, 5);
Console.WriteLine($"The area of the rectangle is: {rectangle.GetArea():F2}");