using PersonelManagerLibrary;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PersonelWcfService
{
    
    [ServiceContract]
    public interface IPersonelService
    {

        [OperationContract]
        bool Add(Personel personel);

        [OperationContract]
        bool Delete(int id);

        [OperationContract]
        bool Update(Personel personel);

        [OperationContract]
        Personel GetById(int id);

        [OperationContract]
        DataTable GetAll();


        
    }


    
   
}
