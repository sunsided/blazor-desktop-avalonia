using System.Windows.Input;
using ReactiveUI;

namespace AvaloniaUI.ViewModels;

public class MainWindowViewModel : ViewModelBase
{
    private int _count;

    public MainWindowViewModel()
    {
        AddOneCommand = ReactiveCommand.Create(() => { Count++; });
    }

    public int Count
    {
        get => _count;
        private set => this.RaiseAndSetIfChanged(ref _count, value);
    }

    public ICommand AddOneCommand { get; }
}
