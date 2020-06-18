  
using System;
using System.IO;
using System.Text;

class PacienteParticular : Paciente{
  protected string plano; //Nome da empresa do plano de saude
  protected int numeroCad; //Numero de cadastro do plano

  StreamWriter pacpart = new StreamWriter("PacienteParticular.txt");
  
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
    
    Console.Write("Sexo: ");
    s = char.Parse(Console.ReadLine());

    Console.Write("Plano de Saúde: ");
    plan = Console.ReadLine();

    Console.Write("Numero Inscrição do Plano de Saúde: ");
    cad = int.Parse(Console.ReadLine());

    pacpart.WriteLine("===== Pacientes Particulares ===== \nNome: " +nome + "\nIdade: " +idade + "\nSexo: "+sexo + "\nPlano de saúde: "+ plano+ "\nNumero inscrição do PS: "+cad);
    
    pacpart.Close();

  }
}
  