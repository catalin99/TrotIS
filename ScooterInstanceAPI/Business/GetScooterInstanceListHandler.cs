﻿using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Microsoft.EntityFrameworkCore;
using ScooterInstanceAPI.Data;
using ScooterInstanceAPI.DTOs;

namespace ScooterInstanceAPI.Business
{
    public class GetScooterInstanceListHandler: IRequestHandler<GetScooterInstanceList, List<ScooterInstance>>
    {
        private readonly Context context;

        public GetScooterInstanceListHandler(Context context)
        {
            this.context = context;
        }

        public async Task<List<ScooterInstance>> Handle(GetScooterInstanceList request, CancellationToken cancellationToken)
        {
            var scooterInstances = await context.ScooterInstances.Include(a=>a.Scooter).ToListAsync();
            var myScootersInstances = scooterInstances.Where(a => request.ScooterInstanceList.Contains(a.ScooterInstanceId)).ToList();
            return myScootersInstances;
        }
    }
}
