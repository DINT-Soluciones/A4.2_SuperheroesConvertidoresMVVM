using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using SuperheroesConvertidoresMVVM.Model;
using SuperheroesCovertidoresMVVM.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperheroesConvertidoresMVVM.ViewModels
{
    public partial class MainWindowVM : ObservableObject
    {
        // Lista de superhéroes.
        private List<Superheroe> listaSuperheroes;

        // Genera la propiedad "HeroeActual automáticamente.
        [ObservableProperty]             
        private Superheroe _heroeActual;

        // Genera la propiedad "Actual" automáticamente.
        [ObservableProperty]
        private int _actual;

        // Genera la propiedad "Total" automáticamente.
        [ObservableProperty]
        private int _total;

        public MainWindowVM()
        {
            listaSuperheroes = DataService.GetSamples();       // Obtiene la lista de superhéroes del servicio de datos.

            Total = listaSuperheroes.Count;                    // Número máximo de superhéroes en la lista.
            
            Actual = 1;                                        // Inicializa el contador de superhéroes. Tomará valores de 1 a 3.
            HeroeActual = listaSuperheroes[Actual - 1];
        }

        [RelayCommand]
        public void Anterior()
        {
            // Aquí estamos pulsando la flecha izquierda, por lo que debemos retroceder al superhéroe anterior.
            // En este caso debemos actualizar la propiedad "Actual" y la propiedad "HeroeActual" que es la que se está mostrando en la vista.
         
            if (Actual > 1)
            {
                Actual--;                                   // Decrementamos el contador de superhéroes, rango de 1 a 3.
                HeroeActual = listaSuperheroes[Actual - 1]; // Actualizamos el superhéroe actual que se está mostrando en la vista, indice de la lista de 0 a 2.
            }
        }

        [RelayCommand]
        public void Siguiente()
        {
            // Aquí estamos pulsando la flecha derecha, por lo que debemos avanzar al siguiente superhéroe.
            // En este caso debemos actualizar la propiedad "Actual" y la propiedad "HeroeActual" que es la que se está mostrando en la vista.

            if (Actual < Total)
            {
                Actual++;                                   // Incrementamos el contador de superhéroes, rango de 1 a 3.
                HeroeActual = listaSuperheroes[Actual - 1]; // Actualizamos el superhéroe actual que se está mostrando en la vista, indice de la lista de 0 a 2.
            }
        }
    }
}
