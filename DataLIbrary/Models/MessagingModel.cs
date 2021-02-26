using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLIbrary.Models
{
    public class MessagingModel
    {
        public string id { get; set; }

        public string DisplayName { get; set; }

        public string Location { get; set; }

        public string Message { get; set; }

        public bool Visible { get; set; }
    }
}
