using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Annotations;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LAB_5
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
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                bool isPalindrome = IsPalindrome(Word.Text);
                string a = Word.Text;
                static bool IsPalindrome(string str)
                {
                    int left = 0;
                    int right = str.Length - 1;

                    while (left < right)
                    {
                        if (str[left] != str[right])
                        {
                            return false;
                        }
                        left++;
                        right--;
                    }
                    return true;
                }
                if (isPalindrome == true)
                {
                    Result.Text = "Слова является палиндромом)";
                }
                else if (isPalindrome != true)
                {
                    Result.Text = "Слова не является палиндромом(";
                }
            }
            catch 
            {
                MessageBox.Show("Проверьте правильность введенных данных");
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                bool isPalindrome = IsPalindrome(Word.Text);
                string a = Word.Text;
               if (a =="") throw new Exception("Введите не пустую строку");
                if (a == " ") throw new Exception("Не введите пробел)");

                static bool IsPalindrome(string str)
                {
                    int left = 0;
                    int right = str.Length - 1;

                    while (left < right)
                    {
                        if (str[left] != str[right])
                        {
                            return false;
                        }
                        left++;
                        right--;
                    }
                    return true;
                }
                if (isPalindrome == true)
                {
                    Result.Text = "Слова является палиндромом)";
                }
                else if (isPalindrome != true)
                {
                    Result.Text = "Слова не является палиндромом(";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка:{ex.Message}");
            }
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            try
            {
                bool isPalindrome = IsPalindrome(Word.Text);
                string a = Word.Text;
                if (a == "") throw new FormatException("Введите не пустую строку");
                if (a == " ") throw new FormatException("Не введите пробел)");
                static bool IsPalindrome(string str)
                {
                    int left = 0;
                    int right = str.Length - 1;
                    while (left < right)
                    {
                        if (str[left] != str[right])
                        {
                            return false;
                        }
                        left++;
                        right--;
                    }
                    return true;
                }
                if (isPalindrome == true)
                {
                    Result.Text = "Слова является палиндромом)";
                }
                else if (isPalindrome != true)
                {
                    Result.Text = "Слова не является палиндромом(";
                }
            }
            catch (FormatException ex)
            {
                MessageBox.Show($"Ошибка: {ex.Message}");
            }
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            try
            {
                bool isPalindrome = IsPalindrome(Word.Text);
                string a = Word.Text;
                if (a == "") throw new WordException("Введите не пустую строку");
                if (a == " ") throw new WordException("Не введите пробел)");

                static bool IsPalindrome(string str)
                {
                    int left = 0;
                    int right = str.Length - 1;

                    while (left < right)
                    {
                        if (str[left] != str[right])
                        {
                            return false;
                        }
                        left++;
                        right--;
                    }

                    return true;
                }

                if (isPalindrome == true)
                {
                    Result.Text = "Слова является палиндромом)";
                }
                else if (isPalindrome != true)
                {
                    Result.Text = "Слова не является палиндромом(";
                }

            }
            catch (WordException ex)
            {
                MessageBox.Show($"Ошибка:{ex.Message}");
            }

        }
    }
}
