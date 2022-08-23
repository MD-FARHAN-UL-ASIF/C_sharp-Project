
namespace oop2_c_sharp_supermarket_management_windowsform
{
    partial class InventoryManager
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SidenavContainer = new System.Windows.Forms.Panel();
            this.MessagesButton = new System.Windows.Forms.Button();
            this.addProductButton = new System.Windows.Forms.Button();
            this.editProductButton = new System.Windows.Forms.Button();
            this.allProductButton = new System.Windows.Forms.Button();
            this.logoutButton = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pageRoleName = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.exitButton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SidenavContainer.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.Location = new System.Drawing.Point(286, 27);
            this.mainPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(857, 906);
            this.mainPanel.TabIndex = 17;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.SlateGray;
            this.panel1.Controls.Add(this.SidenavContainer);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 27);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 906);
            this.panel1.TabIndex = 15;
            // 
            // SidenavContainer
            // 
            this.SidenavContainer.Controls.Add(this.MessagesButton);
            this.SidenavContainer.Controls.Add(this.addProductButton);
            this.SidenavContainer.Controls.Add(this.editProductButton);
            this.SidenavContainer.Controls.Add(this.allProductButton);
            this.SidenavContainer.Controls.Add(this.logoutButton);
            this.SidenavContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SidenavContainer.Location = new System.Drawing.Point(0, 107);
            this.SidenavContainer.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SidenavContainer.Name = "SidenavContainer";
            this.SidenavContainer.Size = new System.Drawing.Size(286, 799);
            this.SidenavContainer.TabIndex = 7;
            // 
            // MessagesButton
            // 
            this.MessagesButton.AutoSize = true;
            this.MessagesButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.MessagesButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MessagesButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MessagesButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.MessagesButton.ForeColor = System.Drawing.Color.Blue;
            this.MessagesButton.Location = new System.Drawing.Point(0, 639);
            this.MessagesButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MessagesButton.Name = "MessagesButton";
            this.MessagesButton.Size = new System.Drawing.Size(286, 80);
            this.MessagesButton.TabIndex = 11;
            this.MessagesButton.Text = "Chat";
            this.MessagesButton.UseVisualStyleBackColor = false;
            this.MessagesButton.Click += new System.EventHandler(this.MessagesButton_Click);
            // 
            // addProductButton
            // 
            this.addProductButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.addProductButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.addProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.addProductButton.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addProductButton.Location = new System.Drawing.Point(0, 160);
            this.addProductButton.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.addProductButton.Name = "addProductButton";
            this.addProductButton.Size = new System.Drawing.Size(286, 80);
            this.addProductButton.TabIndex = 10;
            this.addProductButton.Text = "Add Product";
            this.addProductButton.UseVisualStyleBackColor = false;
            this.addProductButton.Click += new System.EventHandler(this.addProductButton_Click_1);
            // 
            // editProductButton
            // 
            this.editProductButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.editProductButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.editProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.editProductButton.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.editProductButton.Location = new System.Drawing.Point(0, 80);
            this.editProductButton.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.editProductButton.Name = "editProductButton";
            this.editProductButton.Size = new System.Drawing.Size(286, 80);
            this.editProductButton.TabIndex = 9;
            this.editProductButton.Text = "Edit Product";
            this.editProductButton.UseVisualStyleBackColor = false;
            this.editProductButton.Click += new System.EventHandler(this.editProductButton_Click_1);
            // 
            // allProductButton
            // 
            this.allProductButton.BackColor = System.Drawing.Color.LightSlateGray;
            this.allProductButton.Dock = System.Windows.Forms.DockStyle.Top;
            this.allProductButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allProductButton.Font = new System.Drawing.Font("Malgun Gothic Semilight", 13F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.allProductButton.Location = new System.Drawing.Point(0, 0);
            this.allProductButton.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.allProductButton.Name = "allProductButton";
            this.allProductButton.Size = new System.Drawing.Size(286, 80);
            this.allProductButton.TabIndex = 8;
            this.allProductButton.Text = "All Products";
            this.allProductButton.UseVisualStyleBackColor = false;
            this.allProductButton.Click += new System.EventHandler(this.allProductButton_Click_1);
            // 
            // logoutButton
            // 
            this.logoutButton.AutoSize = true;
            this.logoutButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutButton.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.logoutButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.logoutButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.logoutButton.ForeColor = System.Drawing.Color.Crimson;
            this.logoutButton.Location = new System.Drawing.Point(0, 719);
            this.logoutButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.logoutButton.Name = "logoutButton";
            this.logoutButton.Size = new System.Drawing.Size(286, 80);
            this.logoutButton.TabIndex = 7;
            this.logoutButton.Text = "Logout";
            this.logoutButton.UseVisualStyleBackColor = false;
            this.logoutButton.Click += new System.EventHandler(this.logoutButton_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.pageRoleName);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(286, 107);
            this.panel3.TabIndex = 2;
            // 
            // pageRoleName
            // 
            this.pageRoleName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pageRoleName.AutoSize = true;
            this.pageRoleName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.pageRoleName.ForeColor = System.Drawing.Color.Azure;
            this.pageRoleName.Location = new System.Drawing.Point(12, 19);
            this.pageRoleName.Name = "pageRoleName";
            this.pageRoleName.Size = new System.Drawing.Size(263, 41);
            this.pageRoleName.TabIndex = 2;
            this.pageRoleName.Text = "Product Manager";
            this.pageRoleName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.exitButton);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1143, 27);
            this.panel4.TabIndex = 16;
            // 
            // exitButton
            // 
            this.exitButton.AutoSize = true;
            this.exitButton.BackColor = System.Drawing.Color.Red;
            this.exitButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exitButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.exitButton.FlatAppearance.BorderSize = 0;
            this.exitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exitButton.Font = new System.Drawing.Font("Segoe UI", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.exitButton.ForeColor = System.Drawing.Color.DimGray;
            this.exitButton.Location = new System.Drawing.Point(1109, 0);
            this.exitButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(34, 27);
            this.exitButton.TabIndex = 6;
            this.exitButton.Text = "X";
            this.exitButton.UseVisualStyleBackColor = false;
            this.exitButton.Click += new System.EventHandler(this.exitButton_Click);
            // 
            // InventoryManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1143, 933);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel4);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "InventoryManager";
            this.Text = "InventoryManager";
            this.panel1.ResumeLayout(false);
            this.SidenavContainer.ResumeLayout(false);
            this.SidenavContainer.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel SidenavContainer;
        private System.Windows.Forms.Button addUserButton;
        private System.Windows.Forms.Button editUserButton;
        private System.Windows.Forms.Button allUserButton;
        private System.Windows.Forms.Button logoutButton;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label pageRoleName;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button MessagesButton;
        private System.Windows.Forms.Button addProductButton;
        private System.Windows.Forms.Button editProductButton;
        private System.Windows.Forms.Button allProductButton;
    }
}