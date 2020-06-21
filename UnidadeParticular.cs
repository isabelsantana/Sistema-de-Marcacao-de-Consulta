using System;
using System.IO;

class UnidadeParticular : Unidade{
  protected string nomeunip;
  protected int dia;
  protected int mes;
  protected int hora;
  
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

    Console.Write("Dia: ");
    Dia = int.Parse(Console.ReadLine());
    if(Dia > 31){
      CadUnidadeParticular();
    }
    else{
      Console.Write("Mes: ");
      Mes = int.Parse(Console.ReadLine());
      if(Mes > 12){
        CadUnidadeParticular();
      }
      else{
        Console.Write("Hora (escolha de 8 ás 17): ");
        Hora = int.Parse(Console.ReadLine());
        if(Hora < 8 || Hora > 17){
          Console.WriteLine("Hora Inválida.");
          CadUnidadeParticular();
        }
        Console.WriteLine("\nConsulta marcada com sucesso !!\n");
      }
    }

    srp.WriteLine("===== Unidade de consulta ===== \nNome unidade: "+nomeunip+"\nData: {0}/{1}\nHorario da consulta: {2}:00", dia, mes, hora);

    srp.Close();
  }
}