<?php

// mesmo padrão das outras linguagens : contendo - string, int , float, boolean, array, objeto


// string
$nome = "Vinicius";
var_dump($nome); // mostra as propriedades da variável 

// Condicional de teste para confirmar que é uma string 
if (is_string($nome)):
    echo "é uma string";
else:
    echo "não é uma string";
endif;

echo "<hr>";

//int 
$idade = 21;
var_dump($idade);
echo "<hr>";
//boolean

$pessoa = true;
echo $pessoa;
echo "<hr>";
//array

$carros = array ("Jetta","Golf","Passat","Tiguan");
var_dump($carros);
echo "<hr>";

// Objeto 
// criando classe de objeto  
// Atributo - Variável 
// Método - Function

class Cliente{
    public $nome; // atributo
    public function atribuirNome($nome) {  // Dentro desta classe realizamos a atribuição de nome aos clientes 
        $this -> $nome = $nome;
    }
}
// chamando o objeto 

$cliente = new Cliente(); // cliente ao invés de ser uma variável, se tornou um objeto 

// Utilizando objeto 

$cliente -> atribuirNome("H. Vinicius Lopes Santos");

var_dump($cliente);


// Concluindo : Na programação Orientada à Objeto, criamos tais objetos com atributos e métodos, para serem reutilizados
// no decorrer do projeto, mantendo a premissa de reutilização de códigos



?>