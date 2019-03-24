﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cohaerens.Models
{
    public class DataRepository : IRepository
    {
        private DataContext context;

        public DataRepository(DataContext ctx) => context = ctx;

        public IEnumerable<SysCom> SysComs => context.SysComs;

        public SysCom GetSysCom(long key) => context.SysComs.Find(key);

        public void Add(SysCom syscom)
        {
            context.SysComs.Add(syscom);
            context.SaveChanges();
        }

        public void Update(SysCom syscom)
        {
            context.SysComs.Update(syscom);
            context.SaveChanges();
        }

        /*
        public void UpdateAll(SysCom[] syscoms)
        {
            context.SysComs.UpdateRange(syscoms);
            context.SaveChanges();
        }
        */

        public void Delete(SysCom syscom)
        {
            context.SysComs.Remove(syscom);
        }

        public IEnumerable<Place> Places => context.Places;

        public Place GetPlace(long key) => context.Places.Find(key);

        public void Add(Place place)
        {
            context.Places.Add(place);
            context.SaveChanges();
        }

        public void Update(Place place)
        {
            context.Places.Update(place);
            context.SaveChanges();
        }

        /*
        public void UpdateAll(Place[] places)
        {
            context.Places.UpdateRange(places);
        }
        */

        public void Delete(Place place)
        {
            context.Places.Remove(place);
            context.SaveChanges();
        }
    }
}
