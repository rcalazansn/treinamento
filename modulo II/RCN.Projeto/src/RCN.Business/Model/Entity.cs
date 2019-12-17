using System;

namespace RCN.Business.Model
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