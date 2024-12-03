using Fornecedores.Data;
using Fornecedores.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Diagnostics;

namespace ToDo.Controllers
{
    public class TarefasController : Controller
    {
        private readonly AppCont _appCont;

        public TarefasController(AppCont appCont)
        {
            _appCont = appCont;
        }

        public IActionResult Index()
        {
            var allTasks = _appCont.Tarefas.ToList();
            return View(allTasks);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var fornecedor = await _appCont.Tarefas.FirstOrDefaultAsync(x => x.Id == id);

            if (fornecedor == null)
            {
                return BadRequest();
            }
            return View(fornecedor);
        }

        //GET: Tarefas/Create
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Fornecedor fornecedor)
        {
            if (ModelState.IsValid)
            {
                _appCont.Add(fornecedor);
                await _appCont.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(fornecedor);
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var tarefa = await _appCont.Tarefas.FirstOrDefaultAsync(x => x.Id == id);
            if (tarefa == null)
            {
                return BadRequest();
            }
            return View(tarefa);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int? id, Fornecedor fornecedor)
        {
            if (id == null)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                _appCont.Update(fornecedor);
                await _appCont.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(fornecedor);
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var fornec = await _appCont.Tarefas.FirstOrDefaultAsync(x => x.Id == id);

            if (fornec == null)
            {
                return NotFound();
            }
            return View(fornec);
        }


        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var tarefa = await _appCont.Tarefas.FirstOrDefaultAsync(x => x.Id == id);
            if (tarefa != null)
            {
                _appCont.Tarefas.Remove(tarefa);
                await _appCont.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(tarefa);
        }
    }
}
