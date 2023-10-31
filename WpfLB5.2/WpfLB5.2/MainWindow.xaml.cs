using System;
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

namespace WpfLB5._2
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void MenuItem_MouseEnter(object sender, MouseEventArgs e)
        {
            FrameworkElement element = sender as FrameworkElement;
            if (element == null)
                return;

            switch (element.Tag.ToString())
            {
                case "close":
                    statusBlock.Text = "Закрыть программу";
                    break;
                case "about":
                    statusBlock.Text = "О программе";
                    break;
                case "change_color":
                    statusBlock.Text = "Изменить цвет фона";
                    break;
                default:
                    statusBlock.Text = string.Empty;
                    break;
            }
        }
        private void MenuItem_MouseLeave(object sender, MouseEventArgs e)
        {
            statusBlock.Text = string.Empty;
        }

        private void MenuItem_Click(object sender, RoutedEventArgs e)
        {
            FrameworkElement element = sender as FrameworkElement;
            if (element == null)
                return;

            switch (element.Tag.ToString())
            {
                case "close":
                    Application.Current.Shutdown();
                    break;
                case "about":
                    MessageBox.Show("(^˵◕ω◕˵^)");
                    break;
                default:
                    statusBlock.Text = string.Empty;
                    break;
            }
        }

        private void ComboBox_Selected(object sender, RoutedEventArgs e)
        {
            ComboBox element = sender as ComboBox;
            if (element == null)
                return;
            ComboBoxItem item = element.SelectedItem as ComboBoxItem;
            if (item == null)
                return;
            string color_hex = item.Tag.ToString();
            Color color = (Color)ColorConverter.ConvertFromString(color_hex);
            Background = new SolidColorBrush(color);
        }
    }
}
