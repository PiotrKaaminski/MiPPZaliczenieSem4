using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MiPPZaliczenie.model
{
    class Message
    {
        public DateTime messageDate { get; set; }
        public Users author { get; set; }
        public string content { get; set; }

    }
}
