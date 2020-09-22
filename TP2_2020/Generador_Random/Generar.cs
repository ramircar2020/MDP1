using System;
using System.Collections.Generic;
using System.Text;
namespace TP2.Generador_Random
{
    public class Generar : IGenerador
    {	
    	static Random rnd_dni = new Random();
    	public int Gen_DNI()
    	{	
    		int dni = rnd_dni.Next(26000000, 43000000);
    		return dni;
        }
    	static Random rnd_legajo = new Random();
        public int Gen_Legajo()
        {
            int legajo = rnd_legajo.Next(0, 20000);
            return legajo;
        }
		static Random rnd_nom = new Random();
        public string Gen_Nombre()
        {
            List<string> nombresAlAzar = new List<string>
            {	"Joseph","Ismael","Joaquin","Elsa",
                "Carlos","Esteban","Raul","Luana",
                "Beto","Juan","Ángel","Santiago",
                "Kiko","Dario","Marcos","Carmen",
                "María","Mateo","Jesús","Julian",
                "Gino","Gina","Elias","Moises",
                "Leandro","Gonzalo","Gabriel","Franco",
                "Sergio","Ariel","Nehuen","Gerardo",
                "Jeremy","Antonio","Rosa","Bastian",
                "Julio","André","Roque","Jimena",
                "Laura","Rinaldo","Sharon","Rosa",
                "Claudia","Hector","Mabi","Osvaldo",
                "Matias","Miguel"
            };
            int indice_nom = rnd_nom.Next(nombresAlAzar.Count);
            return nombresAlAzar[indice_nom];
        }
		static Random rnd_promedio = new Random();
        public double Gen_Promedio()
        {	
        	double promedio = Math.Round(rnd_promedio.Next(2, 10) + rnd_promedio.NextDouble(), 2);
            return promedio;
        }
    }
}
