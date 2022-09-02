﻿using System.ComponentModel.DataAnnotations;

namespace OnlineShop2.Areas.Admin.Models
{
    public class RoleUserVm
    {
        [Required]
        [Display(Name ="User")]
        public string UserId { get; set; }

        [Required]
        [Display(Name ="Role")]
        public string RoleId { get; set; }
    }
}
