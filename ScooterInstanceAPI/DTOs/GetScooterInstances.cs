﻿using System.Collections.Generic;
using MediatR;
using ScooterInstanceAPI.Data;

namespace ScooterInstanceAPI.DTOs
{
    public class GetScooterInstances : IRequest<List<ScooterInstance>>
    {

    }
}
