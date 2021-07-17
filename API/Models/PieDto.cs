using System;

namespace API.Models
{
    public class PieDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int PieTypeId { get; set; }
        public DateTime DateCreated { get; set; }
        public int ShopId { get; set; }
    }
}