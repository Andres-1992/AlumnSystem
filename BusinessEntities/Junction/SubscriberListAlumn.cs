﻿using BusinessEntities.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace BusinessEntities.Junction
{
   public class SubscriberListAlumn
    {
        public int AlumnId { get; set; }
        public Alumn Alumn { get; set; }

        public int SubscriberListId { get; set; }
        public SubscriberList SubscriberList { get; set; }
    }
}
