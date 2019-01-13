<?php
// ao utilizar aspas simples, não é possível concatenar variáveis ao ao texto
// aspas simples são literais, não interpretadas
// para concatenar variáveis com aspas simples, precisamos utilizar o . 

$nome = "Vinicius Lopes";
echo "Meu nome é $nome"; // Correto
echo "<hr>";
echo 'Meu nome é $nome'; // Incorreto
echo "<hr>";
echo 'meu nome é '.$nome;


?>