// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

 int x;
 float y;


 x = 10;
 y = 10.50f; // colocamos a letra F para indetificar com essa variavel e do tipo float ou seja flutuante

// imprimindo no console 


Console.WriteLine($"Valor de X; {x}");

Console.WriteLine($"Valor de Y; {y}");


var x = 10;
var y = 10.50;
string texto = "Bem vindo ao curso C#";
bool teste = true;
decimal valorDoProduto = 5.5m;

Console.WriteLine($"Valor de X; {x}");
Console.WriteLine($"Valor de Y; {y}");
Console.WriteLine($"Valor de texto: {texto}");
Console.WriteLine($"Valor de teste: {teste}");
Console.WriteLine($"Valor de volores: {valorDoProduto}"); 

 
//int minimo = -2000;  // para essa variavel e possivel imprimir porque o valor atende a variavel para colocarmos o uma variavel com valor muito alto devemos usar o long

long minimo = -2147483999; // ou 

double minimo = 3402823e38; // a letra é segnifica elevado a 38


Console.WriteLine(minimo);


// Enum - serve para enumerar um determinado tipo  de usuario em nosso sistema, ele deve ser declardo da seguinte forma !


var tipoDeUsuario = TipoDeUsuario.DUO;
Console.WriteLine(tipoDeUsuario);

public enum TipoDeUsuario{
	
	CLT,
	
	PJ,
	
	DUO
	
	
}


// condicionais sem elas não conseguimos desenvolver nada.

//eles servem para darmos condição em um termindado assunto usando os sinal de = < > == deve ser declarado da seguinte forma

        int  salario = 2000;
       bool tipoClt = true;
// usando a condição com a palavra if (>)maior = igual < menor >= maior ou igual <= menor ou igual

        if(salario >= 5000 || tipoClt == false) {
            Console.WriteLine("Funcionario não tem direito ao plano de Saúde");
            Console.WriteLine("Funcionario não tem direito ao vale alimentação");
            
        }
        else if(salario >=1000 && salario < 5000) {
            Console.WriteLine("Funcionario tem direito ao plano de Saúde");
        }

        else{
          Console.WriteLine("Funcionario tem direito ao plano de Saúde");
           Console.WriteLine("Funcionario tem direito ao vale alimentação");
       }

        Console.WriteLine($"Salário: {salario}");


int temperatura = 30;

switch(temperatura)
{
	case < 0:  // caso a temperatura é menor que zero 
		Console.WriteLine($"Esta frio para um caralho!");
		break;
		
	case >= 0 and < 10: // caso a temperatura é maior ou igual ou menor que 10 
		Console.WriteLine($"Está muito frio");
		break;
	case >= 10 and < 23: // caso a temperatura é maior ou igual ou menor que 23
		Console.WriteLine($"Frio");
		break;
	
	case >= 23 and < 30: // caso a temperatura é maior ou igual ou menor que 30
		Console.WriteLine($"Tempo bom");
		break;
		
	default:
		Console.WriteLine($"Está calor");
		break;
		
}

