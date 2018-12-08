using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamerQasaly.Data.DBModel;

namespace TamerQasaly.Data.Interfaces
{
    interface ICareer
    {
        IQueryable<Office_Career> GetCareers { get; }
        Office_Career GetCareer(int key);
        int AddCareer(Office_Career career);
        int UpdateCareer(Office_Career career);
        int DeleteCareer(int id);

    }
}
