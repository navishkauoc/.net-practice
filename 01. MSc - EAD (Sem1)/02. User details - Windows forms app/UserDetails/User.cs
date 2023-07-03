using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserDetails
{
    class User
    {
        private string firstName;
        private string lastName;
        private string address;
        private string city;
        private string postcode;

        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Address { get => address; set => address = value; }
        public string City { get => city; set => city = value; }
        public string Postcode { get => postcode; set => postcode = value; }
    }
}
