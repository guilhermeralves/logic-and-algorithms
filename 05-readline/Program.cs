// o comando readline é usado como input de dados pelo usuário.

Console.WriteLine("Qual é a minha cor favorita?\n");

/* input de dados do usuario para obter a informação de qual cor é a favorita.
    Observação: o ponto de interrogação é usado antes do nome da variavel para informar ao C# que ela pode receber um valor nulo caso o usuário não informe nada e prossiga. 
*/

string ?corFavorita = Console.ReadLine();

Console.WriteLine($"\nA sua cor favorita é o {corFavorita}");