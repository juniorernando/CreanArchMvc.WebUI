using CleanArchMvc.Domain.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchMvc.Application.Products.Commands
{
    public abstract class ProductCommand : IRequest<Product>
    {
        public string Name { get; protected set; }
        public string Description { get; protected set; }
        public decimal Price { get; protected set; }
        public int Stock { get; protected set; }
        public string Image { get; protected set; }
        public int CategoryId { get; protected set; }
    }
}
