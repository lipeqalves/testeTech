﻿namespace ApiTeste.Models
{
    public class Veiculo
    {
        public int Id { get; set; }
       
        public string? TipoVeiculo { get; set; }
        public string? Placa { get; set; }
        public string? Modelo { get; set; }

        public string? Ano { get; set; }
        public string? Cor { get; set; }


    }
}