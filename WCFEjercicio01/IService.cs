using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WCFEjercicio01.Model;

namespace WCFEjercicio01
{
    [ServiceContract]
    public interface IService
    {
        [OperationContract]
        Person getByDNI(string dni);
        [OperationContract]
        Person updateByDNI(Person p);
    }
}
