using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerApp.Model
{
    internal class Customer
    {
        private string name;
        private int orderCount;
        private int _id;

        private static int _nextId = 1000;

        //static Customer()
        //{
        //    _nextId = 1000;
        //}

        public Customer(string name, int orderCount)
        {
            this.name = name;
            this.orderCount = orderCount;
            _nextId += 1;
            _id = _nextId;
        }

        public string Name
        {
            get { return this.name; }
        } 
        public int OrderCount
        {
            get { return this.orderCount; }
        }

        public int Id
        {
            get { return this._id; }
        }
    }
}
