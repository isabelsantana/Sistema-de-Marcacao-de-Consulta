using System;
using System.IO;

class Menu{
    public static void Escolha(){
    try{
      int n1;
      PacientePublico a = new PacientePublico();
      PacienteParticular b = new PacienteParticular();

      string[] lines = File.ReadAllLines("menu.txt"); //arquivo pra mostrar mensagem 
        foreach(var line in lines) Console.WriteLine(line); 
    
      Console.WriteLine("\nVocê é um paciente: \n1 - Público\n2 - Particular\n");
      n1 = int.Parse(Console.ReadLine());
            
      if (n1 == 1){
        a.CadPacientePublico();

      }
      else if (n1 == 2){
        b.CadPacienteParticular();
      }
    }
    catch(FormatException){
      Console.WriteLine("Não deixe em Branco, digite números e não letras!");
    }
  }
}