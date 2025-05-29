programa 
{
  funcao inicio() 
  {
    inteiro a, b, aux

    escreva("informe um valor para variavel A: ")
    leia(a)

    escreva("informe um valor para variavel B: ")
    leia(b)

    limpa()

    escreva("variaveis antes de troca: \n")
    escreva("A = ", a, " B = ", b, "\n")

    aux = a
    a = b
    b = aux

    escreva("\n")
    
    escreva("Variáveis após a troca: \n")
		escreva("A = ", a, "; B = ", b, "\n")
  }
}
