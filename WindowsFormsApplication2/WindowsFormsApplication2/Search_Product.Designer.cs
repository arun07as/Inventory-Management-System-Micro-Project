namespace Inventory_Management_System
{
    partial class Search_Product
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
            this.ProductCode_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.ProductName_textbox = new System.Windows.Forms.TextBox();
            this.Rate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Refresh_button = new System.Windows.Forms.Button();
            this.ProductQuantity_textbox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ProductRate_textbox = new System.Windows.Forms.TextBox();
            this.Search_button = new System.Windows.Forms.Button();
            this.Select_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(26, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Product Code";
            // 
            // ProductCode_textbox
            // 
            this.ProductCode_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductCode_textbox.Location = new System.Drawing.Point(29, 38);
            this.ProductCode_textbox.Name = "ProductCode_textbox";
            this.ProductCode_textbox.Size = new System.Drawing.Size(150, 22);
            this.ProductCode_textbox.TabIndex = 19;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(199, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(94, 16);
            this.label2.TabIndex = 22;
            this.label2.Text = "Product Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(26, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 16);
            this.label3.TabIndex = 24;
            this.label3.Text = "Quantity";
            // 
            // ProductName_textbox
            // 
            this.ProductName_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductName_textbox.Location = new System.Drawing.Point(202, 38);
            this.ProductName_textbox.Name = "ProductName_textbox";
            this.ProductName_textbox.Size = new System.Drawing.Size(398, 22);
            this.ProductName_textbox.TabIndex = 20;
            // 
            // Rate
            // 
            this.Rate.HeaderText = "Rate";
            this.Rate.Name = "Rate";
            this.Rate.ReadOnly = true;
            this.Rate.Width = 120;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "Quantity";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 120;
            // 
            // Column2
            // 
            this.Column2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Column2.HeaderText = "Product Name";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Product Code";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 120;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Rate});
            this.dataGridView1.Location = new System.Drawing.Point(29, 191);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(883, 363);
            this.dataGridView1.TabIndex = 25;
            this.dataGridView1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.dataGridView1_MouseDoubleClick);
            // 
            // Refresh_button
            // 
            this.Refresh_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Refresh_button.Location = new System.Drawing.Point(795, 102);
            this.Refresh_button.Name = "Refresh_button";
            this.Refresh_button.Size = new System.Drawing.Size(107, 30);
            this.Refresh_button.TabIndex = 31;
            this.Refresh_button.Text = "Refresh";
            this.Refresh_button.UseVisualStyleBackColor = true;
            this.Refresh_button.Click += new System.EventHandler(this.Refresh_button_Click);
            // 
            // ProductQuantity_textbox
            // 
            this.ProductQuantity_textbox.Enabled = false;
            this.ProductQuantity_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductQuantity_textbox.Location = new System.Drawing.Point(29, 120);
            this.ProductQuantity_textbox.Name = "ProductQuantity_textbox";
            this.ProductQuantity_textbox.Size = new System.Drawing.Size(150, 22);
            this.ProductQuantity_textbox.TabIndex = 26;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(199, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 16);
            this.label4.TabIndex = 27;
            this.label4.Text = "Rate";
            // 
            // ProductRate_textbox
            // 
            this.ProductRate_textbox.Enabled = false;
            this.ProductRate_textbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProductRate_textbox.Location = new System.Drawing.Point(202, 120);
            this.ProductRate_textbox.Name = "ProductRate_textbox";
            this.ProductRate_textbox.Size = new System.Drawing.Size(150, 22);
            this.ProductRate_textbox.TabIndex = 28;
            // 
            // Search_button
            // 
            this.Search_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Search_button.Location = new System.Drawing.Point(621, 102);
            this.Search_button.Name = "Search_button";
            this.Search_button.Size = new System.Drawing.Size(107, 30);
            this.Search_button.TabIndex = 29;
            this.Search_button.Text = "Search";
            this.Search_button.UseVisualStyleBackColor = true;
            this.Search_button.Click += new System.EventHandler(this.Search_button_Click);
            // 
            // Select_button
            // 
            this.Select_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Select_button.Location = new System.Drawing.Point(449, 102);
            this.Select_button.Name = "Select_button";
            this.Select_button.Size = new System.Drawing.Size(107, 30);
            this.Select_button.TabIndex = 30;
            this.Select_button.Text = "Select";
            this.Select_button.UseVisualStyleBackColor = true;
            this.Select_button.Click += new System.EventHandler(this.Select_button_Click);
            // 
            // Search_Product
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 560);
            this.Controls.Add(this.Refresh_button);
            this.Controls.Add(this.Select_button);
            this.Controls.Add(this.Search_button);
            this.Controls.Add(this.ProductRate_textbox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.ProductQuantity_textbox);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.ProductName_textbox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ProductCode_textbox);
            this.Controls.Add(this.label1);
            this.Name = "Search_Product";
            this.Text = "Search_Product";
            this.Load += new System.EventHandler(this.Products_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ProductCode_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox ProductName_textbox;
        private System.Windows.Forms.DataGridViewTextBoxColumn Rate;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button Refresh_button;
        private System.Windows.Forms.TextBox ProductQuantity_textbox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox ProductRate_textbox;
        private System.Windows.Forms.Button Search_button;
        private System.Windows.Forms.Button Select_button;

    }
}