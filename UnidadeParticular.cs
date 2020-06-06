using System;
using System.IO;

class UnidadeParticular : Unidade{
  protected string nomeunip;
  
  public UnidadeParticular()
  {
    nomeunip = "Metropolitano";
  }
  
  public UnidadeParticular(string nounip)
  {
    nomeunip = nounip;
  }
  
  public string nounip{
    get {return nomeunip;}
    set {nomeunip = value;}
  }
}
  