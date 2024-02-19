/*
 * Created by SharpDevelop.
 * User: bmd-tech
 * Date: 24/07/2023
 * Time: 16:50
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace Projet_4
{
	class Program
	{
		public static void Main(string[] args)
		{
			int mn, n, hh, ss;
			
			Console.WriteLine("Entrez le nombre de secondes a convertir: ");
			
			
			n=int.Parse(Console.ReadLine());
			hh=n/3600;
			mn= (n%3600)/60;
			ss= (n%3600)%60;
			
			
			Console.WriteLine(n+"secondes= "+hh+":"+mn+":"+ss);
			           
				
			
			// TODO: Implement Functionality Here
			
			Console.Write("Press any key to continue . . . ");
			Console.ReadKey(true);
		}
	}
}