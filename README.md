# Claro
Desafio Hitss 2020
 
Proposta 
A Claro vai lançar um novo app para venda de celulares e com isso gostaríamos que você construa uma API para fornecer somente a consulta e cadastro de novos celulares.
 
Solução:
A solução consistirá em criar uma API REST, com duas rotas, a especificação da api encontra-se logo abaixo. Basicamente essa rota listará todos os celulares cadastrados da Claro.
 
Arquitetura:
 
-> Banco de dados - Qualquer um, inclusive nosql;
-> Backend – C#;
-> Frontend  - Escolha do candidato (Pode utilizar html + Ajax);
 
Bonus: 
 
-> Autenticação (JWT)
-> Uso de ORM (Nhibernate, Dapper ou Entity)
-> Teste Unitário do API REST
-> Swagger;
 
Especificação da API:

POST /claro/mobile
Esse método deve receber um celular novo e inseri-lo em um banco de dados para ser consumido pela própria API.
{
   "price":1990,
   "model":"Moto G5 Plus",
   "brand":"Motorola",
   "photo":"http://www3.claro.com.br/sites/default/files/claro-net-simples_5654b06692637-224x170_565c9453ee1bf.png",
   "date":"26/11/2015"
}
Campo	Tipo
model	String
price	int
brand	String
photo	String
date	String

GET /claro/mobile
Esse método da API deve retornar o seguinte JSON.
[{
 "price":1990,
 "code": "653d9688-af26-4ff1-b1a6-58c474fba27f",
 "model":"Moto G5 Plus",
 "brand":"Motorola",
 "photo":"http://www3.claro.com.br/sites/default/files/claro-net-simples_5654b06692637-224x170_565c9453ee1bf.png",
 "date":"26/11/2015"
},{
 "price":3990,
 "code": "d10e528f-9f2c-4271-9dc1-967bef224695",
 "model":"IPhone 7 Plus",
 "brand":"Apple",
 "photo":"http://www3.claro.com.br/sites/default/files/claro-net-simples_5654b06692637-224x170_565c9453ee1bf.png",
 "date":"25/12/2015"
},{
 "price":699,
 "code": "ba59f136-9d1f-42bf-8f4a-826dca8dde5b",
 "model":"J7",
 "brand":"Samsung",
 "photo":"http://www3.claro.com.br/sites/default/files/claro-net-simples_5654b06692637-224x170_565c9453ee1bf.png",
 "date":"01/11/2015"
}]
Campo	Tipo
model	String
price	int
code	String
brand	String
photo	String
date	String
 

GET /claro/mobile/{code}
Esse método deve retornar um celular específico.
{
 "price":699,
 "code": "ba59f136-9d1f-42bf-8f4a-826dca8dde5b",
 "model":"J7",
 "brand":"Samsung",
 "photo":"http://www3.claro.com.br/sites/default/files/claro-net-simples_5654b06692637-224x170_565c9453ee1bf.png",
 "date":"01/11/2015"
}
Campo	Tipo
model	String
price	int
code	String
brand	String
photo	String
date	String
 
PUT /claro/mobile/{code}
Esse método deve receber um celular existente e altera-lo no banco de dados.
{
   "price":1990,
   "model":"Moto G5 Plus",
   "brand":"Motorola",
   "photo":"http://www3.claro.com.br/sites/default/files/claro-net-simples_5654b06692637-224x170_565c9453ee1bf.png",
   "date":"26/11/2015"
}
Campo	Tipo
model	String
price	int
brand	String
photo	String
date	String


DELETE /claro/mobile/{code}
Esse método deve excluir um celular específico.

