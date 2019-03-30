using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Cohaerens.Models
{
    public class SysCom
    {
        public long Id { get; set; }

        public string Name { get; set; }
        public string Description { get; set; }

        public long PlaceId { get; set; }
        public Place Place { get; set; }
    }
}
