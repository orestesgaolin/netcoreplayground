using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using netcoreplayground.Controllers.Resources;
using netcoreplayground.Models;
using netcoreplayground.Persistence;

namespace netcoreplayground.Controllers
{
    public class FeaturesController : Controller
    {
        private readonly IMapper mapper;
        private readonly VegaDbContext context;
        public FeaturesController(VegaDbContext context, IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        [HttpGet("/api/features")]
        public async Task<IEnumerable<FeatureResource>> GetFeatures()
        {
            var features = await context.Features.ToListAsync();
            return mapper.Map<List<Feature>, List<FeatureResource>>(features);
        }
    }
}