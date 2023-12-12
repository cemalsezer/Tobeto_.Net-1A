using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Dtos.Responses
{
    public class GetListedProductResponse
    {
        public int Id { get; set; }

        public int CategoryId { get; set; }
        //public int ProductId { get; set; }

        public string CategoryName { get; set; }
        public string InstructorName { get; set; }
        public string Name { get; set; }
        public decimal UnitPrice { get; set; }
        public short UnitsInStock { get; set; }
        public string QuantityPerUnit { get; set; }
    }
}
