# Plano de Testes de Software

| Caso de Teste  |  CT-01 – Sign Up e Sign In                                   |
|---|---|
|Objetivo| Verificar se o processo de registro (Sign Up) e login (Sign In) estão funcionando corretamente.
|Passos|1-      Acessar o navegador.|
||2-      Informar o endereço do site.| 
||3-      Clicar no botão "Registrar".|
||4-      Preencher o formulário com um e-mail e senha válidos.|
||5-      Verificar se é redirecionado para a tela de Sign In.|
||6-      Preencher o formulário de Sign In com o e-mail e senha cadastrados.|
||7-      Enviar o formulário.|
||7-      Verificar se é redirecionado para a tela Home.|
|Critérios de Êxito| - O usuário deve ser capaz de se registrar com sucesso.|
|| - O usuário deve ser capaz de fazer login após o registro.|
|| - Os redirecionamentos devem funcionar conforme o esperado.|

| Caso de Teste  |  CT-02 – Gestor de Repositórios - Adicionar Repositório        |
|---|---|
|Objetivo| Verificar se é possível adicionar um repositório corretamente usando o Gestor de Repositórios.
|Passos|1-      Logar na plataforma.|
||2-      Acessar a tela Home.|
||3-      Clicar na opção "Adicionar Repositório".|
||4-      Preencher o campo de URL do repositório com uma URL válida.|
||5-      Confirmar a adição do repositório.|
||6-      Verificar se o repositório foi adicionado corretamente na lista de repositórios.|
|Critérios de Êxito| - O usuário deve ser capaz de adicionar um repositório com sucesso.|
|| - O repositório adicionado deve aparecer na lista de repositórios.|

| Caso de Teste  |  CT-03 – Tela Repositório - Seleção de Modo de Visualização |
|---|---|
|Objetivo| Verificar se o usuário pode selecionar corretamente o modo de visualização na Tela Repositório.
|Passos|1-      Logar na plataforma.|
||2-      Acessar a tela de um repositório específico.|
||3-      Na tabela de repositório e usuários, selecionar uma tag de repositório.|
||4-      Verificar se as métricas e commits/PRs relacionados ao repositório são exibidos.|
||5-      Na tabela de repositório e usuários, selecionar uma tag de usuário.|
||6-      Verificar se as métricas e commits/PRs relacionados ao usuário são exibidos.|
|Critérios de Êxito| - O usuário deve ser capaz de selecionar corretamente as tags de repositório e usuário.|
|| - As métricas e commits/PRs relacionados devem ser exibidos corretamente de acordo com a tag selecionada.|