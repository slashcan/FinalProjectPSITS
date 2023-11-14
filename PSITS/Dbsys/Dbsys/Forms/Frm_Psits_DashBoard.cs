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
    public partial class Frm_Psits_DashBoard : Form
    {
        public Frm_Psits_DashBoard()
        {
            InitializeComponent();
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void eventToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_Add_Event().Show();
        }

        private void miscToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_Add_Misc().Show();
        }

        private void checkStudentStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
          
        }

        private void createNewToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void studentStatusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new Frm_Student_Status().Show();
        }
    }
}
