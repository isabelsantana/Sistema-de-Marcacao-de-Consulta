using System;
using System.IO;
using System.Text;

public class PacientePublico : Paciente{

  Sintomas sintoma = new Sintomas();
  protected int CartaoSus;

  StreamWriter pacpublic = new StreamWriter("PacientePublico.txt");
  
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
 
  public void CadastroPacientePublico(){ // metodo para cadastrar ficha paciente publico

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

    string opcao; 
    Console.WriteLine("Sua consulta é de rotina ou você tem apresentado sintomas? \nDigite 1 para rotina e 2 se tiver apresentando sintomas\n ");
    opcao = Console.ReadLine();

    if (opcao == "1"){
      Console.WriteLine("Iremos marcar sua consulta!");
    }
    else if(opcao == "2"){
      sintoma.ColetarSintomas();
    }
    else{
      Console.WriteLine("Por favor, digite um número válido.");
      CadastroPacientePublico();
    }
    
          
    pacpublic.WriteLine("===== Pacientes Publicos ===== **\nNome: " +nome + "\nIdade: " +idade + "\nSexo: "+sexo +"\nCartão sus: " +CartaoSus);
      
    pacpublic.Close();
  }
}
  