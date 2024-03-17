using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WaterTourismManager.DTO;
using WaterTourismManager.Models;

namespace WaterTourismManager.Controllers
{
    public class ClientsController : Controller
    {
        private readonly MyDbContext _context;
        private readonly IMapper _mapper;

        public ClientsController(MyDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        [HttpGet(Name = "get-clients-list")]
        public ActionResult<List<ClientDataDto>> GetClientsList()
        {
            return Ok(_context.Clients.ToList());
        }

        [HttpPost(Name = "create-new-client")]
        public ActionResult CreateNewClient([FromBody] ClientDataDto clientData)
        {
            var resultData = _mapper.Map<ClientDataDto, ClientData>(clientData);
            _context.Clients.Add(resultData);
            _context.SaveChanges();
            return Ok();
        }

        [HttpPut(Name = "update-client")]
        public ActionResult UpdateClient(Guid clientId, [FromBody] ClientDataDto clientData)
        {
            var client = _context.Clients.FirstOrDefault(e => e.ClientId == clientId);
            if (client == null)
            {
                return NotFound();
            }
            client = _mapper.Map<ClientDataDto, ClientData>(clientData);   
            _context.SaveChanges();
            return Ok();
        }

        [HttpDelete(Name = "delete-client")]
        public ActionResult DeleteClient(Guid clientId)
        {
            var client = _context.Clients.FirstOrDefault(e => e.ClientId == clientId);
            if (client == null)
            {
                return NotFound();
            }
            _context.Clients.Remove(client);
            _context.SaveChanges();
            return NoContent();
        }

        [HttpPost(Name = "add-balance")]
        public ActionResult AddBalance(Guid clientId, Decimal amount)
        {
            var client = _context.Clients.FirstOrDefault(e => e.ClientId == clientId);
            if (client == null)
            {
                return NotFound();
            }
            var oldBalnce = client.Balance;
            client.Balance = oldBalnce + amount;
            _context.SaveChanges();
            return NoContent();
        }

        [HttpPost(Name = "create-clients-set")]
        public ActionResult CreateClientsSet([FromBody] List<PeopleSetDto> peopleSet)
        {
            var maxId = _context.PeopleSets.Max(set => set.SetId);
            foreach (var person in peopleSet)
            {
                var personData = _mapper.Map<PeopleSetDto, PeopleSetData>(person);
                personData.SetId = maxId + 1;
                _context.Add(personData);               
            }
            _context.SaveChanges();
            return NoContent();
        }
    }
}
