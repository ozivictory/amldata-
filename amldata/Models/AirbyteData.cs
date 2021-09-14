using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace amldata.Models
{
    public class AirbyteData
    {
        [Key]
        public string _airbyte_ab_id { get; set; }

        public string _airbyte_data { get; set; }

        public DateTimeOffset _airbyte_emitted_at { get; set; }
    }
}
