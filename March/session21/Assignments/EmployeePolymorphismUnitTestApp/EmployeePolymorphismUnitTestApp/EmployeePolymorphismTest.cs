using EmployeePolymorphismUnitTestApp.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeePolymorphismUnitTestApp
{
    [TestClass]
    public class EmployeePolymorphismTest
    {
        [TestMethod]
        public void Should_Create_Employee_Object_With_Correct_Values()
        {
            Employee employee = new Employee(101, "Bruce Wayne", 50000);
            Assert.AreEqual(101, employee.Id);
            Assert.AreEqual("Bruce Wayne", employee.Name);
            Assert.AreEqual(50000, employee.BasicSalary);
        }

        [TestMethod]
        public void Should_Create_Manager_Object_With_Correct_Values()
        {
            Manager manager = new Manager(102, "Manjunath Saukar", 80000);
            Assert.AreEqual(102, manager.Id);
            Assert.AreEqual("Manjunath Saukar", manager.Name);
            Assert.AreEqual(80000, manager.BasicSalary);
        }

        [TestMethod]
        public void Should_Create_Developer_Object_With_Correct_Values()
        {
            Developer developer = new Developer(103, "Abhishek Boyanpalli", 60000);
            Assert.AreEqual(103, developer.Id);
            Assert.AreEqual("Abhishek Boyanpalli", developer.Name);
            Assert.AreEqual(60000, developer.BasicSalary);
        }

        [TestMethod]
        public void Should_Create_QualityAnalyst_Object_With_Correct_Values()
        {
            QualityAnalyst qa = new QualityAnalyst(104, "Sisiender Reddy", 55000);
            Assert.AreEqual(104, qa.Id);
            Assert.AreEqual("Sisiender Reddy", qa.Name);
            Assert.AreEqual(55000, qa.BasicSalary);
        }

        [TestMethod]
        public void Should_Return_Correct_AnnualSalary_For_Employee()
        {
            Employee employee = new Employee(101, "Bruce Wayne", 50000);
            double actual = employee.CalculateAnnualSalary();
            double expected = 50000 * 12;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_Return_Correct_AnnualSalary_For_Manager()
        {
            Manager manager = new Manager(101, "Manjunath Saukar", 50000);
            double actual = manager.CalculateAnnualSalary();
            double expected = (0.6 * 50000 + 0.5 * 50000 + 0.4 * 50000 + 50000) * 12;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_Return_Correct_AnnualSalary_For_Developer()
        {
            Developer developer = new Developer(101, "Abhishek Boyanpalli", 50000);
            double actual = developer.CalculateAnnualSalary();
            double expected = (0.5 * 50000 + 0.4 * 50000 + 50000) * 12;
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Should_Return_Correct_AnnualSalary_For_QualityAnalyst()
        {
            QualityAnalyst qa = new QualityAnalyst(101, "Sisiender Reddy", 50000);
            double actual = qa.CalculateAnnualSalary();
            double expected = (0.4 * 50000 + 50000) * 12;
            Assert.AreEqual(expected, actual);
        }
    }
}
