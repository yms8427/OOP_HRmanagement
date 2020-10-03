using BilgeAdam.HR.Common.Enums;
using BilgeAdam.HR.Common.Models;
using System;
using System.Windows.Forms;

namespace BilgeAdam.HR
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var intern1 = new Intern("Buse", "Kara") { LastWorkingDate = DateTime.Now.AddDays(21) };
            var intern2 = new Intern("Simge", "Demircioğlu") { LastWorkingDate = DateTime.Now.AddDays(21) };

            var ma1 = new Manager("Sergen", "Kahraman") { Department = Department.Finance };
            var ma2 = new Manager("Laden", "Akgök") { Department = Department.HR };

            var em1 = new Employee("Hami", "Aktaş");
            em1.SetManager(ma1);
            var em2 = new Employee("Halil", "Bozkurt");
            var em3 = new Employee("Kerem", "Coşkun");
            var em4 = new Employee("Dilara", "İşcanoğlu");
            var em5 = new Employee("Elif", "Yücel");

            if (!string.IsNullOrEmpty(em5.LastName))
            {

            }

            ma1.SetEmployees(em2, em4);
            ma2.SetEmployees(em3, em5);

            listBox1.Items.Add(intern1);
            listBox1.Items.Add(intern2);
            listBox1.Items.Add(ma1);
            listBox1.Items.Add(ma2);
            listBox1.Items.Add(em1);
            listBox1.Items.Add(em2);
            listBox1.Items.Add(em3);
            listBox1.Items.Add(em4);
            listBox1.Items.Add(em5);
        }
    }
}
