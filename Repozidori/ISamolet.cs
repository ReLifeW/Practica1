using Practica1.modal;

namespace Practica1.Repozidori
{
    public interface ISamolet
    {
        public Samolet Add(Samolet samolet);
        public Samolet Get(int ID);
        public List<Samolet> GetLL();
        public Samolet Update(Samolet samolet);
        public void Delete(int ID);
    }
}
