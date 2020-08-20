using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpLabs
{
  class Program
  {
    static void Main(string[] args)
    {
      // 1
      ResearchTeam researchTeam = new ResearchTeam();
      Console.WriteLine(researchTeam.ToShortString());
      // 2
      Console.WriteLine($"Значение для {TimeFrame.Year}: {researchTeam[TimeFrame.Year]}");
      Console.WriteLine($"Значение для {TimeFrame.TwoYears}: {researchTeam[TimeFrame.TwoYears]}");
      Console.WriteLine($"Значение для {TimeFrame.Long}: {researchTeam[TimeFrame.Long]}");
      // 3
      researchTeam.Number = 99;
      researchTeam.Organization = "NPK TC";
      researchTeam.Theme = "CAD";
      researchTeam.TimeFrame = TimeFrame.TwoYears;
      Console.WriteLine(researchTeam.ToString());
      // 4
      researchTeam.Papers.Add(new Paper());
      Console.WriteLine(researchTeam.ToString());
      // 5 
      Console.WriteLine(researchTeam.LastPaper);
      // 6
      Console.WriteLine("Введите через пробел число строк и число столбцов");
      string[] sizeRC = Console.ReadLine().Split(' ');
      if (int.TryParse(sizeRC[0], out int nrow) &&
        int.TryParse(sizeRC[1], out int ncolumn))
      {
        Stopwatch timer = new Stopwatch();
        // замер времени для одномерного массива
        ResearchTeam[] researchTeams1 = new ResearchTeam[nrow * ncolumn];
        for (int i = 0; i < nrow * ncolumn; i++)
          researchTeams1[i] = new ResearchTeam();
        timer.Start();
        for (int i = 0; i < nrow * ncolumn; i++)
          researchTeams1[i].Number = i;
        timer.Stop();
        Console.WriteLine(timer.Elapsed);

        // замер времени для двумерного массива
        ResearchTeam[,] researchTeams2 = new ResearchTeam[nrow, ncolumn];
        for (int i = 0; i < nrow; i++)
        {
          for (int j = 0; j < ncolumn; j++)
            researchTeams2[i, j] = new ResearchTeam();
        }
        timer.Restart();
        for (int i = 0; i < nrow; i++)
        {
          for (int j = 0; j < ncolumn; j++)
            researchTeams2[i, j].Number = j;
        }
        timer.Stop();
        Console.WriteLine(timer.Elapsed);

        // замер времени для ступенчатого массива
        ResearchTeam[][] researchTeams3 = new ResearchTeam[nrow][];
        for (int i = 0; i < nrow; i++)
        {
          researchTeams3[i] = new ResearchTeam[i + 1];
          for (int j = 0; j < i + 1; j++)
            researchTeams3[i][j] = new ResearchTeam();
        }
        timer.Restart();
        for (int i = 0; i < nrow; i++)
        {
          for (int j = 0; j < i + 1; j++)
            researchTeams3[i][j].Number = j;
        }
        timer.Stop();
        Console.WriteLine(timer.Elapsed);
      }
      else
        Console.WriteLine("Введите числа!");
    }
  }
}
