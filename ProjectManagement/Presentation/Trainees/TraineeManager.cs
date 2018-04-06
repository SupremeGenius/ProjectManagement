using ProjectManagement.BAL;
using ProjectManagement.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectManagement.Presentation.Trainees
{
    public partial class TraineeManager : Form
    {
        public TraineeManager()
        {
            InitializeComponent();
        }

        private void traineeForm1_Load(object sender, EventArgs e)
        {

        }

        private void bt_new_Click(object sender, EventArgs e)
        {
            traineeForm.AddNew();
        }

        private void bt_save_Click(object sender, EventArgs e)
        {

            Trainee trainee = traineeForm.TraineeValue;
            if(trainee == null)
            {
                MessageBox.Show(ResourceEntityManager.Please_click_New_before_saving);
            }
            else
            {
                if (new TraineeBLO().Save(trainee))
                {
                    this.RefreshData();
                }
            }


        }

        private void RefreshData()
        {
            this.traineeDataGrid1.DataSource = new TraineeBLO().GetList();
        }

        private void TraineeManager_Load(object sender, EventArgs e)
        {
          //  this.RefreshData();
        }
    }
}
