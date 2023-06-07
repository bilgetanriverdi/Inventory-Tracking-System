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
    public class InventoryTypeBusiness : IDataBusiness<InventoriesTypes>
    {
        public void Add(InventoriesTypes entity)
        {
            using (var db = new DemirbasDbEntities1())
            {
                db.InventoriesTypes.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(InventoriesTypes entity)
        {
            using (var db = new DemirbasDbEntities1())
            {
                db.InventoriesTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new DemirbasDbEntities1())
            {
                var entity = db.InventoriesTypes.Find(id);
                db.InventoriesTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Edit(InventoriesTypes entity)
        {
            using (var db = new DemirbasDbEntities1())
            {
                db.InventoriesTypes.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public InventoriesTypes Get(int id)
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.InventoriesTypes.Find(id);
            }
        }

        public InventoriesTypes Get(Expression<Func<InventoriesTypes, bool>> expression)
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.InventoriesTypes.Where(expression).FirstOrDefault();
            }
        }

        public List<InventoriesTypes> GetAll()
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.InventoriesTypes.ToList();
            }
        }

        public List<InventoriesTypes> GetAll(Expression<Func<InventoriesTypes, bool>> expression)
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.InventoriesTypes.Where(expression).ToList();
            }
        }
    }
}
