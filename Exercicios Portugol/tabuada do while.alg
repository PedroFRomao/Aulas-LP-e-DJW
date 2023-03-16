algoritmo "Tabuada com do While"
// Função :
// Autor :
// Data : 08/03/2023
// Seção de Declarações 
var
num,i, j,con:inteiro
// Seção de Comandos
Inicio
   Escreva("Digite qual número quer multiplicar")
   leia(num)
   i:=1
   repita
    con:= num*i
    Escreval (num, "*", i, "=", con)
    i:=i+1
   ate i > 10

fimalgoritmo
