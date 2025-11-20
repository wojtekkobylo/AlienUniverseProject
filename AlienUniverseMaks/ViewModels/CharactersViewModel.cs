using System.Collections.Generic;
using System.Collections.ObjectModel;
using AlienUniverseMaks.Models;
using Avalonia.ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Reactive;
using System.Reactive.Linq;
using DynamicData.Diagnostics;
using ReactiveUI;
using ReactiveUI.Fody.Helpers;

namespace AlienUniverseMaks.ViewModels;

public class Character
{
    public string Name { get; set; }
    public string Role { get; set; }
    public string Actor { get; set; }
    public string Race { get; set; }
    public string YearOfBirth { get; set; }
    public string Description { get; set; }
}

public class CharactersViewModel : ReactiveObject
{
    public ObservableCollection<Character> Characters { get; }
    public ObservableCollection<Character> FilteredCharacters { get; }
    public ObservableCollection<string> AvailableRaces { get; }

    string selectedRace;
    public string SelectedRace
    {
        get => selectedRace;
        set
        {
            this.RaiseAndSetIfChanged(ref selectedRace, value);
            Filter();
        }
    }

    public CharactersViewModel(List<string> names)
    {
        Characters = new ObservableCollection<Character>(
                 AllCharacters().Where(c =>
                         names.Any(n => c.Name.Contains(n, StringComparison.InvariantCultureIgnoreCase))
                     )
             );
        FilteredCharacters = new ObservableCollection<Character>(Characters);
        AvailableRaces = new ObservableCollection<string>(Characters.Select(c => c.Race).Distinct().Prepend("Wszystkie"));
        SelectedRace = "Wszystkie";
    }

    void Filter()
    {
        FilteredCharacters.Clear();
        foreach (var c in SelectedRace == "Wszystkie" ? Characters : Characters.Where(x => x.Race == SelectedRace))
            FilteredCharacters.Add(c);
    }

    List<Character> AllCharacters() => new List<Character>
    { 
        new Character{ Name="Ellen Louise Ripley", Role="Oficer bezpieczeństwa", Actor="Sigourney Weaver", Race="Człowiek", YearOfBirth="2092", Description="Zdeterminowana, inteligentna." },
        new Character{ Name="Arthur Koblenz Dallas", Role="Kapitan", Actor="Tom Skerritt", Race="Człowiek", YearOfBirth="2071", Description="Opanowany, odpowiedzialny." },
        new Character{ Name="Ash", Role="Oficer naukowy", Actor="Ian Holm", Race="Android", YearOfBirth="Brak danych", Description="Kierowany tajnymi rozkazami." },
        new Character{ Name="Bishop", Role="Oficer naukowy", Actor="Lance Henriksen", Race="Android", YearOfBirth="Brak danych", Description="Empatyczny, lojalny." },
        new Character{ Name="Jenette Vasquez", Role="Strzelec marines", Actor="Jenette Goldstein", Race="Człowiek", YearOfBirth="2124", Description="Odważna i zadziorna." },
        new Character{ Name="Rebecca \"Newt\" Jorden", Role="Ocalona z kolonii", Actor="Carrie Henn", Race="Człowiek", YearOfBirth="2172", Description="Sprytna, psychicznie odporna." },
        new Character{ Name="The Queen Alien", Role="Królowa obcych", Actor="Animatronics", Race="Obcy", YearOfBirth="-", Description="Agresywna, inteligentna." },
        new Character{ Name="Annalee Call", Role="Specjalistka ds. techniki", Actor="Winona Ryder", Race="Android", YearOfBirth="2381", Description="Emocjonalna, moralna." },
        new Character{ Name="Ripley 8", Role="Klon Ripley", Actor="Sigourney Weaver", Race="Hybryda", YearOfBirth="2381", Description="Silna, rozdarta." },
        new Character{ Name="The Engineer", Role="Stwórca ludzi", Actor="Ian Whyte", Race="Inżynier", YearOfBirth="Nieznany", Description="Majestatyczny, potężny." },
        new Character{ Name="Neomorph", Role="Mutant", Actor="CGI", Race="Obcy", YearOfBirth="Brak danych", Description="Szybki, nieprzewidywalny." },
        new Character{ Name="Daniels Branson", Role="Oficer kolonizacyjny", Actor="Katherine Waterston", Race="Człowiek", YearOfBirth="2100", Description="Pragmatyczna, odważna." }
    };
}
