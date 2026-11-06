
using Avalonia.Controls;
using Avalonia.Interactivity;

namespace MiPresentacion;

public partial class MainWindow : Window
{
    private bool saludoAlternativo = false;

    public MainWindow()
    {
        InitializeComponent();
    }

    private void Presentarme_Click(object? sender, RoutedEventArgs e)
    {
        saludoAlternativo = false;
        MostrarPresentacion(false);
    }

    private bool MostrarPresentacion(bool alternativo)
    {
        string nombre = NombreTextBox.Text?.Trim() ?? "";
        string apellido = ApellidoTextBox.Text?.Trim() ?? "";
        string edadTexto = EdadTextBox.Text?.Trim() ?? "";

        if (string.IsNullOrWhiteSpace(nombre))
        {
            ResultadoTextBlock.Text = "Debes ingresar tu nombre.";
            NombreTextBox.Focus();
            return false;
        }

        if (string.IsNullOrWhiteSpace(apellido))
        {
            ResultadoTextBlock.Text = "Debes ingresar tu apellido.";
            ApellidoTextBox.Focus();
            return false;
        }

        if (!int.TryParse(edadTexto, out int edad) || edad <= 0)
        {
            ResultadoTextBlock.Text =
                "Debes ingresar una edad entera mayor que cero.";
            EdadTextBox.Focus();
            return false;
        }

        if (!alternativo)
        {
            ResultadoTextBlock.Text =
                $"¡Hola! Mi nombre es {nombre} {apellido}, " +
                $"tengo {edad} años y estoy aprendiendo " +
                "a desarrollar interfaces gráficas con C#.";
        }
        else
        {
            ResultadoTextBlock.Text =
                $"¡Mucho gusto! Soy {nombre} {apellido}, " +
                $"tengo {edad} años y estoy dando mis primeros " +
                "pasos en el desarrollo de aplicaciones con Avalonia.";
        }

        return true;
    }

    private void Limpiar_Click(object? sender, RoutedEventArgs e)
    {
        NombreTextBox.Text = "";
        ApellidoTextBox.Text = "";
        EdadTextBox.Text = "";

        saludoAlternativo = false;

        ResultadoTextBlock.Text =
            "Aquí aparecerá tu presentación.";

        NombreTextBox.Focus();
    }

    private void CambiarSaludo_Click(object? sender, RoutedEventArgs e)
    {
        bool siguienteSaludo = !saludoAlternativo;

        if (MostrarPresentacion(siguienteSaludo))
        {
            saludoAlternativo = siguienteSaludo;
        }
    }
}
