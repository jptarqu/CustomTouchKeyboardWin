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
        public Form1()
        {
            
            _userKeys = new[]
            {
                new UserKey("A","A"),
                new UserKey("SelWord","(^{LEFT})(+^{RIGHT})"),
                new UserKey("SelLine","({HOME})(+{END})")

            };
            InitializeComponent();
            foreach(var userKey in _userKeys)
            {
                var newBtn = new Button();
                newBtn.Name = userKey.Label + "Btn";
                newBtn.Size = new System.Drawing.Size(80, 80);
                newBtn.Text = userKey.Label;
                newBtn.UseVisualStyleBackColor = true;
                newBtn.Tag = userKey;
                newBtn.Click += new System.EventHandler(this.button1_Click);
                keysPanel.Controls.Add(newBtn);
            }
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



        private void button1_Click(object sender, EventArgs e)

        {
            string combinationToSend = ((UserKey)((Button)sender).Tag).Keys; //select line
            SendKeys.Send(combinationToSend);//"^c"); //Send ctrl+c

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
