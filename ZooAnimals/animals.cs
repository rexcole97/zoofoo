using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data.ZooAnimals
{
    public class animals
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Aid { get; set; }
        public string Agenus { get; set; }
        public string Aspecies { get; set; }
        public int Alocation { get; set; }
    }
}
