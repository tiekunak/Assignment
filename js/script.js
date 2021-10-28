var url = "https://pokeapi.co/api/v2/pokemon/";
var whichPokemon;

function searchPokemon() {
    whichPokemon = document.getElementById("searchbar").value;
    whichPokemon = whichPokemon.toLowerCase();
    url = "https://pokeapi.co/api/v2/pokemon/"
    url += whichPokemon; // url = url + pokemon
    fetch(url)
    .then(response => response.json())
    .then(pokemon => {
        var name = document.getElementById('name');
        var image = document.getElementById('img');
        name.innerHTML = '<p>' + pokemon.name.toUpperCase() +'</p>';
        name.innerHTML += '<p>' + "the "+pokemon.types[0].type.name + " type pokemon" + '</p>';
        image.innerHTML = "<img src=" + pokemon.sprites.front_default + ">";
        var moves = document.getElementById('moves');
        var firstMove = pokemon.moves[0].move.name;
        var secondMove = pokemon.moves[1].move.name;
        var thirdMove = pokemon.moves[2].move.name;
        var fourthMove = pokemon.moves[3].move.name;
        moves.innerHTML = '<p>' + pokemon.name + " can learn the following moves! " + '</p>' + '<p>' + firstMove + '<p>' + secondMove + '</p>'+ '<p>' + thirdMove + '</p>'+ '<p>' + fourthMove +'</p>';
       

         

    }).catch(err => console.log(err))
}