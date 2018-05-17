// Ficheiro JavaScript de funções de acesso a dados


/***********************  NATIONS  *************************/


// função que vai obter a lista das categorias 
function getCategorias() {
    var url = "../api/Nations";

    return fetch(url, { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Error!"));
            }
        });
} // getCategorias()