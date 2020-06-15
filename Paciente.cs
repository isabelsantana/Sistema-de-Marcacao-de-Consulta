using System;
using System.IO;

class Paciente{
  protected string nome;
  protected int idade;
  protected char sexo;
  
  public Paciente()
  {
    nome = "Daniel";
    idade = 20;
    sexo = 'M';
  }
  
  public Paciente(string n, int id, char s)
  {
    nome = n;
    idade = id;
    sexo = s;
  }
  
  public string n{
    get {return nome;}
    set {nome = value;}
  }
  
  public int id{
    get {return idade;}
    set {idade = value;}
  }

  public char s{
    get {return sexo;}
    set {sexo = value;}
  }
}
  