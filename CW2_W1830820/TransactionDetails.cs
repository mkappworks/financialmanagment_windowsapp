using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CW2_W1830820
{
    public class TransactionDetails
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public string Type { get; set; }
        public int ContactId { get; set; }
        public string ContactName { get; set; }
        public double Amount { get; set; }

    }
}
