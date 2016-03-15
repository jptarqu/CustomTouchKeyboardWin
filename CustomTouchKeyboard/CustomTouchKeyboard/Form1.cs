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

            InitializeComponent();
            //var m = conf.Settings.MainKeyboards;
            this.MainPanel.LoadKeyboards(conf.Settings.MainKeyboards);
            this.SnipsPanel.LoadKeyboards(conf.Settings.SnippetsKeyboards);

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

        //[DllImport("user32.dll")]

        //[return: MarshalAs(UnmanagedType.Bool)]

        //static extern bool SetForegroundWindow(IntPtr hWnd);



        //[DllImport("user32.dll", SetLastError = true)]

        //static extern IntPtr GetWindow(IntPtr hWnd, uint uCmd);



        //[DllImport("user32.dll", SetLastError = true, CharSet = CharSet.Auto)]

        //static extern int GetWindowText(IntPtr hWnd, [Out] StringBuilder lpString, int nMaxCount);



        //[DllImport("user32.dll")]

        //[return: MarshalAs(UnmanagedType.Bool)]

        //static extern bool IsWindowVisible(IntPtr hWnd);





        //public const int GW_HWNDNEXT = 2;

        //public const int GW_HWNDLAST = 1;

        //public const int GW_HWNDFIRST = 0;

    }
}
