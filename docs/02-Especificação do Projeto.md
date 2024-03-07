# Especificações do Projeto

<span style="color:red">Pré-requisitos: <a href="1-Documentação de Contexto.md"> Documentação de Contexto</a></span>

Definição do problema e ideia de solução a partir da perspectiva do usuário. É composta pela definição do  diagrama de personas, histórias de usuários, requisitos funcionais e não funcionais além das restrições do projeto.

Apresente uma visão geral do que será abordado nesta parte do documento, enumerando as técnicas e/ou ferramentas utilizadas para realizar a especificações do projeto

## Personas

João Campos tem 35 anos, é professor formado em Ciência da Computação e leciona nos cursos de tecnologia. Ele utiliza o GitHub em suas aulas, assim consegue ver todas as mudanças realizadas pelos alunos, porém, mesmo fazendo uma divisão em grupos, João precisa de muito tempo para avaliar as mudanças, pois são múltiplas turmas com múltiplos grupos.

## Histórias de Usuários

Com base na análise das personas forma identificadas as seguintes histórias de usuários:

| EU COMO... | QUERO/PRECISO ... | PARA ... |
|------------|-------------------|----------|
| Professor  | avaliar os projetos de forma mais objetiva | aumentar minha produtividade |

## Requisitos

As tabelas que se seguem apresentam os requisitos funcionais e não funcionais que detalham o escopo do projeto.

### Requisitos Funcionais

|ID    | Descrição do Requisito  | Prioridade |
|------|-----------------------------------------|----|
|RF-001| A plataforma deve permitir ao usuário cadastrar uma conta | ALTA | 
|RF-002| O sistema deve ser capaz de sincronizar automaticamente as informações dos repositórios do Git com os perfis dos alunos e professores no sistema de gestão educacional, garantindo que as atualizações sejam refletidas em tempo real | ALTA |
|RF-003| O sistema deve ser capaz de gerar relatórios automáticos que detalham as atividades realizadas pelos alunos nos repositórios do Git, incluindo commits, pull requests, e issues abertas e fechadas | MÉDIA |

### Requisitos não Funcionais

|ID     | Descrição do Requisito  |Prioridade |
|-------|-------------------------|----|
| RNF-01 | A aplicação deve ser publicada em um ambiente acessível público na Internet. | ALTA |
| RNF-02 | A aplicação deverá ser responsiva permitindo a visualização em dispositivos diversos de forma adequada. | ALTA |
| RNF-03 | A aplicação deve ser compatível com os navegadores do mercado: Google Chrome, Firefox e Microsoft Edge. | ALTA |
| RNF-04 | A aplicação deve ser intuitiva e dinâmica. | ALTA |
| RNF-05 | Assegurar a privacidade dos usuários conforme a LGPD. | ALTA | 

Com base nas Histórias de Usuário, enumere os requisitos da sua solução. Classifique esses requisitos em dois grupos:

- [Requisitos Funcionais
 (RF)](https://pt.wikipedia.org/wiki/Requisito_funcional):
 correspondem a uma funcionalidade que deve estar presente na
  plataforma (ex: cadastro de usuário).
- [Requisitos Não Funcionais
  (RNF)](https://pt.wikipedia.org/wiki/Requisito_n%C3%A3o_funcional):
  correspondem a uma característica técnica, seja de usabilidade,
  desempenho, confiabilidade, segurança ou outro (ex: suporte a
  dispositivos iOS e Android).
Lembre-se que cada requisito deve corresponder à uma e somente uma
característica alvo da sua solução. Além disso, certifique-se de que
todos os aspectos capturados nas Histórias de Usuário foram cobertos.

## Restrições

O projeto está restrito pelos itens apresentados na tabela a seguir.

|ID| Restrição                                             |
|--|-------------------------------------------------------|
|01| O projeto deverá ser entregue até o final do semestre |


Enumere as restrições à sua solução. Lembre-se de que as restrições geralmente limitam a solução candidata.

> **Links Úteis**:
> - [O que são Requisitos Funcionais e Requisitos Não Funcionais?](https://codificar.com.br/requisitos-funcionais-nao-funcionais/)
> - [O que são requisitos funcionais e requisitos não funcionais?](https://analisederequisitos.com.br/requisitos-funcionais-e-requisitos-nao-funcionais-o-que-sao/)

## Diagrama de Casos de Uso

O diagrama de casos de uso é o próximo passo após a elicitação de requisitos, que utiliza um modelo gráfico e uma tabela com as descrições sucintas dos casos de uso e dos atores. Ele contempla a fronteira do sistema e o detalhamento dos requisitos funcionais com a indicação dos atores, casos de uso e seus relacionamentos. 

As referências abaixo irão auxiliá-lo na geração do artefato “Diagrama de Casos de Uso”.

> **Links Úteis**:
> - [Criando Casos de Uso](https://www.ibm.com/docs/pt-br/elm/6.0?topic=requirements-creating-use-cases)
> - [Como Criar Diagrama de Caso de Uso: Tutorial Passo a Passo](https://gitmind.com/pt/fazer-diagrama-de-caso-uso.html/)
> - [Lucidchart](https://www.lucidchart.com/)
> - [Astah](https://astah.net/)
> - [Diagrams](https://app.diagrams.net/)
