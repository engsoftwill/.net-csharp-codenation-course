using System;
namespace aulaGenerics
{
    public static class extensionmethod
    {
        public static int ContadorDePalavras(this string str) //metodo deve ser estático
        {
            return str.Split(new char[]{' ','.','?' },
            StringSplitOptions.RemoveEmptyEntries).Length;
        }
    }
}