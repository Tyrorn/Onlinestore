using _17327291_Onlinestore.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _17327291_Onlinestore.ViewModels
{
    public class BasketViewModel
    {
        public List<BasketLine> BasketLines { get; set; }
        [Display(Name = "Basket Total")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal TotalCost { get; set; }
    }

}