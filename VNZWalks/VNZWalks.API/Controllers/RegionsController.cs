using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using VNZWalks.API.Models.Dto;
using VNZWalks.API.Repositories;

namespace VNZWalks.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class RegionsController : Controller
    {
        private readonly IRegionRepository _regionRepository;
        private readonly IMapper _mapper;

        public RegionsController(IRegionRepository regionRepository, IMapper mapper)
        {
            this._regionRepository = regionRepository;
            this._mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetAllRegions()
        {
            var records = await _regionRepository.GetAll();

            //var regionsDto = new List<RegionsDto>();

            //records.ToList().ForEach(region =>
            //{
            //    var regionDto = new RegionsDto()
            //    {
            //        Id = region.Id,
            //        Code = region.Code,
            //        Name = region.Name,
            //        Area = region.Area,
            //        Lat = region.Lat,
            //        Long = region.Long,
            //        Population = region.Population
            //    };
            //    regionsDto.Add(regionDto);
            //});

            var regionsDto = _mapper.Map<List<RegionsDto>>(records);
                 
            return Ok(regionsDto);
        }
    }
}
