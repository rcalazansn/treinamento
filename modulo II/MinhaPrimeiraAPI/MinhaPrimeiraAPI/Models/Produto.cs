﻿using System.ComponentModel.DataAnnotations;

namespace MinhaPrimeiraAPI.Models
{
    public class Produto
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public decimal Valor { get; set; }
    }
}
