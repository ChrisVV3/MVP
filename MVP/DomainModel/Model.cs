using System.Linq;
using System.Collections.Generic;
using System.Data.Entity;

namespace MVP.DomainModel
{
    public class Model : IModel
    {
        public void Delete(int id)
        {
            using (DBEFContext db = new DBEFContext())
            {
                var website = db.Websites.Find(id);
                db.Websites.Remove(website);
                db.SaveChanges();
            }
        }
        public void Insert(Website website)
        {
            using (DBEFContext db = new DBEFContext())
            {
                db.Websites.Add(website);
                db.SaveChanges();
            }
        }
        public List<Website> Select()
        {
            List<Website> websites;
            using (DBEFContext db = new DBEFContext())
            {
                websites = db.Websites.ToList();
            }
            return websites;
        }
        public void Change(int id, string site, string url, int gap)
        {
            using (DBEFContext db = new DBEFContext())
            {
                var website = db.Websites.Find(id);
                if (!string.IsNullOrEmpty(site))
                    website.Site = site;
                if (!string.IsNullOrEmpty(url))
                    website.URL = url;
                if (gap != 0)
                    website.Gap = gap;
                db.SaveChanges();
            }
        }
    }
}
