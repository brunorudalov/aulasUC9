programa {

  funcao inicio() 
   {

   inteiro anonasc, mesnasc, dianasc, anoatual, mesatual, diaatual, idade

    escreva("informe ano de nascimento: ")
    leia(anonasc)
    
    escreva("informe meses de nascimento: ")
    leia(mesnasc)

    escreva("informe dia de nascimento: ")
    leia(dianasc)



    escreva("informe ano atual: ")
    leia(anoatual)
    
    escreva("informe meses atual: ")
    leia(mesatual)

    escreva("informe dia atual: ")
    leia(diaatual)
    
    idade = anoatual - anonasc - 1

    se(mesatual < mesnasc)
    {
     escreva(idade)
    }
     senao
    {
      idade = idade - 1
    
      escreva(idade)
    }

  }
}
