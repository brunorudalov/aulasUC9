programa {

  inclua biblioteca Matematica --> mat

  funcao inicio() 
  {
    real valor, renda, percentual, nvalor, mes

    escreva("digite o valor colocado na poupaça: ")
    leia(valor)

    percentual = 0.05
    nvalor = valor * percentual
    renda = percentual + nvalor

    escreva("a renda é de: ", renda, "$")
  }
}
