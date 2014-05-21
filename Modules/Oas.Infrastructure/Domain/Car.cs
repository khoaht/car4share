using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Oas.Infrastructure.Domain
{
    public class Car
    {
        public string Name { get; set; }

        public Guid CategoryId { get; set; }

        public Guid CarSourceId { get; set; }

        public int YearOfProduct { get; set; }

        public string Model { get; set; }

        public CarType CarType { get; set; }

        [ForeignKey("CarSourceId")]
        public CarSource CarSource { get; set; }


        [ForeignKey("CategoryId")]
        public Category Category { get; set; }
    }

    public enum CarType
    {
        AT,
        MT
    }
}
