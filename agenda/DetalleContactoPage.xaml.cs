namespace agenda;

public partial class DetalleContactoPage : ContentPage
{
    public DetalleContactoPage(Contacto contacto)
    {
        InitializeComponent();

        
        NombreLabel.Text = contacto.Nombre;
        TelefonoLabel.Text = contacto.Telefono;
        CorreoLabel.Text = contacto.Correo;
        DireccionLabel.Text = contacto.Direccion;
    }
}