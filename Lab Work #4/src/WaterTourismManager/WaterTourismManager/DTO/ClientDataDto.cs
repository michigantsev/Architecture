namespace WaterTourismManager.DTO
{
    public class ClientDataDto
    {
        public required string Surname { get; set; }
        public required string Name { get; set; }
        public string? PatrName { get; set; }
        public required string Passport { get; set; }
        public DateTime DateOfBirth { get; set; }
        public required decimal Balance { get; set; }
    }
}
