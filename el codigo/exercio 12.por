programa 
{
  funcao inicio() 
  {
    real kilos, dias, dieta, gramas, dia

    escreva("kilo por alimentos: ") 
    leia(kilos)

    gramas = kilos * 1000
    dieta = gramas / 50

   se(gramas > 0)
    {
    escreva("resta para mais: ", dieta, " dias")
    }
  }
}