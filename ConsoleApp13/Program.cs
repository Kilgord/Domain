using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Management;
namespace ConsoleApp13
{
    public class Test
    {
       

    }
    class Program
    {
        static void Main(string[] args)
        {
            string domain = System.Net.NetworkInformation.IPGlobalProperties.GetIPGlobalProperties().DomainName; // Получение домена(если его нет, то выдает пустое значение)
            ManagementObjectSearcher mos = new ManagementObjectSearcher(@"root\CIMV2", @"SELECT * FROM Win32_ComputerSystem");
            
            if (domain == null)
            {
                Console.WriteLine("DomainName: {0}", domain);
            }
            else
            {
                foreach (ManagementObject wg in mos.Get())
                {
                    Console.WriteLine("Workgroup: " + wg["Workgroup"]);
                }
            }
            Console.WriteLine("UserName: {0}", Environment.UserName); // Получение имени

            Console.ReadKey();

        }
    }
}
