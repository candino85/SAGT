using Application.DLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.BLL
{
    public class IntegrityService
    {
        IntegrityRepository integrityRepo = new DLL.IntegrityRepository();

        public void SetDVH(string entity)
        {
            integrityRepo.SetDV(entity);
        }

        public List<Dictionary<string, string>> IntegrityCheck(string entity) 
        { 
            var tables = entity.Split(',');
            List<Dictionary<string,string>> tablesResult = new List<Dictionary<string,string>>();

            foreach (var table in tables)
            {
                tablesResult.Add(integrityRepo.CompareDVs(table));
            }

            return tablesResult;
        }
    }
}
