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
using AppBar;

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

            DockForm(this.Height, this.Width);

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

        #region DOCKING
        private AppBar.ApplicationDesktopToolbar appBar = null;
        //http://www.codeproject.com/KB/cs/TDHAppBar.aspx?msg=2463017
        private void DockForm(int height, int width)
        {
            AppBar.AppBarEdges theAppBarEdge = AppBar.AppBarEdges.Bottom;    // example

            if (this.appBar == null)
            {
                appBar = new AppBar.ApplicationDesktopToolbar(
                    this, theAppBarEdge,
                    // HorizConfig delegate
                    new AppBar.AltitudeConfigDelegate(this.Configure_Horizontal),
                    // VertConfig delegate
                    new AppBar.AltitudeConfigDelegate(this.Configure_Vertical),
                    // AutoHideConfig delegate
                    new AppBar.AutoHideChangedDelegate(this.Configure_AutoHide),
                    // Docking dimensions (max height OR max width, depending upon .Edge)
                    height, width, //TODO fix this, not showing correctly
                    false);    // set .AutoHide
            }
            else
            if (this.appBar.Edge != theAppBarEdge)
            {
                appBar.Edge = theAppBarEdge;    // Change the Docked .Edge
            }

        }

        private void Configure_AutoHide(bool asAutoHide)
        {
            // do something
        }
        private void Configure_Horizontal(bool asDocked)
        {
            // do something
        }

        private void Configure_Vertical(bool asDocked)
        {
            // do something
        }

        private void cmnuMain_DockAutoHide_Click(object sender, System.EventArgs e)
        {
            if (this.appBar != null)
            {
                //this.cmnuMain_DockAutoHide.Checked = !this.cmnuMain_DockAutoHide.Checked;
               // this.appBar.AutoHide = this.cmnuMain_DockAutoHide.Checked;
            }
            else
            {
                //this.cmnuMain_DockAutoHide.Checked = false;
                //this.cmnuMain_DockAutoHide.Enabled = false;
            }
        }

        private void cmnuMain_Float_Click(object sender, System.EventArgs e)
        {
            if (this.appBar != null)
            {
                if (!this.appBar.UnDock(AppBar.Altitude.Horizontal))    // example
                {
                    this.appBar.Dispose();
                }
                this.appBar = null;
            }
        }

#endregion
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
