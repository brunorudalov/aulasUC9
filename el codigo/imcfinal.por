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
     senao se(imc >= 18.5 e imc <= 25.0)
    {
      escreva("ideal")
    }
     senao se(imc >= 25.0 e imc <= 30.0)
    {
      escreva("sobre peso")
    }
     senao se(imc >= 30.0 e imc <= 35.0)
    {
      escreva("excesso de peso")
    }
     senao se(imc >= 35.0)
    {
      escreva("obsidade")
    }
  }
}
