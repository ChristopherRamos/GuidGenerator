using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuidGenerator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuid_Click(object sender, EventArgs e)
        {
            string id = Guid.NewGuid().ToString();
            txtGuid.Clear();
            txtGuid.Text = id;

        }
    }
}
