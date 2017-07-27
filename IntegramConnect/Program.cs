using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegramConnect
{
    class Program
    {
        static void Main(string[] args)
        {
            IIntegramService integramSrv = new IntegramConnect();
            integramSrv.EnviarAlerta("Teste","Meu teste");
        }
    }
}
