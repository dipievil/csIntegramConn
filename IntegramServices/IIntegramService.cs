using System;

namespace IntegramServices
{
    public interface IIntegramServices
    {
        bool EnviarAlerta(string autor, string mensagem);
    }
}