using System;

class MainClass {
  public static void Main (string[] args) {
    Console.WriteLine ("Funcionando");
    Menu.Intro();
    Escolha();
  }
  public static void Escolha(){
    try{
      int n1;
      PacientePublico eu = new PacientePublico();
      PacienteParticular eu2 = new PacienteParticular();

      Console.WriteLine("Informe o código do serviço desejado: ");
      n1 = int.Parse(Console.ReadLine());
        
      if (n1 == 1){
        Console.WriteLine("Escolha um número de Paciente\n1 - Público\n2 - Particular");
        n1 = int.Parse(Console.ReadLine());
            
        if (n1 == 1){
          eu.CadPacientePublico();
        }
        else if (n1 == 2){
          eu2.CadPacienteParticular();
        }
        MainClass.Escolha();
      }
    }
    catch(FormatException e){
      Console.WriteLine("Não deixe em Branco, digite números e não letras!");
    }
    finally{
      Escolha();
    }
  } 
}