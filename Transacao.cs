﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuSuperBanco;
internal class Transacao
{

    public decimal Valor { get; set; }
    public DateTime Data { get; set; }

    public string Obs { get; set; }

    public Transacao(decimal valor, DateTime data, string Obs)
    {
        this.Valor = valor;
        this.Data = data;
        this.Obs = Obs;
    }
}