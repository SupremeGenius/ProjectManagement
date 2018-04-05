using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Entities
{
    public class Trainee : BaseEntity
    {
        // Fr:Etat Civil
        public string FirstName { set; get; }
        public string LastName { set; get; }

        // Fr:Coordonnée
        public string Email { set; get; }
        public string PhoneNumber { set; get; }

        public Group group { set; get; }


    }
}
