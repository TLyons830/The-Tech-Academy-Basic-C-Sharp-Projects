using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TwentyOne
{
    public class _21Dealer : Dealer
    {
        private List<Card> _Hand = new List<Card>();
        public List<Card> Hand { get { return _Hand; } set { _Hand = value; } }
        public bool Stay { get; set; }
        public bool isBusted { get; set; }

    }
}
