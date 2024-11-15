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

namespace C_mastermindSprint1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        
        private void GenerateRandomCode()
        {
            var randomCode = new Random();
            List<string> colors = new List<string> {"Rood", "Geel", "Oranje", "Wit", "Groen", "Blauw"};
            var secretCode = new List<string>();


            for (int i = 0; i < 4; i++)
            {
                secretCode.Add(colors[randomCode.Next(colors.Count)]);

            }
                this.Title = "Secret code: " + string.Join(", ", secretCode);
             
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            List<string> colors = new List<string> { "Rood", "Geel", "Oranje", "Wit", "Groen", "Blauw" };

            GenerateRandomCode();

            foreach (string color in colors)
            {
                comboBoxColour1.Items.Add(new ComboBoxItem { Content = color });
                comboBoxColour2.Items.Add(new ComboBoxItem { Content = color });
                comboBoxColour3.Items.Add(new ComboBoxItem { Content = color });
                comboBoxColour4.Items.Add(new ComboBoxItem { Content = color });
            }
        }

        private void checkButton_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}