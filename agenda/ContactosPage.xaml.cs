using System.Collections.ObjectModel;
using System.Linq;
using Microsoft.Maui.Controls;
using agenda;

namespace agenda;
public partial class ContactosPage : ContentPage
{
    public ObservableCollection<Contacto> Contactos { get; set; }

    public ContactosPage()
    {
        InitializeComponent();
        Contactos = new ObservableCollection<Contacto>
       {
           new Contacto { Nombre = "Kislev Martinez", Telefono = "123456789", Correo = "kislev@correo.com" },
           new Contacto { Nombre = "Melissa Orduño", Telefono = "987654321", Correo = "melissa@correo.com" }
       };
        BindingContext = this;
    }


    public async void OnItemSelected(object sender, SelectionChangedEventArgs e)
    {
        var contactoSeleccionado = e.CurrentSelection.FirstOrDefault() as Contacto;
        if (contactoSeleccionado != null)
        {
            await Navigation.PushAsync(new DetalleContactoPage(contactoSeleccionado));
        }
    }
}