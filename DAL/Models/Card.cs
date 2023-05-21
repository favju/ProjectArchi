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
        public float Quota { get; set; } = 0;
        public int UserId { get; set; }
        public User User { get; set; }
    }
}
