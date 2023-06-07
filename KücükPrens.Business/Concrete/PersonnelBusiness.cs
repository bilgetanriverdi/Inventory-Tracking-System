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
    public class PersonnelBusiness : IDataBusiness<Personnels>
    {
        public void Add(Personnels entity)
        {
            using (var db = new DemirbasDbEntities1())
            {
                db.Personnels.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(Personnels entity)
        {
            using (var db = new DemirbasDbEntities1())
            {
                db.Personnels.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new DemirbasDbEntities1())
            {
                var entity = db.Personnels.Find(id);
                db.Personnels.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Edit(Personnels entity)
        {
            using (var db = new DemirbasDbEntities1())
            {
                db.Personnels.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public Personnels Get(int id)
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.Personnels.Find(id);
            }
        }

        public Personnels Get(Expression<Func<Personnels, bool>> expression)
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.Personnels.Where(expression).FirstOrDefault();
            }
        }

        public List<Personnels> GetAll()
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.Personnels.ToList();
            }
        }

        public List<Personnels> GetAll(Expression<Func<Personnels, bool>> expression)
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.Personnels.Where(expression).ToList();
            }
        }

       public List<SP_PersonnelsWithBranch_Result> PersonelWithBranch()
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.SP_PersonnelsWithBranch().ToList();
            }
        }
    }
}
