
using HumanLib.Model;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HumanUnitTestApp
{
    [TestClass]
    public class HumanUnitTest
    {
        [TestMethod]
        public void Should_Check_Human_Class_Constructor_Passing_The_ValueOf_Name_Gender_Age_Height_Weight()
        {
            Human human = new Human("Gautam", "Male", 23, 168, 53.3);
            string expectedName = "Gautam";
            string expectedGender = "Male";
            int expectedAge = 23;
            double expectedHeight = 168;
            double expectedWeight = 53.3;

            Assert.AreEqual(expectedName, human.Name);
            Assert.AreEqual(expectedGender, human.Gender);
            Assert.AreEqual(expectedAge, human.Age);
            Assert.AreEqual(expectedHeight, human.Height);
            Assert.AreEqual(expectedWeight, human.Weight);
        }
        [TestMethod]
        public void Should_Check_All_Atrubute_Of_Human_After_Changing_SomeThing()
        {
            Human human = new Human("Gautam", "Male", 23, 168, 53.3);

            human.Name = "Ravi";
            human.Age = 25;
            human.Height = 170;
            human.Weight = 60;
            
            string expectedName = "Ravi";
            string expectedGender = "Male";
            int expectedAge = 25;
            double expectedHeight = 170;
            double expectedWeight = 60;

            Assert.AreEqual(expectedName, human.Name);
            Assert.AreEqual(expectedGender, human.Gender);
            Assert.AreEqual(expectedAge, human.Age);
            Assert.AreEqual(expectedHeight, human.Height);
            Assert.AreEqual(expectedWeight, human.Weight);
        }

        [TestMethod]
        public void Should_Check_if_Human_Doing_Workout()
        {
            Human human = new Human("Gautam", "Male", 23, 168, 60);
            human.WorkOut();

            double expectedHeight = 168;
            double expectedWeight = 57;

            Assert.AreEqual(expectedHeight, human.Height);
            Assert.AreEqual(expectedWeight, human.Weight);
        }
        [TestMethod]
        public void Should_Check_if_Human_Eating_Something()
        {
            Human human = new Human("Gautam", "Male", 23, 168, 60);
            human.Eat();

            double expectedHeight = 171.36;
            double expectedWeight = 66;

            Assert.AreEqual(expectedHeight, human.Height);
            Assert.AreEqual(expectedWeight, human.Weight);
        }

        [TestMethod]
        public void Should_Check_Human_BodyMassIndex()
        {
            Human human = new Human("Gautam", "Male", 23, 168, 60);
            double actualBodyMassIndex = human.BodyMassIndex();
            double expectedBodyMassIndex = 21.258503401360546;
            Assert.AreEqual(expectedBodyMassIndex, actualBodyMassIndex);
        }
    }
}
