
using System;

namespace Lista_level_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			int sair = 1;
			int opcao = 0;
			DateTime dataHora = DateTime.Now;
			
			while (sair == 1){
				Console.Clear();
				
				Console.WriteLine("------------ MENU DE ATIVIDADES ------------");
				Console.WriteLine("Data de Acesso: {0}", dataHora);
				Console.WriteLine("(Pressione '0' para sair)");
				Console.Write("Escolha uma opção de 1 ao 20: ");
				opcao = int.Parse(Console.ReadLine());
				
				
				Console.Clear();
				
				
				switch (opcao) {
					case 1:
						/*1. Escreva um programa em C# para aceitar uma nota e exibir
 					a descrição equivalente:
					 Nota Descrição
					A 		Excelente
					C		Muito Bom
					E 		Bom
					F 		Média
					G 		Falhou  */
						
						Console.WriteLine("Atividade 01: ");
						
						Console.Write ("\nOpções de Nota:\nA, C, E, F, G");
						Console.WriteLine("\nDigite uma nota: ");
						char nota = char.Parse(Console.ReadLine());
						
						switch (nota) {
							case 'A':
								Console.WriteLine("Excelente");
								break;
							case 'C':
								Console.WriteLine("Muito Bom");
								break;
							case 'E':
								Console.WriteLine("Bom");
								break;
							case 'F':
								Console.WriteLine("Média");
								break;
							case 'G':
								Console.WriteLine("Falhou");
								break;
						}
						Console.ReadKey(true);
						break;
						
					case 2:
						/*2. Escreva um programa em C# para ler qualquer número de dia em inteiro
						e exibir o nome do dia na palavra.*/
						
						Console.WriteLine("Atividade 2");
						
						Console.WriteLine("Digite o numero de dia (1-7)");
						int numDia = int.Parse(Console.ReadLine());
						
						switch (numDia) {
							case 1:
								Console.WriteLine("Segunda-Feira");
								break;
							case 2:
								Console.WriteLine("Terça-Feira");
								break;
							case 3:
								Console.WriteLine("Quarta-Feira");
								break;
							case 4:
								Console.WriteLine("Quinta-Feira");
								break;
							case 5:
								Console.WriteLine("Sexta-Feira");
								break;
							case 6:
								Console.WriteLine("Sábado");
								break;
							case 7:
								Console.WriteLine("Domingo");
								break;
						}
						Console.ReadKey(true);
						break;
						
					case 3:
						/*3. Escreva um programa em C# para ler qualquer dígito e exibir em formato
						palavra.*/
						
						Console.WriteLine("Atividade 03");
						
						Console.Write("Digite um dígito (0-9): ");
						int digito = int.Parse(Console.ReadLine());
						
						switch (digito) {
							case 0:
								Console.WriteLine("Zero");
								break;
							case 1:
								Console.WriteLine("Um");
								break;
							case 2:
								Console.WriteLine("Dois");
								break;
							case 3:
								Console.WriteLine("Três");
								break;
							case 4:
								Console.WriteLine("Quatro");
								break;
							case 5:
								Console.WriteLine("Cinco");
								break;
							case 6:
								Console.WriteLine("Seis");
								break;
							case 7:
								Console.WriteLine("Sete");
								break;
							case 8:
								Console.WriteLine("Oito");
								break;
							case 9:
								Console.WriteLine("Nove");
								break;
							default:
								Console.WriteLine("Dígito inválido");
								break;
						}
						Console.ReadKey(true);
						break;
						
					case 4:
						/*4. Escreva um programa em C# para ler qualquer número do mês em
						inteiro e exibir o nome do mês em palavra.*/
						
						Console.WriteLine("Digite um número de mês: ");
						int numMes = int.Parse(Console.ReadLine());
						
						switch (numMes) {
							case 1:
								Console.WriteLine("Janeiro");
								break;
							case 2:
								Console.WriteLine("Fevereiro");
								break;
							case 3:
								Console.WriteLine("Março");
								break;
							case 4:
								Console.WriteLine("Abril");
								break;
							case 5:
								Console.WriteLine("Maio");
								break;
							case 6:
								Console.WriteLine("Junho");
								break;
							case 7:
								Console.WriteLine("Julho");
								break;
							case 8:
								Console.WriteLine("Agosto");
								break;
							case 9:
								Console.WriteLine("Setembro");
								break;
							case 10:
								Console.WriteLine("Outubro");
								break;
							case 11:
								Console.WriteLine("Novembro");
								break;
							case 12:
								Console.WriteLine("Dezembro");
								break;
								
							default:
								Console.WriteLine("Mês Inválido");
								break;
						}
						Console.ReadKey(true);
						break;
						
					case 5:
						/* 5. Escreva um programa em C# que seja um programa orientado por menus
						para calcular a área das várias formas geométricas.*/
						
						int sair2 = 1;
						while (sair2 == 1) {
							
							Console.WriteLine("Atividade 05");
							
							Console.WriteLine("Escolha uma opção para calcular a área:");
							Console.WriteLine("Digite 0 para voltar pro Menu...");
							Console.Write("1) Triângulo\n2) Quadrado\n3) Retangulo\n4) Círculo\n:");
							int escolha = int.Parse(Console.ReadLine());
							
							switch (escolha) {
								case 1:
									Console.WriteLine("Cálculo da área do Triângulo");
									Console.WriteLine("A = área  B = Base  H = altura");
									int B, H;
									Console.Write("B:");
									B = int.Parse(Console.ReadLine());
									Console.Write("h:");
									H = int.Parse(Console.ReadLine());
									
									Console.WriteLine("\nA = b * h / 2");
									Console.WriteLine("A área do triangulo será: {0}", (B*H)/2);
									Console.WriteLine("\nPressione algo para continuar..");
									Console.ReadKey(true);
									Console.Clear();
									break;
									
								case 2:
									Console.WriteLine("Cálculo da área do Quadrado");
									Console.WriteLine("A = Área  L = Lado");
									int L;
									Console.Write("L:");
									L = int.Parse(Console.ReadLine());
									
									Console.WriteLine("\nA = L * L");
									Console.WriteLine("A área do quadrado será A = {0}", L*L);
									Console.WriteLine("\nPressione algo para continuar..");
									Console.ReadKey(true);
									Console.Clear();
									break;
									
								case 3:
									Console.WriteLine("Cálculo da área do Retangulo");
									Console.WriteLine("A = Área  B = Base  H = Altura");
									int Base, Haltura;
									Console.Write("B:");
									Base = int.Parse(Console.ReadLine());
									Console.Write("h:");
									Haltura = int.Parse(Console.ReadLine());
									
									Console.WriteLine("\nA = b * h");
									Console.WriteLine("A área do retângulo será: A = {0}", Base*Haltura);
									Console.WriteLine("\nPressione algo para continuar..");
									Console.ReadKey(true);
									Console.Clear();
									break;
									
								case 4:
									Console.WriteLine("Cálculo da área do Círculo");
									Console.WriteLine("A = Área  π = Constante Pi(3,14)  R = Raio");
									Console.Write("π: ");
									float Pi = 3.14F;
									float raio =float.Parse(Console.ReadLine());
									
									
									Console.WriteLine("\nA = π * r*r");
									Console.WriteLine("A área do círculo será A = {0}", Pi * (raio*raio));
									Console.WriteLine("\nPressione algo para continuar..");
									Console.ReadKey(true);
									Console.Clear();
									break;
									
								case 0:
									
									Console.ReadKey(true);
									sair2 = 0;
									Console.Clear();
									break;
									
								default:
									Console.WriteLine("Clique para continuar...");
									break;
							}
						}
						Console.ReadKey(true);
						break;
					case 6:
						/* 6. Escreva um programa em C# que seja um Programa Orientado por Menu
						para realizar cálculos simples(soma, subtração, multiplicação e divisão).*/
						
						int sair3 = 1;
						while (sair3 == 1) {
							Console.WriteLine("\nAtividade 06");
							
							
							Console.WriteLine("\nDigite dois números: ");
							int num1 = int.Parse(Console.ReadLine());
							int num2 = int.Parse(Console.ReadLine());
							Console.Write("\n(Digite 0 para sair)\n");
							Console.WriteLine("Selecione uma operação:");
							Console.Write("1) Soma\n2) Subtração\n3) Multiplicação\n4) Divisão\n:");
							
							
							
							int esc = int.Parse(Console.ReadLine());
							
							switch (esc) {
								case 1:
									Console.WriteLine("Somando {0} + {1} = {2}",num1, num2, num1+num2);
									break;
								case 2:
									Console.WriteLine("Subtraindo {0} - {1} = {2}", num1, num2, num1-num2);
									break;
								case 3:
									Console.WriteLine("Multiplicando {0} x {1} = {2}", num1, num2, num1*num2);
									break;
								case 4:
									Console.WriteLine("Dividindo {0} / {1} = {2}", num1, num2, num1/num2);
									break;
								case 0:
									
									sair3 = 0;
									Console.Clear();
									break;
							}
						}
						
						break;
						
					case 7:
						/*7. Escreva um programa em C# para exibir os 10 primeiros números
						naturais.*/
						
						Console.WriteLine("Atividade 07");
						Console.WriteLine("Escolha uma opção: ");
						Console.WriteLine("1) For\n2) While");
						int eskolha = int.Parse(Console.ReadLine());
						int k = 0;
						
						if (eskolha == 1) {
							for (int i = 0; i < 10; i++) {
								Console.Write("{0} ", i);
							}
							
						} else if (eskolha == 2){
							while (k < 10) {
								Console.WriteLine("{0} ", k);
								k++;
							}
						}
						
						
						Console.ReadKey(true);
						break;
						
					case 8:
						/*8. Escreva um programa em C# para encontrar a soma dos 10 primeiros
						números naturais.*/
						
						Console.WriteLine("Atividade 08");
						Console.WriteLine("Escolha uma opção: ");
						Console.WriteLine("1) For\n2) While");
						int esckolha = int.Parse(Console.ReadLine());
						int soma3 = 0, soma40 = 0;
						int i3 = 0;
						
						if (esckolha == 1) {
							for (int i = 0; i < 10; i++) {
								Console.Write("{0} ", i);
								soma3 += i;

							}
							Console.WriteLine("\nA soma de todos números será: {0}", soma3);
						} else if (esckolha == 2) {
							while(i3 < 10){
								Console.Write("{0} ", i3);
								soma40 += i3;
								i3++;

							}
							Console.WriteLine("\nA soma de todos números será: {0}", soma40);
						}
						
						
						
						Console.ReadKey(true);
						break;
						
					case 9:
						/*9. Escreva um programa em C# para exibir n termos de números naturais e
						sua soma.*/
						
						Console.WriteLine("Atividade 09");
						
						Console.WriteLine("Digite a quantidade de termos: ");
						int num4 = int.Parse(Console.ReadLine());
						
						int soma4 = 0;
						
						for (int i = 0; i <= num4; i++) {
							Console.Write("{0} ", i);
							soma4 += i;
						}
						
						Console.WriteLine("\n\nA soma de todos termos será: {0}", soma4);
						Console.ReadKey(true);
						break;
						
					case 10:
						/*10. Escreva um programa em C# para ler 10 números do teclado e
						encontrar sua soma e média.*/
						
						int num = 0;
						float media = 0.0f;
						float soma = 0.0f;
						
						Console.WriteLine("Insira 10 números para somar e encontrar a média: ");
						for (int i = 1; i <= 10; i++) {
							Console.Write("{0}° Número: ", i);
							num = int.Parse(Console.ReadLine());
							soma += num;
							
						}
						
						media = soma / 10;
						
						Console.WriteLine("A soma destes números é: {0}", soma);
						Console.WriteLine("A média destes números é: {0}", media);
						
						Console.ReadKey(true);
						break;
						
					case 11:
						/*11. Escreva um programa em C# para exibir o cubo do número até a
						quantidade digitada pelo usuário.*/
						
						Console.WriteLine("Atividade 11");
						
						Console.WriteLine("Digite um número: ");
						int numero = int.Parse(Console.ReadLine());
						int cubo = 0;
						
						for (int i = 1; i <= numero; i++) {
							cubo = i * i * i;
							Console.WriteLine("{0}³ é igual à {1}", i, cubo);
						}
						Console.ReadKey(true);
						break;
						
					case 12:
						/*12. Escreva um programa em C# para exibir a tabela de multiplicação de
						um determinado número inteiro.*/
						
						Console.WriteLine("Atividade 12");
						
						Console.WriteLine("Digite um número: ");
						int numero01 = int.Parse(Console.ReadLine());
						
						for (int i = 1; i <= numero01; i++) {
							Console.WriteLine("{0} x {1} = {2}", i, numero01, i * numero01);
						}
						Console.ReadKey(true);
						break;
						
					case 13:
						/*13. Escreva um programa em C# para exibir os n termos do número natural
						ímpar e sua soma.*/
						
						Console.WriteLine("Atividade 13");
						
						Console.WriteLine("Digite um número: ");
						int numeros02 = int.Parse(Console.ReadLine());
						int somaNimpar = 0;
						for (int i = 0; i <= numeros02; i++) {
							if (i % 2 != 0) {
								somaNimpar += i;
								Console.WriteLine("Números ímpares: {0}", i);
							}
						}
						Console.WriteLine("A soma dos números ímpares: {0}", somaNimpar);
						Console.ReadKey(true);
						break;
						
					case 14:
						/*14. Escreva um programa C# para imprimir as letras do alfabeto de a até z.*/
						Console.WriteLine("Atividade 14");
						for (char i = 'A'; i <= 'Z'; i++) {
							Console.Write("{0} ",i);
						}
						
						Console.ReadKey(true);
						break;
						
					case 15:
						/*15. Escreva um programa C# para encontrar a soma de números pares
						entre 1 e n.*/
						Console.WriteLine("Atividade 15");
						int i2 = 0;
						int n = 0;
						int soma2 = 0;
						
						Console.WriteLine("Digite um valor: ");
						n = int.Parse(Console.ReadLine());
						Console.WriteLine("Deseja usar: \n1)For\n2)While");
						int escoulha = int.Parse(Console.ReadLine());
						
						if(escoulha == 1){
							for (int i = 0; i < n; i++) {
								if(i % 2 == 0){
									soma2 += i;
									Console.Write("{0} ", i);
								}
							}
							Console.WriteLine("\nA soma dos números pares é: {0}", soma2);
						} else if (escoulha == 2) {
							
							while (i2 < n) {
								if(i2 % 2 == 0){
									soma2 += i2;
									Console.Write("{0} ", i2);
								}
								i2++;
							}
							Console.WriteLine("\nA soma dos números pares é: {0}", soma2);
						}
						
						
						
						Console.ReadKey(true);
						break;
						
					case 16:
						/* 16. Escreva um programa em C# para calcular o fatorial de um determinado
						número.*/
						Console.WriteLine("Atividade 16");
						
						Console.WriteLine("Digite um número (max: 12): ");
						int numeor = int.Parse(Console.ReadLine());
						int fatorial = 1;
						
						for (int i = 1; i <= numeor; i++) {
							fatorial *=  i;
							Console.WriteLine("{0}! = {1}", i, fatorial);
						}
						Console.ReadKey(true);
						break;
						
					case 17:
						/*17. Escreva um programa em C# para exibir o padrão como triângulo de
						ângulo reto usando um asterisco. */
						Console.WriteLine("Atividade 17");
						
						Console.WriteLine("");
						for (int i = 1; i <= 5; i++) {
							for (int j = 1; j <= i; j++) {
								Console.Write(" *");
							}
							Console.WriteLine(" ");
						}
						
						Console.ReadKey(true);
						break;
						
					case 18:
						/*18. Escreva um programa em C# para criar um padrão como triângulo de
						ângulo reto com números iguais que repetirá um número em cada linha.
						O padrão é o seguinte:*/
<<<<<<< HEAD
						
=======
>>>>>>> 1190b3505672faf6ef88d23349cfb1c5faf5b1d8
						Console.WriteLine("Atividade 18");
						
						Console.WriteLine("");
						for (int i = 1; i <= 5; i++) {
							for (int j = 1; j <= i; j++) {
								Console.Write(i);
							}
							Console.WriteLine(" ");
						}
						
						Console.ReadKey(true);
						break;
						
					case 19:
						/*19. Escreva um programa em C# para exibir a tabuada de multiplicação
						verticalmente de 1 a n.*/
						
						Console.WriteLine("Atividade 19");
						
						Console.WriteLine("Digite um número: ");
						int numero04 = int.Parse(Console.ReadLine());
						
						for (int i = 1; i <= numero04; i++) {
							Console.WriteLine("{0}\nx\n{1}\n=\n{2}\n",i, numero04, i * numero04);
						}
						Console.ReadKey(true);
						break;
						
					case 20:
						/*20. Escreva um programa C# para encontrar a soma do primeiro e do
						último dígito de qualquer número.*/
						
						Console.WriteLine("Atividade 20");
						Console.Write("Digite um número: ");
						int num01 = int.Parse(Console.ReadLine());
						
<<<<<<< HEAD
						int ultiDigit = num01 % 10;
						int primDigit = num01;
						
						for (; primDigit >= 10; primDigit /= 10) {}
						
						int sum = primDigit + ultiDigit;
=======
						int lastDigit = num01 % 10; 
						int firstDigit = num01;
						
						for (; firstDigit >= 10; firstDigit /= 10) {}
						
						int sum = firstDigit + lastDigit;
>>>>>>> 1190b3505672faf6ef88d23349cfb1c5faf5b1d8
						Console.WriteLine("A soma do primeiro e do último dígito é: {0}", sum);
						Console.ReadKey(true);
						break;
					case 0:
						sair = 0;
						break;
					default:
						Console.WriteLine("Opção Inválida");
						break;
				}
				
			}
			
		}
	}
}
