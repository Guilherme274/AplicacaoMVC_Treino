using Microsoft.AspNetCore.Mvc;
using ProjetoMVC_Treino.Data;
using ProjetoMVC_Treino.Models;
using System.Collections.Generic;

namespace ProjetoMVC_Treino.Controllers
{
    public class EmprestimoController : Controller
    {

        readonly private ApplicationDbContext _db;

        public EmprestimoController(ApplicationDbContext db)
        {
            _db = db;
        }
        public IActionResult Index()
        {
            IEnumerable<EmprestimosModel> emprestimos = _db.Emprestimos;
            return View(emprestimos);
        }
    }
}
