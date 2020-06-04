using System;
using System.IO;

class UnidadeParticular : Unidade{
  protected string nomeunip; 
  protected string bairrounip; 
  
  public UnidadeParticular()
  {
    nomeunip = "Metropolitano";
    bairrounip = "laranjeiras";
  }
  
  public UnidadeParticular(string nounip, string baiunip)
  {
    nomeunip = nounip;
    bairrounip = baiunip;
  }
  
  public string nounip{
    get {return nomeunip;}
    set {nomeunip = value;}
  }

  public string baiunip{
    get {return bairrounip;}
    set {bairrounip = value;}
  }
}
  