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
    Console.WriteLine(x);
    
    
    
    }

}





  class ContaBancaria{
    public string titular, numero;
    private double saldo;
    public void Depositar(double valor){
      if (valor > 0) this.saldo += valor;
      // else Console.WriteLine("Valor deve ser maior que zero");
    }
    public void sacar(double valor){
      if (valor <= saldo && valor > 0) this.saldo -= valor;
      // else Console.WriteLine("Saldo insuficiente ou valor depositado invalido");
    }
    public double GetSaldo(){
      return this.saldo;
    }
    public void SetTitular(string s) {
      if (s.IndexOf(' ') != -1 ) this.titular = s;
      // else Console.WriteLine("Nome é invalido");
    }
      public void SetNumero(string s) {
      if (s.IndexOf('-') != -1 ) this.numero = s;
      // else Console.WriteLine("numero é invalido");
      }
    public string GetTitular(){
      return this.titular;
    }
    public string GetNumero(){
    return this.numero;
    }
    public override string ToString() {
      return $"Titular = {titular}, Número da conta = {numero}, Saldo = {saldo}";
    }
  }