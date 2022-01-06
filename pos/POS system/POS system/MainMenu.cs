using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS_system
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void label4_Click(object sender, EventArgs e)
        {
            AddSupplier Obj = new AddSupplier();
            Obj.Show();
            Obj.TopMost= true;
        }

        private void label1_Click(object sender, EventArgs e)
        {
            AddProduct Obj = new AddProduct();
            Obj.Show();
            Obj.TopMost = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {
            ViewProducts Obj = new ViewProducts();
            Obj.Show();
            Obj.TopMost = true;
        }
    }
}
