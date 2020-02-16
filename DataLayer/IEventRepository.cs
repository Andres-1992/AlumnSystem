﻿using BusinessEntities.Models;
using System.Collections.Generic;

namespace DataLayer
{
    public interface IEventRepository:IGenericRepository<Event>
    {
        IEnumerable<Event> GetEvents();
    }
}