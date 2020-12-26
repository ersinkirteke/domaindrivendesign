using Common.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.Domain.ValueObjects
{
    public sealed class ProductCode : ValueObject

    {
        public String Code { get; private set; }
        private ProductCode() { }
        public ProductCode(string code)
        {
            if(String.IsNullOrEmpty(code))
                throw new ArgumentNullException(nameof(code), "Product code cannot be empty");
            Code = code;
        }

        protected override IEnumerable<object> GetEqualityComponents()
        {
            yield return Code;
        }
    }
}
