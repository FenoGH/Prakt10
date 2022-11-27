using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;


namespace Prakt10
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    
    public partial class MainWindow : Window
    {
        List<int> arraylist = new List<int>();
        public MainWindow()
        {
            InitializeComponent();
        }

        private void filling(object sender, RoutedEventArgs e)
        {
            if(arraylist.Count != 0)
            {
                arraylist.Clear();
            }
            MasList.ItemsSource = null;
            int.TryParse(TextContent.Text, out int x);
            if (x != 0 && x > 0)
            {
                int i = 0;
                Random rnd = new Random();
                while (i != x)
                {
                    arraylist.Add(rnd.Next(0, 100));
                    i++;
                }
                MasList.ItemsSource = arraylist;
            }
            else
            {
                MessageBox.Show("Задайте правильное колличество эллементов в коллекции");
            }


        }

        private void sum(object sender, RoutedEventArgs e)
        {
            
            if (arraylist.Count != 0)
            {
                int sum = 0;
                for (int i = 0; i < arraylist.Count; i++)
                {
                    if (arraylist[i] % 3 == 0)
                    {
                        sum += arraylist[i];
                    }
                }
                MessageBox.Show(Convert.ToString(sum));
                
            }
            else
            {
                MessageBox.Show("Коллекция не заполнена");
            }
        }
        private void Info(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Борькин Иван ИСП-31 \nСоставьте программу вычисления в массиве суммы всех чисел, кратных 3");
        }
        private void Clear(object sender, RoutedEventArgs e)
        {
            TextContent.Clear();
            MasList.ItemsSource = null;
            arraylist.Clear();
            RemoveID.Clear();

        }
        private void Close(object sender, RoutedEventArgs e)
        {
            Close();

        }

        private void Remove(object sender, RoutedEventArgs e)
        {
            int.TryParse(RemoveID.Text, out int i);
            arraylist.Remove(i);
            MasList.ItemsSource = arraylist.ToArray();

        }

        private void Add(object sender, RoutedEventArgs e)
        {
            int.TryParse(AddID.Text, out int i);
            arraylist.Add(i);
            MasList.ItemsSource = arraylist.ToArray();
        }
    }
}
