/*
 * Created by SharpDevelop.
 * User: Claudia
 * Date: 24/02/2015
 * Time: 11:54 p. m.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Practica_1
{
	class Practica1
	{
		
		static void Suma(){
			
			Console.WriteLine("Dame el primer valor:");
			double operador1= double.Parse(Console.ReadLine());
			Console.WriteLine("Dame el segundo valor:");
			double operador2= double.Parse(Console.ReadLine());
			double resultado= operador1 + operador2;
			Console.WriteLine("El resultado es " + resultado);
		}
		
		static void Resta(){
			Console.WriteLine("Dame el primer valor:");
			double operador1= double.Parse(Console.ReadLine());
			Console.WriteLine("Dame el segundo valor:");
			double operador2= double.Parse(Console.ReadLine());
			double resultado= operador1 - operador2;
			Console.WriteLine("El resultado es " + resultado);
		}
		
		static void Multiplicacion(){
			Console.WriteLine("Dame el primer número:");
			double operador1= double.Parse(Console.ReadLine());
			Console.WriteLine("Dame el segundo número:");
			double operador2= double.Parse(Console.ReadLine());
			double resultado= operador1 * operador2;
			Console.WriteLine("El resultado es " + resultado);
		}
		
		static void Division(){
			Console.WriteLine("Dame el primer número:");
			double operador1= double.Parse(Console.ReadLine());
			Console.WriteLine("Dame el segundo número:");
			double operador2= double.Parse(Console.ReadLine());
			double resultado= operador1 / operador2;
			Console.WriteLine("El resultado es " + resultado);
		}
		
		static void Areacuadro(){
			Console.WriteLine("Dame valor de la Base:");
			double operador1= double.Parse(Console.ReadLine());
			Console.WriteLine("Dame valor de la Altura:");
			double operador2= double.Parse(Console.ReadLine());
			double resultado= operador1 * operador2;
			Console.WriteLine("El resultado es " + resultado);
		}
		
		static void Areatriangulo(){
			Console.WriteLine("Dame valor de Base:");
			double operador1= double.Parse(Console.ReadLine());
			Console.WriteLine("Dame valor de Altura:");
			double operador2= double.Parse(Console.ReadLine());
			double resultado= (operador1 * operador2)/2;
			Console.WriteLine("El resultado es " + resultado);
		}
		
		static void Areacirculo(){
			Console.WriteLine("Dame el valor de radio:");
			double radio= double.Parse(Console.ReadLine());
			
			Console.WriteLine("Area del circulo es: {1}", Math.PI * radio * radio);
		}
		
		public static void Main(string[] args)
		{
			int opcion;
			
			Console.Write("*****  PROGRAMA DE OPERACIONES DIVERSAS  *****" +"\n");
			do{
				Console.Write("\n" + "1) Suma" + "\n" + "2) Resta" + "\n" + "3) Multiplicación" + "\n" + "4) División" + "\n" +"5) Area Cuadrado" + "\n" + "6) Area Triangulo" + "\n" + "7) Area Circulo" + "\n" + "8) Salir" + "\n");
				opcion = Convert.ToInt32(Console.ReadLine());
				switch(opcion){
						
					case 1:
						
						Suma();
						break;
						
					case 2:
						
						Resta();
						break;
						
					case 3:
						
						Multiplicacion();
						break;
						
					case 4:
						
						Division();
						break;
						
					case 5:
						
						Areacuadro();
						break;
						
					case 6:
						
						Areatriangulo();
						break;
						
					case 7:
						
						Areacirculo();
						break;
						
						
				}
							
			}while(opcion!=8);
			
		}
	}
}