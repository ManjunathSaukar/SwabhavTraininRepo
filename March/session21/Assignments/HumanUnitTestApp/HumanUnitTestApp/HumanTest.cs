using HumanUnitTestApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HumanUnitTestApp
{
    [TestClass]
    public class HumanTest
    {
        [TestMethod]
        public void Should_Create_A_HumanObject_WithThe_Given_Constructor()
        {
            Human person = new Human("Manjunath", 22, 5.9f, 70f, Gender.Male);

            Assert.AreEqual("Manjunath", person.Name);
            Assert.AreEqual(22, person.Age);
            Assert.AreEqual(5.9f, person.Height);
            Assert.AreEqual(70f, person.Weight);
            Assert.AreEqual(Gender.Male, person.Gender);
        }

        [TestMethod]
        public void Should_Test_Name_Property()
        {
            Human person = new Human("Manjunath", 22, 5.9f, 70f, Gender.Male);
            string expectedName = "Manjunath";
            person.Name = expectedName;
            Assert.AreEqual(expectedName, person.Name);
        }

        [TestMethod]
        public void Should_Test_Age_Property()
        {
            Human person = new Human("Manjunath", 22, 5.9f, 70f, Gender.Male);
            int expectedAge = 22;
            person.Age = expectedAge;
            Assert.AreEqual(expectedAge, person.Age);
        }

        [TestMethod]
        public void ShouldTestHeightProperty()
        {
            Human person = new Human("Manjunath", 22, 5.9f, 70f, Gender.Male);
            float expectedHeight = 5.9f;
            person.Height = expectedHeight;
            Assert.AreEqual(expectedHeight, person.Height);
        }

        [TestMethod]
        public void Should_Test_Weight_Property()
        {
            Human person = new Human("Manjunath", 22, 5.9f, 70f, Gender.Male);
            float expectedWeight = 70f;
            person.Weight = expectedWeight;
            Assert.AreEqual(expectedWeight, person.Weight);
        }

        [TestMethod]
        public void Should_Check_For_Female_Gender()
        {
            Human person = new Human("Sunita", 29, 5.4f, 70f, Gender.Female);
            Gender expecetedGender = Gender.Female;
            Assert.AreEqual(expecetedGender, person.Gender);
        }

        [TestMethod]
        public void Should_Calculate_BMI_For_The_Given_Height_And_Weight()
        {
            Human person = new Human("Manjunath", 22, 5.9f, 70f, Gender.Male);
            float expectedBMI = 21.6f; 
            
            float actualBMI = person.CalculateBMI(person.Height);

            Assert.AreEqual(expectedBMI, actualBMI,0.1f);
        }

        [TestMethod]
        public void Should_Calculate_New_Weight_For_Workout_Method()
        {
            Human person = new Human("Manjunath", 22, 5.9f, 70f, Gender.Male);
            float expectedWeight = 66.5f;
            person.Workout();
            Assert.AreEqual(expectedWeight, person.Weight, 0.1f);
        }

        [TestMethod]
        public void Should_Calculate_New_Weight_And_New_Weight_For_Eat_Method()
        {
            Human person = new Human("Manjunath", 22, 5.9f, 70f, Gender.Male);

            float expectedWeight = 77; 
            float expectedHeight = 6.0f; 
            person.Eat();
            Assert.AreEqual(expectedWeight, person.Weight, 0.1f); 
            Assert.AreEqual(expectedHeight, person.Height, 0.1f); 
        }
    }
}

