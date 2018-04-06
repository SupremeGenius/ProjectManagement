using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            //Change Language
            // System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("ar");
            // System.Threading.Thread.CurrentThread.CurrentUICulture = new System.Globalization.CultureInfo("ar");
        }

        private void bt_trainees_Click(object sender, EventArgs e)
        {
            ProjectManagement.Presentation.Trainees.TraineeManager traineeManager
                = new Presentation.Trainees.TraineeManager();
            traineeManager.Show(this);
        }
    }
}
