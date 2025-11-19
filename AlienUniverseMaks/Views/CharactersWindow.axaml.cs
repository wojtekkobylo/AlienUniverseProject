using Avalonia.ReactiveUI;
using ReactiveUI;
using System.Reactive.Disposables;
using AlienUniverseMaks.ViewModels;

namespace AlienUniverseMaks.Views;

public partial class CharactersWindow : ReactiveWindow<CharactersViewModel>
{
    public CharactersWindow()
    {
        InitializeComponent();
    }
}