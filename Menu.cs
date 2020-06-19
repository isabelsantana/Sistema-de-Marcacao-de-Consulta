using System;
using System.IO;

public class Menu{

  public void EscolhaDeServico(){
  string opcao; 

    PacientePublico pacientePublico = new PacientePublico(); //instancia das classes
    PacienteParticular pacienteParticular = new PacienteParticular();
            
    string[] lines = File.ReadAllLines("menu.txt"); //arquivo pra mostrar mensagem 
      foreach(var line in lines) Console.WriteLine(line); 

    Console.WriteLine("\nDigite 1 para continuarmos!\n ");
    opcao = Console.ReadLine();
   
      if (opcao == "1"){
        Console.WriteLine("\nVocê é um paciente: \n1 - Público\n2 - Particular\n");
        opcao = Console.ReadLine();
              
        if (opcao == "1"){
          pacientePublico.CadastroPacientePublico();
        }

        else if (opcao == "2"){
            pacienteParticular.CadastroPacienteParticular();
        }
      }

   
  } 
}