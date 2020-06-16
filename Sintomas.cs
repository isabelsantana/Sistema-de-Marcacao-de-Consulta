using System;
using System.IO;

class Sintomas{

  protected string descricao;
  protected string triagem;

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

    int[] sint = new int [5];
    

    string[] lines = File.ReadAllLines("sintomas.txt");
      foreach(var line in lines) Console.WriteLine(line);

    Console.WriteLine("Informe os sintomas: ");

    for (int i = 0; i < 5 ; i++){
      sint[i] = int.Parse(Console.ReadLine());
    }

    Console.WriteLine("Os sintomas apresentados:{0} ",sint[5]);
      
    

 
  }  



}

