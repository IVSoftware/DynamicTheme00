using System.Diagnostics;
using System.Reflection;

namespace DynamicTheme00;

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
                    CustomAppTheme.Dark :
                    CustomAppTheme.Light;
            }
        }
    }
    bool _isSwitchToggled = default;
}