# Mi primera aplicación gráfica

## Descripción de la aplicación

Este proyecto consiste en una aplicación de escritorio creada con C# y Avalonia. Su objetivo es permitir que una persona escriba su nombre, apellido y edad para mostrar una pequeña presentación en pantalla.

## Controles utilizados

- **TextBlock:** se utiliza para mostrar títulos, nombres de los campos y mensajes.
- **TextBox:** permite escribir el nombre, apellido y edad.
- **Button:** permite realizar acciones dentro de la aplicación.
- **StackPanel:** organiza los elementos uno debajo del otro.
- **Margin:** agrega espacio entre los elementos y los bordes.
- **Spacing:** mantiene una separación entre los controles.

## Funcionamiento de los botones

- **Presentarme:** comprueba que los campos estén completos y que la edad sea un número entero mayor que cero. Si los datos son correctos, muestra una presentación.
- **Limpiar:** borra la información escrita y devuelve el mensaje inicial.
- **Cambiar saludo:** muestra una segunda forma de presentación utilizando los mismos datos.

## Validaciones

La aplicación comprueba que:

- El nombre no esté vacío.
- El apellido no esté vacío.
- La edad sea un número entero.
- La edad sea mayor que cero.

Si algún dato está incorrecto, aparece un mensaje indicando qué se debe corregir.

## ¿Cómo ejecutar el programa?

1. Descargar o clonar el proyecto desde GitHub.
2. Abrir la carpeta del proyecto en Visual Studio Code.
3. Abrir la terminal dentro de la carpeta.
4. Ejecutar los siguientes comandos:

```bash
dotnet restore
dotnet build
dotnet run
```

5. Esperar a que se abra la ventana de la aplicación.

## Reflexión

**¿Qué aprendí sobre XAML y C#?**

Aprendí que XAML permite organizar y diseñar los elementos que aparecen en la ventana, mientras que C# permite controlar lo que sucede cuando utilizamos los botones.

**¿Para qué sirve x:Name?**

Sirve para darle un nombre a cada elemento y poder utilizarlo desde el código C#.

**¿Para qué sirve Click?**

Sirve para indicar qué acción debe realizarse cuando presionamos un botón.

## Tecnologías utilizadas

- C#
- Avalonia UI
- .NET 8
- Visual Studio Code

## Autora

Robyelit Ávila

Proyecto académico.