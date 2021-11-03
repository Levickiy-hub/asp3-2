using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace WCF
{
    [ServiceContract]
    public interface IMyService
    {
        [OperationContract]
        List<Models.Telephone> GetDict();
        [OperationContract]
        string GetAll();
        [OperationContract]
        string AddDict(string surname, int number);
        [OperationContract]
        string UpdDict(int id, string surname, int number);
        [OperationContract]
        string DelDict(int id);
    }
}
