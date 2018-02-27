﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Models
{
    public class Register
    {
        [Required]
        public string FirstName     { get; set; }

        [Required]
        public string LastName      { get; set; }

        [Required]
        public string Email         { get; set; }

        [Required]
        [StringLength(15)]
        public string PhoneNumber   { get; set; }

        [Required]
        public string Password      { get; set; }

        public string Gender        { get; set; }
        public string Education     { get; set; }
    }
}