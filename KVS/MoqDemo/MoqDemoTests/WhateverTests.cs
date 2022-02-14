using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoqDemo.Interfaces;
using Moq;
using MoqDemo;

namespace Tests
{
    [TestClass()]
    public class WhateverTests
    {
        IPeopleHandler people;
        IDatabaseCrud db;
        [TestInitialize]
        public void Init ()
        {
            var moqObject = new Mock<IDatabaseCrud>();
            moqObject.Setup(p => p.GetPerson(It.IsAny<int>())).Returns
                (
                new Person()
                {
                    Name = "Marcus",
                    Email = "marcus.medina@codic.se"
                }
                );
            db = moqObject.Object;
            people = new PeopleHandler(); // new PeopleHandler();
        }

        [TestMethod()]
        public void VerifyEmail_By_Person ()
        {
            var test = db.GetPerson(512); // Simulerar hämtning från databas eller API
            var actual = people.VerifyEmail(test); // Kör riktig test
            Assert.IsTrue(actual); // Verifierar att allt stämmer
        }
        public void VerifyEmail_By_String ()
        {
            var test = db.GetPerson(512); // Simulerar hämtning från databas eller API
            var actual = people.VerifyEmail(test.Email); // Kör riktig test
            Assert.IsTrue(actual); // Verifierar att allt stämmer
        }
    }
}