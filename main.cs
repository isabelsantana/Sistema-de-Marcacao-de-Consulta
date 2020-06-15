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
      UnidadePublica ele = new UnidadePublica();

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
      }
      if (n1 == 2){
        Console.WriteLine("Nos informe os sintomas: ");

        Console.WriteLine("Vamos te encaminhar para uma unidade.");
        ele.CadUnidadePublica();
      }
    }
    catch(FormatException e){
      Console.WriteLine("Não deixe em Branco, digite números e não letras!");
    }
    finally{
      Console.WriteLine("Deseja cadastrar outro paciente s ou n?");
      string escolha = Console.ReadLine();
      if(escolha == "s"){
        Escolha();
      }
    }
  } 
}