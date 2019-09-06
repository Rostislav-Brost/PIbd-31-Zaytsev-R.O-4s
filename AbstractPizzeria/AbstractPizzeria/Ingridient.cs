﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbstractPizzeria
{
    public class Ingridient
    {
        public int Id { get; set; }

        [Required]
        public string IngridientName { get; set; }

        [ForeignKey("IngridientId")]
        public virtual List<ArticleIngridient> ArticleIngridients { get; set; }

        [ForeignKey("IngridientId")]
        public virtual List<ResourceIngridient> ResourceIngridients { get; set; }
    }
}
