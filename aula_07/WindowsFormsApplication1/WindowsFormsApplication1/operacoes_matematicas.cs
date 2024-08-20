using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class operacoes_matematicas
    {
        // Atributos

        //Metodos

            /*
            Todo metodo deve ter visibilidade (public ou private) os metodos sempre serão publicos.
            Int e o tipo do metodo de acordo com a ação do metodo
            soma_dois_numeros é o nome do metodo para sua indentificação quando invocado pelo formularios (um ou mais formularios)
            (int x e int y)  são tipo "variaveis" são parametros.
            Obs parametrso são informações necessárias para o metodo funcionar.
            O que está no return é o retorno do metodo exemplo demonstração de uma formula matematica.
            */
        public int som(int x, int y)
        {
            return (x + y);
        }
        public int sub(int x, int y)
        {
            return (x - y);
        }
        public int div(int x, int y)
        {
            return (x / y);
        }
        public int mul(int x, int y)
        {
            return (x * y);
        }
    }
}
