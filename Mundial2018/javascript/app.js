// Ficheiro JavaScript com a lógica da aplicação

// evento para quando a página está pronta a utilizar
document.addEventListener('DOMContentLoaded', function main() {

    // cria o butão
    backButton();
    // mostra o ecrâ das equipas
    Nations();

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

        // id da nation
        let id = nation.ID;

        // nome da nation
        var nameNation = nation.Name;

        // imagem da nation
        var flag = nation.Flag;

        // wins da nation
        let wins = nation.Wins;

        // caption da nation
        let caption = nation.Caption;

        // hino da nation
        let link = nation.Anthem;

        // participations da nation
        let part = nation.Participations;

        // grupo da nation
        let group = nation.Group;

        // contentor para a nation
        var divNation = document.createElement('div');
        var rowNations = document.querySelector('#rowNations');
        rowNations.appendChild(divNation);

        divNation.className = "nat";
        divNation.setAttribute('data-group', group);
        divNation.classList.add("col-sm-6");
        divNation.classList.add("col-lg-4");
        divNation.classList.add("d-flex");
        divNation.classList.add("align-items-stretch");

        // link para o elemento que faz o popUp
        var popUp = document.createElement('a');
        divNation.appendChild(popUp);

        popUp.setAttribute('data-toggle', 'modal');
        popUp.setAttribute('data-target', '#pop');

        // contentor para a card
        var divCard = document.createElement('div');
        popUp.appendChild(divCard);

        divCard.classList.add("card");
        divCard.classList.add("m-3");

        // contentor para a bandeira da nation
        var containerFlagNation = document.createElement('img')
        divCard.appendChild(containerFlagNation);

        // url da imagem da bandeira da nation
        let flagNation = "/Media/Nations/" + flag;

        containerFlagNation.className = "imgNation";
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

        // evento para mostrar o popUp com informações da nation
        popUp.addEventListener('click', function pop() {

            var popUpImg = document.querySelector('#popUpImg');
            var popUpCaption = document.querySelector('#popUpCaption');
            var popUpVideo = document.querySelector('#popUpVideo');
            var p1 = document.querySelector('#popUpWins');
            var p2 = document.querySelector('#popUpPart');

            // atribui a imagem e a caption ao elemento de imagem do popup
            popUpImg.setAttribute('src', flagNation);
            p1.textContent = "Wins: " + wins;
            p2.textContent = "Participations: " + part;
            popUpCaption.textContent = caption;

            // link do video do youtube
            var videoLink = 'https://www.youtube.com/embed/'
            videoLink += link;
            popUpVideo.setAttribute('src', videoLink);

            // torna os elementos visíveis
            popUpVideo.setAttribute('style', 'display:block');
            popUpVideo.classList.add("img-fluid");
            popUpImg.setAttribute('style', 'display:block');
            popUpImg.classList.add("img-fluid");

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

        // contentor para a imagem do player
        var containerImgPlayer = document.createElement('img')
        divCard.appendChild(containerImgPlayer);

        // url da imagem do player
        var urlImgPlayer = "/Media/Players/" + imgPlayer;

        containerImgPlayer.className = "imgPlayer";
        containerImgPlayer.classList.add("card-img-top");
        containerImgPlayer.setAttribute('src', urlImgPlayer);
        containerImgPlayer.setAttribute('alt', "Card header image");

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

    // nome do player
    var playerName = playerDetails.Name;

    // imagem do player
    var playerImg = playerDetails.Image;

    // posição do player
    var playerPosition = playerDetails.Position;

    // introdução da wikipedia do player
    var playerIntro = playerDetails.Introduction;

    var left = document.querySelector('#detailsLeft');
    var right = document.querySelector('#detailsRight');

    // contentor para o nome do player
    var containerPlayerName = document.createElement('h2');
    right.appendChild(containerPlayerName);

    containerPlayerName.textContent = playerName;
    containerPlayerName.className = "title";

    // contentor para a posição do player
    var containerPlayerPosition = document.createElement('h4');
    right.appendChild(containerPlayerPosition);

    containerPlayerPosition.textContent = playerPosition;
    containerPlayerPosition.className = "title";

    // contentor para a introdução do player
    var containerPlayerIntro = document.createElement('p');
    right.appendChild(containerPlayerIntro);

    containerPlayerIntro.textContent = playerIntro;
    containerPlayerIntro.className = "txt";
    
    // contentor para a imagem do player
    var containerPlayerImg = document.createElement('img');
    left.appendChild(containerPlayerImg);

    // url da imagem do player
    var urlplayerImg = "/Media/Players/" + playerImg;

    containerPlayerImg.classList.add("img-fluid");
    containerPlayerImg.setAttribute('src', urlplayerImg);
    

} // showPlayerDetails(playerDetails)


/************************  NATION -> PLAYER  *************************/


// mostra o ecrã dos players de uma nation
function goPlayers(nation) {
   
    // remove os elementos do details ou esconde as nations e mostra os players
    var btn = document.querySelector('#btn');
    if (btn.getAttribute('data-btnLocal') == 'details') {
        removeDetails();
    } else {
        // esconde o ecrã das nations
        var nations = document.querySelector('#nations');
        nations.setAttribute('style', 'display:none');
    } 

    // cria o ecrã dos players da nation
    Players(nation);

    // esconde o butão
    btn.setAttribute('style', 'display:none');
    
    // mostra o butão
    btn.setAttribute('style', 'display:block');

    // localiza o ecrã atual
    btn.removeAttribute('data-btnLocal');
    btn.setAttribute('data-btnLocal', 'players');

} // goPlayers(nation)

/************************  PLAYER -> DETAILS  *************************/


// esconde o ecrã dos players e mostra o ecrã dos detalhes de um player
function playerToDetails(player) {

    // esconde o ecrã dos players
    var players = document.querySelector('#players');
    players.setAttribute('style', 'display:none');

    // mostra o ecrâ dos detalhes
    var dets = document.querySelector('#playerDetails');
    dets.setAttribute('style', 'display:block');

    // cria o ecrã dos detalhes de um player da nation
    PlayerDetails(player)

    // mostra o butão
    var btn = document.querySelector('#btn');
    btn.setAttribute('style', 'display:block');

    // localiza o ecrã atual
    btn.removeAttribute('data-btnLocal');
    btn.setAttribute('data-btnLocal', 'details');

} // playerToDetails(player)

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
            removeDetails();
        } else {
            removePlayers();
        }
    });
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

    // mostra as nations
    var nat = document.querySelectorAll(".nat");
    for (var i = 0; i < nat.length; i++) {
        nat[i].setAttribute('style', 'display:block');
    }

    // remove os players
    var rowPlayers = document.querySelector('#rowPlayers');
    while (rowPlayers.hasChildNodes()) {
        rowPlayers.removeChild(rowPlayers.firstChild);
    }

    // esconde o butão
    btn.setAttribute('style', 'display:none');

} // removePlayers()

// remove os details e mostra os players
function removeDetails() {

    // localiza o ecrã atual
    var btn = document.querySelector('#btn');
    btn.removeAttribute('data-btnLocal');
    btn.setAttribute('data-btnLocal', 'players');

    // esconde o ecrâ dos detalhes
    var dets = document.querySelector('#playerDetails');
    dets.setAttribute('style', 'display:none');

    // mostra o ecrã dos players
    var players = document.querySelector('#players');
    players.setAttribute('style', 'display:block');

    // remove os detalhes

    var left = document.querySelector('#detailsLeft');
    while (left.hasChildNodes()) {
        left.removeChild(left.firstChild);
    }

    var right = document.querySelector('#detailsRight');
    while (right.hasChildNodes()) {
        right.removeChild(right.firstChild);
    }

} // removeDetails()

// clica em Nations > All na navbar para ir para o ecrã das nations
function goNations() {

    var btn = document.querySelector('#btn');

    // mostra as nations
    var nat = document.querySelectorAll(".nat");
    for (var i = 0; i < nat.length; i++) {
            nat[i].setAttribute('style', 'display:block');
    }

    // se estiver no ecrã dos detalhes apaga os detalhes e os pilotos e mostra as categorias
    if (btn.getAttribute('data-btnLocal') == 'details') {
        removeDetails()
        // esconde o butão
        btn.setAttribute('style', 'display:none');
    }
    // se estiver no ecrã dos pilotos apaga os pilotos e mostra as categorias
    if (btn.getAttribute('data-btnLocal') == 'players') {
        removePlayers();
    }

} // goNations() 


// clica num grupo na navbar para só mostrar as nations desse grupo
function group(letter) {

    // mostra todas as nations
    goNations();
    var nat = document.querySelectorAll(".nat");
    // esconde todas as nations que não são do grupo e moistra as que são
    for (var i = 0; i < nat.length; i++) {
        if (nat[i].getAttribute('data-group') == letter) {
            nat[i].setAttribute('style', 'display:block');
        } else {
            nat[i].setAttribute('style', 'display:none!important');
        }
    }

} // group(letter)