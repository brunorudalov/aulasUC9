programa {
  funcao inicio() 
  {
    real salario, horas, valor

    escreva("escreva valor: ")
    leia(valor)

    escreva("escreva horas trabalhadas no mes: ")
    leia(horas)

    salario = valor * horas

    escreva("\nO salario do funcionario é de: ", salario, " $")
  }
}
