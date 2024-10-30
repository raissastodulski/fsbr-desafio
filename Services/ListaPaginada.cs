using Microsoft.EntityFrameworkCore;

namespace fsbr_desafio.Services
{
    public class ListaPaginada<T> : List<T>
    {
        public int Pagina { get; private set; }
        public int QuantidadeDePaginas { get; private set; }

        public ListaPaginada(List<T> itens, int totalDeRegistros, int pagina, int tamanhoDaPagina)
        {
            Pagina = pagina;
            QuantidadeDePaginas = (int)Math.Ceiling(totalDeRegistros / (double)tamanhoDaPagina);

            this.AddRange(itens);
        }

        public bool TemPaginaAnterior => Pagina > 1;

        public bool TemPaginaSeguinte => Pagina < QuantidadeDePaginas;

        public static async Task<ListaPaginada<T>> CreateAsync(IQueryable<T> source, int pagina, int tamanhoDaPagina)
        {
            var totalDeRegistros = await source.CountAsync();
            var itens = await source.Skip((pagina - 1) * tamanhoDaPagina).Take(tamanhoDaPagina).ToListAsync();
            return new ListaPaginada<T>(itens, totalDeRegistros, pagina, tamanhoDaPagina);
        }
    }
}