using CustomTouchKeyboard.Configuration;
using CustomTouchKeyboard.Keyboard;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomTouchKeyboard
{
    public partial class Form1 : Form
    {
        private IEnumerable<UserKey> _userKeys;
        private const int UNIT_SIZE = 80;

        public Form1()
        {

            //_userKeys = new[]
            //{
            //    new UserKey("A","A",0,0,1,1),
            //    new UserKey("SelWord","(^{LEFT})(+^{RIGHT})",1,0,2,1),
            //    new UserKey("SelLine","({HOME})(+{END})",3,0,2,2)

            //};
            //var json = JsonConvert.SerializeObject(_userKeys);
            ConfigurationManager conf = new ConfigurationManager("KeyboardLayouts.json");
            _keysSender = new KeysMessenger();

            InitializeComponent();
            _userKeys = conf.Settings.MainKeyboards.First().Keys;
            foreach (var userKey in _userKeys)
            {
                var newBtn = new Button();
                newBtn.Name = userKey.Label + "Btn";
                newBtn.Left = UNIT_SIZE * userKey.X;
                newBtn.Top = UNIT_SIZE * userKey.Y;
                newBtn.Size = new Size(UNIT_SIZE * userKey.Width, UNIT_SIZE * userKey.Height);
                newBtn.Text = userKey.Label;
                newBtn.UseVisualStyleBackColor = true;
                newBtn.Tag = userKey;
                newBtn.Click += new EventHandler(button1_Click);
                this.Controls.Add(newBtn);
            }
            this.Width = Screen.PrimaryScreen.Bounds.Width;
        }

        protected override CreateParams CreateParams
        {
            get
            {
                var paramsForm = base.CreateParams;
                paramsForm.ExStyle |= 0x08000000;
                    return paramsForm;
            }
        }
        // For Windows Mobile, replace user32.dll with coredll.dll

        [DllImport("user32.dll")]

        [return: MarshalAs(UnmanagedType.Bool)]

        static extern bool SetForegroundWindow(IntPtr hWnd);



        [DllImport("user32.dll", SetLastError = true)]

        static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);



        [DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]

        static extern int GetWindowText(IntPtr hWnd, [Out] StringBuilder lpString, int nMaxCount);



        [DllImport("user32.dll")]

        [return: MarshalAs(UnmanagedType.Bool)]

        static extern bool IsWindowVisible(IntPtr hWnd);





        public const int GW_HWNDNEXT = 2;

        public const int GW_HWNDLAST = 1;

        public const int GW_HWNDFIRST = 0;

        private KeysMessenger _keysSender;

        private void button1_Click(object sender, EventArgs e)
        { 
        
            _keysSender.SendKey(((UserKey)((Button)sender).Tag));

            //this.TopMost = true;
            //    if (next != last) //If it is not the last window

            //    {

            //        if (IsWindowVisible(next)) //If the window is visible

            //        {

            //            GetWindowText(next, sb, 256);



            //            //if (sb.ToString().Contains("Notepad")) //If it is a notpad.exe

            //            //{



            //            //}



            //            Console.WriteLine(sb.ToString());

            //        }

            //    }

            //    else

            //    {

            //        break;

            //    }

            //}

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
