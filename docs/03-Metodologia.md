
# Metodologia
A abordagem metodológica aplicada é fundamentada na metodologia Ágil Scrum, dada a sua colaboração, eficácia e eficiência na execução do projeto. O Scrum busca uma melhor organização das equipes de trabalho e uma fragmentação das tarefas, distribuindo-se de forma a proporcionar maior eficiência no processo de desenvolvimento, com base na entrega do produto de maneira incremental, ou seja, em etapas curtas e regulares conhecidas como corrida. Além dos sprints, o Scrum é composto por artistas (backlog do produto), reuniões regulares e divisões de funções

## Controle de Versão


| Foto | Especificação |
| ------ | -------------- |
![TRUNK BASED](</docs/img/GITFLOW.png>) | imagem do desenvolvimento baseado em tronco
o desenvolvimento baseado em trunk é uma metodologia para lançar novos recursos e pequenas mudanças rapidamente, ao mesmo tempo que ajuda a evitar longas correções de bugs e "merge hell".

A ferramenta de controle de versão adotada no projeto foi o
[Git](https://git-scm.com/), sendo que o [Github](https://github.com)
foi utilizado para hospedagem do repositório.
O projeto segue a seguinte convenção para o nome de branches:

- `master`: versão estável já testada do software
- `dev`: versão de desenvolvimento do software

 o projeto adota a seguinte convenção para
etiquetas das issues:

- `documentation`: melhorias ou acréscimos à documentação
- `bug`: uma funcionalidade encontra-se com problemas
- `enhancement`: uma funcionalidade precisa ser melhorada
- `feature`: uma nova funcionalidade precisa ser introduzida



## Gerenciamento de Projeto

### Divisão de Papéis
Com base na metodologia escolhida foi definida a divisão dos papéis da seguinte forma:

Scrum Master: Lucas Antonio Riboli
Product Owner: Victor Ornelas da Silva

Equipe de Desenvolvimento : Andryel Passos, Fabio Vinícius Barkoski, Gustavo Marques, João Pedro, Lucas Antonio Riboli, Thiago Luiz e Victor Ornelas da Silva.

Equipe de Design : Andryel Passos, Fabio Vinícius Barkoski, Gustavo Marques, João Pedro, Lucas Antonio Riboli, Thiago Luiz e Victor Ornelas da Silva.

Equipe de Testes : Andryel Passos, Fabio Vinícius Barkoski, Gustavo Marques, João Pedro, Lucas Antonio Riboli, Thiago Luiz e Victor Ornelas da Silva.

### Processo

A equipe é especificada por meio de reuniões semanais para discutir as tarefas e dividir as ações a serem realizadas. Utilizamos as ferramentas Teams e o Whatsaap para nos comunicarmos. Por fim, decidimos usar o Github Project para organizar, dividir e especificar cada tarefa a ser executada por cada membro, com base na seguinte lista:

Product Backlog: Recebe as tarefas a serem trabalhadas e representa o Product Backlog. Todas as atividades identificadas no decorrer do projeto também deverão ser incluídas nesta lista.

To Do: Esta lista representa o Sprint Backlog. Este é o Sprint atual que estamos trabalhando.

Pronto para trabalhar: Tarefas que já estão completamente descritas e livres de impedimentos para serem trabalhadas são enviadas para essa lista pelo Scrum Master

Em andamento: Quando uma tarefa foi iniciada, ela é movida para cá.

Dev Complete: As terefas que foram finalizadas são movidas para essa lista, onde passam a ser revisadas e testadas.

Concluído: nesta lista são colocadas as tarefas que passaram pelos testes e controle de qualidade e estão prontas para serem entregues ao usuário. Não há mais edições ou revisões possíveis, ele está agendado e pronto para a ação.


| Foto | Especificação |
| ------ | -------------- |
![kanban](</docs/img/Kanban git hub.png>) | imagem do quadro Kanban 



### Etapa 1 e 2

A etapa 1 e 3 foram realizadas entre os dias 20 de fevereiro de 2024 e 14 de abril de 2024, e teve os seguintes entregáveis:
- Documentação de contexto
- Especificação de projeto
- Metodologia
- Projeto de Interface
- Arquitetura da Solução
- Modelo Padrão da Aplicação
- Plano de Testes de Software
- Plano de Testes de Usabilidade

#### Planejamento:

- Requisitos funcionais e não funcionais 
- Personas
- Restrições 
- Diagrama de casos de uso
- Wireframe
- Diagrama de fluxo
- Plano de teste de software 
- Diagrama de classes 
- Modelo entidade relacionamento
- Base de dados 
- Vídeo sobre o poblema e a solução proposta
- Documentação da metodologia 
- Documentação do contexto

#### Execução:
Aqui foram planejadas e elaboradas as ideias do projeto, avaliando e executando os requisitos pedidos no trabalho . O grupo se reuniu através das plataformas Teams e WhatsApp para discutir as ideias, fazer planejamentos e definir horários para a realização das tarefas. Várias ideias foram sugeridas antes de entrarmos em comum acordo, escolhendo assim a melhor ideia de projeto.

Nessa etapa foram feitas as partes citadas anteriormente no planejamento. Dividimos as tarefas durante as reuniões semanais feitas na terça-feira e quinta-feira à noite utilizando a plataforma Teams. As tarefas foram divididas entre o grupo mediante a disponibilidade e familiaridade de cada um com algumas ferramentas. Todos tiveram participação na execução do projeto e nas discussões surgidas ao longo da etapa.

#### Evidências e ferramentas
| captura de tela | Especificação |
| ------ | -------------- |
![teams](</docs/img/teams.jpg>) |  imagem do teams 

| captura de tela | Especificação |
| ------ | -------------- |
![diagrama](</docs/img/Diagrama de classe.jpg>) | imagem do diagrama de classe

| captura de tela| Especificação |
| ------ | -------------- |
![diagrama](</docs/img/Diagrama de cadastro usuário.png>) | imagem do diagrama de fluxo

| captura de tela | Especificação |
| ------ | -------------- |
![wireframe](</docs/img/wireframee.jpg>) | wireframe da tela de login/cadastro


### Etapa 3

A etapa 3 foi realizada de 15/04/24 a 12/05/24, e teve os seguintes entregáveis:
- POC 
- Endpoints de login
- Endpoins de repositorio
- Tela de login

#### Execução:

Durante esta etapa de desenvolvimento, usamos .NET e Vue.js para construir uma aplicação web. Começamos configurando o ambiente e desenvolvendo os principais endpoints da API, incluindo autenticação e gestão de repositórios. Paralelamente, realizamos sessões de explicação sobre conceitos de API e aplicativos web. Isso nos deu uma base sólida para criar uma aplicação integrando eficientemente o frontend e o backend.

Vale ressaltar que tivemos alguns problemas no decorrer do desenvolvimento por conta da forte enchente que atingiu o Rio Grande do Sul, tendo 2 integrantes do grupo atingidos indiretamente com o desastre, ficamos alguns períodos sem internet e/ou luz, além de estarmos prestando ajuda também ao estado que está em estado de calamidade. 

### Etapa 4

A etapa 4 foi realizada de 13/05/24 a 09/06/24, e teve os seguintes entregáveis:
- Template padrão da aplicação interativa
- Programação de Funcionalidades
- Realização e registro dos testes de software
- Realização e registro dos testes de usabilidade

Durante esta etapa de desenvolvimento, foram criadas as telas de cadastro, principal e de login. Além disso, registramos os testes de software e de usabilidade. Contudo, houve problemas com as entregas, o que nos levou a mudar o escopo do projeto e reduzir as funcionalidades previstas.

### Etapa 5 

A etapa 5 foi realizada de 10/06/24 a 23/06/24, e teve os seguintes entregáveis:
- Relatório do teste de software
- Relatório do teste de usabilidade
- Apresentação da solução
- Projeto do Github com Backlog e Plano de Sprints
- Vídeo de até 3 minutos

Durante esta etapa do desenvolvimento, entregamos o Relatório do Teste de Software, o Relatório do Teste de Usabilidade, e a Apresentação da Solução. Além disso, organizamos o projeto no Github com backlog e plano de sprints, e produzimos um vídeo de até 3 minutos, além disso revisamos todos os documentos do projeto. Essas entregas garantiram a documentação completa e a qualidade do projeto.

### Ferramentas

As ferramentas empregadas no projeto são:

- Visual Studio
- Microsoft Teams
- Lucidchart (criação de diagramas)
- Excalidraw (criação de wireframe)
- Miro (criação de diagramas)
- DrawIo (criação de diagramas)
- .NET
- Vue Js

O editor de código foi escolhido porque ele possui uma integração com o sistema de versão, além de possuir extensão .NET que é essencial para o desenvolvimento da aplicação C#. As ferramentas de comunicação utilizadas possuem integração semelhante e são recomendada pela universidade, por isso foram selecionadas. Por fim, para criar diagramas utilizamos as ferramentas que melhor captaram as necessidades da nossa solução. Para criação do wireframe a ferramenta foi escolhida por permitir a edição colaborativa.

