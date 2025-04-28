using Microsoft.Maui.Controls;
using agenda;

namespace agenda;
public partial class CrearContactoPage : ContentPage
{
    public CrearContactoPage()
    {
        InitializeComponent();
    }

    public async void OnGuardarClicked(object sender, EventArgs e)
    {
        string nombre = NombreEntry.Text;
        string telefono = TelefonoEntry.Text;
        string correo = CorreoEntry.Text;
        string direccion = DireccionEntry.Text;

        if (string.IsNullOrEmpty(nombre) || string.IsNullOrEmpty(telefono) || string.IsNullOrEmpty(correo) || string.IsNullOrEmpty(direccion))
        {
            await DisplayAlert("Error", "Por favor, complete todos los campos", "OK");
            return;
        }

        var nuevoContacto = new Contacto
        {
            Nombre = nombre,
            Telefono = telefono,
            Correo = correo,
            Direccion = direccion
        };

        var contactosPage = Application.Current?.MainPage?.Navigation.NavigationStack
            .FirstOrDefault(page => page is ContactosPage) as ContactosPage;

        if (contactosPage != null)
        {
            contactosPage.Contactos.Add(nuevoContacto);
        }

        await DisplayAlert("Éxito", "Contacto guardado correctamente", "OK");
        await Navigation.PopAsync();
    }
}