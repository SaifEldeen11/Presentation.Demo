using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo.Data_Acess_Layer.Models
{
    // Base class for all entities common properties can be added here
    public class BaseEntity
    {
        public int Id { get; set; } // PK

        public int CreatedBy { get; set; } // User_Id

        public DateTime? CreatedOn { get; set; } // Date

        public int LastModifiedBy { get; set; } // User_Id

        public DateTime? LastModifiedOn { get; set; } // Date

        public bool IsDeleted { get; set; }

    }
}