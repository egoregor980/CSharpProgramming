using System;
using System.ComponentModel;
using System.Windows.Forms;
using Task6_ClassLibrary;

namespace Task6
{
    public partial class MainForm : Form
    {
        readonly IBindingList cabs = new BindingList<BookCabinet>();

        public MainForm()
        {
            InitializeComponent();
            Bricks.AutoGenerateColumns = true;
            Bricks.DataSource = cabs;
        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            var cab = new BookCabinet
            {
                BooksType = BooksType.Text,
                BooksCount = BooksCount.Text,
                Name = NameField.Text,
                Size = SizeField.Text,
                Capacity = Capacity.Text,
            };

            cabs.Add(cab);

            BooksType.Text = BooksCount.Text = NameField.Text = SizeField.Text = Capacity.Text = "";
        }
    }
}
