using System;
using System.IO;

class UnidadeParticular : Unidade{
  protected string nomeunip; 
  
  StreamWriter srp = new StreamWriter("UnidadeParticular.txt");

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

  public void CadUnidadeParticular(){ // metodo para escolher unidade publica para consulta
    
    int op;
    Console.WriteLine("Insira um número, sendo 1 - Metropolitano, 2 - Apart e 3 - SAMP");
    op = int.Parse(Console.ReadLine());

    switch(op){
      case 1:
      nounip = "Metropolitano";
      break;

      case 2:
      nounip = "Apart";
      break;
      
      case 3:
      nounip = "SAMP";
      break;

      default:
      Console.WriteLine("número inválido");
      break; 
    }
    
    srp.WriteLine("===== Escolha da unidade ===== \nNome unidade: "+nomeunip);

    srp.Close();
  }
}