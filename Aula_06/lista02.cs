using System;

class Program{
  public static void Main(){
    ContaBancaria x = new ContaBancaria();
    x.SetTitular("Eduardo Neto");
    x.SetNumero("123-X");
    x.Depositar(1000);
    Console.WriteLine(x.GetTitular()); // Console.WriteLine(x.titular);
    Console.WriteLine(x.GetNumero());  // Console.WriteLine(x.numero);
    Console.WriteLine($"Saldo = {x.GetSaldo()}");
    x.sacar(100);
    Console.WriteLine($"Saldo = {x.GetSaldo()}");
    
    
    }

}





  class ContaBancaria{
    public string titular, numero;
    private double saldo;
    public void Depositar(double valor){
      if (valor > 0) saldo += valor;
      // else Console.WriteLine("Valor deve ser maior que zero");
    }
    public void sacar(double valor){
      if (valor <= saldo && valor > 0) saldo -= valor;
      // else Console.WriteLine("Saldo insuficiente ou valor depositado invalido");
    }
    public double GetSaldo(){
      return saldo;
    }
    public void SetTitular(string s) {
      if (s.IndexOf(' ') != -1 ) titular = s;
      // else Console.WriteLine("Nome é invalido");
    }
      public void SetNumero(string s) {
      if (s.IndexOf('-') != -1 ) numero = s;
      // else Console.WriteLine("numero é invalido");
      }
    public string GetTitular(){
      return titular;
    }
    public string GetNumero(){
    return numero;
    }
  }