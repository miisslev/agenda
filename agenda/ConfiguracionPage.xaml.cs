using Microsoft.Maui.Controls;

namespace agenda;
public partial class ConfiguracionPage : ContentPage
{
    public ConfiguracionPage()
    {
        InitializeComponent();
    }

    private void OnNotificacionesSwitchToggled(object sender, ToggledEventArgs e)
    {
        bool isNotificacionesOn = e.Value;
        if (isNotificacionesOn)
        {
            DisplayAlert("Notificaciones", "Las notificaciones están activadas.", "OK");
        }
        else
        {
            DisplayAlert("Notificaciones", "Las notificaciones están desactivadas.", "OK");
        }
    }

    private void OnCambiarTemaClicked(object sender, EventArgs e)
    {
        var currentTheme = Application.Current.UserAppTheme;
        Application.Current.UserAppTheme = currentTheme == AppTheme.Dark ? AppTheme.Light : AppTheme.Dark;
    }
}