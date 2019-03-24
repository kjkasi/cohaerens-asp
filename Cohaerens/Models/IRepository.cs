using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cohaerens.Models
{
    public interface IRepository
    {
        IEnumerable<SysCom> SysComs { get; }

        SysCom GetSysCom(long key);
        
        void Add(SysCom syscom);
        void Update(SysCom syscom);
        //void UpdateAll(SysCom[] syscoms);
        void Delete(SysCom syscom);

        IEnumerable<Place> Places { get; }

        Place GetPlace(long key);

        void Add(Place place);
        void Update(Place place);
        //void UpdateAll(Place[] places);
        void Delete(Place place);
    }
}
