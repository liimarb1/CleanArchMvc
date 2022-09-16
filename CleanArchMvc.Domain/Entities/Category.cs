using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Entities
{

    //sealed = essa classe não pode ser herdada
    public sealed class Category
    {
        public int Id { get; private set; }
        public string Name { get; private set; }
        public Category(string name)
        {
            Name = name;
        }
        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public ICollection<Product> Products { get; set; }

    }
}
