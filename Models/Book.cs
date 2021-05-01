using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Project.Models
{
    public class Book
    {
        public int ID {get; set;}
        
        [MaxLength(60), Display(Name = "Titulo"), Required]
        public string Title {get; set;}

        [DataType(DataType.Date), Display(Name = "Fecha de lanzamiento")]
        public DateTime RelaseDate {get; set;}

        [DataType(DataType.Currency), Range(0.25, 100.00), Column(TypeName = "decimal(18,2)"), Display(Name = "Precio (Dolares)")]
        public decimal Price {get; set;}

        [MaxLength(40), Display(Name = "Genero")]
        public string Genre {get; set;}

        [MaxLength(40), Display(Name = "Tipo"), Required]
        public string Type {get; set;}
    }
}