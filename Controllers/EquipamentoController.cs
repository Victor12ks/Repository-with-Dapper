using McardsBanco._Infra;
using McardsBanco._Repositorio;
using McardsBanco.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace McardsBanco.Controllers
{
    public class EquipamentoController : Controller
    {
        EquipamentoRepositorio _ERE = new EquipamentoRepositorio(new MSSQLDB());
        MarcaRepositorio _MRE = new MarcaRepositorio(new MSSQLDB());
        // GET: Equipamento
        public ActionResult Index()
        {
            ViewBag.Marca = _MRE.Listar();
            return View(_ERE.Listar());
            
        }

        // GET: Equipamento/Details/5
        public ActionResult Details(int id)
        {
            ViewBag.Marca = _MRE.Listar();
            return View(_ERE.buscarPorID(id));
        }

        // GET: Equipamento/Create
        public ActionResult Create()
        {
           
                ViewBag.Marca = _MRE.Listar();
            
           
            return View();
        }

        // POST: Equipamento/Create
        [HttpPost]
        public ActionResult Create(Equipamento equipamento)
        {
            if (ModelState.IsValid)
            {
                _ERE.Inserir(equipamento);
                return RedirectToAction("Index");
            }
            ViewBag.Marca = _MRE.Listar();//Vai preencher o DropList na View novamente caso dê erro na validação
            return View(equipamento);
        }
        //public ActionResult ModeloUnico(string Modelo)
        //{
        //    var lista = _ERE.Listar();
        //    return Json(lista.All(x => x.Modelo.ToLower() != Modelo.ToLower()), JsonRequestBehavior.AllowGet);
        //}

        // GET: Equipamento/Edit/5
        public ActionResult Edit(int id)
        {
            ViewBag.Marca = _MRE.Listar();
            return View(_ERE.buscarPorID(id));
        }

        // POST: Equipamento/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Equipamento item)
        {
            if (ModelState.IsValid)
            {
                ViewBag.Marca = _MRE.Listar();
                _ERE.Alterar(item);
                return RedirectToAction("Index");
            }
            else
            {
                ViewBag.Marca = _MRE.Listar();
                return View(item);
            }
        }

        // GET: Equipamento/Delete/5
        public ActionResult Delete(int id)
        {
            ViewBag.Marca = _MRE.Listar();
            return View(_ERE.buscarPorID(id));
        }

        // POST: Equipamento/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Equipamento item)
        {
            try
            {
                ViewBag.Marca = _MRE.Listar();
                _ERE.Deletar(new Equipamento { Id_Equipamento = id });
                return RedirectToAction("Index");
            }
            catch (Exception e)
            {
                return View(_ERE.buscarPorID(id));
            }
        }
    }
}
