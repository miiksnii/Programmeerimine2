using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Properties.Data
{
    public class ProjectList
    {
        [Required]
        public int Id { get; set; } // Employee ID
        // IList to store a collection of Project objects
        public IList<Project> Projects { get; set; }

        // Constructor to initialize the list
        public ProjectList()
        {
            Projects = new List<Project>(); // Initializes the Projects list
        }
    }
}
