using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TelefonRehberUygulaması.Entity
{
    public class TelefonNumaralari
    {
        public TelefonNumaralari(string name, string lastName, string phoneNumber)
        {
            Name = name;
            LastName = lastName;
            PhoneNumber = phoneNumber;
        }


        public string Name { get; set; }
        public string LastName { get; set; }
        public string PhoneNumber { get; set; }

       
    }
}
