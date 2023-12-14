using System;
using System.Diagnostics;

namespace ExecutarComandos.Models
{
    class Executar
    {
        public void EnumerarServicos()
        {
            Process comando = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "powershell.exe";
            startInfo.Arguments = "netstat -aon | findstr \"ESTABLISHED\"";
            comando.StartInfo = startInfo;
            comando.Start();
            
        }

        public void EnumerarUserEGroup()
        {   
            Process comando2 = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "powershell.exe";
            startInfo.Arguments = $@"Get-LocalUser; net localgroup";
            comando2.StartInfo = startInfo;
            comando2.Start();
            
        }

        public void VisualizarHosts()
        {
            Process comando3 = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "powershell.exe";
            startInfo.Arguments = $@"type c:\Windows\System32\Drivers\etc\hosts";
            comando3.StartInfo = startInfo;
            comando3.Start();
            
        }

        public void MapeamentoGeral()
        {
            Process comando4 = new Process();
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = "powershell.exe";
            startInfo.Arguments = $@"whoami;
            reg query HKEY_LOCAL_MACHINE\SYSTEM\ControlSet001\Control\ComputerName\ComputerName;
            wmic os list brief;Get-LocalUser; net localgroup;type c:\Windows\System32\Drivers\etc\hosts;
            netstat -aon | findstr 'ESTABLISHED'";
            comando4.StartInfo = startInfo;
            comando4.Start();
            
        } 
    }
}
