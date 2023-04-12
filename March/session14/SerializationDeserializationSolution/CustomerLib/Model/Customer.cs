using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerLib.Model
{
    [Serializable]
    public class Customer
    {
        private int id;
        private string name;
        private string email;
        private string phone;
        private string city;
        private string state;

        public Customer(int id, string name, string email, string phone, string city, string state)
        {
            this.id = id;
            this.name = name;
            this.email = email;
            this.phone = phone;
            this.city = city;
            this.state = state;
        }
        public int Id { get { return id; } set { id = value; } }
        public string Name { get { return name; } set { name = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string City { get { return city; } set { city = value; } }
        public string State { get { return state; } set { state = value; } }
            
    }
}
