using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamerQasaly.Data.Interfaces;
using TamerQasaly.DBModel;

namespace TamerQasaly.Data.DAL
{
    public class CareerType_DAL : ICareerType
    {
        private TamerQasalyDBEntities _db;
        public CareerType_DAL()
        {
            _db = new TamerQasalyDBEntities();
        }

        public IQueryable<Office_CareerType> GetCareerTypes
        {
            get
            {
                return _db.Office_CareerType.AsQueryable();
            }
        }

        public int AddCareerType(Office_CareerType careertype)
        {
            _db.Office_CareerType.Add(careertype);
            return _db.SaveChanges();
        }

        public int DeleteCareerType(int id)
        {
            _db.Office_CareerType.Remove(GetCareerType(id));
            return _db.SaveChanges();
        }

        public Office_CareerType GetCareerType(int key)
        {
            return _db.Office_CareerType.Find(key);
        }

        public int UpdateCareerType(Office_CareerType careerType)
        {
            using (_db)
            {
                var result = _db.Office_CareerType.SingleOrDefault(b => b.ID == careerType.ID);
                if (result != null)
                {
                    result.Name = careerType.Name;
                    result.Description = careerType.Description;
                    result.Office_Career = careerType.Office_Career;
                    return _db.SaveChanges();
                }
                else
                {
                    return 0;
                }
            }

        }
    }
}
