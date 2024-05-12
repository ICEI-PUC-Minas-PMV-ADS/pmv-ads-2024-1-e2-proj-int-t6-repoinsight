document.getElementById('repoForm').addEventListener('submit', function(event) {
    event.preventDefault();
  
    const formData = new FormData(event.target);
    const formDataObject = Object.fromEntries(formData.entries());
  
    formDataObject.watch = false;
    formDataObject.favorito = false;
  
    fetch('http://localhost:3000/repos', {
      method: 'POST',
      headers: {
        'Content-Type': 'application/json'
      },
      body: JSON.stringify(formDataObject)
    })
    .then(response => response.json())
    .then(data => {
      console.log('Sucesso:', data);
    })
    .catch((error) => {
      console.error('Erro:', error);
    });
  });

  document.getElementById('listarRepositorios').addEventListener('click', function() {
    fetch('http://localhost:3000/repos')
      .then(response => response.json())
      .then(data => {
        const listaRepositorios = document.getElementById('listaRepositorios');
        listaRepositorios.innerHTML = '';
  
        data.forEach(repo => {
          const repoElement = document.createElement('div');
          repoElement.classList.add('repoItem');
          repoElement.innerHTML = `
            <h3>${repo.nome}</h3>
            <p>Contribuintes: ${repo.qtdContribuintes}</p>
            <p>Branches: ${repo.qtdBranches}</p>
            <p>Commits: ${repo.qtdCommits}</p>
            <p>PRs: ${repo.qtdPrs}</p>
          `;
          listaRepositorios.appendChild(repoElement);
        });
      })
      .catch(error => console.error('Erro ao listar repositórios:', error));
  });