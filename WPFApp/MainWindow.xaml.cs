using System.Windows;

namespace WPFApp;

/// <summary>
/// Interaction logic for MainWindow.xaml
/// </summary>
public partial class MainWindow : Window
{
    public MainWindow()
    {
        InitializeComponent();
    }

    void CreateTask()
    {
        Task T;
        Action Code = new Action(ShowMessage);
        T = new Task(Code);
        Task T2 = new Task(delegate
        {
            MessageBox.Show("Ejecutando una tarea en un método anínimo");
        }
        );

        Task T3 = new Task(
           () => ShowMessage());


        Task T4 = new Task(() => MessageBox.Show("Ejecutando la tarea 4"));
                        
        
    }

    

        void ShowMessage()
        {
        MessageBox.Show("Ejecutando el método ShowMessage");

        }
    }
