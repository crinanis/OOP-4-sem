using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    public interface Target
    {
        string Say();
    }
    public class Adapter : Target
    {
        private readonly Owner Own;
        public Adapter(Owner own)
        {
            this.Own = own;
        }
        public string Say()
        {
            return $"{this.Own.Say()}";
        }
    }
}
