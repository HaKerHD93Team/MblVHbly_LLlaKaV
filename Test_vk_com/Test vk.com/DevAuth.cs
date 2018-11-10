using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Test_vk.com
{
    public partial class DevAuth : Form
    {
        public DevAuth()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (maskedTextBox1.Text == "admin")
            {
                if (maskedTextBox2.Text == "123123")
                {
                    DevPanel Panel = new DevPanel();
                    Panel.Show();
                    this.Close();
                }
            }
        }
    }
}
