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
    
    Console.WriteLine("Digite o nome do bairro e cidade onde deseja marcar a consulta\n");
    Console.Write("Bairro: ");
    baiuni = Console.ReadLine();
    Console.Write("Cidade: ");
    ciduni = Console.ReadLine();
    if(baiuni == "NC" && ciduni == "serra"){
      nouni = "Upa Serra";
    }
    else if(baiuni == "Laranjeiras" && ciduni == "serra"){
      nouni = "Upa Carapina";
    }
    else if(ciduni == "serra"){
      nouni = "Jayme Santos Neves";
    }
    
    sr.WriteLine("===== Unidade Publica da Consulta ===== \nNome unidade: "+nomeuni);

    sr.Close();
  }
}
  