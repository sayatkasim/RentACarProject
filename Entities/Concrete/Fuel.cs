using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities.Abstract;

namespace Entities.Concrete
{
    public class Fuel : IEntity
    {
        public int Id { get; set; }
        public string FuelType { get; set; }
    }
}
