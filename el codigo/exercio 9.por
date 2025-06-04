programa {

  inclua biblioteca Matematica --> mat

  funcao inicio() 
  {
    real salario, novosalario, percentual, valor

    escreva("salario antigo: ")
    leia(salario)

    percentual = 15.0 / 100
    valor =  salario * percentual
    novosalario = salario + valor

    escreva("o novo salario do funcionario é: " , novosalario, "$")
  }
}
