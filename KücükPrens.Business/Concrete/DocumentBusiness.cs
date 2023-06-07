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
    public class DocumentBusiness : IDataBusiness<Documents>
    {
        public void Add(Documents entity)
        {
            using (var db = new DemirbasDbEntities1())
            {
                db.Documents.Add(entity);
                db.SaveChanges();
            }
        }

        public void Delete(Documents entity)
        {
            using (var db = new DemirbasDbEntities1())
            {
                db.Documents.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Delete(int id)
        {
            using (var db = new DemirbasDbEntities1())
            {
                var entity = db.Documents.Find(id);
                db.Documents.Attach(entity);
                db.Entry(entity).State = EntityState.Deleted;
                db.SaveChanges();
            }
        }

        public void Edit(Documents entity)
        {
            using (var db = new DemirbasDbEntities1())
            {
                db.Documents.Attach(entity);
                db.Entry(entity).State = EntityState.Modified;
                db.SaveChanges();
            }
        }

        public Documents Get(int id)
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.Documents.Find(id);
            }
        }

        public Documents Get(Expression<Func<Documents, bool>> expression)
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.Documents.Where(expression).FirstOrDefault();
            }
        }

        public List<Documents> GetAll()
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.Documents.ToList();
            }
        }

        public List<Documents> GetAll(Expression<Func<Documents, bool>> expression)
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.Documents.Where(expression).ToList();
            }
        }

        public List<SP_GetDocument_Result> GetDocuments()
        {
            using (var db = new DemirbasDbEntities1())
            {
                return db.SP_GetDocument().ToList();
            }
        }
    }
}
