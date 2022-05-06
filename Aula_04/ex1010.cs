using System;

class Program {
  public static void Main() {
    string s = Console.ReadLine();
    string r = Console.ReadLine();
    string[] vs = s.Split(' ');
    string[] vr = r.Split(' ');
    int np1 = int.Parse(vs[1]);
    double vp1 = double.Parse(vs[2]);
    int np2 = int.Parse(vr[1]);
    double vp2 = double.Parse(vr[2]);
    double t = np1 * vp1 + np2 * vp2;
    Console.WriteLine($"VALOR A PAGAR: R$ {t:0.00}");
    
  }
}