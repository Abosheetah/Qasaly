using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamerQasaly.Data.DBModel;
using TamerQasaly.Data.Interfaces;

namespace TamerQasaly.Data.DAL
{
    class Career_DAL : ICareer
    {
        private TamerQasalyDBEntities _db;
        public Career_DAL()
        {
            _db = new TamerQasalyDBEntities();
        }
        public IQueryable<Office_Career> GetCareers
        {
            get
            {
                return _db.Office_Career.AsQueryable();
            }
        }

        public int AddCareer(Office_Career career)
        {
            _db.Office_Career.Add(career);
           return _db.SaveChanges();
        }

        public int DeleteCareer(int id)
        {
            bool isExist = _db.Office_Employee.Where(i => i.CareerID == id).Any();
            if (!isExist)
            {
                _db.Office_Career.Remove(GetCareer(id));
                return _db.SaveChanges();
            }
            else
            {
                return 0;
            }
        }

        public Office_Career GetCareer(int key)
        {
            return _db.Office_Career.Find(key);
        }

        public int UpdateCareer(Office_Career career)
        {
            Office_Career _career = _db.Office_Career.Find(career.ID);
            _career.Name = career.Name;
            _career.CareerTypeID = career.CareerTypeID;
            _career.Description = career.Description;
            _career.isSysAdmin = career.isSysAdmin;
            _career.isSysUser = career.isSysUser;                      
            return _db.SaveChanges();
        }
    }
}
