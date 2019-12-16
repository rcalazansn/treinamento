using System;

namespace RCN.Data.Model
{
    public class Entity
    {
        public Entity()
        {
            Id = Guid.NewGuid();
        }
        public Guid Id { get; set; }
    }
}