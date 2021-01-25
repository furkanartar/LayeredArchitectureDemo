namespace Entities
{
    public class Customer : IEntity
    {
        public int CustomerId { get; set; }
        public string ContactName { get; set; }
    }
}