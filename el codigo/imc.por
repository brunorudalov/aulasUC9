programa {
  funcao inicio() {

    real peso, altura, imc

    escreva("digite o peso: ")
    leia(peso)

    escreva("digite a altura: ")
    leia(altura)

    imc = (peso / (altura*altura))

    se(imc < 18.5) 
    {
      escreva("abaixo do ideal")
    }
    se(imc > 25.0)
    {

    }
    se(imc > 25.0)
    {
      escreva(ideal)
    }

  }
}
