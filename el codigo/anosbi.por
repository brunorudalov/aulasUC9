programa {
  funcao inicio() 
  {
    inteiro ano_atual, qtd_anos_bi, dias

    escreva("informe o ano atual: ")
    leia(ano_atual)

    qtd_anos_bi = ano_atual / 4

    dias = (ano_atual - 1 ) * 365 + qtd_anos_bi
  escreva("ja se passaram ", dias, " dias desde 01/01/0001\n") 

  escreva("ja se passaram ", qtd_anos_bi," anosbi desde 01/01/0001\n") 
  }
}
