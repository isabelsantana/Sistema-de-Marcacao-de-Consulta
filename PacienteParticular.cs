using System;
using System.IO;

class PacienteParticular : Paciente{
  protected string plano; //Nome da empresa do plano de saude
  protected int numeroCad; //Numero de cadastro do plano
  
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
}
  