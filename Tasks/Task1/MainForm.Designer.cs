
namespace Task1
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.InputView = new System.Windows.Forms.DataGridView();
            this.InputLabel = new System.Windows.Forms.Label();
            this.XT = new System.Windows.Forms.TextBox();
            this.SizeLabel = new System.Windows.Forms.Label();
            this.XLabel = new System.Windows.Forms.Label();
            this.YT = new System.Windows.Forms.TextBox();
            this.OK = new System.Windows.Forms.Button();
            this.Solve = new System.Windows.Forms.Button();
            this.OutputView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.InputView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputView)).BeginInit();
            this.SuspendLayout();
            // 
            // InputView
            // 
            this.InputView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.InputView.Location = new System.Drawing.Point(12, 30);
            this.InputView.Name = "InputView";
            this.InputView.RowHeadersWidth = 51;
            this.InputView.RowTemplate.Height = 24;
            this.InputView.Size = new System.Drawing.Size(1355, 240);
            this.InputView.TabIndex = 0;
            this.InputView.CellValueChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.GridView1_CellValueChanged);
            // 
            // InputLabel
            // 
            this.InputLabel.AutoSize = true;
            this.InputLabel.Location = new System.Drawing.Point(13, 7);
            this.InputLabel.Name = "InputLabel";
            this.InputLabel.Size = new System.Drawing.Size(76, 17);
            this.InputLabel.TabIndex = 1;
            this.InputLabel.Text = "InputMatrix";
            // 
            // XT
            // 
            this.XT.Location = new System.Drawing.Point(1149, 4);
            this.XT.Name = "XT";
            this.XT.Size = new System.Drawing.Size(54, 22);
            this.XT.TabIndex = 2;
            this.XT.Text = "3";
            // 
            // SizeLabel
            // 
            this.SizeLabel.AutoSize = true;
            this.SizeLabel.Location = new System.Drawing.Point(1108, 7);
            this.SizeLabel.Name = "SizeLabel";
            this.SizeLabel.Size = new System.Drawing.Size(35, 17);
            this.SizeLabel.TabIndex = 3;
            this.SizeLabel.Text = "Size";
            // 
            // XLabel
            // 
            this.XLabel.AutoSize = true;
            this.XLabel.Location = new System.Drawing.Point(1209, 7);
            this.XLabel.Name = "XLabel";
            this.XLabel.Size = new System.Drawing.Size(17, 17);
            this.XLabel.TabIndex = 4;
            this.XLabel.Text = "X";
            // 
            // YT
            // 
            this.YT.Location = new System.Drawing.Point(1232, 4);
            this.YT.Name = "YT";
            this.YT.Size = new System.Drawing.Size(54, 22);
            this.YT.TabIndex = 5;
            this.YT.Text = "3";
            // 
            // OK
            // 
            this.OK.Location = new System.Drawing.Point(1292, 4);
            this.OK.Name = "OK";
            this.OK.Size = new System.Drawing.Size(75, 22);
            this.OK.TabIndex = 6;
            this.OK.Text = "OK";
            this.OK.UseVisualStyleBackColor = true;
            this.OK.Click += new System.EventHandler(this.OK_Click);
            // 
            // Solve
            // 
            this.Solve.Location = new System.Drawing.Point(12, 276);
            this.Solve.Name = "Solve";
            this.Solve.Size = new System.Drawing.Size(77, 23);
            this.Solve.TabIndex = 7;
            this.Solve.Text = "Solve";
            this.Solve.UseVisualStyleBackColor = true;
            this.Solve.Click += new System.EventHandler(this.Solve_Click);
            // 
            // OutputView
            // 
            this.OutputView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.OutputView.Location = new System.Drawing.Point(12, 305);
            this.OutputView.Name = "OutputView";
            this.OutputView.RowHeadersWidth = 51;
            this.OutputView.RowTemplate.Height = 24;
            this.OutputView.Size = new System.Drawing.Size(1355, 240);
            this.OutputView.TabIndex = 8;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1379, 581);
            this.Controls.Add(this.OutputView);
            this.Controls.Add(this.Solve);
            this.Controls.Add(this.OK);
            this.Controls.Add(this.YT);
            this.Controls.Add(this.XLabel);
            this.Controls.Add(this.SizeLabel);
            this.Controls.Add(this.XT);
            this.Controls.Add(this.InputLabel);
            this.Controls.Add(this.InputView);
            this.MaximumSize = new System.Drawing.Size(1397, 628);
            this.MinimumSize = new System.Drawing.Size(1397, 628);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.InputView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.OutputView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView InputView;
        private System.Windows.Forms.Label InputLabel;
        private System.Windows.Forms.TextBox XT;
        private System.Windows.Forms.Label SizeLabel;
        private System.Windows.Forms.Label XLabel;
        private System.Windows.Forms.TextBox YT;
        private System.Windows.Forms.Button OK;
        private System.Windows.Forms.Button Solve;
        private System.Windows.Forms.DataGridView OutputView;
    }
}

