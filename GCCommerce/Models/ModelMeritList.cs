﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace GCCommerce.Models
{
    public class ModelMeritList
    {
        [Key]
        public int MeritListId { get; set; }

        public int FkProgramId { get; set; }
         [Required(ErrorMessage = "Select Shift")]
        public string Shift { get; set; }

        [Required (ErrorMessage ="Enter MeritList Value")]
        [Display(Name ="Merit List Value")]
        public string MeritListValue { get; set; }
        public DateTime? DateCreated { get; set; }
        public DateTime? DateUpdated { get; set; }

        public ModelProgram FkProgram { get; set; }
    }
}
