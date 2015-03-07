using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helados
{
    class Helado
    {
        private string _tipohelado;
        public string TipoHelado
        {
            set { _tipohelado = value; }
            get { return _tipohelado; }
        }

        private int _cantidad;
        public int Cantidad
        {
            set { _cantidad = value; }
            get { return _cantidad; }
        }

        public int Valor
        {
            get 
            {
                if (_tipohelado == "Vainilla")
                {
                    return 1300;
                }
                else if (_tipohelado == "Chocolate")
                {
                    return 1000;
                }
                else if (_tipohelado == "Caramelo")
                {
                    return 1200;
                }
                else if (_tipohelado == "Mora")
                {
                    return 500;
                }
                else
                {
                    return 1400;
                }
            }
        }
    }
}
