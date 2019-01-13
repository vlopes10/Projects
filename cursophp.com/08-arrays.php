<?php

$carros = array("BMW","FORD","CHEVROLET");
// visualizar array completa, temos que usar o comando abaixo 
print_r($carros);
echo "<hr>";

// pode visualizar a array por  índice com o echo 
echo $carros[0];
echo "<hr>";

//podemos atribuir o índice do vetor manualmente 
$motos = array (1=>"CB1000", 2=>"ZX10R",3=>"R1" );
print_r($motos);
echo "<hr>";

//cadastrar elemento em Array 
$motos[] ="XJ6";

// podemos cadastrar já em uma posição específica 
$motos[6] = "S1000RR";
print_r($motos);
echo "<hr>";

//exibir em número o tamanho (lenght) do array
echo count($motos); 
// podemos atribuir a ação de contagem à uma variável
$totalMotos = count($motos);
echo "<hr>";

//loop para percorrer array FOREACH = PARA CADA 
foreach($carros as $valor){
    echo $valor."<br>";
}
// Ao percorrer o FOREACH cada elemento do array será atribuído à variável valor 
// após isso, será exibido com o comando echo, sempre pulando uma linha 

echo "<hr>";

// Ao invés do Array possuir um índice número, pode ser um array associativo, possuindo uma nomenclatura em seu índice

$pessoa = array("nome" => "Vinicius", "curso" => "Ciências da Computação");

// cadastrar um elemento em um array associativo 
$pessoa["cidade"] = "São Paulo";

// pesquisar por índice associado
echo $pessoa["nome"];
echo "<hr>";

//Aplicando FOREACH

foreach ($pessoa as $valor){
    echo $valor."<br>"; 
}
echo "<hr>";
// Array Multi dimensional - Auxiliam em melhores divisões , para maior organização de dados

$times = array("paulistas" => array ("Santos", "Ponte Preta","Ituano"),
                "cariocas" => array ("Flamengo","Vasco","Fluminense"),
                "mineiros" => array ("Cruzeiro","América - MG ", "Atlético - MG")                
);

// Exibindo todos os times, índices e dados do Array 
print_r($times);
echo "<hr>";

//Exibindo array times com somente os paulistas
foreach ($times["paulistas"] as $valor){
    echo $valor."<br>";
}

echo "<hr>";

//Exibindo somente times cariocas
foreach ($times["cariocas"] as $valor){
    echo $valor."<br>";
}

echo "<hr>";

//Exibindo somente times mineiro
foreach ($times["mineiros"] as $valor){
    echo $valor."<br>";
}


?>