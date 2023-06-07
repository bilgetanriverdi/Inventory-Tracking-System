using KücükPrens.Business.Abstract;
using KücükPrensEntities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KücükPrens.Business.Concrete
{
    public class UserBusiness : IDataBusiness<Users>
    {
        public void Add(Users entity)
        {
            using (var db = new DemirbasDbEntities1()) 
            {
                db.Users.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(Users entity)
        {
            using (var db = new DemirbasDbEntities1())
            {
                db.Users.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new DemirbasDbEntities1())
            {
                var entity = db.Users.Find(id);
                db.Users.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Edit(Users entity)
        {
            using (var db = new DemirbasDbEntities1())
            {
                db.Users.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public Users Get(int id)
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.Users.Find(id);
            }
        }

        public Users Get(System.Linq.Expressions.Expression<Func<Users, bool>> expression)
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.Users.Where(expression).FirstOrDefault();
            }
        }

        public List<Users> GetAll()
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.Users.ToList();
            }
        }

        public List<Users> GetAll(System.Linq.Expressions.Expression<Func<Users, bool>> expression)
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.Users.Where(expression).ToList();
            }
        }
    }
}
