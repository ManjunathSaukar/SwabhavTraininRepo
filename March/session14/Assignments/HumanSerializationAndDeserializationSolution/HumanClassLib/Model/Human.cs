using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanClassLib.Model
{
    [Serializable]
    public class Human
    {
        private string _name;
        private int _age;
        private float _height;
        private float _weight;
        private float _startingHeight;
        private float _startingWeight;

        public Human(string name, int age, float height, float weight)
        {
            _name = name;
            _age = age;
            _height = height;
            _weight = weight;
            _startingHeight = height;
            _startingWeight = weight;
        }

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public int Age
        {
            get { return _age; }
            set { _age = value; }
        }

        public float Height
        {
            get { return _height; }
            set { _height = value; }
        }

        public float Weight
        {
            get { return _weight; }
            set { _weight = value; }
        }
        public float StartingHeight
        {
            get { return _startingHeight; }
        }

        public float StartingWeight
        {
            get { return _startingWeight; }
        }

        public void Workout()
        {
            float oldWeight = _weight;
            _weight -= (_weight * 0.05f);
            _startingWeight = oldWeight;
            _startingHeight = _height;
        }

        public void Eat()
        {
            float oldWeight = _weight;
            _weight += (_weight * 0.1f);
            _height += (_height * 0.02f);
            _startingWeight = oldWeight;
            _startingHeight = _height;
        }
    }
}
