# Repositório de Avaliação de Conceito
## O que é uma Avaliação de Conceito
A Avaliação de Conceito, ou POC (Proof of Concept, em inglês), é uma prática comum no mundo da tecnologia e dos negócios. Consiste em desenvolver uma demonstração ou protótipo inicial para validar a viabilidade de uma ideia, conceito ou abordagem. A POC é realizada antes do desenvolvimento completo de um projeto, servindo como um teste preliminar para verificar se a ideia funciona na prática e se justifica um investimento maior de recursos.

## Como faremos a Avaliação de Conceito
A Avaliação de Conceito proposta consistirá na criação de um aplicativo em C#. Este aplicativo terá um método GET que retornará um simples "Hello World". Esse método será chamado por uma página HTML estática que realizará a requisição ao endpoint e exibirá.

## Executando a Avaliação de Conceito
Para executar a Avaliação de Conceito, será necessario ter o docker instalado em sua maquina e executar alguns comandos:
- Navegar até o codigo da POC:
`cd .\presentation\pocApi\`
- Realizar dois comandos para subir o banco de dados:
`docker run -e "ACCEPT_EULA=Y" -e "MSSQL_SA_PASSWORD=<YourStrong@Passw0rd>" -p 1433:1433 --name sqlPoc --hostname sqlPoc -d mcr.microsoft.com/mssql/server:2022-latest`
&
`dotnet ef database update`
- Após isso basta executar sua aplicação donet com:
`dotnet run`

Em seguida, abra a página HTML na raiz da pasta "POC" e clique em "Fazer Requisição".


## Resultados Após a Avaliação de Conceito
- Confirmaremos a viabilidade do projeto.
- O método proposto para nossa API demonstra-se satisfatório.
- Validaremos a integração com outras tecnologias e sistemas necessários para o sucesso do projeto.
- Estabeleceremos métricas de desempenho para monitorar e avaliar o desempenho da aplicação em produção.
- Refinaremos a arquitetura e a estrutura do código com base nos aprendizados obtidos durante a Avaliação de Conceito.