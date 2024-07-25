using ControleDeProjetosProauto.Setup.DataBase;
using System.ComponentModel.DataAnnotations;


namespace ControleDeProjetosProauto.Models
{
    public class Projetos
    {
        [Key]
        public int PRONID { get; set; }
        [Required]
        public string PROSNPRO { get; set; }
        [Required]
        public DateTime PRODDATCAD {  get; set; }
        [Required]
        public string PROSDESPRO { get; set; }
        public char PROCSTAT {get; set; }
        public string PROSOBRIG { get; set; }

    }

    public interface IProjetosRepository
    {
        void Insert(Projetos projetos);
        void Update(Projetos projetos);
        void Delete(Projetos projetos);
        Projetos GetByID(int id);
        IEnumerable<Projetos> GetAll();
    }

    public class ProjetoRepository : IProjetosRepository
    {
        private readonly DAL<Projetos> _dal;

        public void Insert(Projetos projetos)
        {
            _dal.AdicionarRegistro(projetos);
        }

        public void Update(Projetos projetos)
        {
            _dal.AtualizarRegistro(projetos);
        }

        public void Delete(Projetos projetos)
        {
            _dal.DeletaRegistro(projetos);
        }

        public Projetos GetByID(int id) 
        {
            return _dal.ObterRegistroPor(c => c.PRONID.Equals(id));
        }

        public IEnumerable<Projetos> GetAll()
        {
            return _dal.ObterRegistros();
        }
    }

    public class ProjetoService
    {
        private readonly IProjetosRepository _projetoRepository;

        public ProjetoService(IProjetosRepository projetoRepository)
        {
            _projetoRepository = projetoRepository;
        }

        public void Incluir(Projetos projeto)
        {
            _projetoRepository.Insert(projeto);
        }


        public void Alterar(Projetos projeto)
        {
            
            _projetoRepository.Update(projeto);
        }

        public void Excluir(Projetos produto)
        {
            _projetoRepository.Delete(produto);
        }

        public Projetos GetByID(int id)
        {
            return _projetoRepository.GetByID(id);
        }

        public IEnumerable<Projetos> GetAll()
        {
            return _projetoRepository.GetAll();
        }
    }
}
