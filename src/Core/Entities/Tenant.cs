namespace Core.Entities
{
    public class Tenant
    {
        public string Name { get; set; }
        public string TenantId { get; set; }
        public string ConnectionString { get; set; }
    }
}