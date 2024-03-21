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
  
1.
 ![image](https://github.com/michigantsev/Architecture/assets/63182310/4d13e31b-4ee0-4d45-bff0-c4541568ac8e)
![image](https://github.com/michigantsev/Architecture/assets/63182310/d534234d-4000-437e-bc8a-9fb6554ef860)

2. 
![image](https://github.com/michigantsev/Architecture/assets/63182310/b8248c0d-536d-47e2-aad7-9c29785e95a8)
![image](https://github.com/michigantsev/Architecture/assets/63182310/20aa63d9-8e3d-4641-b8de-9a5686f7b1b9)  

3.  
![image](https://github.com/michigantsev/Architecture/assets/63182310/6a67d2ae-88ca-40d5-bbf7-9c93536f583e)  
![image](https://github.com/michigantsev/Architecture/assets/63182310/e7a7310e-b63c-4b4e-b5ba-aa3eabffaae8)

4.  
![image](https://github.com/michigantsev/Architecture/assets/63182310/0c4f0bd2-92b1-4c9a-ae5d-4e8a7d4933bf)
![image](https://github.com/michigantsev/Architecture/assets/63182310/d8588997-f601-49a2-a0b1-210250366461)  

5.  
![image](https://github.com/michigantsev/Architecture/assets/63182310/a5c5781c-243f-4d9b-b8a1-f5b8703616ce)  
![image](https://github.com/michigantsev/Architecture/assets/63182310/ad890700-da9e-4877-995c-8053fd57c3e0)

6.  
![image](https://github.com/michigantsev/Architecture/assets/63182310/b29596a3-c3ed-4c6b-ae82-a8e503d5ac01)  
![image](https://github.com/michigantsev/Architecture/assets/63182310/90f4f1a0-1a2c-4cfa-aa0c-d480b0c43599)





