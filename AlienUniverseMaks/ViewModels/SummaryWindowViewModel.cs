using System.Collections.Generic;
using System.Reactive;
using System.Reactive.Linq;
using AlienUniverseMaks.Models;
using AlienUniverseMaks.Views;
using ReactiveUI;

namespace AlienUniverseMaks.ViewModels;

public class SummaryWindowViewModel
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
    
    
     public ReactiveCommand<Unit, Unit> ShowCharactersWindow { get; }
    
    public Interaction<List<string>, Unit> NewCharactersWindow { get; }
    
    
    public SummaryWindowViewModel(Film data)
    {
        title = data.title;
        pltitle = data.pltitle;
        releaseYear = data.releaseYear;
        director = data.director;
        scenario = data.scenario;
        genre = data.genre;
        movieTime = data.movieTime;
        rating = data.rating;
        mainCharacters = data.mainCharacters;
        ship = data.ship;
        description = data.description;
        funFact = data.funFact;
        
        

        NewCharactersWindow = new Interaction<List<string>, Unit>();
        ShowCharactersWindow = ReactiveCommand.CreateFromTask(async () =>
        {
            if (mainCharacters != null)
            {
                await NewCharactersWindow.Handle(mainCharacters);
            }
        });
        

        
    }
    
    
}
