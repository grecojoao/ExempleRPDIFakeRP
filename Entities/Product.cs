using System;

namespace Exemple.Entities
{
    public class Product
    {
        public Guid Id { get; private set; } = Guid.NewGuid();
        public string Code { get; set; }
        public string Description { get; set; }
    }
}