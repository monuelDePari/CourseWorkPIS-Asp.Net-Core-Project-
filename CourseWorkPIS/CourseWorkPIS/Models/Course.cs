﻿using Microsoft.AspNetCore.Authorization;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CourseWorkPIS.Models
{
    public class Course
    {
        public int Id { get; set; }
        public string Title { get; set; }
        [Display(Name = "Start Date")]
        [DataType(DataType.Date)]
        public DateTime StartDate { get; set; }
        [Display(Name = "Finish Date")]
        public string FinishDate { get; set; }
        public decimal Frequency { get; set; }
    }
}
