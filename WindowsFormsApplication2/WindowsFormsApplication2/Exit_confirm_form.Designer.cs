namespace Inventory_Management_System
{
    partial class Exit_confirm_form
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
            this.label1 = new System.Windows.Forms.Label();
            this.Exit_Yes_button = new System.Windows.Forms.Button();
            this.Exit_No_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(328, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Are you sure you want to exit?";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Exit_Yes_button
            // 
            this.Exit_Yes_button.BackColor = System.Drawing.Color.Cyan;
            this.Exit_Yes_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_Yes_button.Location = new System.Drawing.Point(58, 91);
            this.Exit_Yes_button.Name = "Exit_Yes_button";
            this.Exit_Yes_button.Size = new System.Drawing.Size(90, 42);
            this.Exit_Yes_button.TabIndex = 1;
            this.Exit_Yes_button.Text = "Yes";
            this.Exit_Yes_button.UseVisualStyleBackColor = false;
            this.Exit_Yes_button.Click += new System.EventHandler(this.Exit_Yes_button_Click);
            // 
            // Exit_No_button
            // 
            this.Exit_No_button.BackColor = System.Drawing.Color.Cyan;
            this.Exit_No_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_No_button.Location = new System.Drawing.Point(210, 91);
            this.Exit_No_button.Name = "Exit_No_button";
            this.Exit_No_button.Size = new System.Drawing.Size(90, 42);
            this.Exit_No_button.TabIndex = 2;
            this.Exit_No_button.Text = "No";
            this.Exit_No_button.UseVisualStyleBackColor = false;
            this.Exit_No_button.Click += new System.EventHandler(this.Exit_No_button_Click);
            // 
            // Exit_confirm_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(392, 164);
            this.Controls.Add(this.Exit_No_button);
            this.Controls.Add(this.Exit_Yes_button);
            this.Controls.Add(this.label1);
            this.Name = "Exit_confirm_form";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Exit_confirm_form";
            this.Load += new System.EventHandler(this.Exit_confirm_form_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Exit_Yes_button;
        private System.Windows.Forms.Button Exit_No_button;
    }
}