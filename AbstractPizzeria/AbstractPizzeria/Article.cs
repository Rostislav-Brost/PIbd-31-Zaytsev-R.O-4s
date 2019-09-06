using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AbstractPizzeria
{
    public class Article
    {
        public int Id { get; set; }

        [Required]
        public string ArticleName { get; set; }

        [Required]
        public decimal Price { get; set; }

        [ForeignKey("ArticleId")]
        public virtual List<Request> Requests { get; set; }

        [ForeignKey("ArticleId")]
        public virtual List<ArticleIngridient> ArticleIngridients { get; set; }
    }
}
