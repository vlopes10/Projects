<?php

$nomes = array ("Vinicius", "Lopes","Santos");

// Validar se nomes é um array
echo is_array($nomes); // Irá retornar 1 , pois 1 significa true, sua validação é feita de forma booleana 
echo "<br>";
var_dump (is_array($nomes)); // validando com VarDump
echo "<br>";

// validar se um dado está presente no array 
echo in_array("Vinicius",$nomes);   // deverá retornar 1 
echo "<hr>";

// Juntar conteúdo de dois arrays 
$carros = array ("Gol","Fox","Uno","Clio","Onix");
$motos = array ("Hornet","Ninja");

$veiculos = array_merge($carros,$motos);
foreach($veiculos as $valor){
    echo $valor."<br>";
}
echo "<hr>";

// retirar último elemento do array
array_pop($carros);
print_r($carros);

echo "<br>";
// retirar primeiro elento do array 
array_shift($carros);
print_r($carros);

echo "<br>";

// Adicionar um ou mais elementos no inicio do array 

array_unshift($carros, "Ferrari");
print_r($carros);

echo "<br>";

// Adicionar um ou mais elentos no final do array 

array_push($carros, "Lamborghini");
print_r($carros);

echo "<hr>"; 

// Juntar vetor com índices e valores 

$keys = array ("Campeão Mundial", "Sem Mundial" , "Rebaixado");
$valores = array("Santos","Palmeiras","Corinthians");

$descricao = array_combine($keys,$valores);
print_r($descricao);

echo "<hr>";

// Soma de itens dentro do vetor 

$nums = array (10,20,30,40,50);
$resultado = array_sum($nums);
print_r($resultado);

echo "<br>";

// Transformar String em Array - Explode

$name = "Hermes Vinicius Lopes Santos";

$nameArray = explode(' ', $name); // no primeiro campo definimos o que irá separar os itens quando transformado em vetor 
print_r($nameArray);

echo "<hr>";

?>