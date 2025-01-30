using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using WebApplication2.Models;

namespace WebApplication2.Controllers
{
    public class UsuarioController : Controller
    {
        private readonly ApplicationDbContext _context;

        public UsuarioController(ApplicationDbContext context)
        {
            _context = context;
        }

        // GET: Usuarios
        public async Task<IActionResult> Index()
        {
            var usuarios = await _context.Usuarios.ToListAsync();
            return View(usuarios);
        }

        // GET: Usuarios/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Usuarios/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Sobrenome,CPF,Telefone")] Usuario usuario)
        {
            if (ModelState.IsValid)  // Verifica se o modelo está válido
            {
<<<<<<< HEAD
                try
                {
                    _context.Add(usuario);
                    await _context.SaveChangesAsync();
                    Console.WriteLine("Usuário salvo com sucesso!"); // Log para debug
                    return RedirectToAction(nameof(Index));
                }
                catch (DbUpdateException dbEx)
                {
                    Console.WriteLine("DbUpdateException: " + dbEx.Message);
                    if (dbEx.InnerException != null)
                    {
                        Console.WriteLine("InnerException: " + dbEx.InnerException.Message);
                        if (dbEx.InnerException.Message.Contains("could not connect"))
                        {
                            ModelState.AddModelError("", "Erro ao salvar os dados: Banco de dados não encontrado.");
                        }
                        else
                        {
                            ModelState.AddModelError("", "Erro ao salvar os dados: " + dbEx.InnerException.Message);
                        }
                    }
                    else
                    {
                        ModelState.AddModelError("", "Erro ao salvar os dados: " + dbEx.Message);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Exception: " + ex.Message);
                    ModelState.AddModelError("", "Erro ao salvar os dados: " + ex.Message);
                }
            }
            else
            {
                Console.WriteLine("Erro no ModelState");
                foreach (var error in ModelState.Values.SelectMany(v => v.Errors))
                {
                    Console.WriteLine(error.ErrorMessage);
                }
=======
                // Verifica se o CPF já existe na base
                if (_context.Usuarios.Any(u => u.CPF == usuario.CPF))
                {
                    ModelState.AddModelError("CPF", "Já existe um usuário com esse CPF.");
                    return View(usuario);  // Retorna à view com a mensagem de erro
                }

                _context.Add(usuario);  // Adiciona o novo usuário ao contexto
                await _context.SaveChangesAsync();  // Salva as alterações no banco
                return RedirectToAction(nameof(Index));  // Redireciona para a lista de usuários
>>>>>>> main
            }

            return View(usuario);  // Retorna a view com o usuário em caso de erro
        }

        // GET: Usuarios/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();  // Retorna erro se o ID não for fornecido
            }

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();  // Retorna erro se o usuário não for encontrado
            }
            return View(usuario);  // Retorna a view de edição
        }

        // POST: Usuarios/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Nome,Sobrenome,CPF,Telefone")] Usuario usuario)
        {
            if (id != usuario.Id)  // Verifica se o ID corresponde ao usuário editado
            {
                return NotFound();
            }

            if (ModelState.IsValid)  // Verifica se o modelo está válido
            {
                try
                {
<<<<<<< HEAD
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
=======
                    _context.Update(usuario);  // Atualiza o usuário no contexto
                    await _context.SaveChangesAsync();  // Salva as alterações no banco
>>>>>>> main
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.Id))  // Verifica se o usuário ainda existe
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;  // Lança exceção caso haja erro na atualização
                    }
                }
<<<<<<< HEAD
                catch (Exception ex)
                {
                    ModelState.AddModelError("", "Erro ao atualizar os dados: " + ex.Message);
                }
=======
                return RedirectToAction(nameof(Index));  // Redireciona para a lista de usuários
>>>>>>> main
            }
            return View(usuario);  // Retorna a view de edição com erros
        }

        // GET: Usuarios/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();  // Retorna erro se o ID não for fornecido
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Id == id);  // Busca o usuário a ser excluído
            if (usuario == null)
            {
                return NotFound();  // Retorna erro se o usuário não for encontrado
            }

            return View(usuario);  // Retorna a view de exclusão com o usuário
        }

        // POST: Usuarios/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
<<<<<<< HEAD
                return NotFound();
            }

            _context.Usuarios.Remove(usuario);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
=======
                return NotFound();  // Retorna erro se o usuário não for encontrado
            }

            _context.Usuarios.Remove(usuario);  // Remove o usuário do contexto
            await _context.SaveChangesAsync();  // Salva as alterações no banco
            return RedirectToAction(nameof(Index));  // Redireciona para a lista de usuários
>>>>>>> main
        }

        private bool UsuarioExists(int id)
        {
            return _context.Usuarios.Any(e => e.Id == id);  // Verifica se o usuário existe
        }
    }
}
