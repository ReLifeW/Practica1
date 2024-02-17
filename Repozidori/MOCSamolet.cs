using Practica1.modal;

namespace Practica1.Repozidori
{
    public class MOCSamolet : ISamolet
    {
        private List<Samolet> _msam;
        public MOCSamolet()
        {
            _msam ??= new List<Samolet>();
            _msam.Add(new() { Id = 1, Name = "Первый", Type = "Гражданский" });
            _msam.Add(new() { Id = 2, Name = "Второй", Type = "Гражданский" });
            _msam.Add(new() { Id = 3, Name = "Третий", Type = "Гражданский" });
        }

        public Samolet Add(Samolet samolet)
        {
            _msam.Add(samolet);
            return samolet;

        }

        public Samolet Get(int ID)
        {
            return _msam.Where(n => n.Id == ID).ToList().FirstOrDefault();
            
        }

        public List<Samolet> GetLL()
        {
            return _msam;
        }

        public Samolet Update(Samolet samolet)
        {
            var userDB = Get(samolet.Id);
            if (userDB != null)
            {
                _msam.Remove(userDB);
            }
            _msam.Add(samolet);
            return samolet;
        }
        public void Delete(int ID)
        {
            var userDB = Get(ID);
            if (userDB != null)
            {
                _msam.Remove(userDB);
            }
            _msam.Remove(userDB);
        }

       
    }
}
