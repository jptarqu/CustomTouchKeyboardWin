namespace CustomTouchKeyboard.Keyboard
{
    partial class KeysPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SwitchMainLeftBtn = new System.Windows.Forms.Button();
            this.SwitchMainRightBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SwitchMainLeftBtn
            // 
            this.SwitchMainLeftBtn.Location = new System.Drawing.Point(1307, 3);
            this.SwitchMainLeftBtn.Name = "SwitchMainLeftBtn";
            this.SwitchMainLeftBtn.Size = new System.Drawing.Size(40, 40);
            this.SwitchMainLeftBtn.TabIndex = 3;
            this.SwitchMainLeftBtn.Text = "<-";
            this.SwitchMainLeftBtn.UseVisualStyleBackColor = true;
            this.SwitchMainLeftBtn.Click += new System.EventHandler(this.SwitchMainLeftBtn_Click);
            // 
            // SwitchMainRightBtn
            // 
            this.SwitchMainRightBtn.Location = new System.Drawing.Point(1307, 49);
            this.SwitchMainRightBtn.Name = "SwitchMainRightBtn";
            this.SwitchMainRightBtn.Size = new System.Drawing.Size(40, 40);
            this.SwitchMainRightBtn.TabIndex = 2;
            this.SwitchMainRightBtn.Text = "->";
            this.SwitchMainRightBtn.UseVisualStyleBackColor = true;
            this.SwitchMainRightBtn.Click += new System.EventHandler(this.SwitchMainRightBtn_Click);
            // 
            // KeysPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.SwitchMainLeftBtn);
            this.Controls.Add(this.SwitchMainRightBtn);
            this.Name = "KeysPanel";
            this.Size = new System.Drawing.Size(1350, 96);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SwitchMainLeftBtn;
        private System.Windows.Forms.Button SwitchMainRightBtn;
    }
}
