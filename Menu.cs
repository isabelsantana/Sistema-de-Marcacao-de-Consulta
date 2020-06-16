using System;
using System.IO;

class Menu{

  Sintomas s = new Sintomas();
  public void Sumario(){

    Console.WriteLine("----- OLÁ, BEM VINDO(A) AO NOSSO SERVIÇO DE AGENDAMENTO DE CONSULTA -----");
  

    string opcao;

    Console.WriteLine("\nPara marcar uma consulta digite 1\n");
    opcao = Console.ReadLine();
    
    if (opcao == "1"){
      s.ColetarSintomas();
    }



    
    
  }
}