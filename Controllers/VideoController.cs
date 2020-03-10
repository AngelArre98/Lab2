using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using MVCLaboratorio.Utilerias;


namespace MVCLaboratorio.Controllers
{
    public class VideoController : Controller
    {
        //
        // GET: /Video/

        public ActionResult Index()
        {

            ViewData["video"]= BaseHelper.ejecutarConsulta("sp_mostrar", CommandType.StoredProcedure);
            return View();
        }

        public ActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Create(int Idvideo,
                                    string titulo,
                                      int repro,
                                       string url)
        {
            //guardar video

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@Idvideo", Idvideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@repro", repro));
            parametros.Add(new SqlParameter("@url", url));

            BaseHelper.ejecutarSentencia("sp_video_insertar", CommandType.StoredProcedure, parametros);

            return RedirectToAction("Index", "Video");
        }

        public ActionResult Delete()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Delete(int Idvideo)
        {

            //eliminar video

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", Idvideo));

            BaseHelper.ejecutarSentencia("sp_eliminar", CommandType.StoredProcedure, parametros);
            return RedirectToAction("Index", "Video");
        }

        public ActionResult Edit()
        {
            return View();
        }
        [HttpPost]
       
        
        public ActionResult Edit(int Idvideo, string titulo, int repro, string url)
        {
            //Editar

            List<SqlParameter> parametros = new List<SqlParameter>();
            parametros.Add(new SqlParameter("@IdVideo", Idvideo));
            parametros.Add(new SqlParameter("@titulo", titulo));
            parametros.Add(new SqlParameter("@repro", repro));
            parametros.Add(new SqlParameter("@url", url));

            BaseHelper.ejecutarSentencia("sp_edit", CommandType.StoredProcedure, parametros);
            return RedirectToAction("Index", "Video");
        }

      
    }
}
