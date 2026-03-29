using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace FirstMauiApplication.ViewModels
{
    /* INotifyPropertyChanged comes with an event .NET MAUI subscribes to automatically. 
     * This lets .NET MAUI know when the user interface needs to be updated. */

    //public class MainViewModel : INotifyPropertyChanged
    //{
    //    public event PropertyChangedEventHandler? PropertyChanged;

    //    void OnPropertyChanged(string name) 
    //    {
    //        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
    //    }
    //}

    public partial class MainViewModel : ObservableObject
    {
        public MainViewModel()
        {
            this.Items = new ObservableCollection<string>();
        }

        [ObservableProperty]
        ObservableCollection<string> items;

        [ObservableProperty]
        string text;

        [RelayCommand]
        void Add()
        {
            if (string.IsNullOrWhiteSpace(this.Text))
                return;

            this.Items.Add(Text);
            //Add item.
            this.Text = string.Empty;
        }

        [RelayCommand]
        void Delete(string s)
        {
            if(this.Items.Contains(s))
                this.Items.Remove(s);
        }

        [RelayCommand]
        async Task Tap(string s)
        {
            await Shell.Current.GoToAsync($"{nameof(DetailPage)}?Text={s}");
        }
    }
}