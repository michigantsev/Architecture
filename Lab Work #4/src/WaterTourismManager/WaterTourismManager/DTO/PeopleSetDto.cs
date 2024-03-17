namespace WaterTourismManager.DTO
{
    public class PeopleSetDto
    {
        public required Guid PersonId { get; set; }
        public required decimal Price { get; set; }
        public required decimal Reward { get; set; }
    }
}
