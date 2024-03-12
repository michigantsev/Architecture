POST -- создать клиента  
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
  
PUT -- редактировать клиента  
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
В результате код 200 при успешном создании или 422, если существует запись с таким же паспортом/номером  

DELETE -- удалить клиента
В параметрах передается ID удаляемого клиента  
В результате код 204  
  
GET -- получить список клиентов  
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
