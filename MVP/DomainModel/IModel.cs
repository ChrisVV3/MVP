using System.Collections.Generic;

namespace MVP.DomainModel
{
    public interface IModel
    {
        List<Website> Select();
        void Insert(Website website);
        void Delete(int id);
        void Change(int id, string site, string url, int gap);
    }
}
