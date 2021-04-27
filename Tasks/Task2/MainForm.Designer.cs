
namespace Task2
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
            this.WorkingPath = new System.Windows.Forms.TextBox();
            this.SelectFolder = new System.Windows.Forms.Button();
            this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
            this.OutputLabelS = new System.Windows.Forms.Label();
            this.OutputT = new System.Windows.Forms.TextBox();
            this.Start = new System.Windows.Forms.Button();
            this.TestButton = new System.Windows.Forms.Button();
            this.OutputLabelR = new System.Windows.Forms.Label();
            this.OutputN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // WorkingPath
            // 
            this.WorkingPath.Enabled = false;
            this.WorkingPath.Location = new System.Drawing.Point(126, 13);
            this.WorkingPath.Name = "WorkingPath";
            this.WorkingPath.Size = new System.Drawing.Size(884, 22);
            this.WorkingPath.TabIndex = 0;
            // 
            // SelectFolder
            // 
            this.SelectFolder.Location = new System.Drawing.Point(12, 12);
            this.SelectFolder.Name = "SelectFolder";
            this.SelectFolder.Size = new System.Drawing.Size(108, 23);
            this.SelectFolder.TabIndex = 1;
            this.SelectFolder.Text = "Select Folder";
            this.SelectFolder.UseVisualStyleBackColor = true;
            this.SelectFolder.Click += new System.EventHandler(this.SelectFolder_Click);
            // 
            // OutputLabelS
            // 
            this.OutputLabelS.AutoSize = true;
            this.OutputLabelS.Location = new System.Drawing.Point(56, 93);
            this.OutputLabelS.Name = "OutputLabelS";
            this.OutputLabelS.Size = new System.Drawing.Size(64, 17);
            this.OutputLabelS.TabIndex = 3;
            this.OutputLabelS.Text = "OutputT:";
            // 
            // OutputT
            // 
            this.OutputT.Enabled = false;
            this.OutputT.Location = new System.Drawing.Point(126, 88);
            this.OutputT.Name = "OutputT";
            this.OutputT.Size = new System.Drawing.Size(884, 22);
            this.OutputT.TabIndex = 5;
            // 
            // Start
            // 
            this.Start.Location = new System.Drawing.Point(12, 162);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(108, 43);
            this.Start.TabIndex = 6;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // TestButton
            // 
            this.TestButton.Enabled = false;
            this.TestButton.Location = new System.Drawing.Point(850, 182);
            this.TestButton.Name = "TestButton";
            this.TestButton.Size = new System.Drawing.Size(160, 23);
            this.TestButton.TabIndex = 7;
            this.TestButton.Text = "Generate Test Data";
            this.TestButton.UseVisualStyleBackColor = true;
            this.TestButton.Click += new System.EventHandler(this.TestButton_Click);
            // 
            // OutputLabelR
            // 
            this.OutputLabelR.AutoSize = true;
            this.OutputLabelR.Location = new System.Drawing.Point(55, 127);
            this.OutputLabelR.Name = "OutputLabelR";
            this.OutputLabelR.Size = new System.Drawing.Size(65, 17);
            this.OutputLabelR.TabIndex = 8;
            this.OutputLabelR.Text = "OutputN:";
            // 
            // OutputN
            // 
            this.OutputN.Enabled = false;
            this.OutputN.Location = new System.Drawing.Point(126, 122);
            this.OutputN.Name = "OutputN";
            this.OutputN.Size = new System.Drawing.Size(884, 22);
            this.OutputN.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1022, 217);
            this.Controls.Add(this.OutputN);
            this.Controls.Add(this.OutputLabelR);
            this.Controls.Add(this.TestButton);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.OutputT);
            this.Controls.Add(this.OutputLabelS);
            this.Controls.Add(this.SelectFolder);
            this.Controls.Add(this.WorkingPath);
            this.MaximumSize = new System.Drawing.Size(1040, 264);
            this.MinimumSize = new System.Drawing.Size(1040, 264);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox WorkingPath;
        private System.Windows.Forms.Button SelectFolder;
        private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
        private System.Windows.Forms.Label OutputLabelS;
        private System.Windows.Forms.TextBox OutputT;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button TestButton;
        private System.Windows.Forms.Label OutputLabelR;
        private System.Windows.Forms.TextBox OutputN;
    }
}

