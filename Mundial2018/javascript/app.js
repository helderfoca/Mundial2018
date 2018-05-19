// Ficheiro JavaScript com a lógica da aplicação

// evento para quando a página está pronta a utilizar
document.addEventListener('DOMContentLoaded', function main() {

    backButton();
    Nations();
    //Players(7);

}); // main()    


/***********************  NATIONS  *************************/


// função que liga o acesso aos dados das nations com a aplicação
function Nations() {
    return getNations()
        .then(function (nations) {
            showNations(nations);
        })
        .catch(function (erro) {
            console.error(erro);
        });
} // Nations()


// função que cria os elementos html para mostrar as nations
function showNations(nations) {
    for (var i = 0; i < nations.length; i++) {

        // uma nation do array
        var nation = nations[i];

        let id = nation.ID;

        // nome da nation
        var nameNation = nation.Name;

        // imagem da nation
        var flag = nation.Flag;

        // contentor para a nation
        var divNation = document.createElement('div');
        var rowNations = document.querySelector('#rowNations');
        rowNations.appendChild(divNation);

        divNation.classList.add("col-sm-6");
        divNation.classList.add("col-lg-3");
        divNation.classList.add("d-flex");
        divNation.classList.add("align-items-stretch");

        // contentor para a card
        var divCard = document.createElement('div');
        divNation.appendChild(divCard);

        divCard.classList.add("card");
        divCard.classList.add("m-3");

        // contentor para a flag da nation
        var containerFlagNation = document.createElement('img')
        divCard.appendChild(containerFlagNation);

        var flagNation = "/Media/Nations/" + flag;

        containerFlagNation.classList.add("card-img-top");
        containerFlagNation.setAttribute('src', flagNation);
        containerFlagNation.setAttribute('alt', "Card header image");
        containerFlagNation.setAttribute('height', '200px');
        containerFlagNation.setAttribute('style', 'object-fit:cover');

        // div para o corpo da card
        var bodyCard = document.createElement('div');
        divCard.appendChild(bodyCard);

        bodyCard.classList.add("card-body");

        // contentor para nome da nation
        var containerNameNation = document.createElement('h5');
        bodyCard.appendChild(containerNameNation)

        containerNameNation.classList.add("card-title");
        containerNameNation.textContent = nameNation;

        // evento para ir para os players da nation ao clicar numa nation
        divCard.addEventListener('click', function goToPlayer() {
            nationToPlayer(id);
        });

    } // showNations(nations)
}

/************************  PLAYERS  *************************/


// função que liga o acesso aos dados dos players de uma nation com a aplicação
function Players(nation) {
    return getPlayers(nation)
        .then(function (players) {
            showPlayers(players);
        })
        .catch(function (erro) {
            console.error(erro);
        });
} // Players(nation)


// função que cria os elementos html para os players de uma nation
function showPlayers(players) {
    for (var i = 0; i < players.length; i++) {

        // um player do array
        var player = players[i];

        // id do player
        var id = player.id;

        // nome do player
        var namePlayer = player.Name;

        // imagem do player
        var imgPlayer = player.Image;

        //contentor para o player
        var divPlayers = document.createElement('div');
        var rowPlayers = document.querySelector('#rowPlayers');
        rowPlayers.appendChild(divPlayers);

        divPlayers.classList.add("col-sm-6");
        divPlayers.classList.add("col-lg-3");

        // contentor para a card
        var divCard = document.createElement('div');
        divPlayers.appendChild(divCard);

        divCard.classList.add("card");
        divCard.classList.add("m-3");

        // contentor para a imagem do piloto
        var containerImgPlayer = document.createElement('img')
        divCard.appendChild(containerImgPlayer);

        var urlImgPlayer = "/Media/Players/" + imgPlayer;

        containerImgPlayer.classList.add("card-img-top");
        containerImgPlayer.setAttribute('src', urlImgPlayer);
        containerImgPlayer.setAttribute('alt', "Card header image");
        containerImgPlayer.setAttribute('height', '400px');
        containerImgPlayer.setAttribute('style', 'object-fit:cover');

        // div para o corpo da card
        var bodyCard = document.createElement('div');
        divCard.appendChild(bodyCard);
        bodyCard.classList.add("card-body");

        // contentor para nome do player
        var containerNamePlayer = document.createElement('h5');
        bodyCard.appendChild(containerNamePlayer);

        containerNamePlayer.classList.add("card-title");
        containerNamePlayer.textContent = namePlayer;
    }
} // showPlayers(players)

/************************  NATION -> PLAYER  *************************/


// esconde o ecrã das nations e mostra o ecrã dos players de uma nation
function nationToPlayer(nation) {

    // esconde o ecrã das nations
    var nations = document.querySelector('#nations');
    nations.setAttribute('style', 'display:none');

    // cria o ecrã dos players da nation
    Players(nation);

    // mostra o butão
    var btn = document.querySelector('#btn');
    btn.setAttribute('style', 'display:block');

    // localiza o ecrã atual
    btn.removeAttribute('data-btnLocal');
    btn.setAttribute('data-btnLocal', 'players');

} // nationToPlayer(nation)

/*********************  BACK BUTTON  ************************/


function backButton() {

    var btn = document.querySelector('#btn');

    // localiza o ecrã atual
    btn.setAttribute('data-btnLocal', 'nations');

    // esconde o butão
    btn.setAttribute('style', 'display:none');

    //evento do butão
    btn.addEventListener('click', function goBack() {
        // remove os elementos do ecrã em que se encontra e mostra o ecrã anterior
        if (btn.getAttribute('data-btnLocal') == 'details') {
            removeDetalhes();
        } else {
            removePlayers();
        }
    });
    //var topbar = document.querySelector('#topbar');
    //topbar.appendChild(btn);
} // backButton()

// remove os players e mostra as nations
function removePlayers() {

    // localiza o ecrã atual
    var btn = document.querySelector('#btn');
    btn.removeAttribute('data-btnLocal');
    btn.setAttribute('data-btnLocal', 'nations');

    // mostra o ecrã das nations
    var nations = document.querySelector('#nations');
    nations.setAttribute('style', 'display:block');

    // remove os players
    var rowPlayers = document.querySelector('#rowPlayers');
    while (rowPlayers.hasChildNodes()) {
        rowPlayers.removeChild(rowPlayers.firstChild);
    }

    // esconde o butão
    btn.setAttribute('style', 'display:none');

} // removePlayers()