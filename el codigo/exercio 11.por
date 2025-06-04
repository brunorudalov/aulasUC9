programa {
  inclua biblioteca Matematica --> mat
  funcao inicio() {
    inteiro resto,numero,result

    escreva("digite o valor: ")
    leia(numero)

    result = numero / 3
    resto =  numero % 3
    
   

    escreva("valor da divi é: ", result, "% ")
    escreva("\nvalor do calculo é: ", resto, " ")
  }
}
