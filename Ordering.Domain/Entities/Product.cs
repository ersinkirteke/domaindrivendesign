using Common.Domain;
using Ordering.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;
using static Ordering.Domain.Events.Events;

namespace Ordering.Domain.Entities
{
    public class Product : Entity
    {
        public ProductCode ProductCode { get; private set; }
        public Price Price { get; private set; }

        public Product(ProductCode productCode) =>
           Apply(new ProductCreated
           {
               ProductCode = productCode.Code
           });

        protected override void When(object @event)
        {
            switch (@event)
            {
                case ProductCreated e:
                    ProductCode = new ProductCode(e.ProductCode);
                    break;
            }
        }
    }
}
