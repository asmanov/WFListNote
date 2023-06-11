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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void show_btn_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Remove(fname_tb);
            this.panel1.Controls.Remove(lname_tb);
            this.panel1.Controls.Remove(phone1_tb);
            this.panel1.Controls.Remove(phone2_tb);
            this.panel1.Controls.Add(show_panel);
            List<Phone> list = new List<Phone>();
            using(MyDbContex contex = new MyDbContex())
            {
                if (fname_tb.Text == "" && lname_tb.Text == "" && phone1_tb.Text == "" && phone2_tb.Text == "")
                {
                    foreach(var phone in contex.Phones)
                    {
                        UserControl1 userControl1 = new UserControl1(phone);
                        this.show_panel.Controls.Add(userControl1);
                    }
                }
                if ((fname_tb.Text != "" || lname_tb.Text != "") && (phone1_tb.Text == "" && phone2_tb.Text == ""))
                {
                    list = FindByName();
                    foreach (var phone in list)
                    {
                        UserControl1 userControl1 = new UserControl1(phone);
                        this.show_panel.Controls.Add(userControl1);
                    }
                }
                if ((fname_tb.Text == "" || lname_tb.Text == "") && (phone1_tb.Text != "" && phone2_tb.Text != ""))
                {
                    var phone = FindByPhone();
                    UserControl1 userControl1 = new UserControl1(phone);
                    this.show_panel.Controls.Add(userControl1);
                }
                this.panel1.Controls.Add(show_panel);
            }
            
        }

        private void find_btn_Click(object sender, EventArgs e)
        {
            this.panel1.Controls.Remove(this.show_panel);
            this.panel1.Controls.Add(this.fname_tb);
            this.panel1.Controls.Add(this.lname_tb);
            this.panel1.Controls.Add(this.phone1_tb);
            this.panel1.Controls.Add(this.phone2_tb);
        }
        private void add_btn_Click(object sender, EventArgs e)
        {
            using(MyDbContex context = new MyDbContex())
            {
                context.Phones.Add(new Phone() { FirstName = fname_tb.Text, LastName = lname_tb.Text, Phone1 = phone1_tb.Text, Phone2 = phone2_tb.Text });
                context.SaveChanges();
                fname_tb.Text = "";
                lname_tb.Text = "";
                phone1_tb.Text = "";
                phone2_tb.Text = "";
            }
        }

        private void del_btn_Click(object sender, EventArgs e)
        {
            using (MyDbContex contex = new MyDbContex())
            {
                if (lname_tb.Text == "")
                {
                    contex.Phones.Remove(contex.Phones.First(x => x.FirstName.Equals(fname_tb.Text))); 
                }
                else if (fname_tb.Text == "")
                {
                    contex.Phones.Remove(contex.Phones.First(x => x.LastName.Equals(lname_tb.Text)));
                }
                else if (fname_tb.Text != "" || lname_tb.Text != ""){
                    contex.Phones.Remove(contex.Phones.First(x => x.FirstName.Equals(fname_tb.Text) && x.LastName.Equals(lname_tb.Text)));
                }
                contex.SaveChanges();
            }
            fname_tb.Text = "";
            lname_tb.Text = "";
            phone1_tb.Text = "";
            phone2_tb.Text = "";
        }
        private Phone FindByPhone()
        {
            using(MyDbContex contex = new MyDbContex())
            {
                Phone phone = new Phone();
                phone = contex.Phones.First(x => (x.Phone1 == phone1_tb.Text || x.Phone1 == phone2_tb.Text) || (x.Phone2 == phone1_tb.Text || x.Phone2 == phone2_tb.Text));
                return phone;
            }
        }
        private List<Phone> FindByName()
        {
            using(MyDbContex contex = new MyDbContex())
            {
                List<Phone> list = new List<Phone>();
                if ((fname_tb.Text != ""/* || fname_tb.Text != " "*/) && (lname_tb.Text == ""/* || lname_tb.Text == " "*/))
                {
                    list = contex.Phones.Where(x => x.FirstName == fname_tb.Text).ToList();
                }
                if ((lname_tb.Text != ""/* || lname_tb.Text != " "*/) && (fname_tb.Text == ""/* || fname_tb.Text == " "*/))
                {
                    list = contex.Phones.Where(x => x.LastName == lname_tb.Text).ToList();
                }
                if ((fname_tb.Text != "") && (lname_tb.Text != ""))
                {
                    list = contex.Phones.Where(x => x.LastName == lname_tb.Text && x.FirstName == fname_tb.Text).ToList();
                }
                return list;
            }
            

        }
    }
}
