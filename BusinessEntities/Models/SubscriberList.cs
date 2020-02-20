using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Models
{
    public class SubscriberList
    {
       public ICollection<Alumn> alumns { get; set; }
       public DateTime Created { get; set; }
    }
   
}
