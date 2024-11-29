using Microsoft.Maui.Controls;
using StarBank.Views;

namespace StarBank.Views;

public partial class PageLogin : ContentPage
{
	public PageLogin()
	{
		InitializeComponent();
	}

    // Método que se ejecuta cuando se hace clic en el label "Regístrese aquí"
    private async void OnRegisterLblRegistro(object sender, EventArgs e)
    {
        // Navegar a la página de registro
        await Navigation.PushAsync(new PageRegistro());
    }

    // Método que se ejecuta cuando el usuario hace clic en "Ingresar"
    private async void Button_Clicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text?.Trim();
        string password = PasswordEntry.Text?.Trim();

        // Validación de usuario y contraseña
        if (string.IsNullOrEmpty(username))
        {
            await DisplayAlert("Error", "Por favor, ingrese su usuario.", "OK");
            return;
        }

        if (string.IsNullOrEmpty(password))
        {
            await DisplayAlert("Error", "Por favor, ingrese su contraseña.", "OK");
            return;
        }

        // Si la validación pasa, proceder con la autenticación
        bool isAuthenticated = AuthenticateUser(username, password);

        if (isAuthenticated)
        {
            // Si el usuario está autenticado, navegar a la página principal
            await Navigation.PushAsync(new PagePrincipal());
        }
        else
        {
            // Si la autenticación falla, mostrar un mensaje de error
            await DisplayAlert("Error", "Usuario o contraseña incorrectos.", "OK");
        }
    }

    // Método para la autenticación (esto debe ser reemplazado por la lógica de autenticación real)
    private bool AuthenticateUser(string username, string password)
    {
        // Aquí se podría conectar con un backend o API para verificar las credenciales del usuario
        return username == "admin" && password == "123456"; // Ejemplo de autenticación fija
    }

   
}
