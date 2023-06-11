using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WFListNote
{
    public partial class UserControl1 : UserControl
    {
        public UserControl1()
        {
            InitializeComponent();
        }
        public UserControl1(string f, string l, string p1, string p2) : this()
        {
            this.textBox1.Text = f;
            this.textBox1.ReadOnly = true;
            this.textBox2.Text = l;
            this.textBox2.ReadOnly = true;
            this.textBox3.Text = p1;
            this.textBox3.ReadOnly = true;
            this.textBox4.Text = p2;
            this.textBox4.ReadOnly = true;
        }
        public UserControl1(Phone phone) : this()
        {
            this.textBox1.Text = phone.FirstName;
            this.textBox1.ReadOnly = true;
            this.textBox2.Text = phone.LastName;
            this.textBox2.ReadOnly = true;
            this.textBox3.Text = phone.Phone1;
            this.textBox3.ReadOnly = true;
            this.textBox4.Text = phone.Phone2;
            this.textBox4.ReadOnly = true;
        }
    }
}
