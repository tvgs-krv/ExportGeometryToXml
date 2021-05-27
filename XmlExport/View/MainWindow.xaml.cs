using System;
using System.Globalization;
using System.Text.RegularExpressions;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using MaterialDesignThemes.Wpf;

namespace XmlExport.View
{
    public partial class MainWindow : Window
    {
        public string prevTextBox2 = "";
        public int prevIndexTextbox2 = 0;
        public MainWindow()
        {
            InitializeMaterialDesign();
            InitializeComponent();
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
            Close();
        }

        private void InitializeMaterialDesign()
        {
            // Create dummy objects to force the MaterialDesign assemblies to be loaded
            // from this assembly, which causes the MaterialDesign assemblies to be searched
            // relative to this assembly's path. Otherwise, the MaterialDesign assemblies
            // are searched relative to Eclipse's path, so they're not found.
            var card = new Card();
            var hue = new MaterialDesignColors.Hue("Dummy", Colors.Black, Colors.White);
            var dummy = typeof(MaterialDesignThemes.Wpf.Theme);
        }

        private void TextBox_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            e.Handled = !(Char.IsDigit(e.Text, 0) 
                          || e.Text == System.Globalization
                              .CultureInfo.CurrentCulture.NumberFormat
                              .NumberDecimalSeparator[0]
                              .ToString() 
                          && (DS_Count(((TextBox)sender).Text) < 1));
        }
        public int DS_Count(string s)
        {
            string substr = System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator[0].ToString();
            int count = (s.Length - s.Replace(substr, "").Length) / substr.Length;
            return count;
        }


        private void textBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            var tb = (TextBox)sender;
            // Здесь возможно попадется десятичная запятая
            var f = CultureInfo.CurrentUICulture.NumberFormat;

            // Жестко задаем десятичную точку
            f = CultureInfo.GetCultureInfo("en-US").NumberFormat;

            var str = tb.Text;
            var regex = new Regex($"^\\{f.NegativeSign}?\\d*(\\{f.CurrencyDecimalSeparator}\\d*)?$");
            if (regex.IsMatch(str))
            {
                prevTextBox2 = str;
                prevIndexTextbox2 = tb.CaretIndex;
            }
            else
            {
                var savedPrevIndex = prevIndexTextbox2;
                tb.Text = prevTextBox2;
                prevIndexTextbox2 = savedPrevIndex;
                tb.CaretIndex = savedPrevIndex;
            }
        }

        
    }
}
