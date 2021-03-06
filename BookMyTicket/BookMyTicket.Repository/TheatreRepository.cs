﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookMyTicket.DomainModel;

namespace BookMyTicket.Repository
{
    public interface ITheatreRepository : IGenericDataRepository<Theatre>
    {
    }

    public class TheatreRepository : GenericDataRepository<Theatre>, ITheatreRepository
    {
    }
}
