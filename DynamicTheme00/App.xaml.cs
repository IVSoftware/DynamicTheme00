namespace DynamicTheme00
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            MainPage = new AppShell();
        }
        public new Enum UserAppTheme
        {
            get => _userAppTheme;
            set
            {
                if (!Equals(_userAppTheme, value))
                {
                    _userAppTheme = value;
                    switch (value)
                    {
                        case AppTheme.Light:
                        case CustomAppTheme.Light:
                            base.UserAppTheme = AppTheme.Light;
                            break;
                        case AppTheme.Dark:
                        case CustomAppTheme.Dark:
                            base.UserAppTheme = AppTheme.Dark;
                            break;
                        default:
                            _ = MainPage?.DisplayAlert("ThemeChange", $"{value}", "OK");
                            break;
                    }
                    OnPropertyChanged();
                }
            }
        }
        Enum _userAppTheme = AppTheme.Light;
    }
}
