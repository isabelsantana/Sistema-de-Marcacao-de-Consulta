using System;
using System.IO;

class Menu{
  public static void Intro(){ // Método para exibir menu inicial
    string[] lines = File.ReadAllLines("Intro.txt");
      foreach(var line in lines) Console.WriteLine(line);
  }
}