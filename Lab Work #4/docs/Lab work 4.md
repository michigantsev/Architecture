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
