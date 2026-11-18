using Microsoft.Extensions.DependencyInjection;
using Microsoft.Win32;
using SuperheroesConvertidoresMVVM.Views;
using System.Configuration;
using System.Data;
using System.Windows;
using System.Windows.Navigation;
using SuperheroesConvertidoresMVVM.ViewModels;

namespace SuperheroesConvertidoresMVVM
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /* Se encarga de:
            - Configurar DI.
            - Registrar servicios.
            - Registrar vistas-modelo (ViewModels).
            - Registrar ventanas y vistas.
            - Crear el contenedor de dependencias.
            - Iniciar la ventana principal.
            - Gestionar el cierre de la aplicación.
        */

        // Contenedor de dependencias (DI)
        private ServiceProvider _provider = null!;

        // Configuración de la aplicación al iniciar.
        protected override void OnStartup(StartupEventArgs e)
        {
            base.OnStartup(e);

            var services = new ServiceCollection();

            // Servicios de interfaz (no definido todavía).

            // Ventana principal y ViewModel
            services.AddSingleton<MainWindow>();
            services.AddSingleton<MainWindowVM>();

            // Navegación (no definido todavía para varias sub-vistas (UserControl) dentro de la ventana principal).

            // Ventanas independientes (no definidas todavía).

            // Diálogos específicos (no definidos todavía).

            // Construir el contenedor de dependencias.
            _provider = services.BuildServiceProvider();

            // Obtener la ventana principal y su ViewModel desde el contenedor de dependencias.
            var mainWindow = _provider.GetRequiredService<MainWindow>();
            var mainViewModel = _provider.GetRequiredService<MainWindowVM>();

            // Asignar el ViewModel a la ventana principal (DataContext).
            mainWindow.DataContext = mainViewModel;

            // Mostrar la ventana principal.
            mainWindow.Show();
        }

        // Liberar los recursos del contenedor de inyección de dependencias (DI).
        // Es llamado automáticamente cuando la aplicación se cierra.
        protected override void OnExit(ExitEventArgs e)
        {
            _provider?.Dispose();

            base.OnExit(e);
        }
    }
}
