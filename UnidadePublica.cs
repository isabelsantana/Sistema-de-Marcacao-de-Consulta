using System;
using System.IO;

class UnidadePublica : Unidade{
  protected string nomeuni; 
  
  public UnidadePublica()
  {
    nomeuni = "UPA";
  }
  
  public UnidadePublica(string nouni)
  {
    nomeuni = nouni;
  }
  
  public string nouni{
    get {return nomeuni;}
    set {nomeuni = value;}
  }
}
  