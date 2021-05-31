namespace API.Models
{
    public class PieDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PieTypeId { get; set; }
        public int DateCreated { get; set; }
        public int ShopId { get; set; }
    }
}