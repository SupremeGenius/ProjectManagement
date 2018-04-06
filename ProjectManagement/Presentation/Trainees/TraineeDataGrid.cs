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
    public partial class TraineeDataGrid : UserControl
    {
        public TraineeDataGrid()
        {
            InitializeComponent();
        }

        public List<Trainee> DataSource {
            set
            {
                if(value != null)
               this.traineeBindingSource.DataSource = value;
            }
        }
    }
}
