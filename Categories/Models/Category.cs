﻿using System.ComponentModel.DataAnnotations;

namespace Categories.Models
{
    public class Category
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public int DisplayOrder { get; set; }       
    }
}
