# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

João Campos tem 35 anos, é professor formado em Ciência da Computação e leciona nos cursos de tecnologia. Ele utiliza o GitHub em suas aulas, assim consegue ver todas as mudanças realizadas pelos alunos, porém, mesmo fazendo uma divisão em grupos, João precisa de muito tempo para avaliar as mudanças, pois são múltiplas turmas com múltiplos grupos.

Maria Silva tem 40 anos e é professora universitária de Engenharia de Software. Ela ensina disciplinas avançadas de desenvolvimento de software e gerenciamento de projetos. Maria utiliza o GitHub em suas aulas para supervisionar o progresso dos projetos dos alunos. No entanto, ela enfrenta dificuldades para acompanhar todas as contribuições devido ao grande volume de projetos e equipes.

Pedro Oliveira é um professor de 30 anos, formado em Engenharia Elétrica, que ministra disciplinas relacionadas a sistemas embarcados e programação de baixo nível. Ele usa o GitHub como plataforma principal para colaboração e avaliação de projetos práticos de seus alunos. Pedro enfrenta desafios semelhantes aos de João e Maria, pois precisa de uma maneira mais eficiente de avaliar as contribuições dos alunos em vários projetos.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

| EU COMO...`PERSONA` | QUERO/PRECISO ...`O QUE` | PARA ...`MOTIVO`|
|------------|-------------------|----------|
| João Campos  | avaliar os projetos de forma mais objetiva | aumentar minha produtividade |
| Maria Silva  | ter uma visão consolidada das contribuições dos alunos em projetos do GitHub	| facilitar a avaliação e o acompanhamento do progresso dos alunos em suas disciplinas
| Pedro Oliveira  | visualizar as alterações nos projetos dos alunos de forma mais eficiente	| gerenciar melhor o tempo dedicado à avaliação e feedback dos alunos

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A plataforma deve permitir ao usuário cadastrar uma conta. | ALTA | 
|RF-002| A plataforma deve permitir ao usuário fazer login em uma conta. | ALTA | 
|RF-003| O sistema deve ser capaz de sincronizar automaticamente as informações dos repositórios do Git com os perfis dos alunos e professores no sistema de gestão educacional, garantindo que as atualizações sejam refletidas em tempo real. | ALTA |
|RF-004| O sistema deve ser capaz de gerar relatórios automáticos que detalham as atividades realizadas pelos alunos nos repositórios do Git, incluindo commits, pull requests, e issues abertas e fechadas. | MÉDIA |
|RF-005| O sistema deve oferecer uma interface de usuário intuitiva para facilitar a interação dos professores e alunos com as funcionalidades disponíveis na plataforma. | MÉDIA |
|RF-006| O sistema deve permitir aos usuários definirem notificações personalizadas para eventos específicos nos repositórios do Git, como novos commits ou pull requests, para facilitar o acompanhamento das atividades | BAIXA |

> **Prioridade: Alta / Média / Baixa. 

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
| RNF-01 | A aplicação deve ser publicada em um ambiente acessível público na Internet. | ALTA |
| RNF-02 | A aplicação deverá ser responsiva permitindo a visualização em dispositivos diversos de forma adequada. | ALTA |
| RNF-03 | A aplicação deve ser compatível com os navegadores do mercado: Google Chrome, Firefox e Microsoft Edge. | ALTA |
| RNF-04 | A aplicação deve ser intuitiva e dinâmica. | ALTA |
| RNF-05 | Assegurar a privacidade dos usuários conforme a LGPD. | ALTA | 
| RNF-06 | A aplicação deve garantir um tempo de resposta rápido para todas as interações do usuário, visando uma experiência fluida.  | ALTA |

> **Prioridade: Alta / Média / Baixa. 

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |
|02| A equipe de desenvolvimento deve contar com 6 (seis) desenvolvedores |
|03| Deve haver pelo menos 1 (uma) reunião geral por semana, com duração de até 2 (duas) horas |

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
