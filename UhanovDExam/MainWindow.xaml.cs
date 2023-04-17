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

namespace UhanovDExam
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

        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(textBox.Text.Length < 10 || textBox.Text.Length > 40)
            {
                textBox.Background = Brushes.Red;
                string text = "Колличество букв от 10 до 40";
                textBlock.Text = text;

            }

            else
            {
                textBox.Background = Brushes.Green;
                string text1 = "Успешно";
                textBlock.Text = text1;
            }
        }

        private void TextBox_TextChanged_1(object sender, TextChangedEventArgs e)
        {
            if (textBox1.Text.Length < 10 || textBox1.Text.Length > 60)
            {
                textBox1.Background = Brushes.Red;
                string text2 = "Колличество букв от 10 до 60";
                textBlock1.Text = text2;

            }

            else
            {
                textBox1.Background = Brushes.Green;
                string text3 = "Успешно";
                textBlock1.Text = text3;
            }
        }

        private void TextBox_TextChanged_2(object sender, TextChangedEventArgs e)
        {
            if (textBox2.Text.Length < 10 || textBox2.Text.Length > 60)
            {
                textBox2.Background = Brushes.Red;
                string text4 = "Колличество букв от 10 до 60";
                textBlock2.Text = text4;

            }

            else
            {
                textBox2.Background = Brushes.Green;
                string text4 = "Успешно";
                textBlock2.Text = text4;
            }
        }

        private void textBoxminus_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            if(!char.IsDigit(e.Text, e.Text.Length -1) || textBoxminus.Text == "" && e.Text == "-")
            {
                e.Handled = true;
            }
        }
    }
}
