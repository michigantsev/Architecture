namespace WaterTourismManager.Models
{
    public class PeopleSetData
    {
        public required int SetId { get; set; }
        public required Guid PersonId { get; set; }
        public required decimal Price { get; set; }
        public required decimal Reward { get; set; }
    }
}
