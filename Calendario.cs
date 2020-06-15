using System;
using System.IO;

class Calendario{

  protected int dia; //atributos
  protected int mes;


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
