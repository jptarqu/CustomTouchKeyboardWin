using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomTouchKeyboard.Keyboard
{
    public partial class KeysPanel : UserControl
    {
        private const int UNIT_SIZE = 36;
        private readonly KeysMessenger _keysSender;
        private readonly LinkedList<Button> _currKeyBtns;
        private KeyboardLayout[] _possibleKeyboards;
        private int _currKeyboardIdx;

        public KeysPanel()
        {
            _keysSender = new KeysMessenger();
            _currKeyBtns = new LinkedList<Button>();
            InitializeComponent();
        }

        private void CleanPanel()
        {
            var btns = this.Controls;
            foreach (var btn in _currKeyBtns)
            {
                btn.Click -= button1_Click;
                btns.Remove(btn);
            }
        }
        public void RebuildKeysPanel(IEnumerable<UserKey> userKeys)
        {
            CleanPanel();
            foreach (var userKey in userKeys)
            {
                var newBtn = new Button();
                newBtn.Name = userKey.Label + "Btn";
                newBtn.Left = UNIT_SIZE * userKey.X;
                newBtn.Top = UNIT_SIZE * userKey.Y;
                newBtn.Size = new Size(UNIT_SIZE * userKey.Width, UNIT_SIZE * userKey.Height);
                newBtn.Text = userKey.Label;
                newBtn.UseVisualStyleBackColor = true;
                newBtn.Tag = userKey;
                newBtn.Click += button1_Click;
                this.Controls.Add(newBtn);
                _currKeyBtns.AddLast(newBtn);
            }
            this.Width = Parent.Width - 4;
        }


        internal void LoadKeyboards(IEnumerable<KeyboardLayout> keyboards)
        {
            _possibleKeyboards = keyboards.ToArray();
            if (_possibleKeyboards != null && _possibleKeyboards.Length > 0)
            {
                RebuildKeysPanel(_possibleKeyboards.First().Keys);
                _currKeyboardIdx = 0;
            }
            GuardSwitchBtns();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            _keysSender.SendKey(((UserKey)((Button)sender).Tag));
        }

        private void SwitchMainLeftBtn_Click(object sender, EventArgs e)
        {
            if (_currKeyboardIdx > 0)
            {
                _currKeyboardIdx--;
                RebuildKeysPanel(_possibleKeyboards[_currKeyboardIdx].Keys);
                
            }
            GuardSwitchBtns();
        }

        private void GuardSwitchBtns()
        {

            if (_currKeyboardIdx <= 0)
            {
                SwitchMainLeftBtn.Enabled = false;
            }
            else
            {
                SwitchMainLeftBtn.Enabled = true;
            }
            if (_currKeyboardIdx >= (_possibleKeyboards.Length - 1))
            {
                SwitchMainRightBtn.Enabled = false;
            }
            else
            {
                SwitchMainRightBtn.Enabled = true;
            }
        }
        private void SwitchMainRightBtn_Click(object sender, EventArgs e)
        {
            if (_currKeyboardIdx < (_possibleKeyboards.Length - 1))
            {
                _currKeyboardIdx++;
                RebuildKeysPanel(_possibleKeyboards[_currKeyboardIdx].Keys);

            }
            GuardSwitchBtns();
        }
    }
}
