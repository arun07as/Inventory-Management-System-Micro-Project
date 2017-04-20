namespace WindowsFormsApplication2
{
    
    partial class Login_Form
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login_Form));
            this.login_panel = new System.Windows.Forms.Panel();
            this.Exit_button = new System.Windows.Forms.Button();
            this.Login_button = new System.Windows.Forms.Button();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Password_label = new System.Windows.Forms.Label();
            this.Username_textBox = new System.Windows.Forms.TextBox();
            this.Username_label = new System.Windows.Forms.Label();
            this.login_label = new System.Windows.Forms.Label();
            this.pageSetupDialog1 = new System.Windows.Forms.PageSetupDialog();
            this.login_panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // login_panel
            // 
            this.login_panel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.login_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(180)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.login_panel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.login_panel.Controls.Add(this.Exit_button);
            this.login_panel.Controls.Add(this.Login_button);
            this.login_panel.Controls.Add(this.Password_textBox);
            this.login_panel.Controls.Add(this.Password_label);
            this.login_panel.Controls.Add(this.Username_textBox);
            this.login_panel.Controls.Add(this.Username_label);
            this.login_panel.Controls.Add(this.login_label);
            this.login_panel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.login_panel.Location = new System.Drawing.Point(183, 124);
            this.login_panel.Name = "login_panel";
            this.login_panel.Size = new System.Drawing.Size(512, 333);
            this.login_panel.TabIndex = 0;
            this.login_panel.Paint += new System.Windows.Forms.PaintEventHandler(this.login_panel_Paint);
            // 
            // Exit_button
            // 
            this.Exit_button.BackColor = System.Drawing.Color.Turquoise;
            this.Exit_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_button.Location = new System.Drawing.Point(282, 261);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(130, 34);
            this.Exit_button.TabIndex = 6;
            this.Exit_button.Text = "Exit";
            this.Exit_button.UseVisualStyleBackColor = false;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // Login_button
            // 
            this.Login_button.BackColor = System.Drawing.Color.Turquoise;
            this.Login_button.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Login_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Login_button.Location = new System.Drawing.Point(73, 261);
            this.Login_button.Name = "Login_button";
            this.Login_button.Size = new System.Drawing.Size(130, 34);
            this.Login_button.TabIndex = 5;
            this.Login_button.Text = "Log In";
            this.Login_button.UseVisualStyleBackColor = false;
            this.Login_button.Click += new System.EventHandler(this.Login_button_Click);
            // 
            // Password_textBox
            // 
            this.Password_textBox.AcceptsReturn = true;
            this.Password_textBox.AcceptsTab = true;
            this.Password_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_textBox.Location = new System.Drawing.Point(156, 187);
            this.Password_textBox.MaxLength = 20;
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.PasswordChar = '*';
            this.Password_textBox.Size = new System.Drawing.Size(305, 35);
            this.Password_textBox.TabIndex = 4;
            this.Password_textBox.TextChanged += new System.EventHandler(this.Password_textBox_TextChanged);
            // 
            // Password_label
            // 
            this.Password_label.BackColor = System.Drawing.Color.Transparent;
            this.Password_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Password_label.ForeColor = System.Drawing.Color.Transparent;
            this.Password_label.Location = new System.Drawing.Point(26, 187);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(122, 35);
            this.Password_label.TabIndex = 3;
            this.Password_label.Text = "Password";
            this.Password_label.Click += new System.EventHandler(this.Password_label_Click);
            // 
            // Username_textBox
            // 
            this.Username_textBox.AcceptsReturn = true;
            this.Username_textBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Lower;
            this.Username_textBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_textBox.HideSelection = false;
            this.Username_textBox.Location = new System.Drawing.Point(156, 106);
            this.Username_textBox.MaxLength = 20;
            this.Username_textBox.Name = "Username_textBox";
            this.Username_textBox.Size = new System.Drawing.Size(305, 35);
            this.Username_textBox.TabIndex = 2;
            this.Username_textBox.TextChanged += new System.EventHandler(this.Username_textBox_TextChanged);
            // 
            // Username_label
            // 
            this.Username_label.BackColor = System.Drawing.Color.Transparent;
            this.Username_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Username_label.ForeColor = System.Drawing.Color.Transparent;
            this.Username_label.Location = new System.Drawing.Point(21, 106);
            this.Username_label.Name = "Username_label";
            this.Username_label.Size = new System.Drawing.Size(127, 35);
            this.Username_label.TabIndex = 1;
            this.Username_label.Text = "Username";
            // 
            // login_label
            // 
            this.login_label.BackColor = System.Drawing.Color.Transparent;
            this.login_label.Font = new System.Drawing.Font("Bookman Old Style", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.ForeColor = System.Drawing.Color.White;
            this.login_label.Location = new System.Drawing.Point(162, 16);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(227, 64);
            this.login_label.TabIndex = 0;
            this.login_label.Text = "LOGIN";
            this.login_label.Click += new System.EventHandler(this.login_label_Click);
            // 
            // Login_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(876, 573);
            this.Controls.Add(this.login_panel);
            this.Name = "Login_Form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login_Form";
            this.TransparencyKey = System.Drawing.SystemColors.Control;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.login_panel.ResumeLayout(false);
            this.login_panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel login_panel;
        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.TextBox Username_textBox;
        private System.Windows.Forms.Label Username_label;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.Button Login_button;
        private System.Windows.Forms.PageSetupDialog pageSetupDialog1;
        private System.Windows.Forms.Button Exit_button;

    }
}

