using Core.Interfaces;

namespace Core.Entities
{
    public class Product : BaseEntity, ITenantIdentifier
    {
        public string TenantId { get; set; }
        
        public string Name { get; set; }
        public string Description { get; set; }
        public float Price { get; set; }
        public int Stock { get; set; }
        
    }
}