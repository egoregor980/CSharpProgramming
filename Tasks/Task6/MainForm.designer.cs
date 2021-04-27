
namespace Task6
{
    partial class MainForm
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BooksType = new System.Windows.Forms.TextBox();
            this.BooksCount = new System.Windows.Forms.TextBox();
            this.NameField = new System.Windows.Forms.TextBox();
            this.SizeField = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Capacity = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.Bricks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.Bricks)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 329);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "BooksType";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 357);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "BooksCount";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 387);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name";
            // 
            // BooksType
            // 
            this.BooksType.Location = new System.Drawing.Point(99, 326);
            this.BooksType.Name = "BooksType";
            this.BooksType.Size = new System.Drawing.Size(650, 22);
            this.BooksType.TabIndex = 3;
            // 
            // BooksCount
            // 
            this.BooksCount.Location = new System.Drawing.Point(99, 354);
            this.BooksCount.Name = "BooksCount";
            this.BooksCount.Size = new System.Drawing.Size(650, 22);
            this.BooksCount.TabIndex = 4;
            // 
            // NameField
            // 
            this.NameField.Location = new System.Drawing.Point(99, 384);
            this.NameField.Name = "NameField";
            this.NameField.Size = new System.Drawing.Size(650, 22);
            this.NameField.TabIndex = 5;
            // 
            // SizeField
            // 
            this.SizeField.Location = new System.Drawing.Point(99, 412);
            this.SizeField.Name = "SizeField";
            this.SizeField.Size = new System.Drawing.Size(650, 22);
            this.SizeField.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 415);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Size";
            // 
            // Capacity
            // 
            this.Capacity.Location = new System.Drawing.Point(99, 440);
            this.Capacity.Name = "Capacity";
            this.Capacity.Size = new System.Drawing.Size(650, 22);
            this.Capacity.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "Capacity";
            // 
            // addBtn
            // 
            this.addBtn.Location = new System.Drawing.Point(674, 468);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(75, 23);
            this.addBtn.TabIndex = 13;
            this.addBtn.Text = "Add";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // Bricks
            // 
            this.Bricks.AllowUserToAddRows = false;
            this.Bricks.BackgroundColor = System.Drawing.Color.Silver;
            this.Bricks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Bricks.GridColor = System.Drawing.Color.Honeydew;
            this.Bricks.Location = new System.Drawing.Point(12, 12);
            this.Bricks.Name = "Bricks";
            this.Bricks.ReadOnly = true;
            this.Bricks.RowHeadersWidth = 51;
            this.Bricks.RowTemplate.Height = 24;
            this.Bricks.Size = new System.Drawing.Size(737, 301);
            this.Bricks.TabIndex = 14;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(759, 502);
            this.Controls.Add(this.Bricks);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.Capacity);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SizeField);
            this.Controls.Add(this.NameField);
            this.Controls.Add(this.BooksCount);
            this.Controls.Add(this.BooksType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.ForeColor = System.Drawing.Color.Purple;
            this.MaximumSize = new System.Drawing.Size(777, 549);
            this.MinimumSize = new System.Drawing.Size(777, 549);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.Bricks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox BooksType;
        private System.Windows.Forms.TextBox BooksCount;
        private System.Windows.Forms.TextBox NameField;
        private System.Windows.Forms.TextBox SizeField;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox Capacity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.DataGridView Bricks;
    }
}