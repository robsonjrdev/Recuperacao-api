using WebAPI.Context;
using WebAPI.Models;

namespace WebAPI.Repositories
{
    public class LivroRepository
    {
        private readonly ChapterContext _chapterContext;

        public LivroRepository(ChapterContext chapterContext)
        {
            _chapterContext = chapterContext;
        }

        public List<Livro> Listar()
        {
            return _chapterContext.Livros.ToList();
        }

        public Livro BuscarPorId(int id)
        {
            return _chapterContext.Livros.Find(id);
        }

        public void Cadastrar(Livro livro)
        {
            _chapterContext.Livros.Add(livro);
            _chapterContext.SaveChanges();
        }
    }
}
