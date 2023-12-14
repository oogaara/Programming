using System;
using System.Diagnostics;
using ExecutarComandos.Models;

Executar comando = new Executar();

Console.WriteLine(" BWR - Basic Windows Recon v1\n\t by felipsfelix_");
Console.Write("---------------------------------------------\n");

Console.WriteLine("O que deseja fazer na maquina?\n");
Console.WriteLine("[1] Enumerar serviços Ativos");
Console.WriteLine("[2] Vizualizar usuarios e grupos");
Console.WriteLine($@"[3] Visualizar /etc/hosts");
Console.Write("[4] Mapeamento completo do sistema\n\n-> ");

int acao = Convert.ToInt32(Console.ReadLine());
Console.Clear();

switch (acao)
{
    case 1:
        Console.WriteLine("[1] Enumerar serviços Ativos");
        comando.EnumerarServicos();
        break;

    case 2:
        Console.WriteLine("[2] Vizualizar usuarios e grupos");
        comando.EnumerarUserEGroup();
        break;

    case 3:
        Console.WriteLine($@"[3] Visualizar /etc/hosts");
        comando.VisualizarHosts();
        break;

    case 4:
        Console.Write("[4] Mapeamento completo do sistema");
        comando.MapeamentoGeral();
        break;

    default:
        Console.WriteLine("Algo inesperado aconteceu!!");
        break;
}
