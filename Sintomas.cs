using System;
using System.IO;

class Sintomas{

  private string descricao;
  private string triagem;

  public string Descricao{
    get{ 
      return descricao;
    }
    set{
      descricao = value;
    }
  }

  public string Triagem{
    get{
      return triagem;      
    }
    set{
      triagem = value;
    } 
  }   

  public void ColetarSintomas(){ // método para coletar os sintomas do usuário 
  
  Console.WriteLine("Informe seus sintomas: ");
  Descricao = Console.ReadLine();

  }  

}

