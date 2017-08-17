using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using NetCoreWithMosh.Controllers.Resources;
using NetCoreWithMosh.Models;
using NetCoreWithMosh.Persistence;

namespace NetCoreWithMosh.Controllers
{
  public class FeaturesController : Controller
  {
    private readonly MoshDbContext context;
    private readonly IMapper mapper;
    public FeaturesController(MoshDbContext context, IMapper mapper)
    {
      this.mapper = mapper;
      this.context = context;
    }

    [HttpGet("/api/features")]
    public async Task<IEnumerable<FeatureResource>> GetFeatures()
    {
      var features = await context.Features.ToListAsync();
      
      return mapper.Map<List<Feature>, List<FeatureResource>>(features); 
    }
  }
}