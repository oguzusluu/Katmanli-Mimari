using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entity.Entites
{
    public class Game
    {
        [Key]

        public int gameid { get; set; }
        [StringLength(50)]
        public string gamename { get; set; }

        public ICollection<info> Bilgiler{ get; set; }



    }
}
