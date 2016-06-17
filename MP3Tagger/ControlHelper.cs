using System;
using System.Windows.Forms;

namespace MP3Tagger
{
    public static class ControlHelper{
        public static void InvokeEx(this Control control, Action action){
            if (control.InvokeRequired){
                control.Invoke(action);
            }
            else action();
        }
    }
}
