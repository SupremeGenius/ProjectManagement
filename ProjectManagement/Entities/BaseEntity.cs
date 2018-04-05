using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectManagement.Entities
{
    public class BaseEntity
    {
        public int Id { set; get; }
        public DateTime CreateDate { set; get; }
        public DateTime UpdateDate { set; get; }

    }
}
