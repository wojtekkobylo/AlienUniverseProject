using System.Reactive;
using System.Reactive.Disposables;
using AlienUniverseMaks.ViewModels;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using ReactiveUI;

namespace AlienUniverseMaks.Views;

public partial class SummaryWindow : ReactiveWindow<SummaryWindowViewModel>
{
    public SummaryWindow()
    {
        InitializeComponent();
        
        this.WhenActivated((CompositeDisposable disposables) =>
        {
            ViewModel!.NewCharactersWindow.RegisterHandler(async interaction =>
            {
                var win = new CharactersWindow()
                {
                    DataContext = new CharactersViewModel(interaction.Input)
                };
                
                
                await win.ShowDialog(this);
                interaction.SetOutput(Unit.Default);
            }).DisposeWith(disposables);
        });
    }
}