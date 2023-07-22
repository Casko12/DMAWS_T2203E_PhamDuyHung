using System.ComponentModel.DataAnnotations;

namespace DMAWS_T2203E_PhamDuyHung.Models
{ 
    public class ProjectEmployee
    {
        [Key]
        public int EmployeeId
        {
            get;
            set;
        }
        public int ProjectId
        {
            get;
            set;
        }
        [Required]
        public string Tasks
        {
            get;
            set;
        }
        
        public virtual Employee Employees
        {
            get;
            set;
        }
        public virtual Project Projects
        {
            get;
            set;
        }
    }
}

