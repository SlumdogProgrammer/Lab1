using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1.Code
{
  class ResearchTeam
  {
    private string _Theme;
    private string _Organization;
    private int _Number;
    private TimeFrame _TimeFrame;
    private List<Paper> _Papers;

    public ResearchTeam(string theme, string org, int num, TimeFrame tf)
    {
      _Theme = theme;
      _Organization = org;
      _Number = num;
      _TimeFrame = tf;
      _Papers = new List<Paper>();
    }

    public ResearchTeam()
    {
      _Theme = "MyTheme";
      _Organization = "MyOrg";
      _Number = 1;
      _TimeFrame = TimeFrame.Long;
      _Papers = new List<Paper>();
    }

    public string Theme
    {
      get => _Theme;
      set => _Theme = value;
    }

    public string Organization
    {
      get => _Organization;
      set => _Organization = value;
    }

    public int Number
    {
      get => _Number;
      set => _Number = value;
    }

    public TimeFrame TimeFrame
    {
      get => _TimeFrame;
      set => _TimeFrame = value;
    }

    public List<Paper> Papers => _Papers;

    public Paper LastPaper => _Papers.Find(l => l.Date == _Papers.Max(p => p.Date));

    public bool this[TimeFrame timeFrame]
    {
      get => timeFrame == _TimeFrame;
    }

    public void AddPapers(params Paper[] papers)
    {
      Papers.AddRange(papers);
    }

    public string ToShortString() =>
      $"Theme: {_Theme}\tOrganization: {_Organization}\t" +
      $"Number: {_Number}\tTimeFrame: {_TimeFrame}";

    public override string ToString() =>
      _Papers.Count == 0 ? "Нет публикаций" : $"{ToShortString()}\tPapers: {string.Join<Paper>("\n", _Papers.ToArray())}";
  }
}
