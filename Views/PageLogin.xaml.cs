using Microsoft.Maui.Controls;
using StarBank.Views;

namespace StarBank.Views;

public partial class PageLogin : ContentPage
{
	public PageLogin()
	{
		InitializeComponent();
	}

    // M�todo que se ejecuta cuando se hace clic en el label "Reg�strese aqu�"
    private async void OnRegisterLblRegistro(object sender, EventArgs e)
    {
        // Navegar a la p�gina de registro
        await Navigation.PushAsync(new PageRegistro());
    }

    // M�todo que se ejecuta cuando el usuario hace clic en "Ingresar"
    private async void Button_Clicked(object sender, EventArgs e)
    {
        string username = UsernameEntry.Text?.Trim();
        string password = PasswordEntry.Text?.Trim();

        // Validaci�n de usuario y contrase�a
        if (string.IsNullOrEmpty(username))
        {
            await DisplayAlert("Error", "Por favor, ingrese su usuario.", "OK");
            return;
        }

        if (string.IsNullOrEmpty(password))
        {
            await DisplayAlert("Error", "Por favor, ingrese su contrase�a.", "OK");
            return;
        }

        // Si la validaci�n pasa, proceder con la autenticaci�n
        bool isAuthenticated = AuthenticateUser(username, password);

        if (isAuthenticated)
        {
            // Si el usuario est� autenticado, navegar a la p�gina principal
            await Navigation.PushAsync(new PagePrincipal());
        }
        else
        {
            // Si la autenticaci�n falla, mostrar un mensaje de error
            await DisplayAlert("Error", "Usuario o contrase�a incorrectos.", "OK");
        }
    }

    // M�todo para la autenticaci�n (esto debe ser reemplazado por la l�gica de autenticaci�n real)
    private bool AuthenticateUser(string username, string password)
    {
        // Aqu� se podr�a conectar con un backend o API para verificar las credenciales del usuario
        return username == "admin" && password == "123456"; // Ejemplo de autenticaci�n fija
    }

   
}
