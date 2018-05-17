// Ficheiro JavaScript com a lógica da aplicação

// evento para quando a página está pronta a utilizar
document.addEventListener('DOMContentLoaded', function main() {

    Nations();

}); // main()    


/***********************  NATIONS  *************************/


// função que liga o acesso aos dados da categoria com a aplicação
function Nations() {
    return getCategorias()
        .then(function (nations) {
            showNations(nations);
        })
        .catch(function (erro) {
            console.error(erro);
        });
} // ecraCategorias()


// função que cria os elementos html para mostrar as seleções
function showNations(nations) {
    for (var i = 0; i < nations.length; i++) {

        // uma seleção do array
        var nation = nations[i];

        divNation = document.querySelector('#divNations');
        var nomeNation = nation.Name;
        console.log(nomeNation);
        var containerNationName = document.createElement('p');
        divNation.appendChild(containerNationName);
        containerNationName.textContent = nomeNation;
    }
}