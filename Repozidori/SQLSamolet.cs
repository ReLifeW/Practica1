using Practica1.modal;

namespace Practica1.Repozidori
{
    public class SQLSamolet : ISamolet
    {

        private readonly AppDbContext _appDbContext;

        public SQLSamolet(AppDbContext appDbContext)
        {
            _appDbContext = appDbContext;
        }

        public Samolet Add(Samolet samolet)
        {
            _appDbContext.Add(samolet);
            _appDbContext.SaveChanges();
            return samolet;
        }

        public void Delete(int ID)
        {
            var samoletToDelete = Get(ID);

            if (samoletToDelete != null)
            {
                _appDbContext.Samolet.Remove(samoletToDelete);
                _appDbContext.SaveChanges();
            }
        }
       
            public Samolet Get(int ID)
        {
            return _appDbContext.Samolet.Where(u => u.Id == ID).ToList().FirstOrDefault();
        }

        public List<Samolet> GetLL()
        {
            return _appDbContext.Samolet.ToList();
        }

        public Samolet Update(Samolet samolet)
        {
            if (samolet.Id == 0)
            {
                _appDbContext.Samolet.Add(samolet);
            }
            else
            {
                _appDbContext.Samolet.Update(samolet);
            }
            _appDbContext.SaveChanges();
            return samolet;
        }
    }
}
