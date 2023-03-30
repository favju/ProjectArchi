using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Models
{
    public class Card
    {
        public int CardId { get; set; }
        public Person Person { get; set; }

        public ICollection<Purse> Purses { get; set; }
    }
}
