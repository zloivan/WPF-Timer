using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Timer.Settings;
using Timer.ShutDown;

namespace Timer
{
    static public class Action
    {
        //
        public static void StateChack()
        {
            if (CSettings.OperationOption != Operations.DoNothing)
            {
                ConfurmCheck form = new ConfurmCheck();
                form.ShowDialog();
            }
            else
            {
                var result = MessageBox.Show("Your timer ended!", "Ding! Dong!", MessageBoxButtons.OK);
            }
        }
        public static void Run(Operations mode)
        {
            
            ShutDownClass sh = new ShutDownClass();
            if (mode == Operations.Lock)
            {
                
                sh.Lock();
                Application.Exit();
            }
            else if (mode == Operations.ShutDown)
            {
                sh.halt(false, false);
            }
            else if (mode == Operations.Hebernate)
            {
                Application.Exit();
                Application.SetSuspendState(PowerState.Hibernate, true, false);

            }
            else if (mode == Operations.Sleep)

            {
                Application.Exit();
                Application.SetSuspendState(PowerState.Suspend, true, false);
            }
            



        }
    }
}
