using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanUnitTestApp.Model
{
    [Serializable]
    public class Human
    {
        private string _name;
        private int _age;
        private float _height;
        private float _weight;
        //private string _gender;
        private Gender _gender;

        public Human(string name, int age, float height, float weight, Gender gender)
        {
            _name = name;
            _age = age;
            _height = height;
            _weight = weight;
            _gender = gender;
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

        public Gender Gender
        {
            get { return _gender; }
        }

        public float CalculateBMI(float heightInFeet)
        {
            float heightInMeters = heightInFeet * 0.3048f; // 1 foot = 0.3048 meters
            return _weight / (heightInMeters * heightInMeters);
        }

        public void Workout()
        {
            _weight -= (_weight * 0.05f);
        }

        public void Eat()
        {
            _weight += (_weight * 0.1f);
            _height += (_height * 0.02f);
        }
    }
}
