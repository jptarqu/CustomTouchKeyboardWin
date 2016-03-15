namespace CustomTouchKeyboard
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SnipsPanel = new CustomTouchKeyboard.Keyboard.KeysPanel();
            this.MainPanel = new CustomTouchKeyboard.Keyboard.KeysPanel();
            this.SuspendLayout();
            // 
            // SnipsPanel
            // 
            this.SnipsPanel.AutoSize = true;
            this.SnipsPanel.Location = new System.Drawing.Point(13, 13);
            this.SnipsPanel.Name = "SnipsPanel";
            this.SnipsPanel.Size = new System.Drawing.Size(1350, 92);
            this.SnipsPanel.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.AutoSize = true;
            this.MainPanel.Location = new System.Drawing.Point(11, 123);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(1350, 280);
            this.MainPanel.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 415);
            this.Controls.Add(this.MainPanel);
            this.Controls.Add(this.SnipsPanel);
            this.Name = "Form1";
            this.Text = "Keyboard";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Keyboard.KeysPanel SnipsPanel;
        private Keyboard.KeysPanel MainPanel;
    }
}

