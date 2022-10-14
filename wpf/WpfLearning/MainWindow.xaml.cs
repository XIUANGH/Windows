using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace WpfLearning
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<people> peopleList = new ObservableCollection<people>();
        public MainWindow()
        {
            InitializeComponent();
            datagrid1.ItemsSource = peopleList;
            cmbColors.ItemsSource = typeof(Colors).GetProperties();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("你点击了按钮");
            MyLabel.Content = "sda";
            SJB.Content = "点击了按钮";
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            lab1.Content = textbox1.Text;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            peopleList.Add(new people()
            {
                name = "小明",
                age = "18",
                sex = "男",
                birthday = "1990-9-9"
            });
        }
    }
}
