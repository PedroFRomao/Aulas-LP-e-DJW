algoritmo "Exercicio Posto"
// Função :
// Autor :
// Data : 24/10/2022
// Seção de Declarações 
var
   quant, des, pag: real
   comb: caracter
inicio
// Seção de Comandos
Escreval("Digite a quantidade de litros: ")
Leia (quant)
Escreval("Digite 'A' para alcool ou 'G' para gasolina: ")
Leia (comb)
Se(comb == 'A')entao
   Se(quant <= 20)entao
      des:= 4.9 * 0.03 * quant
      pag:= 4.9 * quant - des
   Senao
      des:= 4.9 * 0.05 * quant
      pag:= 4.9 * quant - des
   Fimse
Senao
   Se(comb == 'G')entao
      Se(quant <= 20)entao
         des:= 5.5 * 0.03 * quant
         pag:= 5.5 * quant - des
      Senao
         des:= 5.5 * 0.05 * quant
         pag:= 5.5 * quant - des
      Fimse
   Senao
      Escreva("ERROR")
      Fimse
   Fimse
Fimse
Escreva("o valor do desconto sera de", des)
Escreva("o valor total do desconto sera de", pag)
fimalgoritmo
