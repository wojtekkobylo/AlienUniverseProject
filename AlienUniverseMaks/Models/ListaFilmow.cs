using System.Collections.Generic;

namespace AlienUniverseMaks.Models;

public class Film
{
    public string title { get; set; } = "";
    public string pltitle {get; set;} = "";
    public int releaseYear { get; set; }
    public string director { get; set; } = "";
    public string scenario  { get; set; } = "";
    public string genre { get; set; } = "";
    public string movieTime {get; set;} = "x minut";
    public double rating  { get; set; } = 0;
    public List<string> mainCharacters {get; set;}
    public string ship {get; set;} = "";
    public string description  {get; set;} = "";
    public string funFact { get; set; } = "";
}