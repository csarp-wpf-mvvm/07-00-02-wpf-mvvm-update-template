﻿using Kreta.Backend.Repos;
using Kreta.Shared.Assamblers;
using Kreta.Shared.Models;
using Kreta.Shared.Models.Entites;
using Microsoft.AspNetCore.Mvc;

namespace Kreta.Backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class SubjectTypeController : BaseController<SubjectType, SubjectTypeDto>
    {
        public SubjectTypeController(SubjectTypeAssambler? assambler, IRepositoryBase<SubjectType>? repo) : base(assambler, repo)
        {
        }
    }
}
