using CleanArchMvc.Domain.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Domain.Entities
{
    public sealed class Category : Entity
    {
        public int Id { get; private set; }
        public string? Name { get; private set; }


        public Category(string name)
        {
            DomainExceptionValidation.When(Id < 0, "Invalid Id value");
            Id = Id;
            ValidateDomain(name);
        }

        public void Update(string name)
        {
            ValidateDomain(name);
        }
        public Category(int id, string name)
        {
            this.Id = id;
            Name = name;
        }
        public ICollection<Product>? Products { get; set; }

        private void ValidateDomain(string name)
        {
            DomainExceptionValidation.When(string.IsNullOrEmpty(name), "Invalid name. Name is required");
            DomainExceptionValidation.When(name.Length < 3, "Invalid name. Too short, minimum 3 characters");
            Name = name;
        }
    }
}
