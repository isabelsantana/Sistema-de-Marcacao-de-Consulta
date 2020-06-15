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

    File.WriteAllText("UniPublic.txt", "===== Unidade Publica da Consulta =====\nBairro do paciente: " +bairrouni + "\nCidade do paciente: " +cidadeuni + "\nNome unidade: "+nomeuni);

  }
}
  