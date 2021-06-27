﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ApiCatalogoJogos.Entities;

namespace ApiCatalogoJogos.Repositories
{
    public interface IJogoRespostiry : IDisposable
    {
        Task<List<Jogo>> Obter(int pagina, int quantidade);
        Task<Jogo> Obter(Guid id);
        Task<List<Jogo>> Obter(string nome, string produtora);
        Task<List<Jogo>> Inserir(Jogo jogo);
        Task Atualizar(Jogo jogo);
        Task Remover(Guid id);
    }
}