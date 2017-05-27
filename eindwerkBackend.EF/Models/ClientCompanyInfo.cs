namespace eindwerkBackend.EF.Models
{
    public class ClientCompanyInfo
    {
        public int Id { get; set; }
        public string ClientName { get; set; }
        public string ClientStreetName { get; set; }
        public string ClientHouseNumber { get; set; }
        public string ClientPostalCode { get; set; }
        public string ClientCity { get; set; }
        public string TvaClient { get; set; }

    }
}