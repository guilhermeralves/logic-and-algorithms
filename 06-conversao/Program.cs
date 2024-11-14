/*nesse modulo o exemplo acontece nas linhas 7 e 13, o tipo de variavel do numero01 e numero02 é do tipo Int
ou seja o programa espera um dado do tipo numero inteiro, porem o retorno padrão da função Console.ReadLine é texto, então nesse casso é necessário realizar a conversão do dado para que o input do usuario seja transformado em tipo int e aceito pela variavel numero01 e numero02*/

//obter primeiro numero

Console.WriteLine("Informe o primeiro numero:\n");

int numero01 = Convert.ToInt16(Console.ReadLine());

//obter segundo numero

Console.WriteLine("Informe o segundo numero:\n");

int numero02 = Convert.ToInt16(Console.ReadLine());

Console.WriteLine("");

//realizar a soma

Console.WriteLine($"\nA soma dos numeros é igual à: {numero01+numero02}");