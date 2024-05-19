﻿using ForeningsPortalen.Application.Features.UserRoleHistories.Queries;
using ForeningsPortalen.Infrastructure.Database.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForeningsPortalen.Infrastructure.Queries
{
    public class UserRoleHistoryQueries : IUserRoleHistoryQueries
    {
        private readonly ForeningsPortalenContext _dbcontext;
        public UserRoleHistoryQueries(ForeningsPortalenContext dbcontext)
        {
            _dbcontext = dbcontext;
        }
    }
}
