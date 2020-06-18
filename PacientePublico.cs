using System;
using System.IO;
using System.Text;

class PacientePublico : Paciente{
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
 
  public void CadPacientePublico(){ // metodo para cadastrar ficha paciente publico

    Console.WriteLine("\n  ===== Paciente Publico ===== \n ");
    
    Console.Write("Nome: ");
    nome = Console.ReadLine();

    Console.Write("Idade: ");
    idade = int.Parse(Console.ReadLine());

    Console.Write("Sexo: ");
    sexo = char.Parse(Console.ReadLine());

    Console.Write("Cartão SUS: ");
    cs = int.Parse(Console.ReadLine());

    Console.WriteLine("Iremos marcar sua consulta: ");
    
          
    pacpublic.WriteLine("===== Pacientes Publicos ===== **\nNome: " +nome + "\nIdade: " +idade + "\nSexo: "+sexo +"\nCartão sus: " +CartaoSus);
      
    pacpublic.Close();
  }
}
  