using PersonelManagerLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace PersonelWcfService
{
    
    public class PersonelService : IPersonelService
    {

        public bool Add(PersonelManagerLibrary.Personel personel)
        {
            PersonelManager personelManager = new PersonelManager();
            return personelManager.Ekle(personel);
        }


        public bool Delete(int id)
        {
            PersonelManager personelManager = new PersonelManager();
            return personelManager.Sil(id);
        }


        public bool Update(PersonelManagerLibrary.Personel personel)
        {
            PersonelManager personelManager = new PersonelManager();
            return personelManager.Guncelle(personel);
        }


        public PersonelManagerLibrary.Personel GetById(int id)
        {
            PersonelManager personelManager = new PersonelManager();
            return personelManager.GetirById(id);
        }


        public System.Data.DataTable GetAll()
        {
            PersonelManager personelManager = new PersonelManager();
            return personelManager.GetirHepsi();
        }
    }
}
