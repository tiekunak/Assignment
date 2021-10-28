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
        var parent = document.getElementById('parent');
        var image = document.getElementById('img');
        var img = document.getElementById('image');
        parent.innerHTML = '<p style= "text-transform: capitalize;">' + pokemon.name +'</p>';
        parent.innerHTML += '<p style= "text-transform: capitalize;">' + "the "+pokemon.types[0].type.name + " type of pokemon" + '</p>';
        img.innerHTML = "<img src=" + pokemon.sprites.front_default + ">";
        image.innerHTML = "<img src=" + pokemon.sprites.back_shiny + ">";
        var moves = document.getElementById('moves');
        var Move1 = pokemon.moves[0].move.name;
        var Move2 = pokemon.moves[1].move.name;
        var Move3 = pokemon.moves[2].move.name;
        var Move4 = pokemon.moves[3].move.name;
        moves.innerHTML = '<p style= "text-transform: capitalize;">' + pokemon.name + " is capable of learning these moves! " + '</p>' + '<p style= "text-transform: capitalize;">' + Move1 + '<p style= "text-transform: capitalize;">' + Move2 + '</p>' + '<p style= "text-transform: capitalize;">' + Move3 + '</p>' + '<p style= "text-transform: capitalize;">' + Move4 + '</p>';
        // console.log(pokemon);
    }).catch(err => console.log(err))
}