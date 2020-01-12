﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LocationAPI.DTOs
{
    public class GetScooterInstancesIDs: IRequest<List<Guid>>
    {
        public GetScooterInstancesIDs(Guid id)
        {
            LocationID = id;
        }
        public Guid LocationID { get; set; }
    }
}
