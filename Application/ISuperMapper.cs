using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationBusiness
{
    public interface ISuperMapper<TInp1, TInp2, TOut>
    {
        public TOut Map(TInp1 inpunt1, TInp2 inpunt2);
    }
}
