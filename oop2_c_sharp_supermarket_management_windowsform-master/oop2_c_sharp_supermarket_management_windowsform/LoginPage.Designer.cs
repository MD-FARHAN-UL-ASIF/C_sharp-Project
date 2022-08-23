
namespace oop2_c_sharp_supermarket_management_windowsform
{
    partial class LoginPage
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
            this.components = new System.ComponentModel.Container();
            this.pageHeaderContainer = new System.Windows.Forms.Panel();
            this.pageHeaderLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.loginButton = new System.Windows.Forms.Button();
            this.buttonsContainer = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.passwordError = new System.Windows.Forms.Label();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.usernameError = new System.Windows.Forms.Label();
            this.usernameTextBox = new System.Windows.Forms.TextBox();
            this.passwordTextBoxLabel = new System.Windows.Forms.Label();
            this.usernameTextBoxLabel = new System.Windows.Forms.Label();
            this.textBoxContainer = new System.Windows.Forms.Panel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.pageHeaderContainer.SuspendLayout();
            this.buttonsContainer.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.textBoxContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // pageHeaderContainer
            // 
            this.pageHeaderContainer.Controls.Add(this.pageHeaderLabel);
            this.pageHeaderContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.pageHeaderContainer.Location = new System.Drawing.Point(0, 0);
            this.pageHeaderContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pageHeaderContainer.Name = "pageHeaderContainer";
            this.pageHeaderContainer.Size = new System.Drawing.Size(672, 133);
            this.pageHeaderContainer.TabIndex = 0;
            // 
            // pageHeaderLabel
            // 
            this.pageHeaderLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pageHeaderLabel.AutoSize = true;
            this.pageHeaderLabel.Font = new System.Drawing.Font("Segoe UI", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pageHeaderLabel.Location = new System.Drawing.Point(257, 32);
            this.pageHeaderLabel.Name = "pageHeaderLabel";
            this.pageHeaderLabel.Size = new System.Drawing.Size(161, 67);
            this.pageHeaderLabel.TabIndex = 1;
            this.pageHeaderLabel.Text = "Login";
            this.pageHeaderLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.AutoSize = true;
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.Location = new System.Drawing.Point(69, 36);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(102, 60);
            this.exitButton.TabIndex = 3;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.AutoSize = true;
            this.loginButton.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.loginButton.Location = new System.Drawing.Point(488, 36);
            this.loginButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(102, 60);
            this.loginButton.TabIndex = 2;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // buttonsContainer
            // 
            this.buttonsContainer.Controls.Add(this.loginButton);
            this.buttonsContainer.Controls.Add(this.exitButton);
            this.buttonsContainer.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.buttonsContainer.Location = new System.Drawing.Point(0, 566);
            this.buttonsContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.buttonsContainer.Name = "buttonsContainer";
            this.buttonsContainer.Size = new System.Drawing.Size(672, 133);
            this.buttonsContainer.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel1.Controls.Add(this.panel2, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel1, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.passwordTextBoxLabel, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.usernameTextBoxLabel, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(30, 142);
            this.tableLayoutPanel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 27F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(617, 200);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.passwordError);
            this.panel2.Controls.Add(this.passwordTextBox);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(188, 104);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(426, 92);
            this.panel2.TabIndex = 4;
            // 
            // passwordError
            // 
            this.passwordError.AccessibleName = "";
            this.passwordError.AutoSize = true;
            this.passwordError.Dock = System.Windows.Forms.DockStyle.Top;
            this.passwordError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordError.ForeColor = System.Drawing.Color.Red;
            this.passwordError.Location = new System.Drawing.Point(0, 39);
            this.passwordError.Name = "passwordError";
            this.passwordError.Size = new System.Drawing.Size(0, 28);
            this.passwordError.TabIndex = 6;
            this.passwordError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.passwordTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBox.Location = new System.Drawing.Point(0, 0);
            this.passwordTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.Size = new System.Drawing.Size(426, 39);
            this.passwordTextBox.TabIndex = 5;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.usernameError);
            this.panel1.Controls.Add(this.usernameTextBox);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(188, 4);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(426, 92);
            this.panel1.TabIndex = 4;
            // 
            // usernameError
            // 
            this.usernameError.AccessibleName = "";
            this.usernameError.AutoSize = true;
            this.usernameError.Dock = System.Windows.Forms.DockStyle.Top;
            this.usernameError.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameError.ForeColor = System.Drawing.Color.Red;
            this.usernameError.Location = new System.Drawing.Point(0, 39);
            this.usernameError.Name = "usernameError";
            this.usernameError.Size = new System.Drawing.Size(0, 28);
            this.usernameError.TabIndex = 3;
            this.usernameError.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameTextBox
            // 
            this.usernameTextBox.Dock = System.Windows.Forms.DockStyle.Top;
            this.usernameTextBox.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.usernameTextBox.Location = new System.Drawing.Point(0, 0);
            this.usernameTextBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.usernameTextBox.Name = "usernameTextBox";
            this.usernameTextBox.Size = new System.Drawing.Size(426, 39);
            this.usernameTextBox.TabIndex = 4;
            // 
            // passwordTextBoxLabel
            // 
            this.passwordTextBoxLabel.AccessibleName = "";
            this.passwordTextBoxLabel.AutoSize = true;
            this.passwordTextBoxLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.passwordTextBoxLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.passwordTextBoxLabel.Location = new System.Drawing.Point(3, 100);
            this.passwordTextBoxLabel.Name = "passwordTextBoxLabel";
            this.passwordTextBoxLabel.Size = new System.Drawing.Size(179, 37);
            this.passwordTextBoxLabel.TabIndex = 3;
            this.passwordTextBoxLabel.Text = "Password";
            this.passwordTextBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // usernameTextBoxLabel
            // 
            this.usernameTextBoxLabel.AccessibleName = "";
            this.usernameTextBoxLabel.AutoSize = true;
            this.usernameTextBoxLabel.Dock = System.Windows.Forms.DockStyle.Top;
            this.usernameTextBoxLabel.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.usernameTextBoxLabel.Location = new System.Drawing.Point(3, 0);
            this.usernameTextBoxLabel.Name = "usernameTextBoxLabel";
            this.usernameTextBoxLabel.Size = new System.Drawing.Size(179, 37);
            this.usernameTextBoxLabel.TabIndex = 2;
            this.usernameTextBoxLabel.Text = "Username";
            this.usernameTextBoxLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxContainer
            // 
            this.textBoxContainer.Controls.Add(this.tableLayoutPanel1);
            this.textBoxContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.textBoxContainer.Location = new System.Drawing.Point(0, 133);
            this.textBoxContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.textBoxContainer.Name = "textBoxContainer";
            this.textBoxContainer.Size = new System.Drawing.Size(672, 566);
            this.textBoxContainer.TabIndex = 1;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // LoginPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(672, 699);
            this.Controls.Add(this.buttonsContainer);
            this.Controls.Add(this.textBoxContainer);
            this.Controls.Add(this.pageHeaderContainer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "LoginPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.pageHeaderContainer.ResumeLayout(false);
            this.pageHeaderContainer.PerformLayout();
            this.buttonsContainer.ResumeLayout(false);
            this.buttonsContainer.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.textBoxContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pageHeaderContainer;
        private System.Windows.Forms.Label pageHeaderLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.Panel buttonsContainer;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label passwordTextBoxLabel;
        private System.Windows.Forms.Label usernameTextBoxLabel;
        private System.Windows.Forms.Panel textBoxContainer;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.TextBox usernameTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label passwordError;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label usernameError;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}