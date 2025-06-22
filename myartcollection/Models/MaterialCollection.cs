using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace myartcollection.Models
{
    public class MaterialCollection
    {
        public List<ArtMaterial> Items { get; set; }

        public MaterialCollection()
        {
            Items = new List<ArtMaterial>();
        }
    }
}
