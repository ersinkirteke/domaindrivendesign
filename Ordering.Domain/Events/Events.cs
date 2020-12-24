using Ordering.Domain.ValueObjects;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ordering.Domain.Events
{
    public static class Events
    {
        public class ProductCreated
        {
            public string ProductCode { get; set; }
        }
    }
}
