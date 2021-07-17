using System.Collections.Generic;
using API.Models;

namespace API
{
    public class PiesDataStore
    {
        public static PiesDataStore Current { get; } = new PiesDataStore();
        public List<PieDto> Pies { get; set; }

        public PiesDataStore()
        {
          Pies = new List<PieDto>()
          {
            new PieDto()
            {
              Id = 1,
              Name = "Pork & Apple Pie",
              PieTypeId = 1,
              ShopId = 2
            },
            new PieDto()
            {
              Id = 2,
              Name = "Pork & Apple Pie",
              PieTypeId = 1,
              ShopId = 1
            }
          };
        }
    }
}