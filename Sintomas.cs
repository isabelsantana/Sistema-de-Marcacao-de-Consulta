using System;
using System.IO;
using System.Text;

class Sintomas{

  private string sintoma;
  private string triagem;

  StreamWriter sin = new StreamWriter("Sintomas.txt");

  public Sintomas(){
    sintoma = "febre";
    triagem = "Laranja";
  }

  public Sintomas(string Sintoma, string Triagem){
    sintoma = Sintoma;
    triagem = Triagem;
  }

  public string Sintoma{
    get {return sintoma;}
    set {sintoma = value;}
  }

  public string Triagem{
    get{return triagem;}
    set{triagem = value;} 
  }   

  public void ColetarSintomas(){ // método para coletar os sintomas do usuário 
  
  Console.WriteLine("Informe seus sintomas: ");
  Sintoma = Console.ReadLine();
  if(Sintoma == "dor no peito" || Sintoma == "falta de ar" || Sintoma == "febre" || Sintoma == "vomito"){
    Triagem = "Laranja";
  }
  else if(sintoma == "desmaio"){
    Triagem = "Vermelha";
  }
  else{
    Triagem = "Amarela";
  }

  sin.WriteLine("===== Sintomas ===== \nPrincipal sintoma: "+sintoma + "\nTriagem"+ triagem);

  sin.Close();

  }  

}

