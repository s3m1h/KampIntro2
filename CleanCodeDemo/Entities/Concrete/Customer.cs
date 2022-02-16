using CleanCodeDemo.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanCodeDemo.Entities
{
    public class Customer:IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public bool IsStudent { get; set; }
    }
}
