
namespace EFCoreHomework5_1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.textBoxCategories = new System.Windows.Forms.TextBox();
            this.BtnDelCategories = new System.Windows.Forms.Button();
            this.BtnUpdCategories = new System.Windows.Forms.Button();
            this.BtnAddCategories = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBoxProducts = new System.Windows.Forms.TextBox();
            this.BtnDelProducts = new System.Windows.Forms.Button();
            this.BtnUpdProducts = new System.Windows.Forms.Button();
            this.BtnAddProducts = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.textBoxWords = new System.Windows.Forms.TextBox();
            this.BtnDelWords = new System.Windows.Forms.Button();
            this.BtnUpdWords = new System.Windows.Forms.Button();
            this.BtnAddWords = new System.Windows.Forms.Button();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.btnRestoreDB = new System.Windows.Forms.Button();
            this.btnCreateBackUp = new System.Windows.Forms.Button();
            this.dataGridView4 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(9, 8);
            this.tabControl1.Margin = new System.Windows.Forms.Padding(2);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1096, 516);
            this.tabControl1.TabIndex = 0;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.tabControl1_SelectedIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.textBoxCategories);
            this.tabPage1.Controls.Add(this.BtnDelCategories);
            this.tabPage1.Controls.Add(this.BtnUpdCategories);
            this.tabPage1.Controls.Add(this.BtnAddCategories);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage1.Size = new System.Drawing.Size(1088, 488);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Categories";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // textBoxCategories
            // 
            this.textBoxCategories.Location = new System.Drawing.Point(5, 108);
            this.textBoxCategories.Name = "textBoxCategories";
            this.textBoxCategories.Size = new System.Drawing.Size(220, 23);
            this.textBoxCategories.TabIndex = 4;
            // 
            // BtnDelCategories
            // 
            this.BtnDelCategories.Location = new System.Drawing.Point(582, 22);
            this.BtnDelCategories.Name = "BtnDelCategories";
            this.BtnDelCategories.Size = new System.Drawing.Size(143, 23);
            this.BtnDelCategories.TabIndex = 3;
            this.BtnDelCategories.Text = "Delete";
            this.BtnDelCategories.UseVisualStyleBackColor = true;
            this.BtnDelCategories.Click += new System.EventHandler(this.BtnDelCategories_Click);
            // 
            // BtnUpdCategories
            // 
            this.BtnUpdCategories.Location = new System.Drawing.Point(398, 23);
            this.BtnUpdCategories.Name = "BtnUpdCategories";
            this.BtnUpdCategories.Size = new System.Drawing.Size(155, 23);
            this.BtnUpdCategories.TabIndex = 2;
            this.BtnUpdCategories.Text = "Update";
            this.BtnUpdCategories.UseVisualStyleBackColor = true;
            this.BtnUpdCategories.Click += new System.EventHandler(this.BtnUpdCategories_Click);
            // 
            // BtnAddCategories
            // 
            this.BtnAddCategories.Location = new System.Drawing.Point(230, 23);
            this.BtnAddCategories.Name = "BtnAddCategories";
            this.BtnAddCategories.Size = new System.Drawing.Size(139, 23);
            this.BtnAddCategories.TabIndex = 1;
            this.BtnAddCategories.Text = "Add";
            this.BtnAddCategories.UseVisualStyleBackColor = true;
            this.BtnAddCategories.Click += new System.EventHandler(this.BtnAddCategories_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(230, 69);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 62;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(854, 392);
            this.dataGridView1.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.textBoxProducts);
            this.tabPage2.Controls.Add(this.BtnDelProducts);
            this.tabPage2.Controls.Add(this.BtnUpdProducts);
            this.tabPage2.Controls.Add(this.BtnAddProducts);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(2);
            this.tabPage2.Size = new System.Drawing.Size(1088, 488);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Products";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // textBoxProducts
            // 
            this.textBoxProducts.Location = new System.Drawing.Point(5, 82);
            this.textBoxProducts.Name = "textBoxProducts";
            this.textBoxProducts.Size = new System.Drawing.Size(274, 23);
            this.textBoxProducts.TabIndex = 7;
            // 
            // BtnDelProducts
            // 
            this.BtnDelProducts.Location = new System.Drawing.Point(636, 24);
            this.BtnDelProducts.Name = "BtnDelProducts";
            this.BtnDelProducts.Size = new System.Drawing.Size(143, 23);
            this.BtnDelProducts.TabIndex = 6;
            this.BtnDelProducts.Text = "Delete";
            this.BtnDelProducts.UseVisualStyleBackColor = true;
            this.BtnDelProducts.Click += new System.EventHandler(this.BtnDelProducts_Click);
            // 
            // BtnUpdProducts
            // 
            this.BtnUpdProducts.Location = new System.Drawing.Point(452, 25);
            this.BtnUpdProducts.Name = "BtnUpdProducts";
            this.BtnUpdProducts.Size = new System.Drawing.Size(155, 23);
            this.BtnUpdProducts.TabIndex = 5;
            this.BtnUpdProducts.Text = "Update";
            this.BtnUpdProducts.UseVisualStyleBackColor = true;
            this.BtnUpdProducts.Click += new System.EventHandler(this.BtnUpdProducts_Click);
            // 
            // BtnAddProducts
            // 
            this.BtnAddProducts.Location = new System.Drawing.Point(284, 25);
            this.BtnAddProducts.Name = "BtnAddProducts";
            this.BtnAddProducts.Size = new System.Drawing.Size(139, 23);
            this.BtnAddProducts.TabIndex = 4;
            this.BtnAddProducts.Text = "Add";
            this.BtnAddProducts.UseVisualStyleBackColor = true;
            this.BtnAddProducts.Click += new System.EventHandler(this.BtnAddProducts_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(284, 82);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 62;
            this.dataGridView2.RowTemplate.Height = 33;
            this.dataGridView2.Size = new System.Drawing.Size(800, 424);
            this.dataGridView2.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.textBoxWords);
            this.tabPage3.Controls.Add(this.BtnDelWords);
            this.tabPage3.Controls.Add(this.BtnUpdWords);
            this.tabPage3.Controls.Add(this.BtnAddWords);
            this.tabPage3.Controls.Add(this.dataGridView3);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(2);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1088, 488);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Words";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // textBoxWords
            // 
            this.textBoxWords.Location = new System.Drawing.Point(3, 83);
            this.textBoxWords.Name = "textBoxWords";
            this.textBoxWords.Size = new System.Drawing.Size(250, 23);
            this.textBoxWords.TabIndex = 10;
            // 
            // BtnDelWords
            // 
            this.BtnDelWords.Location = new System.Drawing.Point(610, 27);
            this.BtnDelWords.Name = "BtnDelWords";
            this.BtnDelWords.Size = new System.Drawing.Size(143, 23);
            this.BtnDelWords.TabIndex = 9;
            this.BtnDelWords.Text = "Delete";
            this.BtnDelWords.UseVisualStyleBackColor = true;
            this.BtnDelWords.Click += new System.EventHandler(this.BtnDelWords_Click);
            // 
            // BtnUpdWords
            // 
            this.BtnUpdWords.Location = new System.Drawing.Point(426, 28);
            this.BtnUpdWords.Name = "BtnUpdWords";
            this.BtnUpdWords.Size = new System.Drawing.Size(155, 23);
            this.BtnUpdWords.TabIndex = 8;
            this.BtnUpdWords.Text = "Update";
            this.BtnUpdWords.UseVisualStyleBackColor = true;
            this.BtnUpdWords.Click += new System.EventHandler(this.BtnUpdWords_Click);
            // 
            // BtnAddWords
            // 
            this.BtnAddWords.Location = new System.Drawing.Point(258, 28);
            this.BtnAddWords.Name = "BtnAddWords";
            this.BtnAddWords.Size = new System.Drawing.Size(139, 23);
            this.BtnAddWords.TabIndex = 7;
            this.BtnAddWords.Text = "Add";
            this.BtnAddWords.UseVisualStyleBackColor = true;
            this.BtnAddWords.Click += new System.EventHandler(this.BtnAddWords_Click);
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(258, 83);
            this.dataGridView3.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.RowHeadersWidth = 62;
            this.dataGridView3.RowTemplate.Height = 33;
            this.dataGridView3.Size = new System.Drawing.Size(828, 425);
            this.dataGridView3.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.btnRestoreDB);
            this.tabPage4.Controls.Add(this.btnCreateBackUp);
            this.tabPage4.Controls.Add(this.dataGridView4);
            this.tabPage4.Controls.Add(this.textBox1);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1088, 488);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Backup DataBases";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // btnRestoreDB
            // 
            this.btnRestoreDB.Location = new System.Drawing.Point(317, 90);
            this.btnRestoreDB.Name = "btnRestoreDB";
            this.btnRestoreDB.Size = new System.Drawing.Size(150, 23);
            this.btnRestoreDB.TabIndex = 4;
            this.btnRestoreDB.Text = "Restore DB";
            this.btnRestoreDB.UseVisualStyleBackColor = true;
            this.btnRestoreDB.Click += new System.EventHandler(this.btnRestoreDB_Click);
            // 
            // btnCreateBackUp
            // 
            this.btnCreateBackUp.Location = new System.Drawing.Point(21, 90);
            this.btnCreateBackUp.Name = "btnCreateBackUp";
            this.btnCreateBackUp.Size = new System.Drawing.Size(150, 23);
            this.btnCreateBackUp.TabIndex = 3;
            this.btnCreateBackUp.Text = "Create backup DB";
            this.btnCreateBackUp.UseVisualStyleBackColor = true;
            this.btnCreateBackUp.Click += new System.EventHandler(this.btnCreateBackUp_Click);
            // 
            // dataGridView4
            // 
            this.dataGridView4.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView4.Location = new System.Drawing.Point(21, 131);
            this.dataGridView4.Name = "dataGridView4";
            this.dataGridView4.RowTemplate.Height = 25;
            this.dataGridView4.Size = new System.Drawing.Size(1064, 289);
            this.dataGridView4.TabIndex = 2;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(155, 35);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(930, 23);
            this.textBox1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(21, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(128, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Select folder";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1157, 605);
            this.Controls.Add(this.tabControl1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.tabPage4.ResumeLayout(false);
            this.tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.TextBox textBoxCategories;
        private System.Windows.Forms.Button BtnDelCategories;
        private System.Windows.Forms.Button BtnUpdCategories;
        private System.Windows.Forms.Button BtnAddCategories;
        private System.Windows.Forms.Button BtnDelProducts;
        private System.Windows.Forms.Button BtnUpdProducts;
        private System.Windows.Forms.Button BtnAddProducts;
        private System.Windows.Forms.TextBox textBoxProducts;
        private System.Windows.Forms.TextBox textBoxWords;
        private System.Windows.Forms.Button BtnDelWords;
        private System.Windows.Forms.Button BtnUpdWords;
        private System.Windows.Forms.Button BtnAddWords;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnRestoreDB;
        private System.Windows.Forms.Button btnCreateBackUp;
        private System.Windows.Forms.DataGridView dataGridView4;
    }
}

