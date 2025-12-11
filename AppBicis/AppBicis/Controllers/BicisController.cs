using AppBicis.Models;
using Microsoft.AspNetCore.Mvc;

namespace AppBicis.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BicisController : ControllerBase
    {

        private readonly DbContextBici _context = null;

        public BicisController(DbContextBici pContext)
        {
            _context = pContext;
        }

        [HttpGet]
        [Route("List")]
        public List<Bici> List()
        {
            return _context.Bicis.ToList();
        }

        [HttpPost]
        [Route("Save")]
        public string Save(Bici temp)
        {

            string msj = "";

            try
            {

                if (temp == null)
                {
                    msj = "No se pueden ingresar valores nulos";
                }
                else
                {
                    _context.Bicis.Add(temp);
                    _context.SaveChanges();
                    msj = $"La bici con codigo de barra {temp.CodBarra} se ha registrado correctamente";
                }

            }
            catch (Exception ex)
            {
                msj = $"Error: {ex.Message}";
            }
            return msj;
        }//CIerre Post

        [HttpPut]
        [Route("Update")]
        public string Update(Bici temp)
        {
            string msj = "";
            try
            {
                if (temp == null)
                {
                    msj = "No se pueden ingresar valores nulos";
                }
                else
                {
                    var bicicleta = _context.Bicis.FirstOrDefault(o => o.CodBarra == temp.CodBarra);
                    if (bicicleta != null)
                    {
                        bicicleta.Modelo = temp.Modelo;
                        bicicleta.Annio = temp.Annio;
                        bicicleta.PrecioVenta = temp.PrecioVenta;
                        bicicleta.Proveedor = temp.Proveedor;
                        bicicleta.FechaRegistro = temp.FechaRegistro;
                        bicicleta.Estado = temp.Estado;

                        //Aplicamos cambios
                        _context.Bicis.Update(bicicleta);
                        _context.SaveChanges();

                        msj = $"La bici con codigo de barra {temp.CodBarra} se ha actualizado correctamente";
                    }
                    else
                    { 
                        msj = $"La bici con codigo de barra {temp.CodBarra} no existe";
                    }
                }
            }
            catch(Exception ex)
            {
                msj = $"Error: {ex.Message}";
            }
            return msj;
        }// cierre metodo

        [HttpGet]
        [Route("Search")]
        public Bici Search(string pCodBarra)
        { 
            return  _context.Bicis.FirstOrDefault(o => o.CodBarra == pCodBarra);
        }//Cieerre metodo

        [HttpDelete]
        [Route("Delete")]
        public string Delete(string tCodBarra)
        {

            string msj = "";
            try
            {
                Bici temp = _context.Bicis.FirstOrDefault(o => o.CodBarra == tCodBarra);
                if (temp == null)
                {
                    msj = $"La bici con codigo de barra {tCodBarra} no existe";
                }
                else
                {
                    _context.Bicis.Remove(temp);
                    _context.SaveChanges();
                    msj = $"La bici con codigo de barra {tCodBarra} se ha eliminado correctamente";
                }
            }
            catch (Exception ex)
            {
                msj = $"Error: {ex.Message}";
            }
            return msj;
        }//Cierre metodo



    }//cierre class
}//cierre namespace
