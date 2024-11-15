using System.Text;
using System.Threading.Tasks.Dataflow;
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
            List<string> colors = new List<string> { "Rood", "Geel", "Oranje", "Wit", "Groen", "Blauw" };
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



        private void ComboBoxColour_SelectionChanged1(object sender, SelectionChangedEventArgs e)
        {
            if (sender == comboBoxColour1 && comboBoxColour1.SelectedItem != null)
            {
                switch (comboBoxColour1.SelectedIndex)
                {
                    case 0:
                        labelColorOne.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 1:
                        labelColorOne.Background = new SolidColorBrush(Colors.Yellow);
                        break;
                    case 2:
                        labelColorOne.Background = new SolidColorBrush(Colors.Orange);
                        break;
                    case 3:
                        labelColorOne.Background = new SolidColorBrush(Colors.White);
                        break;
                    case 4:
                        labelColorOne.Background = new SolidColorBrush(Colors.Green);
                        break;
                    case 5:
                        labelColorOne.Background = new SolidColorBrush(Colors.Blue);
                        break;
                    }
            }  
            if (sender == comboBoxColour2 && comboBoxColour2.SelectedItem != null)
                {
                    switch (comboBoxColour2.SelectedIndex)
                    {
                        case 0:
                            labelColorTwo.Background = new SolidColorBrush(Colors.Red);
                            break;
                        case 1:
                            labelColorTwo.Background = new SolidColorBrush(Colors.Yellow);
                            break;
                        case 2:
                            labelColorTwo.Background = new SolidColorBrush(Colors.Orange);
                            break;
                        case 3:
                            labelColorTwo.Background = new SolidColorBrush(Colors.White);
                            break;
                        case 4:
                            labelColorTwo.Background = new SolidColorBrush(Colors.Green);
                            break;
                        case 5:
                            labelColorTwo.Background = new SolidColorBrush(Colors.Blue);
                            break;
                        }
                }
            if (sender == comboBoxColour3 && comboBoxColour3.SelectedItem != null)
            {
                switch (comboBoxColour3.SelectedIndex)
                {
                    case 0:
                        labelColorThree.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 1:
                        labelColorThree.Background = new SolidColorBrush(Colors.Yellow);
                        break;
                    case 2:
                        labelColorThree.Background = new SolidColorBrush(Colors.Orange);
                        break;
                    case 3:
                        labelColorThree.Background = new SolidColorBrush(Colors.White);
                        break;
                    case 4:
                        labelColorThree.Background = new SolidColorBrush(Colors.Green);
                        break;
                    case 5:
                        labelColorThree.Background = new SolidColorBrush(Colors.Blue);
                        break;
                    
                }
            }
            if (sender == comboBoxColour4 && comboBoxColour4.SelectedItem != null)
            {
                switch (comboBoxColour4.SelectedIndex)
                {
                    case 0:
                        labelColorFour.Background = new SolidColorBrush(Colors.Red);
                        break;
                    case 1:
                        labelColorFour.Background = new SolidColorBrush(Colors.Yellow);
                        break;
                    case 2:
                        labelColorFour.Background = new SolidColorBrush(Colors.Orange);
                        break;
                    case 3:
                        labelColorFour.Background = new SolidColorBrush(Colors.White);
                        break;
                    case 4:
                        labelColorFour.Background = new SolidColorBrush(Colors.Green);
                        break;
                    case 5:
                        labelColorFour.Background = new SolidColorBrush(Colors.Blue);
                        break;
                    }
            }


        }
    }
}


     
    