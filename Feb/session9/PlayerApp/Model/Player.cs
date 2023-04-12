using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerApp.Model
{
    internal class Player : Object
    {
        private readonly int id;
        private readonly string name;
        private readonly int age;
        private const int MINIMUM_AGE = 18;

        public Player(int id, string name, int age)
        {
            this.id = id; //_id = id;
            this.name = name;
            this.age = age;
            Console.WriteLine("3 params constructor");
        }

        /*public Player(int id, string name)
        {
            this.id = id;
            this.name = name;
            age = 18;
        }*/

        public Player(int id, string name) : this(id, name, MINIMUM_AGE)
        {
            Console.WriteLine("2 params constructor");
        }

        public int Id
        {
            get { return id; }
            //set { id = value; }
        }

        public string Name
        {
            get { return name; }
        }
        public int Age
        {
            get { return age; }
        }
        public Player WhoIsElder(Player secondPlayer)
        {
            return this.age > secondPlayer.age ? this : secondPlayer;
        }
    }
}
