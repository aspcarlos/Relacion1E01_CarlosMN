namespace Relacion1E01_CarlosMN;

public partial class Ejercicio01 : ContentPage
{
	public Ejercicio01()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
        try
        {
            string nombre = Nombre.Text;
            string apellido = Apellidos.Text;
            int edad = int.Parse(Edad.Text);

            Usuario usuario = new Usuario(nombre, apellido, edad);
            usuario.ValidarDatos();

            // Si la validación es exitosa, mostraremos una alerta con DisplayAlert()
            if (usuario.TieneAcceso() && usuario.ValidarDatos())
            {
                lblResultado.Text = $"{apellido}, {nombre} : Tienes Acceso al Sistema";
            }
            else
            {
                lblResultado.Text = $"{apellido}, {nombre} : No tienes Acceso al Sistema";
            }
           
        }
        catch (NombreInvalidoException ex)
        {
            DisplayAlert("Error", ex.Message, "OK");
        }
        catch (ApellidoInvalidoException ex)
        {
            DisplayAlert("Error", ex.Message, "OK");
        }
        catch (EdadInvalidaException ex)
        {
            DisplayAlert("Error", ex.Message, "OK");
        }
    }
}