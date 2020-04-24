using Microsoft.AspNetCore.Mvc;
using Repository.Base;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace FlowerDelivery.Controllers.EFCoreBaseController
{
    public abstract class EFCoreBaseController<TModel, TRepository> : Controller
        where TModel : class
        where TRepository : IRepository<TModel>
    {
        protected readonly TRepository _repository;

        public EFCoreBaseController(TRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<TModel>>> Index()
        {
            return View(await _repository.GetAll());
        }

        [HttpGet]
        public async Task<ActionResult> Details(int id)
        {
            return View(await _repository.Get(id));
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public async Task<ActionResult> Create(TModel model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    await _repository.Add(model);
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes.");
            }
            return View(model);
        }

        [HttpGet]
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
                return NotFound();
            return View(await _repository.Get(id));
        }

        [HttpPost]
        public virtual async Task<ActionResult> Edit([FromForm]TModel model)
        {
            try
            {
                if (model == null)
                    return View();

                if (ModelState.IsValid)
                {
                    await _repository.Update(model);
                    return RedirectToAction("Index");
                }
            }
            catch (DataException)
            {
                ModelState.AddModelError("", "Unable to save changes.");
            }
            return View(model);
        }

        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
                return NotFound();
            try
            {
                await _repository.Delete(id);
                return RedirectToAction("Index");
            }
            catch (DataException)
            {
                return RedirectToAction("Index");
            }
        }
    }
}
