using System;

class Program {
 
  public static void Main() {
    Console.WriteLine("Digite a base e a altura do retãngulo");
    double b = double.Parse(Console.ReadLine());
    double h = double.Parse(Console.ReadLine());
    double area = b * h;
    double perimetro = 2 * b + 2 * h;
    double diagonal = Math.Sqrt(Math.Pow(b,2) + h*h);
    Console.WriteLine($"A are do retângulo é {area}, o perimetro é {perimetro} e a diagonal é {diagonal:0.00}");
  }
}