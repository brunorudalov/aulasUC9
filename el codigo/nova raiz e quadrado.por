programa 
{
  inclua biblioteca Matematica --> mat
  
  funcao inicio() 
{
   real valor, potencia, raiz_quadrada
   escreva("Digite o valor:")
    leia(valor)

   potencia = mat.potencia(valor, 3.0)
   raiz_quadrada = mat.raiz(valor, 2.0)

   escreva("\nO número ao cubo é: ", potencia, "\n")
   escreva("A raiz quadrada do número é: ", raiz_quadrada, "\n")

  }
}