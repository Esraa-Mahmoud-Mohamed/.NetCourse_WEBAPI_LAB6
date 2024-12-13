using WEBAPI_LAB6.Models;

namespace WEBAPI_LAB6.UnitOfWorks
{
    public class GenericRepository<TEntity> where TEntity:class
    {
        public CompanyContext DB { get; set; }
        public GenericRepository(CompanyContext db)
        {
            DB = db;
        }

        public List<TEntity> SelectAll()
        {
            return DB.Set<TEntity>().ToList();
        }

        public TEntity SelectById(int id)
        {
            return DB.Set<TEntity>().Find(id);
        }

        public void Add(TEntity entity) {
            DB.Set<TEntity>().Add(entity);
           // Db.SaveChanges();
        }


        //public void edit (TEntity entity)
        //{
        //    DB.Entry(entity).State= Microsoft.EntityFrameworkCore.EntityState.Modified;
        //    //Db.SaveChanges();
        //}

        //public void delete(int id) 
        //{ 
        //    TEntity entity=selectbyid(id);
        //    DB.Set<TEntity>().Remove(entity);
        //    //Db.SaveChanges();
        //}

        //public void save()
        //{
        //    DB.SaveChanges();
        //}


    }
}
