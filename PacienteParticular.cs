  
using System;
using System.IO;
using System.Text;

class PacienteParticular : Paciente{

  Sintomas sintoma = new Sintomas();//intancia de outra classe
  protected string plano; //Nome da empresa do plano de saude
  protected int numeroCad; //Numero de cadastro do plano

  StreamWriter pacpart = new StreamWriter("PacienteParticular.txt");
  UnidadeParticular unidpart = new UnidadeParticular();
  
  public PacienteParticular()
  {
    plano = "Unimed Vitoria";
    numeroCad = 1234567891;
  }
  
  public PacienteParticular(string plan, int cad)
  {
    plano = plan;
    numeroCad = cad;
  }
  
  public string plan{
    get {return plano;}
    set {plano = value;}
  }

  public int cad{
    get {return numeroCad;}
    set {numeroCad = value;}
  }

  public void CadPacienteParticular(){ // metodo para cadastrar ficha paciente particular

    Console.WriteLine("\n  ===== Paciente Particular ===== \n ");
  
    Console.Write("Nome: ");
    n = Console.ReadLine(); 

    Console.Write("Idade: ");
    id = int.Parse(Console.ReadLine());
    
    Console.Write("Sexo(F/M): ");
    s = char.Parse(Console.ReadLine());

    Console.Write("Plano de Saúde: ");
    plan = Console.ReadLine();

    Console.Write("Numero Inscrição do Plano de Saúde: ");
    cad = int.Parse(Console.ReadLine());
    Console.WriteLine();

    int opcao; 
    Console.WriteLine("Sua consulta é de rotina ou você tem apresentado sintomas? \nDigite 1 para rotina e 2 se tiver apresentando sintomas\n ");
    opcao = int.Parse(Console.ReadLine());

    if (opcao == 1){
      Console.WriteLine("Iremos marcar sua consulta!");
    }
    else if(opcao == 2){
      sintoma.ColetarSintomas();
      unidpart.CadUnidadeParticular();
    }
    else{
      Console.WriteLine("Por favor, digite um número válido.");
      CadPacienteParticular();
    }

    pacpart.WriteLine("===== Pacientes Particulares ===== \nNome: " +nome + "\nIdade: " +idade + "\nSexo: "+sexo + "\nPlano de saúde: "+ plano+ "\nNumero inscrição do PS: "+cad);
    
    pacpart.Close();

    string[] lines = File.ReadAllLines("PacienteParticular.txt"); //arquivo pra mostrar mensagem 
      foreach(var line in lines) Console.WriteLine(line);

    string[] lines1 = File.ReadAllLines("UnidadeParticular.txt"); //arquivo pra mostrar mensagem 
      foreach(var line1 in lines1) Console.WriteLine(line1); 

  }
}
  