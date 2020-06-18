using System;
using System.IO;

class Menu{
    //Escolha();
  
    public static void Escolha(){
      try{
      
      int n1;
      PacientePublico a = new PacientePublico();
      PacienteParticular b = new PacienteParticular();
      UnidadePublica c = new UnidadePublica();
      Sintomas d = new Sintomas();

      Console.WriteLine("Informe o código do serviço desejado: ");
      n1 = int.Parse(Console.ReadLine());
        
      if (n1 == 1){
        Console.WriteLine("Escolha um número de Paciente\n1 - Público\n2 - Particular");
        n1 = int.Parse(Console.ReadLine());
            
        if (n1 == 1){
          a.CadPacientePublico();
        }
        else if (n1 == 2){
          b.CadPacienteParticular();
        }
      }
      if (n1 == 2){
        Console.WriteLine("Nos informe os sintomas: ");
        d.ColetarSintomas();

        Console.WriteLine("Vamos te encaminhar para uma unidade.");
        c.CadUnidadePublica();
      }
    }
    catch(FormatException e){
      Console.WriteLine("Não deixe em Branco, digite números e não letras!");
    }
  } 
}