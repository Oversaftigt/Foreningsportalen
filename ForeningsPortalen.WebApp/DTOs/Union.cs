namespace ForeningsPortalen.WebApp.DTOs
{
    public class Union
    {
        public Guid Id { get; set; }
        public IEnumerable<Address>? UnionAddresses { get; set; }

    }

}
