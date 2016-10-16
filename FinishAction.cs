using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WPFTimer.Enums;
using System.Windows;
using System.Windows.Forms;
using System.Media;
using System.IO;
using System.Threading.Tasks;

using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;




namespace WPFTimer
{
    class FinishAction
    {

        public FinishAction(SettingRadioButtonsState settingRadioButtonsState)
        {
            switch (settingRadioButtonsState)
            {
                case SettingRadioButtonsState.PlaySound:
                    {
                        var soundwin = new PlaySoundWindow();
                        soundwin.ShowDialog();
                    }
                    break;
                case SettingRadioButtonsState.TurnOff:
                    {
                        System.Windows.Application.Current.Shutdown();
                        System.Diagnostics.Process.Start("shutdown.exe", "/s /t 0");
                       
                    }
                    break;
                case SettingRadioButtonsState.OpenAudio:
                    {
                        if (MemoryBuffer.MusicFileName != "" && MemoryBuffer.MusicFileName!=null)
                        {
                            //WindowsMediaPlayer mp = new WindowsMediaPlayer();
                            
                            //mp.openPlayer(MemoryBuffer.MusicFileName);
                            
                        }
 
                    }
                    break;
                case SettingRadioButtonsState.OpenFile:
                    {
                        if (MemoryBuffer.ExecutingFileName != "" && MemoryBuffer.ExecutingFileName!=null)
                        {
                            System.Diagnostics.Process.Start(MemoryBuffer.ExecutingFileName);
                        }
                    }
                    break;
                case SettingRadioButtonsState.Sleep:
                    {
                        System.Windows.Application.Current.Shutdown();
                        System.Windows.Forms.Application.SetSuspendState(PowerState.Suspend, true, false);
                        
                    }
                    break;
                case SettingRadioButtonsState.Hebirnate:
                    {
                        System.Windows.Application.Current.Shutdown();
                        System.Windows.Forms.Application.SetSuspendState(PowerState.Hibernate, true, false);
                       
                    }
                    break;
                default:
                    {
                        var soundwin = new PlaySoundWindow();
                        soundwin.ShowDialog();
                    }
                    break;
            }


        }
    }
}
