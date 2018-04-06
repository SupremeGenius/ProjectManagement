using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProjectManagement.Entities;

namespace ProjectManagement.Presentation.Trainees
{
    public partial class TraineeForm : UserControl
    {



        public Trainee TraineeValue {
            get
            {
                //// Solution 1 
                //Trainee trainee = new Trainee();
                //trainee.FirstName = this.firstNameTextBox.Text;
                //return trainee;

                // Solution 2 
                return this.traineeBindingSource.Current as Trainee ;



            }
            set
            {
                Trainee trainee = value as Trainee;

                //// Solution 1 
                //this.firstNameTextBox.Text = trainee.FirstName;

                // Solution 2
                if(trainee != null)
                this.traineeBindingSource.DataSource = trainee;




            }
        }

      

        public TraineeForm()
        {
            InitializeComponent();
        }

        public void AddNew()
        {
            Trainee trainee = new Trainee();
            this.traineeBindingSource.DataSource = trainee;
        }


        private void TraineeForm_Load(object sender, EventArgs e)
        {

        }

        private void emailLabel_Click(object sender, EventArgs e)
        {

        }

        private void emailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void phoneNumberLabel_Click(object sender, EventArgs e)
        {

        }

        private void codeLabel_Click(object sender, EventArgs e)
        {

        }

        private void codeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void updateDateLabel_Click(object sender, EventArgs e)
        {

        }

        private void createDateLabel1_Click(object sender, EventArgs e)
        {

        }

        private void createDateDateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void updateDateDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
