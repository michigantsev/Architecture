using AutoMapper;
using WaterTourismManager.DTO;
using WaterTourismManager.Models;

namespace WaterTourismManager.Mappers
{
    public class ClientsMapper : Profile
    {
        public ClientsMapper() 
        {
            CreateMap<ClientData, ClientDataDto>();
            CreateMap<ClientDataDto, ClientData>();
            CreateMap<PeopleSetData, PeopleSetDto>();
            CreateMap<PeopleSetDto, PeopleSetData>();
        }

    }
}
