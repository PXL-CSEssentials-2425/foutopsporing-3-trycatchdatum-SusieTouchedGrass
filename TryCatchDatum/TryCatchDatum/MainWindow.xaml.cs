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
using System.IO;

namespace TryCatchDatum
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        TextBox[] textBoxes;

        public MainWindow()
        {

            InitializeComponent();
            try
            {
                ImageBrush myBrush = new ImageBrush();
                myBrush.ImageSource = new BitmapImage(new Uri(@"C:\Users\suyen\Desktop\C# Essentials (2024-25 - GRPRO)\Hoofdstuk 10 - Foutopsporing\Oefening 3 - TryCatchDatum\foto.jpg"));
                this.Background = myBrush;
                MessageBox.Show("Afbeelding op achtergrond van formulier is ingeladen.", "Melding", MessageBoxButton.OK, MessageBoxImage.Information);
                textBoxes = new TextBox[] { textBox1, textBox2, textBox3 };
            }
            catch
            {
                MessageBox.Show("Afbeelding op achtergrond van formulier is NIET ingeladen.", "Melding", MessageBoxButton.OK, MessageBoxImage.Information);
            }

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                for (int i = 2; i >= 3; i--)
                {
                    string input = textBoxes[i].Text;
                    int number = int.Parse(input);

                }
                string dag = textBoxes[0].Text;
                string month = textBoxes[1].Text;
                string year = textBoxes[2].Text;

                string s = $@"{dag}/{month}/{year}";
                if (DateTime.TryParse(s, out DateTime date))
                {
                    MessageBox.Show("Geldig datum.", "Melding", MessageBoxButton.OK, MessageBoxImage.Information);
                }
                else
                {
                    MessageBox.Show("Ongeldige datum.", "Foutmelding", MessageBoxButton.OK, MessageBoxImage.Warning);
                }
            }
            catch
            {
                MessageBox.Show("Gelieve 3 getallen in te geven.", "Foutmelding", MessageBoxButton.OK, MessageBoxImage.Warning);
            }
        }
    }
}