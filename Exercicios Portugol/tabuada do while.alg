algoritmo "Tabuada com do While"
// Função :
// Autor :
// Data : 08/03/2023
// Seção de Declarações 
var
num,i,con:inteiro
// Seção de Comandos
Inicio
   i:=1
   Escreva("Digite qual número quer multiplicar")
   leia(num)
   repita
    con:= num*i
    Escreval (num, " * ", i, " = ", con)
    i:=i+1
   ate i > 10

fimalgoritmo
