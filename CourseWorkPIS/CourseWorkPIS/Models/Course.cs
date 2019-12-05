using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWorkPIS.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        public string FinishDate { get; set; }
        public decimal Frequency { get; set; }
    }
}
