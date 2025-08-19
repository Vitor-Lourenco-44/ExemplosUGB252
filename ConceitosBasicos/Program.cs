/*
try
{
    Console.WriteLine("Informe seu nome: ");
    string nome = Console.ReadLine();
    Console.WriteLine("Informe seu salário: ");
    decimal salario = decimal.Parse(Console.ReadLine());
    Console.WriteLine("O seu salário é R$" + salario);
    Console.WriteLine("O seu nome é " + nome);

    decimal irpfDevido;

    if (salario <= 2259.20m)
        irpfDevido = 0;
    else if (salario <= 2826.65m)
        irpfDevido = salario * 0.075m - 169.21m;
    else if (salario <= 3751.65m)
        irpfDevido = salario * 0.15m - 381.44m;
    else if (salario <= 4664.68m)
        irpfDevido = salario * 0.225m - 662.77m;
    else
        irpfDevido = salario * 0.275m - 896m;

    Console.WriteLine($"Para o salário de {salario} o valor a ser pago de IRPF é de {irpfDevido}, então o salário com desconto de IRPF será de {salario - irpfDevido}");
}
catch (FormatException)
{
    Console.WriteLine("O saláiro deve ser informado em formato numérico");
}
catch (Exception e)
{
    Console.WriteLine("Ocorreu um erro. Contate o suporte técnico.");
    Console.WriteLine(e.StackTrace);
}

*/


// if (salario >= 2826.66 && <= 3751.05)



// Informem o valor do IRPF a ser pago de acordo com o salário informado. Utilize a tabela real de desconto de IRPF.

// Usar "Você terá um desconto de X em IRPF" R$ 2.259,20

// Usando o if


using ConceitosBasicos.uteis;

SomaDoisNumeros somaDoisNumeros = new SomaDoisNumeros();
int resultado = somaDoisNumeros.Somar(20, 22);
Console.WriteLine(resultado);


int milimetros = MetrosMilimetros.Converter(2);
Console.WriteLine(milimetros);


