using LibreriaClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Data.Modelos;

namespace LibreriaExpertoLogica
{
    public class ExpertoCotizacion
    {
        #region Obtener datos simulando la consulta a una base de datos.

        ParametrosAplicativo paramAplicativo = null;
        public ExpertoCotizacion() {
            paramAplicativo = ExpertoConexion.GenerarDatos();
        }

        public ParametrosAplicativo ConsultarDatosBD() {
            paramAplicativo = ExpertoConexion.GenerarDatos();
            return paramAplicativo;
        }
        #endregion
        public string GetNombreTienda() {
            return paramAplicativo.tienda.nombreTiendaRopa;
        }
        public string GetDireccionTienda() {
            return paramAplicativo.tienda.direccion;
        }
        public string GetDatosVendedor() {
            return paramAplicativo.tienda.vendedores.First().nombreVendedor + " " + paramAplicativo.tienda.vendedores.First().apellidoVendedor + " ID: " + paramAplicativo.tienda.vendedores.First().idVendedor;
        }
        public int ConsultarStockDisponible(int codigoBusqueda) {
            int cantidadStockDisponible = 0;
            paramAplicativo.prendas = new List<Prenda>();
            switch (codigoBusqueda) {
                //Buscar todas las camisas
                case 0:
                    List<Prenda> camisas = paramAplicativo.camisas.Where(x => x.tipoPrenda.nombreTipoPrenda == "Camisa").ToList();
                    cantidadStockDisponible = camisas.Count();
                    paramAplicativo.prendas = camisas;
                    break;
                //Buscar todos los pantalones.
                case 1:
                    List<Prenda> pantalones = paramAplicativo.pantalones.Where(x => x.tipoPrenda.nombreTipoPrenda == "Pantalón").ToList();
                    cantidadStockDisponible = pantalones.Count();
                    paramAplicativo.prendas = pantalones;
                    break;
                //Buscar camisas con manga corta.
                case 2:
                    List<Prenda> camisasMangaCortas = paramAplicativo.camisas.Where(x => x.tipoPrenda.nombreTipoPrenda == "Camisa").Where(x => x.nombrePrenda.Contains("Manga Corta")).ToList();
                    cantidadStockDisponible = camisasMangaCortas.Count();
                    paramAplicativo.prendas = camisasMangaCortas;
                    break;
                //Buscar camisas con cuello mao
                case 3:
                    List<Prenda> camisasCuelloMao = paramAplicativo.camisas.Where(x => x.tipoPrenda.nombreTipoPrenda.Contains("Camisa")).Where(x => x.nombrePrenda.Contains("Manga Larga")).Where(x => x.caracteristica.nombreCaracteristicaTipoPrenda.Contains("Cuello Mao")).ToList();
                    cantidadStockDisponible = camisasCuelloMao.Count();
                    paramAplicativo.prendas = camisasCuelloMao;
                    break;
                //Buscar camisas mangas cortas con cuello mao.
                case 4:
                    List<Prenda> camisaMangaCorta = paramAplicativo.camisas.Where(x => x.tipoPrenda.nombreTipoPrenda.Contains("Camisa")).Where(x => x.nombrePrenda.Contains("Manga Corta") && x.caracteristica.nombreCaracteristicaTipoPrenda.Contains("Cuello Mao")).ToList();
                    cantidadStockDisponible = camisaMangaCorta.Count();
                    paramAplicativo.prendas = camisaMangaCorta;
                    break;
                //Buscar pantalones con chupin.
                case 5:
                    List<Prenda> pantalonesChupin = paramAplicativo.pantalones.Where(x => x.tipoPrenda.nombreTipoPrenda.Contains("Pantalón")).Where(x => x.caracteristica.nombreCaracteristicaTipoPrenda.Contains("Chupin")).ToList();
                    cantidadStockDisponible = pantalonesChupin.Count();
                    paramAplicativo.prendas = pantalonesChupin;
                    break;
                    //Filtrar por calidad

            }
            return cantidadStockDisponible;
        }
        public int FiltrarPorCalidad(int codigoBusqueda) {
            int cantidadDisponible = 0;
            if (paramAplicativo.prendas!=null) {
                switch (codigoBusqueda)
                {
                    //Busco por Standard
                    case 0:
                        paramAplicativo.prendas = paramAplicativo.prendas.Where(x=>x.calidad.nombreCalidadPrenda.Contains("Standard")).ToList();
                        cantidadDisponible = paramAplicativo.prendas.Count;
                        break;
                    //Busco por Premium
                    case 1:
                        paramAplicativo.prendas = paramAplicativo.prendas.Where(x => x.calidad.nombreCalidadPrenda.Contains("Premium")).ToList();
                        cantidadDisponible = paramAplicativo.prendas.Count;
                        break;
                }
            }
            return cantidadDisponible;
        }
        public (ErrorAplicativo, decimal) CalcularPrecioCotizacion(decimal precioUnitario,int cantidad) {
            #region Validaciones
            ErrorAplicativo err = new ErrorAplicativo();
            if (cantidad>paramAplicativo.prendas.Count)
            {
                err.codigoError = -1;
                err.descripcionError = "La cantidad indicada supera a la cantidad de stock disponible";
                return (err, 0);
            }
            #endregion
            
            int porcentajeAumentoRebajaAplicar = paramAplicativo.prendas.First().caracteristica.porcentajeAumentoRebaja;
            int porcentajeAumentoRebajaCalidadAplicar = paramAplicativo.prendas.First().calidad.porcentajeAumentoRebaja;
            //Para simplificar el cálculo del ID de la cotización se hará uso de la clase Random que genera un número aleatorio.
            //Aclaro que en un entorno real esto no es una buena práctica porque puede dar lugar a IDs repetidos.
            var random = new Random();
            decimal precioCotizado = (precioUnitario + ((precioUnitario*porcentajeAumentoRebajaAplicar)/(100))+((precioUnitario*porcentajeAumentoRebajaCalidadAplicar)/(100)))*cantidad;
            //Se registra la cotización.
            Cotizacion cotizacion = new Cotizacion
            {
                idCotizacion = random.Next(0, Int32.MaxValue),
                fechaHoraCotizacion = DateTime.Now,
                cantidadCotizada = cantidad,
                idVendedor = paramAplicativo.vendedor.idVendedor,
                precioCotizacion = precioCotizado,
            };
            paramAplicativo.cotizaciones.Add(cotizacion);
            return (err,precioCotizado);
        }
        public List<(int, string, string, int)> ConsultarCotizaciones() {
            List<(int, string, string, int)> cotizaciones = new List<(int, string, string, int)>();
            foreach (var cotizacion in paramAplicativo.cotizaciones) {
                (int, string, string, int) dataCotizacion =  (cotizacion.idCotizacion,cotizacion.fechaHoraCotizacion.ToShortDateString()+"-"+cotizacion.fechaHoraCotizacion.ToShortTimeString(),string.Format("{0:c}",cotizacion.precioCotizacion),cotizacion.cantidadCotizada);
                cotizaciones.Add(dataCotizacion);
            }
            return cotizaciones;
        }
    }
}
