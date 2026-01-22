using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ViewInformation
{
    public interface IObject
    {
        List<DataItem> GetObjectItems();
        string GetObjectType();
    }

}
