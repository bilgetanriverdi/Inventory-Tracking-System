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
    public class BranchBusiness : IDataBusiness<Branches>
    {
        public void Add(Branches entity)
        {
            using (var db = new DemirbasDbEntities1())
            {
                db.Branches.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(Branches entity)
        {
            using (var db = new DemirbasDbEntities1())
            {
                db.Branches.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new DemirbasDbEntities1())
            {
                var entity = db.Branches.Find(id);
                db.Branches.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Edit(Branches entity)
        {
            using (var db = new DemirbasDbEntities1())
            {
                db.Branches.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public Branches Get(int id)
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.Branches.Find(id);
            }
        }

        public Branches Get(Expression<Func<Branches, bool>> expression)
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.Branches.Where(expression).FirstOrDefault();
            }
        }

        public List<Branches> GetAll()
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.Branches.ToList();
            }
        }

        public List<Branches> GetAll(Expression<Func<Branches, bool>> expression)
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.Branches.Where(expression).ToList();
            }
        }
    }
}
