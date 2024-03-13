**1. POST -- создать клиента**  
В теле запроса передается JSON-файл с данными нового клиента:  
{  
Surname : string,  
Name : string,  
PatrName : string,  
PhoneNumber : string,  
Passport : string,  
RegistrationDate : datetime  
}  
В результате код 201 при успешном создании или 422, если существует запись с таким же паспортом/номером  
  
**2. PUT -- редактировать клиента**  
В параметрах передается ID изменяемого клиента  
В теле запроса передается JSON-файл с данными клиента:    
{  
Surname : string,  
Name : string,  
PatrName : string,  
PhoneNumber : string,  
Passport : string,  
RegistrationDate : datetime  
}  
В результате код 204 при успешном редактировании или 422, если существует запись с таким же паспортом/номером  

**3. DELETE -- удалить клиента**
В параметрах передается ID удаляемого клиента  
В результате код 204  
  
**4. GET -- получить список клиентов**  
В результате массив вида:  
[  
{  
Surname : string,  
Name : string,  
PatrName : string,  
PhoneNumber : string,  
Passport : string,  
RegistrationDate : datetime  
}, ...  
]  
  
**5. POST -- пополнить баланс клиента**  
В параметрах передается ID клиента и сумма пополнения  
В результате код 204.  

**6. POST -- создать услугу**  
В теле запроса передается JSON-файл с данными об услуге:   
{  
Name : string,  
Time : timestamp,  
ClientSetId : Number,  
ExecutorSetId : Number,  
StatusId : Number,  
EquipmentId : Number  
}  
Если на это время уже есть услуга возвращается 422, если нет - 201  

**7. POST -- создать список людей(список для создания услуги)**  
В теле запроса передается массив из ID людей  
В результате 201  
  
**8. POST -- создать водный инвентарь/транспорт**  
В теле запроса передается JSON-файл с данными об инвентаре:   
{  
Name : string  
}  
