using Microsoft.EntityFrameworkCore;
using fsbr_desafio.Models;

namespace fsbr_desafio.Data
{
    public class FsbrDesafioContexto : DbContext
    {
        public FsbrDesafioContexto (DbContextOptions<FsbrDesafioContexto> options)
            : base(options)
        {
        }

        public DbSet<Processo> Processos { get; set; } = default!;
    }
}
