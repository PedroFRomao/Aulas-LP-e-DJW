algoritmo "Votacao"
// Fun??o :
// Autor :
// Data : 15/03/2023
// Se??o de Declara??es
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
      //votao
      Escreval("Digite 1 para votar em maria")
      Escreval("Digite 2 para votar em joao")
      Escreval("Digite 3 para votar em jose")
      Leia(voto)
      Se(voto=1) entao
         c1:= c1+1
         Escreval("voto confirmado")
         i:= (i+1)
      Senao
         Se(voto=2) entao
            c2:= c2+1
            Escreval("voto confirmado")
            i:= (i+1)
         Senao
            Se (voto=3) entao
               c3:= c3+1
               Escreval("voto confirmado")
               i:= (i+1)
            Senao
               Escreval("ERROR")
            Fimse
         Fimse
      Fimse
      //fim votacao
      Escreval("Deseja terminar a votacao: (s ou n)")
      leia (fim)
   fimenquanto
   //maria vence
   Se (c1>c2) e (c1>c3)entao
         Escreval("A Maria foi a vencedora com ", c1," ponto(s)")
         Escreval("Ela conquistou ", c1*100/i ,"% dos votos")
         //caso ela seja invicta
         Se (c2 + c3 = 0) entao
            Escreval("Ela ganhou invcta")
         Senao
            //teste
            Se (c2 > c3) entao
               Escreval("Ela ganhou com uma diferenca de ", c1-c2 ," votos de Joao")
            Senao
               Escreval("Ela ganhou com uma diferenca de ", c1-c3 ," votos de Jose")
            Fimse
         Fimse
   Senao
         //joao vence
         Se(c2 > c1) e (c2 > c3) entao
            Escreval("O Joao foi a vencedor com ", c2," ponto(s)")
            Escreval("Ele conquistou ", c2*100/i ,"% dos votos")
            //caso ela seja invicta
            Se (c1 + c3 = 0) entao
               Escreval("Ele ganhou invcto")
            Senao
               //teste
               Se (c1 > c3) entao
                  Escreval("Ele ganhou com uma diferenca de ", c2-c1 ," votos de Maria")
               Senao
                  Escreval("Ele ganhou com uma diferenca de ", c2-c3 ," votos de Jose")
               Fimse
            Fimse
         Senao
            // jose vence
            Se(c3 > c1) e (c3 > c2) entao
               Escreval("O Jose foi a vencedor com ", c3," ponto(s)")
               Escreval("Ele conquistou ", c3*100/i ,"% dos votos")
               //caso ela seja invicta
               Se (c1 + c2 = 0) entao
                  Escreval("Ele ganhou invcto")
               Senao
                  //teste
                  Se (c2 > c1) entao
                     Escreval("Ele ganhou com uma diferenca de ", c3-c2 ," votos de Joao")
                  Senao
                     Escreval("Ele ganhou com uma diferenca de ", c3-c1 ," votos de Maria")
                  Fimse
               Fimse
            Senao
               //EMPATE
               Escreval("Ouve um empate entre dois candidatos")
               //Maria e Joao
               Se (c1 = c2) entao
                  Escreval("Os candidatos Maria e Joao empataram com", c1," voto(s)")
               Senao
                  //Maria e Jose
                  Se (c1 = c3) entao
                     Escreval("Os candidatos Maria e Jose empataram com", c1," voto(s)")
                  Senao
                     //Jose e Joao
                     Se (c2 = c3) entao
                        Escreval("Os candidatos Jose e Joao empataram com", c2," voto(s)")
                     Senao
                        Escreval("ERROR")
                     Fimse
                  Fimse
               Fimse
            Fimse
         Fimse

   Fimse
fimalgoritmo
