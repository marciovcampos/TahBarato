using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;
using TahBarato.Models;

namespace TahBarato.ViewModels
{
    public class PromocaoPageViewModel
    {
        public IList<PromocaoPageModel> PromocaoPageViewCollection { get; set; }
        public object SelectedItem { get; set; }
        public PromocaoPageViewModel()
        {
            PromocaoPageViewCollection = new List<PromocaoPageModel>();
            GerarPromocaoViewModel();
        }
        private void GerarPromocaoViewModel()
        {
            PromocaoPageViewCollection = new ObservableCollection<PromocaoPageModel>
            {
                    new PromocaoPageModel
                    {
                         Supermercado = "Dia",
                         Marca = "Arrroz",
                         Quantidade= "5KG" ,
                         Foto = "",
                         Preco = "R$ 12,49"

                    },
                    new PromocaoPageModel
                    {
                         Supermercado = "Dia",
                         Marca = "Arrroz",
                         Quantidade= "5KG" ,
                         Foto = "",
                         Preco = "R$ 12,49"
                    },
                    new PromocaoPageModel
                    {
                         Supermercado = "Dia",
                         Marca = "Arrroz",
                         Quantidade= "5KG" ,
                         Foto = "",
                         Preco = "R$ 12,49"
                    },
                    new PromocaoPageModel
                    {
                        Supermercado = "Dia",
                         Marca = "Arrroz",
                         Quantidade= "5KG" ,
                         Foto = "",
                         Preco = "R$ 12,49"
                    },
                    new PromocaoPageModel
                    {
                         Supermercado = "Dia",
                         Marca = "Arrroz",
                         Quantidade= "5KG" ,
                         Foto = "",
                         Preco = "R$ 12,49"
                    },
                };
        }
    }
}
