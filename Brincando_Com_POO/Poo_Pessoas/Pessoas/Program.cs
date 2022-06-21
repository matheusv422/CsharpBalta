using System;
using Pessoas.Domain;
using Pessoas.Messages;
using Pessoas.Service;

internal class Program
{
    private static void Main(string[] args)
    {
        var iniciarPrograma = new Business();
       iniciarPrograma.DescobrirPessoaMaisVelha();
    }

}
