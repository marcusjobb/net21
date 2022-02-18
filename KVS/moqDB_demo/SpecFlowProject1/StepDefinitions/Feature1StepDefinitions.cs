using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Moq;
using moqDB_demo;
using moqDB_demo.Data;
using moqDB_demo.Models;
using TechTalk.SpecFlow;

namespace SpecFlowProject1.StepDefinitions
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

            // Find(int) och Update(T) funkar inte!

            return dbSet.Object;
        }
    }

    [Binding]
    public class Feature1StepDefinitions
    {
        CatsContext context;
        CatCrud catCrud;
        int kittens;
        public Feature1StepDefinitions ()
        {
            context = new CatsContext();
            var catList = new List<Cat>()
            {
                new Cat{Name="Mrs Meow", Colour="Striped yellow", Id=1},
                new Cat{Name="Mr Meow", Colour="Striped yellow", Id=4},
                new Cat{Name="Baby Meow", Colour="Striped brown", Id=2},
                new Cat{Name="Granny Meow", Colour="Black", Id=3},
            };
            context.MyCats = DbContextMock.GetQueryableMockDbSet<Cat>(catList);
            catCrud = new(context);
        }

        [Given(@"that Mr and Mrs Meow have one kitten")]
        public void GivenThatMrAndMrsMeowHaveOneKitten ()
        {
            kittens = catCrud.GetCatByNameContains("Baby").Count();
        }

        [When(@"they adopt a new one")]
        public void WhenTheyAdoptANewOne ()
        {
            catCrud.AddCat(new Cat { Name = "Baby cat II", Colour = "Grey", Id = 911 });
        }

        [Then(@"they will have (.*) kittens\.")]
        public void ThenTheyWillHaveKittens_ (int amount)
        {
            kittens = catCrud.GetCatByNameContains("Baby").Count();
            kittens.Should().Be(amount);
        }
    }
}
