﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemplo_herança
{
    class funcionario: pessoa_fisica
    {
        private string cartao;
        public void setCartao(string cartao)
        {
            this.cartao = cartao;
        }
        public string getCartao()
        {
            return this.cartao;
        }
    }
}
