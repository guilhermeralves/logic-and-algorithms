// o sinal de + é usado no C# para concatenar informações

//variaveis

string name = "Guilherme";
string lastName = " Rodrigues";
string city = "Caçapava";
string state = "-SP";
string country = " Brazil";

Console.WriteLine(name+lastName+" mora em "+city+state+" localizado no país "+country+"!!!\n");

//interpolação de strings, a concatenação tambem pode ser feita utilizando o simbolo de $ e colocando as variaveis dentro de chaves. 

Console.WriteLine($"Meu nome é {name}{lastName}!");