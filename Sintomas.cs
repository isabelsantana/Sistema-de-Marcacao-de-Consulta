using System;
using System.IO;
using System.Collections.Generic;

public class Sintomas{

  public void ColetarSintomas(){ // método para coletar os sintomas do usuário 

    Console.WriteLine("\nInforme o código dos seus 3 principais sintomas: \n");

    Dictionary <int, string> sintoma = new Dictionary <int,string>();  

    sintoma.Add(1,"Dores locais nas articulações");
    sintoma.Add(2,"Tosse com catarro, seca, forte ou leve");
    sintoma.Add(3,"Calafrios");    
    sintoma.Add(4,"Febre");
    sintoma.Add(5,"Perda de Apetite");
    sintoma.Add(6,"Dor de gargangta ou irritação");
    sintoma.Add(7,"Dor de cabeça");
    sintoma.Add(8,"Falta de ar");
    sintoma.Add(9,"Dor ao movimentar os olhos");
    sintoma.Add(10,"Manchas vermelhas no corpo");
    sintoma.Add(11,"Dores musculares intensas");
    sintoma.Add(12,"Mal estar");
    sintoma.Add(13,"Chiado no peito");
    sintoma.Add(14,"Desconforto torácico");
    sintoma.Add(15,"Ansiedade");

    foreach (KeyValuePair <int, string> sint in sintoma){
      Console.WriteLine(sint.Key + " - " + sint.Value);
    }
    
    Console.WriteLine(); //apenas pular linha
    int[] vet = new int[3];

    for (int i = 0; i < vet.Length; i++){
      Console.WriteLine("Nos informe o código dos sintomas que tem apresentado.");
      vet[i] = int.Parse(Console.ReadLine());
    }
    Console.WriteLine("Obrigada, vamos te encaminhar para uma unidade!");  
  }
}







