namespace WaterTourismManager.Models
{
    public class ClientData
    {
        public required Guid ClientId { get; set; }
        public required string Surname { get; set; }
        public required string Name { get; set; }
        public string? PatrName { get; set; }
        public required string Passport { get; set; }
        public DateTime DateOfBirth { get; set; }
        public required decimal Balance { get; set; }
    }
}
