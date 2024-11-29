using System.Globalization;
using System;
using Microsoft.Maui.Controls;

namespace StarBank.Views;

public partial class PagePrincipal : ContentPage
{
	public PagePrincipal()
    {
        InitializeComponent();
        GenerateMonthButtons();
    }

    private void GenerateMonthButtons()
    {
        // Limpiar el contenedor para evitar duplicados
        MonthTabs.Children.Clear();

        // Obtener la fecha actual
        DateTime currentDate = DateTime.Now;

        // Generar los �ltimos tres meses
        for (int i = 0; i < 3; i++)
        {
            DateTime monthDate = currentDate.AddMonths(-i);
            string monthName = monthDate.ToString("MMMM yyyy", CultureInfo.CurrentCulture);

            // Crear un bot�n para cada mes
            var monthButton = new Button
            {
                Text = monthName,                   // Nombre del mes
                BackgroundColor = Colors.LightGray, // Color de fondo
                TextColor = Colors.Black,           // Color del texto
                FontSize = 14,
                CornerRadius = 10,
                Padding = new Thickness(10, 5),
                WidthRequest = 120,                 // Tama�o fijo para buena alineaci�n
                HorizontalOptions = LayoutOptions.Center
            };

            // Agregar cada bot�n al HorizontalStackLayout
            MonthTabs.Children.Add(monthButton);
        }
    }
}
