using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [MinLength(3, ErrorMessage = "جداقل طول این فیلد ۳ کاراکتر است")]
        [MaxLength(100, ErrorMessage = "حداکثر طول این فیلد ۱۰۰ کاراکتر است")]
        public string Name { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        [EmailAddress(ErrorMessage = "ایمیل را صحیح وارد نمایید")]
        public string Email { get; set; }

        public string Message { get; set; }
        public int Service { get; set; }

        public SelectList Services { get; set; }
    }
}