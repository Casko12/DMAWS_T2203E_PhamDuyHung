using System.ComponentModel.DataAnnotations;

namespace DMAWS_T2203E_PhamDuyHung.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId
        {
            get;
            set;
        }
        public string EmployeeName
        {
            get;
            set;
        }
        public DateTime EmployeeDOB
        {
            get;
            set;
        }
        public string EmployeeDepartment
        {
            get;
            set;
        }
        public virtual ICollection<ProjectEmployee> ProjectEmployees
        {
            get;
            set;
        }
    }
}

