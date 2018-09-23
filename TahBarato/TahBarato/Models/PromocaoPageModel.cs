using System;
using System.Collections.Generic;
using System.Text;

namespace TahBarato.Models
{
    public class PromocaoPageModel
    {
        public string Supermercado { get; set; }
        public string Marca { get; set; }
        public string Nome { get; set; }
        public string Quantidade { get; set; }
        public string Foto { get; set; }
        public DateTime Validade { get; set; }
        public string Preco { get; set; }
        public int Likes { get; set; }
        public int Dislikes { get; set; }
    }
}
