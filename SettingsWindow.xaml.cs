using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Text.RegularExpressions;
using WPFTimer.Enums;
using System;
using Microsoft.Win32;

namespace WPFTimer
{
    /// <summary>
    /// Логика взаимодействия для SettingsWindow.xaml
    /// </summary>
    public partial class SettingsWindow : Window
    {
        public SettingRadioButtonsState CurrentOperationRadioButtonState = MemoryBuffer.ChosenRadioButtonState;
        public int TurnOfTimer = MemoryBuffer.TurnOfTimeToCancel;
        public string tempMediaFilePath = MemoryBuffer.MusicFileName;
        public string tempFilePath = MemoryBuffer.ExecutingFileName;
        public bool tempCBResult = MemoryBuffer.CBClearCheched;
        



        
        public SettingsWindow()
        {
            InitializeComponent();
            txtTurnOffTime.Text = TurnOfTimer.ToString();
            RadioButtonState(MemoryBuffer.ChosenRadioButtonState);
            MemoryBuffer.MusicPathChanged += IsMusicFileChosen;
            MemoryBuffer.FilePathChanged += IsExecutableFileChosen;
            txtMusicPath.Text = MemoryBuffer.MusicFileName;
            txtFilePath.Text = MemoryBuffer.ExecutingFileName;
            CBClearTime.IsChecked = MemoryBuffer.CBClearCheched;
        }

        private void IsExecutableFileChosen(object sender, EventArgs e)
        {
            txtFilePath.Text = MemoryBuffer.ExecutingFileName;
        }
        //Метод получает в качестве аргумента перечисление "состояние радио кнопки" из буфера памяти, и устанавливает в соответсвующее положение радио кнопки.
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

        private void IsMusicFileChosen(object sender,EventArgs e)
        {
            txtMusicPath.Text = MemoryBuffer.MusicFileName;
 
        }

        private void btnOk_Click(object sender, RoutedEventArgs e)
        {
            MemoryBuffer.ChosenRadioButtonState = CurrentOperationRadioButtonState;
            MemoryBuffer.TurnOfTimeToCancel = TurnOfTimer;
            MemoryBuffer.MusicFileName = tempMediaFilePath;
            MemoryBuffer.ExecutingFileName = tempFilePath;
            MemoryBuffer.CBClearCheched = tempCBResult;
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

        private void btnBrouseFile_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();

            Nullable<bool> result = dlg.ShowDialog();
            if (result == true)
            {
                tempFilePath = dlg.FileName;
                txtFilePath.Text = tempFilePath;
            }
        }

        private void btmBrouseAudio_Click(object sender, RoutedEventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Media Files|*.mp3;*.wav;*.flac;*.mp4;*.avi;*.mov" ;
            Nullable<bool> result= dlg.ShowDialog();
            if (result == true)
            {
                tempMediaFilePath = dlg.FileName;
                txtMusicPath.Text = tempMediaFilePath;
            }
        }
        
       
        private void ToDefault()
        {
            tempFilePath = "";
            txtMusicPath.Text = "";
            txtFilePath.Text = "";
            tempMediaFilePath = "";
            RBSound.IsChecked = true;
            txtTurnOffTime.Text = "5";

            CBClearTime.IsChecked = false;

        }
        private void btnToDefault_Click(object sender, RoutedEventArgs e)
        {
            ToDefault();


        }

        private void CBClearTime_DataContextChanged(object sender, DependencyPropertyChangedEventArgs e)
        {
            
        }

        private void CBClearTime_Checked(object sender, RoutedEventArgs e)
        {
            tempCBResult = true;
        }

        private void CBClearTime_Unchecked(object sender, RoutedEventArgs e)
        {
            tempCBResult = false;
        }
    }
}
