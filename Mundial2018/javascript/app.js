// Ficheiro JavaScript com a lógica da aplicação

// evento para quando a página está pronta a utilizar
document.addEventListener('DOMContentLoaded', function main() {

    backButton();
    Nations();
    //PlayerDetails(1);

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
        divNation.classList.add("col-lg-4");
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
        //divCard.addEventListener('click', function goToPlayer() {
        //    nationToPlayer(id);
        //});

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
        let id = player.ID;

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

        //evento para ir para os players da nation ao clicar numa nation
        divCard.addEventListener('click', function goToDetails() {
            playerToDetails(id);
        });

    }
} // showPlayers(players)

/************************  PLAYER DETAILS  *************************/


// função que liga o acesso aos dados dos detalhes de um player de uma nation com a aplicação
function PlayerDetails(player) {
    return getPlayerDetails(player)
        .then(function (playerDetails) {
            showPlayerDetails(playerDetails);
        })
        .catch(function (erro) {
            console.error(erro);
        });
} // PlayerDetails(player)


// função que cria os elementos html para os players de uma nation
function showPlayerDetails(playerDetails) {

    // contentor para os detalhes de um player
    var details = document.querySelector('#playersDetails');

    // nome do player
    var playerName = playerDetails.Name;

    // imagem do player
    var playerImg = playerDetails.Image;

    // data de nascimento do player
    var playerBirthday = playerDetails.BirthDate;

    // posição do player
    var playerPosition = playerDetails.Position;

    // introdução da wikipedia do player
    var playerIntro = playerDetails.Introduction;

    // contentor para o nome do player
    var containerPlayerName = document.createElement('p');
    details.appendChild(containerPlayerName);

    containerPlayerName.textContent= playerName;

    // contentor para a data de nascimento do player
    var containerPlayerBirthday = document.createElement('p');
    details.appendChild(containerPlayerBirthday);

    containerPlayerBirthday.textContent = playerBirthday

    // contentor para a posição do player
    var containerPlayerPosition = document.createElement('p');
    details.appendChild(containerPlayerPosition);

    containerPlayerPosition.textContent = playerPosition;

    // contentor para a introdução do player
    var containerPlayerIntro = document.createElement('p');
    details.appendChild(containerPlayerIntro);

    containerPlayerIntro.textContent = playerIntro;
    
    // contentor para a imagem do player
    var containerPlayerImg = document.createElement('img');
    details.appendChild(containerPlayerImg);
    
    var urlplayerImg = "/Media/Players/" + playerImg;

    containerPlayerImg.setAttribute('src', urlplayerImg);

} // showPlayerDetails(playerDetails)


/************************  NATION -> PLAYER  *************************/


// esconde o ecrã das nations e mostra o ecrã dos players de uma nation
function nationToPlayer() {

    // esconde o ecrã das nations
    var nations = document.querySelector('#nations');
    nations.setAttribute('style', 'display:none');

    // cria o ecrã dos players da nation
    Players(7);

    // mostra o butão
    var btn = document.querySelector('#btn');
    btn.setAttribute('style', 'display:block');

    // localiza o ecrã atual
    btn.removeAttribute('data-btnLocal');
    btn.setAttribute('data-btnLocal', 'players');

} // nationToPlayer(nation)

/************************  PLAYER -> DETAILS  *************************/


// esconde o ecrã das nations e mostra o ecrã dos players de uma nation
function playerToDetails(player) {

    // esconde o ecrã dos players
    var players = document.querySelector('#players');
    players.setAttribute('style', 'display:none');

    // cria o ecrã dos players da nation
    PlayerDetails(player)

    // mostra o butão
    var btn = document.querySelector('#btn');
    btn.setAttribute('style', 'display:block');

    // localiza o ecrã atual
    btn.removeAttribute('data-btnLocal');
    btn.setAttribute('data-btnLocal', 'details');

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

// remove os players e mostra as nations
function removeDetalhes() {

    // localiza o ecrã atual
    var btn = document.querySelector('#btn');
    btn.removeAttribute('data-btnLocal');
    btn.setAttribute('data-btnLocal', 'details');

    // mostra o ecrã dos players
    var players = document.querySelector('#players');
    players.setAttribute('style', 'display:block');

    // remove os detalhes
    var det = document.querySelector('#playersDetails');
    while (det.hasChildNodes()) {
        det.removeChild(det.firstChild);
    }

    // esconde o butão
    btn.setAttribute('style', 'display:none');

} // removePlayers()

// clica em Racing Legends para ir para o ecrã das categorias
function goNations() {

    var btn = document.querySelector('#btn');

    // se estiver no ecrã dos detalhes apaga os detalhes e os pilotos e mostra as categorias
    if (btn.getAttribute('data-btnLocal') == 'details') {
        removeDetalhes();
    }
    // se estiver no ecrã dos pilotos apaga os pilotos e mostra as categorias
    if (btn.getAttribute('data-btnLocal') == 'players') {
        removePlayers();
    }

} // goNations() 