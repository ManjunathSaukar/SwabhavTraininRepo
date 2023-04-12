using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefactoredMoveableApp.Model
{
    abstract class Vehicle : IMoveable
    {
        private string _name;
        
        public string Name { get { return _name; } }
        public Vehicle(string name) { _name = name; }
        public abstract void Move();
    }
}
