using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Code
{
  class Paper
  {
    public string Title { get; set; }
    public Person Author { get; set; }
    public DateTime Date { get; set; }

    public Paper(string title, Person author, DateTime date)
    {
      Title = title;
      Author = author;
      Date = date;
    }

    public Paper()
    {
      Title = "MyIssue";
      Author = new Person();
      Date = new DateTime();
    }

    public override string ToString() =>
      $"Title: {Title}\t Author: {Author}\t Date: {Date}";
  }
}
