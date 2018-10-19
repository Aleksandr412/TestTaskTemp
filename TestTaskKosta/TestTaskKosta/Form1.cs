using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestTaskKosta
{
    public partial class Form1 : Form
    {
        List<Employee> employee = new List<Employee>();
        List<Department> dept = new List<Department>();
        DataTable dt = new DataTable();
        

        public Form1()
        {
            InitializeComponent();

            listBox1.DataSource = employee;
            listBox1.DisplayMember = "FullInfo";
        }

        

        private void button1_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            employee = db.GetEmployees(textBox1.Text);

            listBox1.DataSource = employee;
            listBox1.DisplayMember = "FullInfo";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataAccess db = new DataAccess();

            dept = db.GetOrgStructure();

            listBox1.DataSource = dept;
            listBox1.DisplayMember = "GetOrgStructure";


        }

        private void comboDepartmentSelect_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            string[] m = { };

            if (comboDepartmentSelect.Text == Name)
            {
                comboDepartmentSelect.Items.Clear();
                comboDepartmentSelect.Items.AddRange(m);
            }
        }
    }
}
