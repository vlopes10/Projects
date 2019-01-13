<?php

$n1 = 10;
$n2 = 20;

if ($n1 > $n2):
     echo "N1 é o maior número";
else:
    echo "N2 é o maior número";
endif;    

echo "<hr>";

// OU ENTÃO 

echo ($n1 > $n2) ? "N1 é Maior" : "N2 é Maior"; // toda tratativa do ERRO FOI feita aqui 

echo "<hr>";

// SWITCH CASE - Precisa atender alguma das opções dentro do switch 

$cor = "preto";

switch ($cor):
    case "Preto":
    echo "A cor escolhida foi preto";
    break;

    case "Branco":
    echo "A cor escolhida foi branco";
    break;

    case "Azul":
    echo "A cor escolhida foi azul";
    break;

    default:
    echo "A cor escolhida não está cadastrada em nosso banco";

endswitch;

?>