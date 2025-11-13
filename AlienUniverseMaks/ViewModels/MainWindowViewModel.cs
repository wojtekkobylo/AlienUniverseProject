using System.Collections.Generic;
using System.Collections.ObjectModel;
using AlienUniverseMaks.Models;
using Avalonia.ReactiveUI;
using System;
using System.Collections.ObjectModel;
using System.Reactive;
using System.Reactive.Linq;
using ReactiveUI;

namespace AlienUniverseMaks.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    public ObservableCollection<Film> Films { get; } = new()
    {
        new Film
        {
            title = "Alien",
            pltitle = "Obcy – ósmy pasażer Nostromo",
            releaseYear = 1979,
            director = "Ridley Scott",
            scenario = "Dan O’Bannon",
            genre = "Sci-Fi / Horror",
            movieTime = "117 minut",
            rating = 8.5,
            mainCharacters = new List<string> { "Ellen Ripley", "Dallas", "Ash", "Lambert", "Kane" },
            ship = "USCSS Nostromo",
            description = "Załoga statku handlowego Nostromo odbiera sygnał z nieznanej planety. Po lądowaniu odkrywają obcą formę życia, która zaczyna eliminować członków załogi jeden po drugim.",
            funFact = "Scena z „wyskakującym potworem” z klatki piersiowej aktora była niespodzianką dla obsady – ich reakcje są autentyczne."
        },
        new Film
        {
            title = "Aliens",
            pltitle = "Obcy – decydujące starcie",
            releaseYear = 1986,
            director = "James Cameron",
            scenario = "James Cameron, David Giler, Walter Hill",
            genre = "Sci-Fi / Akcja / Horror",
            movieTime = "137 minut",
            rating = 8.4,
            mainCharacters = new List<string> { "Ellen Ripley", "Hicks", "Newt", "Bishop", "Vasquez" },
            ship = "USS Sulaco",
            description = "Ripley, jedyna ocalała z wcześniejszego ataku obcego, wraca z oddziałem kolonialnych marines na księżyc LV-426, by zbadać utratę kontaktu z kolonią. Wkrótce stają oko w oko z armią obcych.",
            funFact = "James Cameron napisał scenariusz podczas lotu do Londynu, tworząc tytuł w liczbie mnogiej – symbolicznie zapowiadając, że tym razem potworów będzie więcej."
        },
        new Film
        {
            title = "Alien³",
            pltitle = "Obcy³",
            releaseYear = 1992,
            director = "David Fincher",
            scenario = "David Giler, Walter Hill, Larry Ferguson",
            genre = "Sci-Fi / Horror",
            movieTime = "114 minut",
            rating = 6.5,
            mainCharacters = new List<string> { "Ellen Ripley", "Dillon", "Clemens", "Morse", "Andrews" },
            ship = "E.E.V. z USS Sulaco (katastrofa)",
            description = "Po katastrofie statku Sulaco Ripley trafia na więzienną planetę Fiorina 161, gdzie wkrótce pojawia się obcy. Pozbawiona broni i wsparcia, musi walczyć o życie wśród skazańców i odkrywa, że nosi w sobie embrion królowej obcych.",
            funFact = "David Fincher zadebiutował tym filmem jako reżyser, jednak miał ograniczoną kontrolę twórczą, a produkcja była pełna konfliktów – reżyser później odciął się od tego projektu."
        },
        new Film
        {
            title = "Alien: Resurrection",
            pltitle = "Obcy: Przebudzenie",
            releaseYear = 1997,
            director = "Jean-Pierre Jeunet",
            scenario = "Joss Whedon",
            genre = "Sci-Fi / Horror",
            movieTime = "109 minut",
            rating = 6.2,
            mainCharacters = new List<string> { "Ellen Ripley (klon)", "Call", "Johner", "Christie", "Dr. Gediman" },
            ship = "USM Auriga",
            description = "Dwieście lat po śmierci Ripley naukowcy klonują ją, by wydobyć królową obcych z jej ciała. Klonowana Ripley zyskuje niezwykłe zdolności i wraz z grupą kosmicznych najemników musi zapobiec katastrofie, gdy obcy wydostają się na wolność.",
            funFact = "Postać androidki Call gra Winona Ryder, a film miał początkowo być początkiem nowej trylogii, która jednak nigdy nie powstała."
        },
        new Film
        {
            title = "Prometheus",
            pltitle = "Prometeusz",
            releaseYear = 2012,
            director = "Ridley Scott",
            scenario = "Jon Spaihts, Damon Lindelof",
            genre = "Sci-Fi / Thriller",
            movieTime = "124 minuty",
            rating = 7.0,
            mainCharacters = new List<string> { "Elizabeth Shaw", "David", "Charlie Holloway", "Meredith Vickers" },
            ship = "USCSS Prometheus",
            description = "Ekspedycja naukowa wyrusza na odległą planetę, by odkryć pochodzenie ludzkości. Na miejscu załoga Prometeusza odkrywa ruiny cywilizacji Inżynierów oraz coś, co nigdy nie powinno zostać obudzone.",
            funFact = "Ridley Scott planował, aby film stanowił zarówno prequel „Obcego”, jak i samodzielną opowieść o powstaniu życia i człowieka – wiele elementów łączy się z mitologią obcych w sposób pośredni."
        },
        new Film
        {
            title = "Alien: Covenant",
            pltitle = "Obcy: Przymierze",
            releaseYear = 2017,
            director = "Ridley Scott",
            scenario = "John Logan, Dante Harper",
            genre = "Sci-Fi / Horror",
            movieTime = "122 minuty",
            rating = 6.4,
            mainCharacters = new List<string> { "Daniels", "David", "Walter", "Oram", "Tennessee" },
            ship = "USCSS Covenant",
            description = "Załoga statku kolonizacyjnego Covenant odkrywa nieznaną planetę, idealną do osiedlenia. Na miejscu natrafiają jednak na Davida – syntetyka ocalałego z Prometeusza – oraz nowe formy obcych stworzeń, które mogą zakończyć ludzką ekspansję w kosmosie.",
            funFact = "Film pierwotnie miał być zatytułowany „Paradise Lost”, a reżyser planował jeszcze jedną część łączącą fabułę z oryginalnym „Obcym” z 1979 roku."
        }
    };
    private Film _selectedFilm;

    public Film SelectedFilm
    {
        get => _selectedFilm;
        set => this.RaiseAndSetIfChanged( ref this._selectedFilm, value );
    }
}
