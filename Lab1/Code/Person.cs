using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs
{
  class Person
  {
    private string _Name;
    private string _Surname;
    DateTime _Birth;

    public Person(string name, string surname, DateTime birth)
    {
      _Name = name;
      _Surname = surname;
      _Birth = birth;
    }

    public Person()
    {
      _Name = "Ivan";
      _Surname = "Bolvan";
      _Birth = new DateTime(2020, 8, 9);
    }

    public string Name
    {
      get => _Name;
      set => _Name = value;
    }

    public string Surname
    {
      get => _Surname;
      set => _Surname = value;
    }

    public DateTime Birth
    {
      get => _Birth;
      set => _Birth = value;
    }

    public int ChangeYear
    {
      get => _Birth.Year;
      set => _Birth.AddYears(-_Birth.Year + value);
    }

    public virtual string ToShortString() =>
      $"Name: {_Name}\t Surname: {_Surname}";

    public override string ToString() =>
      $"{ToShortString()}\tBirt: {_Birth}";

  }
}
