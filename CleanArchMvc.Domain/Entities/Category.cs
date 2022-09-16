using CleanArchMvc.Domain.Validation;
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
            ValidateDomain(name);
        }
        public Category(int id, string name)
        {
            Id = id;
            Name = name;
        }
        public ICollection<Product> Products { get; set; }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name.Name is required");
        }

    }
}
