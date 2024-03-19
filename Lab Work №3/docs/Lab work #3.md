Диаграмма компонентов  
Диаграмма компонентов для варианта использования "Создать записи на оказание услуги". Администратор системы задает основные данные об услуге, при необходимсоти выбирает исполнителя, выбирает записывающегося на услугу клиента(при необходимости создает нового). У этого клиента проверяется баланс на возможность оплаты услуги.
![image](https://github.com/michigantsev/Architecture/assets/63182310/e5a7dfdc-151f-4d8e-890a-beaed1c94836)  
Диаграмма последовательностей  
В результате сообщение об успешном создании или недостаточном балансе  
![image](https://github.com/michigantsev/Architecture/assets/63182310/2b0c3acd-4145-4b24-8402-5e4715764480)  
Модель БД  
![image](https://github.com/michigantsev/Architecture/assets/63182310/21c58351-3fef-4c97-9d22-15087f1996c9)  
KISS -- использование простых методов там, где это возможно:  
```
        [HttpGet(Name = "get-clients-list")]
        public ActionResult<List<ClientDataDto>> GetClientsList()
        {
            return Ok(_context.Clients.ToList());
        }
```  
DRY -- использование маппера, вместо повторяещегося присваивания полей:  
```
private readonly IMapper _mapper;

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
```
