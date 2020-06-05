using System;
using System.IO;

class Calendario{

  private int dia; //atributos
  private int mes;


  public int Dia{ //encapsulamento
    get{ 
      return dia;
    }
    set{
      dia = value;
    }
  }
  public int Mes{
    get{
      return mes;
    }
    set{
      mes = value;
    }
  }
}
