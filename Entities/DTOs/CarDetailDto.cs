using System;
using System.Collections.Generic;
using System.Text;

namespace Core.Entities.DTOs
{
    public class CarDetailDto
    {
        public int CarId { get; set; }
        public decimal DailyPrice { get; set; }
        public string BrandName { get; set; }
        public string Description { get; set; }
    }
}
