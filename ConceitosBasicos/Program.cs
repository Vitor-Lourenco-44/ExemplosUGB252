Console.WriteLine("Informe seu nome: ");
string nome = Console.ReadLine();
Console.WriteLine("Informe seu salário: ");
decimal salario = decimal.Parse( Console.ReadLine());
Console.WriteLine("O seu salário é R$" + salario);
Console.WriteLine("O seu nome é " + nome);

decimal calculo1 = salario * 0.0075m;

{
    if (salario <= 2259.20m)
        Console.WriteLine("Você terá isenção de IRPF, parabéns!");
}

{

    if (salario >= 2259.21m && <= 2826.65m)
        Console.WriteLine("Você deverá pagar R${0} de IRPF com base no seu salário, ou seja, 7,5%", calculo1);
}
// if (salario >= 2826.66 && <= 3751.05)



// Informem o valor do IRPF a ser pago de acordo com o salário informado. Utilize a tabela real de desconto de IRPF.

// Usar "Você terá um desconto de X em IRPF" R$ 2.259,20

// Usando o if



