using ProjectManagement.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.DAL
{
    public class ProjectManagerDataObject
    {
        public List<Trainee> trainees;
        public List<Project> projects;
        public List<TaskProject> tasks;
    }
}
