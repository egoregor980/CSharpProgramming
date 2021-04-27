using System;
using System.Data;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Task2_ClassLibrary;

namespace Task2
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void SelectFolder_Click(object sender, EventArgs e)
        {
            if (this.FolderBrowserDialog.ShowDialog() == DialogResult.OK)
            {
                this.WorkingPath.Text = this.FolderBrowserDialog.SelectedPath;
                this.OutputT.Text = Path.Combine(this.WorkingPath.Text, "NameT");
                this.OutputN.Text = Path.Combine(this.WorkingPath.Text, "NameN");
                this.TestButton.Enabled = true;
            }
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            var rnd = new Random();
            using (var fileT = new StreamWriter(this.OutputT.Text, false))
            {
                using (var fileN = new StreamWriter(this.OutputN.Text, false))
                {
                    foreach (var fe in Enumerable.Range(0, 1000))
                    {
                        var Text = string.Join("", Enumerable.Range(1, 60).Select(x => rnd.Next(68, 82)).Select(x => (char)x));
                        var Number = rnd.NextDouble() * 100;
                        fileT.WriteLine($"{Text}");
                        fileN.WriteLine($"{(int)Number}");
                    }
                }
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            var extractor = new Extractor()
            {
                OutputT = this.OutputT.Text,
                OutputN = this.OutputN.Text
            };
            extractor.Extract();
        }
    }
}
