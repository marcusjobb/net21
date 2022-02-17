using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using moqDB_demo;
using moqDB_demo.Data;
using moqDB_demo.Models;

namespace moqDB_demo.Tests
{
    public static class DbContextMock
    {
        // From https://medium.com/@briangoncalves/dbcontext-dbset-mock-for-unit-test-in-c-with-moq-db5c270e68f3
        public static DbSet<T> GetQueryableMockDbSet<T> (List<T> sourceList) where T : class
        {
            var queryable = sourceList.AsQueryable();
            var dbSet = new Mock<DbSet<T>>();
            dbSet.As<IQueryable<T>>().Setup(m => m.Provider).Returns(queryable.Provider);
            dbSet.As<IQueryable<T>>().Setup(m => m.Expression).Returns(queryable.Expression);
            dbSet.As<IQueryable<T>>().Setup(m => m.ElementType).Returns(queryable.ElementType);
            dbSet.As<IQueryable<T>>().Setup(m => m.GetEnumerator()).Returns(() => queryable.GetEnumerator());

            dbSet.Setup(d => d.Add(It.IsAny<T>())).Callback<T>((s) => sourceList.Add(s));
            dbSet.Setup(d => d.Remove(It.IsAny<T>())).Callback<T>((s) => sourceList.Remove(s));
            return dbSet.Object;
        }
    }

    [TestClass()]
    public class CatCrudTests
    {
        CatsContext context;
        [TestInitialize]
        public void TestInit ()
        {
            context = new CatsContext();
            var catList = new List<Cat>()
            {
                new Cat{Name="Mrs Meow", Colour="Striped yellow", Id=1},
                new Cat{Name="Baby Meow", Colour="Striped brown", Id=2},
                new Cat{Name="Granny Meow", Colour="Black", Id=3},
                new Cat{Name="Mr Meow", Colour="Striped yellow", Id=4},
            };
            context.MyCats = DbContextMock.GetQueryableMockDbSet<Cat>(catList);
        }
        [TestMethod()]
        public void MoqWorks ()
        {
            var expected = "Baby Meow";
            var actual = context.MyCats.FirstOrDefault(c => c.Id == 2)?.Name;

            Assert.AreEqual(expected, actual);
        }
        [TestMethod()]
        public void AddCatTest ()
        {
            var expected = context.MyCats.Count() + 1;
            var crud = new CatCrud(context);
            crud.AddCat(new Cat { Name = "Weird cat", Colour = "Blue", Id = 10 });

            var actual = context.MyCats.Count();
            Assert.AreEqual(expected, actual);
        }

        [TestMethod()]
        public void RemoveCatTest ()
        {
            var expected = context.MyCats.Count() - 1;
            var crud = new CatCrud(context);
            crud.DeleteCat(context.MyCats.First());

            var actual = context.MyCats.Count();
            Assert.AreEqual(expected, actual);
        }
    }
}