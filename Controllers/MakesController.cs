using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreWithMosh.Controllers.Resources;
using NetCoreWithMosh.Models;
using NetCoreWithMosh.Persistence;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace NetCoreWithMosh.Controllers
{
    public class MakesController : Controller
    {

        private readonly MoshDbContext context;
        private IMapper mapper;

        public MakesController(MoshDbContext context,IMapper mapper)
        {
            this.mapper = mapper;
            this.context = context;
        }


        [HttpGet("/api/makes")]
        public async Task<IEnumerable<MakeResource>> GetMakes()
        {
            var makes = await context.Makes.Include(m => m.Models).ToListAsync();

            return mapper.Map<List<Make>, List<MakeResource>>(makes);
        }

    }
}
