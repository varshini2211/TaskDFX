﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DolphinFx.Models
{
    public class Team
    {
        [Key]
        public int TeamID { get; set; } // Primary Key

        [Required(ErrorMessage = "Team Name is required.")]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z0-9\s]*$", ErrorMessage = "TeamName must start with a letter and contain only letters, numbers, and spaces.")]
        [StringLength(20, ErrorMessage = "TeamName should not contain more than 20 characters.")]
        public string? TeamName { get; set; } = string.Empty;

        [Required(ErrorMessage = "Team Description is required.")]
        [RegularExpression(@"^[a-zA-Z][a-zA-Z0-9\s]*$", ErrorMessage = "TeamDescription must start with a letter and contain only letters, numbers, and spaces.")]
        [StringLength(50, ErrorMessage = "TeamDescription should not contain more than 50 characters.")]
        public string? TeamDescription { get; set; } = string.Empty;

        [Required]
        [ForeignKey("Client")]
        public int ClientID { get; set; } // Foreign Key to client

        public virtual Client? Client { get; set; } // Navigation property
    }
}
