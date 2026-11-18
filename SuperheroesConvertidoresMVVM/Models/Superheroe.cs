using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.Generic;
using System.ComponentModel;

namespace SuperheroesConvertidoresMVVM.Model
{
    public partial class Superheroe : ObservableObject
    {
        // Genera la propiedad "Nombre" automáticamente.
        [ObservableProperty]
        private string? _nombre;

        // Genera la propiedad "ImagenRuta" automáticamente.
        [ObservableProperty]
        private string? _imagenRuta;

        // Genera la propiedad "Vengador" automáticamente.
        [ObservableProperty]
        private bool _vengador;

        // Genera la propiedad "Xmen" automáticamente.
        [ObservableProperty]
        private bool _xmen;

        // Genera la propiedad "Heroe" automáticamente.
        [ObservableProperty]
        private bool _heroe;

        // Constructor por defecto. Se inicializan las propiedades con valores predeterminados.
        public Superheroe()   
        {
            Nombre = string.Empty;
            ImagenRuta = string.Empty;
            Vengador = false;
            Xmen = false;
            Heroe = false;
        }

        // Constructor con parámetros. Se inicializan las propiedades con los valores proporcionados por los argumentos.
        public Superheroe(string nombre, string imagenRuta, bool vengador, bool xmen, bool heroe)
        {
            Nombre = nombre;
            ImagenRuta = imagenRuta;
            Vengador = vengador;
            Xmen = xmen;
            Heroe = heroe;
        }
    }
}
