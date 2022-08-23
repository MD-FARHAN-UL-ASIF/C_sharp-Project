
namespace oop2_c_sharp_supermarket_management_windowsform
{
    partial class MessagingPage
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.MainPanel = new System.Windows.Forms.Panel();
            this.ContactPanel = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.MainPanel);
            this.panel1.Controls.Add(this.ContactPanel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(750, 680);
            this.panel1.TabIndex = 0;
            // 
            // MainPanel
            // 
            this.MainPanel.AutoScroll = true;
            this.MainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainPanel.Location = new System.Drawing.Point(200, 0);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Size = new System.Drawing.Size(550, 680);
            this.MainPanel.TabIndex = 1;
            // 
            // ContactPanel
            // 
            this.ContactPanel.AutoScroll = true;
            this.ContactPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.ContactPanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.ContactPanel.Location = new System.Drawing.Point(0, 0);
            this.ContactPanel.Name = "ContactPanel";
            this.ContactPanel.Padding = new System.Windows.Forms.Padding(0, 0, 10, 0);
            this.ContactPanel.Size = new System.Drawing.Size(200, 680);
            this.ContactPanel.TabIndex = 0;
            // 
            // MessagingPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 680);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "MessagingPage";
            this.Text = "MessagingPage";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel MainPanel;
        private System.Windows.Forms.Panel ContactPanel;
        private System.Windows.Forms.Button button1;
    }
}