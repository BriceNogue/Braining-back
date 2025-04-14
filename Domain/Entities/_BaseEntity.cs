using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Entities
{
    public class _BaseEntity
    {
        public int Id { get; set; }
        public DateTimeOffset Created_date { get; set; }
        public DateTimeOffset Updated_date { get; set; }
        public bool Is_deleted { get; set; }
        public DateTimeOffset Deleted_date { get; set; }
    }
}
