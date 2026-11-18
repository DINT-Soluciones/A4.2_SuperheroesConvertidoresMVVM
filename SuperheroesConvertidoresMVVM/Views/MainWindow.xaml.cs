using SuperheroesConvertidoresMVVM.ViewModels;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SuperheroesConvertidoresMVVM.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        // ---------------------------------------------------------------------------------------------------------------------------
        // El DataContext se asigna desde App.xaml.cs al iniciar la aplicación para MVVM, por lo que no es necesario instanciarlo aquí.
        // ---------------------------------------------------------------------------------------------------------------------------
        // private MainWindowVM vm;     
        // public MainWindow()
        // {
        //    InitializeComponent();
        //    vm = new MainWindowVM(); 
        //    this.DataContext = vm;   
        // }

        public MainWindow()
        {
            InitializeComponent();
        }
    }
}