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
using System.Windows.Shapes;
using System.Text.RegularExpressions;
namespace WPFTimer
{
    /// <summary>
    /// Логика взаимодействия для SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingsWindow()
        {
            InitializeComponent();
        }

        
        
        
        
        private void txtTurnOffTime_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var _textInput = new Regex(@"^[0-9]");

            var match = _textInput.Match(e.Text);

            if ((sender as TextBox).Text.Length >= 2 || !match.Success || (sender as TextBox).Text == "0")
                e.Handled = true;

            
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
           // RBAudio.Checked+={}
        }
    }
}
