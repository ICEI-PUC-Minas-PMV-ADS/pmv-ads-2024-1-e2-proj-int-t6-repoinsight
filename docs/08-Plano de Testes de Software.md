# Plano de Testes de Software

| Caso de Teste  |                    CT-01 – Sign Up e Sign In               |
|---|---|
| Requisitos Associados | RF-001|
|Objetivo| Verificar se o processo de registro (Sign Up) e login (Sign In) estão funcionando corretamente.|
|Passos|1-      Acessar o navegador. <br> 2-      Informar o endereço do site.  <br> 3-      Clicar no botão "Registrar".  <br> 4-      Preencher o formulário com um e-mail e senha válidos.  <br> 5-      Verificar se é redirecionado para a tela de Sign In. <br> 6-      Preencher o formulário de Sign In com o e-mail e senha cadastrados.<br> 7-      Enviar o formulário. <br> 8-      Verificar se é redirecionado para a tela Home.|
Critérios de Êxito| - O usuário deve ser capaz de se registrar com sucesso. <br> - O usuário deve ser capaz de fazer login após o registro. <br> - Os redirecionamentos devem funcionar conforme o esperado, garantindo que o usuário seja direcionado para as telas corretas após o registro e o login, conforme o fluxo esperado da aplicação. |


| Caso de Teste  |     CT-02 – Gestor de Repositórios - Adicionar Repositório  |
|---|---|
| Requisitos Associados | RF-002|
|Objetivo| Verificar se é possível adicionar um repositório corretamente usando o Gestor de Repositórios.|
|Passos|1-       Logar na plataforma. <br> 2-       Acessar a tela Home. <br> 3-       Clicar na opção "Adicionar Repositório". <br> 4-       Preencher o campo de URL do repositório com uma URL válida. <br> 5-       Confirmar a adição do repositório. <br> 6-       Verificar se o repositório foi adicionado corretamente na lista de repositórios.|
|Critérios de Êxito| - O usuário deve ser capaz de adicionar um repositório com sucesso.<br> - O repositório adicionado deve aparecer na lista de repositórios da plataforma, garantindo que o usuário possa visualizá-lo facilmente após a adição. |

| Caso de Teste  |  CT-03 – Tela Repositório - Seleção de Modo de Visualização |
|---|---|
| Requisitos Associados | RF-003, RF-004, RF-005,  RF-007,  RF-008,  RF-009|
|Objetivo| Verificar se o usuário pode selecionar corretamente o modo de visualização na Tela Repositório.|
|Passos|1-       Logar na plataforma. <br> 2-       Acessar a tela de um repositório específico. <br> 3-       Na tabela de repositório e usuários, selecionar uma tag de repositório. <br> 4-       Verificar se as métricas e commits/PRs relacionados ao repositório são exibidos. <br> 5-       Na tabela de repositório e usuários, selecionar uma tag de usuário. <br> 6-       Verificar se as métricas e commits/PRs relacionados ao usuário são exibidos.|
|Critérios de Êxito| - O usuário deve ser capaz de selecionar corretamente as tags de repositório e usuário. <br> - As métricas e commits/PRs relacionados devem ser exibidos corretamente de acordo com a tag selecionada.|

