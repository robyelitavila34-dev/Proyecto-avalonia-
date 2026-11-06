
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

    // BOTON PRESENTARME
    private void Presentarme_Click(object? sender, RoutedEventArgs e)
    {
        saludoAlternativo = false;
        MostrarPresentacion(false);
    }

    // METODO PARA VALIDAR Y MOSTRAR LOS DATOS
    private bool MostrarPresentacion(bool alternativo)
    {
        string nombre = NombreTextBox.Text?.Trim() ?? "";
        string apellido = ApellidoTextBox.Text?.Trim() ?? "";
        string edadTexto = EdadTextBox.Text?.Trim() ?? "";

        // VALIDAR NOMBRE
        if (string.IsNullOrWhiteSpace(nombre))
        {
            ResultadoTextBlock.Text =
                "Advertencia: debes ingresar tu nombre.";
            NombreTextBox.Focus();
            return false;
        }

        // VALIDAR APELLIDO
        if (string.IsNullOrWhiteSpace(apellido))
        {
            ResultadoTextBlock.Text =
                "Advertencia: debes ingresar tu apellido.";
            ApellidoTextBox.Focus();
            return false;
        }

        // VALIDAR QUE LA EDAD SEA UN NUMERO ENTERO
        if (!int.TryParse(edadTexto, out int edad))
        {
            ResultadoTextBlock.Text =
                "Advertencia: debes ingresar una edad numerica.";
            EdadTextBox.Focus();
            return false;
        }

        // VALIDAR QUE LA EDAD SEA POSITIVA
        if (edad <= 0)
        {
            ResultadoTextBlock.Text =
                "Advertencia: la edad debe ser mayor que cero.";
            EdadTextBox.Focus();
            return false;
        }

        // MOSTRAR PRESENTACION
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

    // BOTON LIMPIAR
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

    // BOTON CAMBIAR SALUDO
    private void CambiarSaludo_Click(object? sender, RoutedEventArgs e)
    {
        bool siguienteSaludo = !saludoAlternativo;

        if (MostrarPresentacion(siguienteSaludo))
        {
            saludoAlternativo = siguienteSaludo;
        }
    }
}
