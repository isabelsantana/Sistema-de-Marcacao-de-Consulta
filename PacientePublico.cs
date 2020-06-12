using System;
using System.IO;

class PacientePublico : Paciente{
  protected int CartaoSus;
  
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

    Console.Write("Cidade: ");
    cidade = Console.ReadLine();

    Console.Write("Cartão SUS: ");
    cs = int.Parse(Console.ReadLine());
        
    File.WriteAllText("PacientePublico.txt", "===== Pacientes Publicos ===== **\nNome: " +nome + "\nIdade: " +idade + "\nSexo: "+sexo +"\nCidade do paciente: " +cidade);

  }
}
  