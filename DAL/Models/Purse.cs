using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Purse
    {
        public int PurseId { get; set; }
        public string PurseName { get; set;}
        public int Amount { get; set; }

        public int CardId { get; set; }
        public Card Card { get; set; }
    }
}
