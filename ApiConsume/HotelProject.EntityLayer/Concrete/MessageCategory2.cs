using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelProject.EntityLayer.Concrete
{
    public class MessageCategory2
    {
        public int MessageCategory2ID { get; set; }
        public string? MessageCategory2Name { get; set;}
        public List<Contact> Contacts { get; set; }

    }
}
