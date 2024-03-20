using System.Diagnostics;
using System.Reflection;

namespace DynamicTheme00;
enum CustomAppTheme
{
    Light,
    Dark,
    Warm,
}
public partial class Banner : ContentView
{
    public Banner() => InitializeComponent();
    public bool IsSwitchToggled
    {
        get => _isSwitchToggled;
        set
        {
            if (!Equals(_isSwitchToggled, value))
            {
                _isSwitchToggled = value;
                ((App)App.Current!).UserAppTheme = 
                    _isSwitchToggled ? 
                    CustomAppTheme.Warm :
                    CustomAppTheme.Light;
                OnPropertyChanged();
            }
        }
    }
    bool _isSwitchToggled = default;
}