using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Text.RegularExpressions;
using WPFTimer.Enums;
using System;

namespace WPFTimer
{
    /// <summary>
    /// Логика взаимодействия для SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingRadioButtonsState CurrentOperationRadioButtonState = MemoryBuffer.ChosenRadioButtonState;
        public int TurnOfTimer = MemoryBuffer.TurnOfTimeToCancel;


        
        public SettingsWindow()
        {
            InitializeComponent();
            txtTurnOffTime.Text = TurnOfTimer.ToString();
            RadioButtonState(MemoryBuffer.ChosenRadioButtonState);
        }

        private void RadioButtonState(SettingRadioButtonsState settingRadioButtonsState)
        {
            switch (settingRadioButtonsState)
            {
                case SettingRadioButtonsState.PlaySound: RBSound.IsChecked = true;
                    break;
                case SettingRadioButtonsState.OpenFile: RBFile.IsChecked = true;
                    break;
                case SettingRadioButtonsState.Hebirnate: RBHebirnate.IsChecked = true;
                    break;
                case SettingRadioButtonsState.OpenAudio: RBAudio.IsChecked = true;
                    break;
                case SettingRadioButtonsState.Sleep: RBSleep.IsChecked = true;
                    break;
                case SettingRadioButtonsState.TurnOff: RBTurnOff.IsChecked = true;
                    break;
                default :RBSound.IsChecked=true;
                    break;
            }
        }

        
        
        
        
        private void txtTurnOffTime_PreviewTextInput(object sender, TextCompositionEventArgs e)
        {
            var _textInput = new Regex(@"^[0-9]");

            var match = _textInput.Match(e.Text);

            if (!match.Success || (sender as TextBox).Text == "0")
                e.Handled = true;

            
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            MemoryBuffer.ChosenRadioButtonState = CurrentOperationRadioButtonState;
            MemoryBuffer.TurnOfTimeToCancel = TurnOfTimer;
            this.Close();
        }

        private void RBSound_Checked(object sender, RoutedEventArgs e)
        {
            CurrentOperationRadioButtonState = SettingRadioButtonsState.PlaySound;
        }

        private void RBAudio_Checked(object sender, RoutedEventArgs e)
        {
            CurrentOperationRadioButtonState = SettingRadioButtonsState.OpenAudio;
            btmBrouseAudio.IsEnabled = true;
        }

        private void RBAudio_Unchecked(object sender, RoutedEventArgs e)
        {
            btmBrouseAudio.IsEnabled = false;
        }

        private void RBFile_Checked(object sender, RoutedEventArgs e)
        {
            CurrentOperationRadioButtonState = SettingRadioButtonsState.OpenFile;
            btnBrouseFile.IsEnabled = true;
        }

        private void RBFile_Unchecked(object sender, RoutedEventArgs e)
        {
            btnBrouseFile.IsEnabled = false;
        }

        private void RBTurnOff_Checked(object sender, RoutedEventArgs e)
        {
            CurrentOperationRadioButtonState = SettingRadioButtonsState.TurnOff;
        }

        private void RBHebirnate_Checked(object sender, RoutedEventArgs e)
        {
            CurrentOperationRadioButtonState = SettingRadioButtonsState.Hebirnate;
        }

        private void RBSleep_Checked(object sender, RoutedEventArgs e)
        {
            CurrentOperationRadioButtonState = SettingRadioButtonsState.Sleep;
        }

        private void btnNotOk_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void txtTurnOffTime_TextChanged(object sender, TextChangedEventArgs e)
        {
            if(txtTurnOffTime.Text!="")
            TurnOfTimer= Convert.ToInt32(txtTurnOffTime.Text);
        }
    }
}
