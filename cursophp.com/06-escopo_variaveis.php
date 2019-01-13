<?php

//Escopo de variáveis = contexto em que ela foi definida


//ESCOPO GLOBAL
$nome = "Vinicius Lopes";
$a = 10;
$b = 20;
$c = 30;


// ESCOPO INTERNO DE FUNÇÃO 
function exibeNome(){
    global $nome; // caso não tenha a especificação de que tal variável é global , a function não irá encontrar a variável
    echo $nome;
}
exibeNome();

echo "<hr>";

////////////////////////
function exibeCidade(){
    // ESCOPO LOCAL, para acessar de fora, ela precisa ser global
    global $cidade;
    $cidade = " São Paulo";
}
exibeCidade();
echo $cidade;

echo "<hr>";

// Utilizando método GLOBALS

function soma(){
    // se utilizarmos o método abaixo teremos erro, pois a variável está fora da function
    // echo $a + $b + $c;

    // Para utilizar dentro da function variáveis externas, podemos utilizar o ARRAY ESPECIAL GLOBALS
  echo  $GLOBALS['a'] + $GLOBALS['b'] + $GLOBALS['c'];
}

soma(); // Não temos necessidade do ECHO , pois ele já está dentro da function, apenas precisamos chamá-la



?>