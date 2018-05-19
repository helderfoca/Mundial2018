// Ficheiro JavaScript de funções de acesso a dados


/***********************  NATIONS  *************************/


// função que vai obter a lista das nations 
function getNations() {
    var url = "/api/Nations";

    return fetch(url, { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Error!"));
            }
        });
} // getNations()

// função que vai obter os players de uma nation
function getPlayers(idNation) {
    var url = "/api/Nations/";
    url += idNation;
    url += "/Players";

    return fetch(url, { headers: { Accept: 'application/json' } })
        .then(function (resposta) {
            if (resposta.status === 200) {
                return resposta.json();
            } else {
                return Promise.reject(new Error("Erro!"));
            }
        });
} // getPlayers(idNation)