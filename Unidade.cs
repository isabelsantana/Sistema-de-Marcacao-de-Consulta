using System;
using System.IO;

class Unidade{
  protected string cidadeuni;
  
  public Unidade()
  {
    cidadeuni = "Serra";
  }
  
  public Unidade(string ciduni)
  {
    cidadeuni = ciduni;
  }

  public string ciduni{
    get {return cidadeuni;}
    set {cidadeuni = value;}
  }
}
  