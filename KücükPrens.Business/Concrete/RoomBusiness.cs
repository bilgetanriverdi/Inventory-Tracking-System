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
    public class RoomBusiness : IDataBusiness<Rooms>
    {
        public void Add(Rooms entity)
        {
            using (var db = new DemirbasDbEntities1())
            {
                db.Rooms.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(Rooms entity)
        {
            using (var db = new DemirbasDbEntities1())
            {
                db.Rooms.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new DemirbasDbEntities1())
            {
                var entity = db.Rooms.Find(id);
                db.Rooms.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Edit(Rooms entity)
        {
            using (var db = new DemirbasDbEntities1())
            {
                db.Rooms.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public Rooms Get(int id)
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.Rooms.Find(id);
            }
        }

        public Rooms Get(Expression<Func<Rooms, bool>> expression)
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.Rooms.Where(expression).FirstOrDefault();
            }
        }

        public List<Rooms> GetAll()
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.Rooms.ToList();
            }
        }

        public List<Rooms> GetAll(Expression<Func<Rooms, bool>> expression)
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.Rooms.Where(expression).ToList();
            }
        }
    }
}
