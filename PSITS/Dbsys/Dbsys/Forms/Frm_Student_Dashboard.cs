using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dbsys.Forms
{
    public partial class Frm_Student_Dashboard : Form
    {
        UserRepository userRepo;
        public Frm_Student_Dashboard()
        {
            InitializeComponent();
        }

        private void Frm_Student_Dashboard_Load(object sender, EventArgs e)
        {
            userRepo = new UserRepository();
            loadEvents();
            loadMisc();
        }

        private void loadEvents()
        {
            dgvEvents.DataSource = userRepo.ShowEvents();
        }

        private void loadMisc()
        {
            dgvMisc.DataSource = userRepo.ShowMisc();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            new Frm_Payment_Form_Student().Show();
        }

        private void payBtnMisc_Click(object sender, EventArgs e)
        {
            new Frm_Payment_Form_Student().Show();
        }

        
    }
}
