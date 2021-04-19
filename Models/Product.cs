using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace MyFirstService.Models
{
    public class Product
    {

        public int Id { get; set; }
        [Required]
        [MaxLength(20)]
        
        public string Maker { get; set; }

        [JsonPropertyName("img")]
        [MaxLength(150)]
        public string Image { get; set; }
        [Required]
        [MaxLength(100)]
        public string Url { get; set; }
        [Required]
        [MaxLength(60)]
        [Column(TypeName = "varchar(60)")]
        public string Title { get; set; }
        [MaxLength(200)]
        [Column(TypeName = "varchar(200)")]
        public string Description { get; set; }
        

        public override string ToString() => JsonSerializer.Serialize<Product>(this);

    }
}
