using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaseDeDatos
{
    public class Beer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int BrandId { get; set; }

        public Beer(int id, string name, int brandId)
        {
            this.Id = id;
            this.Name = name;
            this.BrandId = brandId;
        }

        public Beer(string name, int brandId)
        {
            this.Name = name;
            this.BrandId = brandId;
        }
    }
}
