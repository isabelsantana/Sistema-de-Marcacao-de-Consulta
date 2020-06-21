using System;
using System.IO;
using System.Text;

class UnidadePublica : Unidade{
  protected string nomeuni;
  protected int dia;
  protected int mes;
  protected int hora;

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

  public int Dia{
    get {return dia;}
    set {dia = value;}
  }

  public int Mes{
    get {return mes;}
    set {mes = value;}
  }

  public int Hora{
    get {return hora;}
    set {hora = value;}
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

    Console.Write("Dia: ");
    Dia = int.Parse(Console.ReadLine());
    if(Dia > 31){
      CadUnidadePublica();
    }
    else{
      Console.Write("Mes: ");
      Mes = int.Parse(Console.ReadLine());
      if(Mes > 12){
        CadUnidadePublica();
      }
      else{
        Console.Write("Hora (escolha de 8 ás 17): ");
        Hora = int.Parse(Console.ReadLine());
        if(Hora < 8 || Hora > 17){
          Console.WriteLine("Hora Inválida.");
          CadUnidadePublica();
        }
        Console.WriteLine("\nConsulta marcada com sucesso !!\n");
      }
    }

    sr.WriteLine("===== Unidade de consulta ===== \nNome unidade: "+nomeuni+"\nData: {0}/{1}\nHorario da consulta: {2}:00", dia, mes, hora);

    sr.Close();
  }
}
  