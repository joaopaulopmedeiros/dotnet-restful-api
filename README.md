# .NET Core Restful API

## Objetivo
Restful web api desenvolvida em .NET Core. Este projeto serve de exemplo para estudo de design patterns e boas práticas em especial para devs júniores.

## Arquitetura
- Application: interceptação de requests e devolução de resposta http;
- Presentation: camada intermediária que prepara o formato de dados e simplifica o uso da camada de negócios pela aplicação;
- Domain: contém regra de negócios, utiliza service-repository pattern;
- Infra: realiza conexões com banco de dados (ajuda a trazer o baixo acoplamento entre código de regra de negócios e os detalhes de implementação para persistir os dados) 
- Tests: testes automatizados;

## Documentação dinâmica da API
<img src=".github/images/swagger.png"/>
