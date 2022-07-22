using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entites
{
    public class info
    {
        [Key]
        public int gameinfoid  { get; set; }
        [StringLength(50)]
        public string gamecategory{ get; set; }

        public int price { get; set; }
        public virtual Game Oyunlar{ get; set; }


    }
}
