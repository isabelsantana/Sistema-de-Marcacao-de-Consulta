using System;
using System.IO;
using System.Text;

class PacientePublico : Paciente{

  Sintomas sintoma = new Sintomas();
  protected int CartaoSus;

  StreamWriter pacpublic = new StreamWriter("PacientePublico.txt");
  UnidadePublica unidpub = new UnidadePublica();
  
  public PacientePublico()
  {
    CartaoSus = 1234567891;
  }
  
  public PacientePublico(int cs)
  {
    CartaoSus = cs;
  }
  
  public int cs{
    get {return CartaoSus;}
    set {CartaoSus = value;}
  } 
 
  public void CadPacientePublico(){ // metodo para cadastrar ficha paciente publico

    Console.WriteLine("\n  ===== Paciente Publico ===== \n ");
    
    Console.Write("Nome: ");
    nome = Console.ReadLine();

    Console.Write("Idade: ");
    idade = int.Parse(Console.ReadLine());

    Console.Write("Sexo (F/M): ");
    sexo = char.Parse(Console.ReadLine());

    Console.Write("Número do seu cartão SUS: ");
    cs = int.Parse(Console.ReadLine());
    Console.WriteLine();

    int opcao; 
    Console.WriteLine("Sua consulta é de rotina ou você tem apresentado sintomas? \nDigite 1 para rotina e 2 se tiver apresentando sintomas\n ");
    opcao = int.Parse(Console.ReadLine());

    if (opcao == 1){
      Console.WriteLine("Iremos marcar sua consulta!");
    }
    else if(opcao == 2){
      sintoma.ColetarSintomas();
      unidpub.CadUnidadePublica();
    }
    else{
      Console.WriteLine("Por favor, digite um número válido.");
      CadPacientePublico();
    }
    
          
    pacpublic.WriteLine("===== Consulta paciente publico ===== \nNome: " +nome + "\nIdade: " +idade + "\nSexo: "+sexo +"\nCartão sus: " +CartaoSus);
      
    pacpublic.Close();

    string[] lines = File.ReadAllLines("PacientePublico.txt"); //arquivo pra mostrar mensagem 
      foreach(var line in lines) Console.WriteLine(line);

    string[] lines1 = File.ReadAllLines("UnidadePublica.txt"); //arquivo pra mostrar mensagem 
      foreach(var line1 in lines1) Console.WriteLine(line1); 
  }
}
  