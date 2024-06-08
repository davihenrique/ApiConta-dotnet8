﻿using ApiTestePraticoDesenvolvedor.Application.Commands.Conta.Enum;
using ApiTestePraticoDesenvolvedor.Application.Commands.Conta.Responses;

namespace ApiTestePraticoDesenvolvedor.Tests.SharedKernel.Mock.Application.Commands.Conta.Responses;
public static class ContaIncluirResponseMock
{
    public static ContaIncluirResponse ContaIncluirResponsePagamentoJaExistente(DateTime data)
    {
        return new ContaIncluirResponse
        {
            Status = StatusConta.ProblemaAoIncluir,
            Menssagens = ["Problema ao Incluir a Conta.",
                              $"Já Existe Um Pagamento Com a Data {data} !"]
        };
    }

    public static ContaIncluirResponse ContaIncluirResponseFalha()
    {
        return new ContaIncluirResponse
        {
            Status = StatusConta.ProblemaAoIncluir,
            Menssagens = ["Problema ao Incluir a Conta.",
                              "Conta não Inclusa!"]
        };
    }

    public static ContaIncluirResponse ContaInclida()
    {
        return new ContaIncluirResponse
        {
            Status = StatusConta.ContaIncluida,
            Menssagens = ["Conta Incluída Com Sucesso."]
        };
    }
}