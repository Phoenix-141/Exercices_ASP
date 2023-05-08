using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using ExeRibeiroCipriano.Models;

namespace ExeRibeiroCipriano.Areas.Veiculo.Controllers
{
    public class AutoController : Controller
    {

        private Carro infoCarro()
        {
            return new Carro
            {
                fabricante = "Jaguar",
                tipo = "sport",
                nome = "XE",
                transmissao = "automática"
            };
        }

        private Moto infoMoto()
        {
            return new Moto
            {
                fabricante = "Kawasaki",
                categoria = "2023",
                cilindrada = 948,
                transmissao = "automática"
            };
        }

        public ActionResult Veiculos()
        {
            var carro = infoCarro();
            var moto = infoMoto();

            var tupla = new Tuple<Carro, Moto>(carro, moto);

            return View(tupla);
        }

        public ActionResult ConsultaCarros()
        {
            var carro = infoCarro();
            return View(carro);
        }

        public ActionResult ConsultaMoto()
        {
            var moto = infoMoto();
            return View(moto);
        }
    }
}