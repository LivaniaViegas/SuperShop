﻿using System.ComponentModel.DataAnnotations;
using System.Xml.Linq;
using System;

namespace SuperShop.Data.Entities
{
    public class Product:IEntity
    {
        public int Id{ get; set; }

        [Required]
        [MaxLength(50, ErrorMessage = "The field {0} can contain {1} characters lenght.")]
        public string Name { get; set; }

        [DisplayFormat(DataFormatString = "{0:C2}", ApplyFormatInEditMode = false)]
        public decimal Price { get; set; }

        [Display(Name = "Image")]
        public string ImageUrl { get; set; }

        [Display(Name = "LastPurchase")]
        public DateTime? LastPurchase { get; set; }

        [Display(Name = "LastSale")]
        public DateTime? LastSale { get; set; }

        [Display(Name = "Is Available")]
        public bool IsAvailable { get; set; }

        [DisplayFormat(DataFormatString = "{0:N2}", ApplyFormatInEditMode = false)]
        public double Stock { get; set; }

        public User User { get; set; } //propriedade móvel, com relação de 1 para muitos, o user pode ter muit pro..

    }
}
