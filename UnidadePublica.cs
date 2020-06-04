using System;
using System.IO;

class UnidadePublica : Unidade{
  protected string nomeuni; //Nome da empresa do plano de saude
  protected string bairrouni; //Numero de cadastro do plano
  
  public UnidadePublica()
  {
    nomeuni = "UPA";
    bairrouni = "NC";
  }
  
  public UnidadePublica(string nouni, string baiuni)
  {
    nomeuni = nouni;
    bairrouni = baiuni;
  }
  
  public string nouni{
    get {return nomeuni;}
    set {nomeuni = value;}
  }

  public string baiuni{
    get {return bairrouni;}
    set {bairrouni = value;}
  }
}
  