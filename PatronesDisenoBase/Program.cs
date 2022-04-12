using System;
using System.Collections.Generic;

namespace PatronesDisenoBase
{
  public class Program
  {
    static void Main(string[] args)
    {
      var jose = new SportyPerson("José", 42, "mexicano");
      var pancho = new SportyPerson("Francisco", 35, "mexicano");
      Console.WriteLine(jose.Show());
      Console.WriteLine(pancho.Show());
      jose.Running();

      // Pato instancia de la clase abstracta
      List<IVolador> patos = new List<IVolador>();
      List<IVolador> gallinas = new List<IVolador>();

      var pato1 = new Pato();
      var pato2 = new Pato();
      var pato3 = new Pato();
      patos.Add(pato1);
      patos.Add(pato2);
      patos.Add(pato3);

      AVolar(patos);

      var gallina1 = new Gallina();
      var gallina2 = new Gallina();
      var gallina3 = new Gallina();
      gallinas.Add(gallina1);
      gallinas.Add(gallina2);
      gallinas.Add(gallina3);

      AVolar(gallinas);

      Console.ReadLine();
    }

    static void AVolar(List<IVolador> aves)
    {
      foreach (var ave in aves)
      {
        ave.Vuela();
      }
    }

    interface IVolador
    {
      public void Vuela();
    }

    interface ICamidador
    {
      public void Camina();
    }

    public class Pato : IVolador, ICamidador
    {
      public void Vuela()
      {
        Console.WriteLine("Pato vuela");
      }

      public void Camina()
      {
        Console.WriteLine("Pato camina");
      }
    }

    public class Gallina : IVolador
    {
      public void Vuela()
      {
        Console.WriteLine("Gallina vuela");
      }
    }
  }
}

abstract class Person
{
  public string name;
  public int age;
  public string nationality;

  public Person(string _name, int _age, string _nationality)
  {
    name = _name;
    age = _age;
    nationality = _nationality;
  }

  public string Show()
  {
    return name + " " + age + " " + nationality;
  }
}

class SportyPerson : Person
{
  public SportyPerson(string _name, int _age, string _nationality) : base(_name, _age, _nationality)
  {

  }

  public void Running()
  {
    Console.WriteLine($"{name} esta corriendo");
  }
}



