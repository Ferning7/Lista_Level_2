
using System;

namespace Lista_level_2
{
	class Program
	{
		public static void Main(string[] args)
		{
			int sair = 1;
			int opcao = 0;
			
			while (sair == 1){
				Console.Clear();
				Console.WriteLine("------------ MENU DE ATIVIDADES ------------");
				Console.WriteLine("(Pressione '0' para sair)");
				Console.WriteLine("Escolha uma opção de 1 ao 12: ");
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
						
						Console.WriteLine("Digite uma letra: ");
						
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
						Console.WriteLine("Atividade 05");
						
						Console.WriteLine("Escolha uma opção para calcular a área:");
						
						Console.WriteLine("1) Triângulo\n2) Quadrado\n3) Retangulo\n4) Círculo");
						int escolha = int.Parse(Console.ReadLine());
						
						switch (escolha) {
							case 1:
								Console.WriteLine("Cálculo da área do Triângulo");
								Console.WriteLine("A = área  B = Base  H = altura");		
								int A, B, H;
								Console.Write("A:");
								A = int.Parse(Console.ReadLine());
								Console.Write("B:");
								B = int.Parse(Console.ReadLine());
								Console.Write("h:");
								H = int.Parse(Console.ReadLine());
								
								Console.WriteLine("A = b * h / 2");
								Console.WriteLine("Área: ({0}) = {1} * {2} / {3}", A, B, H, (B*H)/2);
		
								break;
							case 2:
								Console.WriteLine("Cálculo da área do Triângulo");
								Console.WriteLine("A = área  B = Base  H = altura");		
								int A, B, H;
								Console.Write("A:");
								A = int.Parse(Console.ReadLine());
								Console.Write("B:");
								B = int.Parse(Console.ReadLine());
								Console.Write("h:");
								H = int.Parse(Console.ReadLine());
								
								Console.WriteLine("A = b * h / 2");
								Console.WriteLine("Área: ({0}) = {1} * {2} / {3}", A, B, H, (B*H)/2);
						}
						Console.ReadKey(true);
						break;
					case 6:
						/* 6. Escreva um programa em C# que seja um Programa Orientado por Menu
						para realizar cálculos simples(soma, subtração, multiplicação e divisão).*/
						
					case 0:
						Console.WriteLine("Saindo... ");
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