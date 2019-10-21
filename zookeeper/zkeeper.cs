using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Data.zookeeper
{
    public class zkeeper
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ZKid { get; set; }
        public string ZKfname { get; set; }
        public string ZKlname { get; set; }
        public string ZKteam { get; set; }
    }
}
