using KücükPrens.Business.Abstract;
using KücükPrensEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KücükPrens.Business.Concrete
{
    public class InventoryBusiness : IDataBusiness<Inventories>
    {
        public void Add(Inventories entity)
        {
            using (var db = new DemirbasDbEntities1())
            {
                db.Inventories.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(Inventories entity)
        {
            using (var db = new DemirbasDbEntities1())
            {
                db.Inventories.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new DemirbasDbEntities1())
            {
                var entity = db.Inventories.Find(id);
                db.Inventories.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Edit(Inventories entity)
        {
            using (var db = new DemirbasDbEntities1())
            {
                db.Inventories.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public Inventories Get(int id)
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.Inventories.Find(id);
            }
        }

        public Inventories Get(Expression<Func<Inventories, bool>> expression)
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.Inventories.Where(expression).FirstOrDefault();
            }
        }

        public List<Inventories> GetAll()
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.Inventories.ToList();
            }
        }

        public List<Inventories> GetAll(Expression<Func<Inventories, bool>> expression)
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.Inventories.Where(expression).ToList();
            }
        }

        public List<SP_GetInventroies_Result> GetInventory()
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.SP_GetInventroies().ToList();
            }
        }
    }
}
