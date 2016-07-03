using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomTouchKeyboard.Keyboard
{
    public class KeysMessenger
    {
        private bool _isCapLock;
        public void SendKey(UserKey key)
        {
            if (key.IsCapsLock)
            {
                _isCapLock = !_isCapLock;
            }
            string combinationToSend = key.Keys; //we assume the configuration file already is scaping +^%~()
            if (_isCapLock)
            {
                combinationToSend = combinationToSend.ToUpper();
            }
            SendKeys.Send(combinationToSend);//"^c"); //Send ctrl+c
        }
    }
}
