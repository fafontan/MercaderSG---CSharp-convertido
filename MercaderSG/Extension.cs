using System.Collections.Generic;
using System.Linq;

namespace MercaderSG
{
    static class Extension
    {
        public static IEnumerable<TSource> Paginacion<TSource>(this IEnumerable<TSource> source, int Pagina)
        {
            const int CantidadRegPag = 25;
            return source.Skip((Pagina - 1) * CantidadRegPag).Take(CantidadRegPag);
        }
    }
}