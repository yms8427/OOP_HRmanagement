using BilgeAdam.HR.Common.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            var intern1 = new Intern("Buse", "Kara");
            var intern2 = new Intern("Simge", "Demircioğlu");
            var ma = new Manager("Sergen", "Kahraman");
            var em1 = new Employee("Hami", "Aktaş");
            em1.SetManager(ma);
            var em2 = new Employee("Halil", "Bozkurt");
            var em3 = new Employee("Kerem", "Coşkun");
            var em4 = new Employee("Dilara", "İşcanoğlu");
            var em5 = new Employee("Elif", "Yücel");
            ma.SetEmployees(em2, em3, em4, em5);
        }
    }
}
