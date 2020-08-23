﻿using AutoMapper;
using Entities;
using Entities.DataTransferObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AccountOwnerServer
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Owner, OwnerDto>();
            CreateMap<Account, AccountDto>();
            CreateMap<OwnerForCreationDto, Owner>();
        }
    }
}
