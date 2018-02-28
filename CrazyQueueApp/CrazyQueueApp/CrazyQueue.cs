using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrazyQueueApp
{
    class CrazyQueue : IEnumerable
    {
        private List<Object> elements;
        private bool isCrazy;
        Random rand = new Random();



        public IEnumerator GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
