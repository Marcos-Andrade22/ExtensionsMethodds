using System;

namespace ExtensionsMethodds;

public static class Extensoes
{
    public static double ElevadoA(this double numero, double expoente)
    {
        return Math.Pow(numero, expoente);
    }

    public static string RemoverAcentos(this string texto)
    {
        string comAcentos = "Olá,vocêgostariadeiràpadariaamanhã?Émuitoimportantetrazeropãoquentinho!";
        string semAcentos = "Ola,vocegostariadeirapadariaamanha?Emuitoimportantetrazeropaoquentinho!";

        for (int i = 0; i < comAcentos.Length; i++){
            texto = texto.Replace(comAcentos[i].ToString(), semAcentos[i].ToString());
        }
        
        return texto;

    }
}
