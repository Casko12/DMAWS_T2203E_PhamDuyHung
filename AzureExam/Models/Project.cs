using System.ComponentModel.DataAnnotations;

namespace DMAWS_T2203E_PhamDuyHung.Models
{
    public class Project
    {
        [Key]
        public int ProjectId
        {
            get;
            set;
        }
        public string ProjectName
        {
            get;
            set;
        }
        public DateTime ProjectStartDate
        {
            get;
            set;
        }
        public DateTime ProjectEndDate
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

