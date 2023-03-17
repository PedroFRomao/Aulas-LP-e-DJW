algoritmo "semnome"
// Função :
// Autor :
// Data : 15/03/2023
// Seção de Declarações 
var
   i, c1, c2, c3, voto:inteiro
   fim:caracter
inicio
   c1:=0
   c2:=0
   c3:=0
   i:=0
   fim:="n"
   enquanto (fim = "n") faca
      Escreval("Digite 1 para votar em maria")
      Escreval("Digite 2 para votar em joao")
      Escreval("Digite 3 para votar em jose")
      Leia(voto)
      Se(voto=1) entao
         c1:= c1+1
      Senao
         Se(voto=2) entao
            c2:= c2+1
         Senao
            Se (voto=3) entao
               c3:= c3+1
            Senao
               Escreva("ERROR")
            Fimse
         Fimse
      Fimse
      i:= (i+1)
      Escreval("voto confirmado")
      Escreval("Deseja terminar a votacao: (s ou n)")
      leia (fim)
   fimenquanto
   Se c1>c2 e c1>c3 entao
         Escreval("A maria foi a vencedora com ", c1,"pontos")
      Senao
         Se(c2>c1) e (c2>c3 entao
            Escreval("O joao foi a vencedora com ", c2,"pontos")
         Senao
            Se(c3>c1) e (c3>c2 entao
               Escreval("O Jose foi a vencedora com ", c3,"pontos")
            Senao
               Escreva("ouve um empate entre dois candidatos")
            Fimse
         Fimse
      Fimse
// Seção de Comandos 
fimalgoritmo
