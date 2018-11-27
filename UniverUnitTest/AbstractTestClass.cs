using Demo.AppContext;
using Demo.EntityConsole.Abstract;
using Demo.EntityConsole.Common;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UniverUnitTest
{
    [TestClass]
    public abstract class AbstractTestClass<T> where T : DbEntity
    {
        protected MyAppDbContext _context = new MyAppDbContext("MyAppConnStr");
        protected DbRepository<T> r;
        protected T model1;
        protected T model2;
        protected DbSet<T> dbSet;

        protected abstract void ChangeModel(T model);

        [TestInitialize]
        public abstract void InitParams();

        protected abstract T FindEqualModel(DbRepository<T> r, T model);

        [TestMethod]
        public void TestMethod()
        {
            var models = r.AddItem(model1);
            _context.SaveChanges();
            var dbItem = FindEqualModel(r, model1);

            Assert.IsNotNull(dbItem);
            Assert.AreEqual(dbSet.Count(), r.AllItems.Count());
            r.DeleteItem(dbItem.Id);
            _context.SaveChanges();

            Assert.AreEqual(dbSet.Count(), r.AllItems.Count());
            Assert.IsNull(FindEqualModel(r, model1));
            r.AddItems(new T[] { model1, model2 });
            _context.SaveChanges();

            var dbItem1 = FindEqualModel(r, model1);
            Assert.IsNotNull(dbItem1);
            var dbItem2 = FindEqualModel(r, model2);
            Assert.IsNotNull(dbItem2);
            Assert.AreEqual(dbSet.Count(), r.AllItems.Count());

            r.DeleteItem(dbItem1.Id);
            _context.SaveChanges();
            dbItem1 = FindEqualModel(r, model1);
            Assert.IsNull(dbItem1);
            Assert.AreEqual(dbSet.Count(), r.AllItems.Count());

            ChangeModel(dbItem2);

            var dbItem2m = FindEqualModel(r, dbItem2);

            Assert.IsNotNull(dbItem2m);

            r.DeleteItem(dbItem2m.Id);
            dbItem2 = FindEqualModel(r, dbItem2m);
            Assert.IsNull(dbItem2);
            Assert.AreEqual(dbSet.Count(), r.AllItems.Count());
        }


    }
}
