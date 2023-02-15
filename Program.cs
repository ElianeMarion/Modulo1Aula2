namespace Aula02
{
	internal class Program
	{
		static void Main(string[] args)
		{
			/*
			Console.WriteLine("Aula 02");
			Console.WriteLine("Digite sua idade: ");
			int idade = Convert.ToInt32(Console.ReadLine());
			//Decisão condicional simples
			if (idade >= 12) //(10 >= 12) F
			{
				Console.WriteLine("Você pode jogar");
			}
			else //senão
			{
				Console.WriteLine("Você não pode jogar");			
			}
			Console.WriteLine("Idade indicativa 12 anos!");

			double investimento;
			Console.WriteLine("Aula 02 - exercício 2");
			Console.WriteLine("Digite sua doação: ");
		
			double doacao = Convert.ToDouble(Console.ReadLine());
			if(doacao >= 1000)
			{
				investimento = doacao * 0.15; 
			}
			else
			{
				investimento = doacao * 0.05;
			}

			Console.WriteLine("Valor do investimento: R$" + investimento);

			/*
			 * if(doacao < 1000)
				investimento = doacao * 0.05;
			else
				investimento = doacao * 0.15;
			*/

			//If encadeado
			/*Console.WriteLine("Aula 02 - Exercício 3");
			Console.WriteLine("Digite sua idade: ");
			int idade = Convert.ToInt32(Console.ReadLine());
			if(idade < 16)
			{ //executar bloco verdadeiro
				Console.WriteLine("Você não pode votar nem embarcar");
			}
			else if(idade >= 18)
			{
				Console.WriteLine("Voto é obrigatório, deve embarcar");
			}
			else
			{
				Console.WriteLine("Pode optar por votar ou não, embarque opcional");
			}

			/* Operadores aritméticos | Relacionais | Lógicos 
			 / - divisão 1
			* - multiplicação 1
			* % - resto da divisão
			* + soma  2
			* - subtração 2
			* 2 + 3 * 5 = 17 
			* (2 + 3) * 5 = 25
			* ++ incremento  i = i + 1 =  i++
			* -- decremento  i = i - 1 =  i--
			* += | -= | *= | /=
			* i = i + 2 => i += 2
			* 
			* Lógicos - comparar 2 condições if(idade >= 16 && idade < 18)  
			*							15		F	  E		  V = f 
			*							17      V	  E		  V = V
			* Não - !
			* E - &&
			* OU - ||
			*

			 */
			/*Calcule a média aritmética das três notas de um aluno e mostre, além do valor da média, 
			 * uma mensagem de "Aprovado", caso a média seja igual ou superior a 7; a mensagem “em prova final”
			 * caso a média seja menor que 7 e maior ou igual a 4; e "reprovado", caso contrário.
			*/
			/*Console.WriteLine("Momento Hands On");
			//declarando as variáveis
			double nota1, nota2, nota3, media;
			Console.WriteLine("Digite a primeira nota: ");
			nota1 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Digite a segunda nota: ");
			nota2 = Convert.ToDouble(Console.ReadLine());
			Console.WriteLine("Digite a terceira nota: ");
			nota3 = Convert.ToDouble(Console.ReadLine());
			media = (nota1 + nota2 + nota3) / 3;
			//Console.WriteLine("Média: " + media);

			if(media >= 7) {
				Console.WriteLine("Parabéns! Você foi aprovado com média: " + media);
			}
			else if(media < 4)
			{
				Console.WriteLine("Você foi reprovado com a media " + media);
			}else
			{
				Console.WriteLine("Você deve fazer a prova final, sua média foi " + media);
			}*/

			/*Console.WriteLine("Momento Hands On");
			//declarando as variáveis
			double saldo, credito;
			Console.WriteLine("Digite o saldo médio: ");
			saldo = Convert.ToDouble(Console.ReadLine());


			if (saldo <= 200)
			{
				credito = 0;
			}else if (saldo <= 400) // else if (saldo > 200 && saldo <= 400)
			{
				credito = saldo * 0.2;
			}
			else if (saldo <= 600)
			{
				credito = saldo * 0.3;
			}
			else
			{
				credito = saldo * 0.4;
			}
			Console.WriteLine("Saldo médio: R$ " + saldo + " - Crédito: R$" + credito);

			*/
			double salario, desconto;
			Console.WriteLine("Digite seu salário");
			salario = Convert.ToDouble(Console.ReadLine());
			desconto = salario * 0.11;

			if (desconto >= 720)
				desconto = 720;

			Console.WriteLine("Seu desconto será: R$ " + desconto);
		}
}
}