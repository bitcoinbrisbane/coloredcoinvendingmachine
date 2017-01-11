using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ColouredCoinVendingMachine.Models;
using LiteDB;

namespace ColouredCoinVendingMachine.Repository
{
    public class LightDB : IRepository<Listing>
    {
        private readonly String _fileName;

        public IEnumerable<Listing> All
        {
            get
            {
                using (LiteDatabase db = new LiteDatabase(_fileName))
                {
                    var listings = db.GetCollection<Listing>("listings");
                    return listings.FindAll();
                }
            }
        }

        public LightDB(String connectionString)
        {
            _fileName = connectionString;
        }

        public void Add(Listing entity)
        {
            using (LiteDatabase db = new LiteDatabase(_fileName))
            {
                var listings = db.GetCollection<Listing>("listings");
                listings.Insert(entity);
            }
        }

        public void Delete(Listing entity)
        {
            throw new NotImplementedException();
        }

        public Listing FindById(string id)
        {
            using (LiteDatabase db = new LiteDatabase(_fileName))
            {
                var listings = db.GetCollection<Listing>("listings");
                return listings.FindById(id);
            }
        }

        public void Update(Listing entity)
        {
            throw new NotImplementedException();
        }
    }
}