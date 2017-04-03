using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TechJobs.Models;

namespace TechJobs.ViewModels
{
    public class BaseViewModel
    {
        // The current column, initialized to All
        public JobFieldType Column { get; set; } = JobFieldType.All;

        // All columns, for display
        public List<JobFieldType> Columns { get; set; }

        //View Title
        public string Title { get; set; } = "";

        public void populateColumns()
        {
            Columns = new List<JobFieldType>();

            foreach (JobFieldType enumVal in Enum.GetValues(typeof(JobFieldType)))
            {
                Columns.Add(enumVal);
            }
        }
    }
}
