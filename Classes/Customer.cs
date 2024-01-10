using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    internal class Customer //Class içindeki property bölümü, aşağıdaki id,firstname vs. property'dir.
    {

        //Property / Genel Kullanım
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public string City { get; set; }

        //Encapsulation / Eski Kullanım
        //public string _FirstName;
        //public string FirstName
        //{
        //    get { return Id == 1 ? "Mr." + _FirstName : "Mrs." + _FirstName; } 
        //    set { _FirstName = value; }
        //}

    }
}
