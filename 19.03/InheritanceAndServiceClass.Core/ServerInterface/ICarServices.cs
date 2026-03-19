using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceAndServiceClass.Core.ServerInterface
{
    public interface ICarServices
    {
        void GetData();
        void PostData();
        void UpdateData();
        void DeleteData();
    }
}
