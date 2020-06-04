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
}
  