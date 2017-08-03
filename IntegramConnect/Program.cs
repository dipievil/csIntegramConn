using IntegramConn;
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
            IIntegramServices integramSrv = new IntegramService();
            integramSrv.EnviarAlerta("dipi","Meu teste");
        }
    }
}
