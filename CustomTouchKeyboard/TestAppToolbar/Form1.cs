using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestAppToolbar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            DockForm(this.Height, this.Width);
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
                   100 + 4, width, //TODO fix this, not showing correctly
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
    }
}
