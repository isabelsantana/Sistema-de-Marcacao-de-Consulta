using System;
using System.IO;

class Unidade{
  protected string bairrouni; // Bairro onde a unidade se encontra
  protected string cidadeuni; // Cidade onde a unidade se encontra
  
  public Unidade()
  {
    bairrouni = "NC";
    cidadeuni = "Serra";
  }
  
  public Unidade(string baiuni, string ciduni)
  {
    bairrouni = baiuni;
    cidadeuni = ciduni;
  }

  public string ciduni{
    get {return cidadeuni;}
    set {cidadeuni = value;}
  }
  
  public string baiuni{
    get {return bairrouni;}
    set {bairrouni = value;}
  }
}
  