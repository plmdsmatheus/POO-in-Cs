using System;

class Program{
  public static void Main(){

    Aluno a1 = new Aluno();
    a1.nome = "Thavinson";
    a1.matricula = "20211014040001";
    a1.idade = 20;
    Console.WriteLine(a1.nome);
    Console.WriteLine(a1.matricula);
    Console.WriteLine(a1.idade);
    Console.WriteLine(a1.DiasVividos());
    Console.WriteLine();
    
    Aluno a2 = new Aluno();
    a2.nome = "Virgilio";
    a2.matricula = "20211014040002";
    a2.idade = 18;
    Console.WriteLine(a2.nome);
    Console.WriteLine(a2.matricula);
    Console.WriteLine(a2.idade);
    Console.WriteLine(a2.DiasVividos());
  }
}


class Aluno{
  public string nome;
  public string matricula;
  public int idade;
  public int DiasVividos(){
    return idade * 365;
  }
}