using System;

namespace ExemploSwitchCaseCsharp8
{
    class Program
    {
        static void Main()
        {
            var resultado = GetOperador(Operador.somar);

            Console.WriteLine(resultado);

            SwitchExemplo();
        }

        public enum Operador
        {
            subtrair,
            multiplicar,
            somar
        }

        private static string GetOperador(Operador operador) => operador switch
        {
            Operador.multiplicar => "Multiplicar",
            Operador.somar => "Somar",
            Operador.subtrair => "subtrair",
            _ => throw new ArgumentException("Operador desconhecido")
        };


        private static void SwitchExemplo()
        {
            var operador = "+";
            var resultado = operador switch
            {
                "-" => "Subtrair",
                "*" => "Multiplicar",
                "+" => "Somar",
                "_" => "Operador desconhecido"
            };

            Console.WriteLine(resultado);
        }
    }
}
