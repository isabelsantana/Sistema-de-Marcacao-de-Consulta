using System;
using System.IO;
using System.Text;

class UnidadePublica : Unidade{
  protected string nomeuni;

  StreamWriter sr = new StreamWriter("UnidadePublica.txt");
  
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

  public void CadUnidadePublica(){ // metodo para escolher unidade publica para consulta
    
    int op;
    Console.WriteLine("Insira um número, sendo 1 - Jayme, 2 - Dorio silva e 3 - UPA Serra");
    op = int.Parse(Console.ReadLine());

    switch(op){
      case 1:
      nouni = "Jayme";
      break;

      case 2:
      nouni = "Dorio silva";
      break;
      
      case 3:
      nouni = "UPA Serra";
      break;

      default:
      Console.WriteLine("número inválido");
      break; 
    }

    Console.WriteLine("Consulta marcada com sucesso !!\n");

    sr.WriteLine("===== Unidade de consulta ===== \nNome unidade: "+nomeuni);

    sr.Close();
  }
}
  