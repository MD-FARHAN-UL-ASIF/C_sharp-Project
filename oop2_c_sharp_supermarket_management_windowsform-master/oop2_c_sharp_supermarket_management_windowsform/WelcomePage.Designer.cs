
namespace oop2_c_sharp_supermarket_management_windowsform
{
    partial class WelcomePage
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
            this.welcomeTextPanel = new System.Windows.Forms.Panel();
            this.appName = new System.Windows.Forms.Label();
            this.buttonContainer = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.welcomeTextPanel.SuspendLayout();
            this.buttonContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // welcomeTextPanel
            // 
            this.welcomeTextPanel.Controls.Add(this.appName);
            this.welcomeTextPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.welcomeTextPanel.Location = new System.Drawing.Point(0, 0);
            this.welcomeTextPanel.Name = "welcomeTextPanel";
            this.welcomeTextPanel.Size = new System.Drawing.Size(792, 238);
            this.welcomeTextPanel.TabIndex = 0;
            // 
            // appName
            // 
            this.appName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.appName.AutoSize = true;
            this.appName.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.appName.Location = new System.Drawing.Point(86, 78);
            this.appName.Name = "appName";
            this.appName.Size = new System.Drawing.Size(618, 54);
            this.appName.TabIndex = 0;
            this.appName.Text = "Supermarket Management App";
            this.appName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonContainer
            // 
            this.buttonContainer.Controls.Add(this.exitButton);
            this.buttonContainer.Controls.Add(this.loginButton);
            this.buttonContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonContainer.Location = new System.Drawing.Point(0, 238);
            this.buttonContainer.Name = "buttonContainer";
            this.buttonContainer.Size = new System.Drawing.Size(792, 286);
            this.buttonContainer.TabIndex = 1;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.AutoSize = true;
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(177, 157);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(89, 45);
            this.exitButton.TabIndex = 1;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.AutoSize = true;
            this.loginButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginButton.Location = new System.Drawing.Point(499, 157);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(89, 45);
            this.loginButton.TabIndex = 0;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // WelcomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 524);
            this.Controls.Add(this.buttonContainer);
            this.Controls.Add(this.welcomeTextPanel);
            this.Name = "WelcomePage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Welcome";
            this.welcomeTextPanel.ResumeLayout(false);
            this.welcomeTextPanel.PerformLayout();
            this.buttonContainer.ResumeLayout(false);
            this.buttonContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel welcomeTextPanel;
        private System.Windows.Forms.Label appName;
        private System.Windows.Forms.Panel buttonContainer;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Button exitButton;
    }
}