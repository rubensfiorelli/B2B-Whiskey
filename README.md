# API B2B-Whiskey

Api objeto de estudo bem completa, esta faltando implementar as Controller, decidi iniciar outro projeto por isso parei. Mas esse estudo esta bacana porque estou usando as melhores praticas para construir a API robusta, segura e com a camada de dados completamente desacoplada para o consumidor ter a liberdade de usar a plataforma de dados que quiser.

Tecnologias e padraos aplicados ao projeto:

- Arquitetura em camadas (5 camadas)
- Inversao de controles
- Padrao Repository
- SOLID totalmente respeitado
- Event Sourcing
- Unit of Work
- Classes ricas e com validacçoes e comportamentos no dominio
- Dominio Agregado
- CQRS sem uso do MediatR
- Consultas compiladas no EF 7
- Pool de DBContext EF 7
- Fliente Api
- Camada de ifraestrutura IoC (Api nao tem acesso ao domínio de forma alguma)
- 100% acesso a dados atraves de interfaces
- value objects
- Notifications & Validations

- ORM - Obviamente o melhor EF 7
- Database: MySql
- Linguagem 100% C#
- Libs: Microsoft Dependency Injection, MediatR(parcialmente usado 1 classo do produto)
- IDE: Obviamente Visual Studio (Visual Code tem muuuito problema, dispenso, obriogado)
- 
