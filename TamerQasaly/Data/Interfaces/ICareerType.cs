using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TamerQasaly.DBModel;

namespace TamerQasaly.Data.Interfaces
{
    public interface ICareerType
    {
        IQueryable<Office_CareerType> GetCareerTypes { get; }
        Office_CareerType GetCareerType(int key);
        int AddCareerType(Office_CareerType careertype);
        int UpdateCareerType(Office_CareerType careerType);
        int DeleteCareerType(int id);

    }
}
