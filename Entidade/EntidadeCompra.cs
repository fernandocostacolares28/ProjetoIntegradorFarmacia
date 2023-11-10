using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoIntegradorFarmacia.Entidade
{
    internal class EntidadeCompra
    {
        public Int32 id_compra;
        public string nomefornecedor;
        public string nameproduto_compra;
        public Double valortotal_compra;
        public Int64 quantidade_produto;
        public DateTime systemData;
    }
}
