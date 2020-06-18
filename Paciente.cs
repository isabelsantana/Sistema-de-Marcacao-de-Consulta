using System;
using System.IO;

class Paciente{
  protected string nome;
  protected int idade;
  protected char sexo;
  protected string cidade;
  
  public Paciente()
  {
    nome = "Daniel";
    idade = 20;
    sexo = 'M';
    cidade = "Serra";
  }
  
  public Paciente(string n, int id, char s, string cid)
  {
    nome = n;
    idade = id;
    sexo = s;
    cidade = cid;
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

  public string cid{
    get {return cidade;}
    set {cidade = value;}
  }


  //METÓDO PARA PEDIR AS INFORMAÇÕES DO PACIENTE
  
  

}
  