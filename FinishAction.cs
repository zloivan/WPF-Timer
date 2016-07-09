using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using WPFTimer.Enums;
using System.Windows;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace WPFTimer
{
    class FinishAction
    {

        public FinishAction(SettingRadioButtonsState settingRadioButtonsState)
        {
            switch (settingRadioButtonsState)
            {
                case SettingRadioButtonsState.Sleep:
                    {
                        System.Windows.Forms.Application.SetSuspendState(PowerState.Suspend, true, false);
                        System.Windows.Application.Current.Shutdown();
                    }
                    break;
                case SettingRadioButtonsState.Hebirnate:
                    {
                        System.Windows.Forms.Application.SetSuspendState(PowerState.Hibernate, true, false);
                        System.Windows.Application.Current.Shutdown();
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
