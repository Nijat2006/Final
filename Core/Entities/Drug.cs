using Core.Abstractions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities
{
    public class Drug : IEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public byte Price { get; set; }
        public int Count { get; set; }
        public DrugStore DrugStores { get; set; }
        public int CurrentCount { get; set; }
        public double SumPrice { get; set; }

    }
}
