using Data.Modelos;
using LibreriaClases;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaExpertoLogica
{
    public static class ExpertoConexion
    {
        private static int id = 0;
        //Aquí se lleva a cabo la operación de llenado de datos ficticios para las clases parametrizadas. Se simula una conexión con una base de datos.
        public static ParametrosAplicativo GenerarDatos() {
            ParametrosAplicativo paramAplicativo = new ParametrosAplicativo();
            paramAplicativo.cotizaciones = new List<Cotizacion>();
            #region Creación de Tienda.
            TiendaRopa tienda = new TiendaRopa
            {
                idTiendaRopa = GenerarID(),
                nombreTiendaRopa = "Ropa para vos",
                direccion = "Candelaria 1550, Godoy Cruz, Mendoza, Argentina",

            };
            paramAplicativo.tienda = tienda;
            #endregion
            #region Creación del vendedor.

            Vendedor vendedor = new Vendedor
            {
                idVendedor = GenerarID(),
                nombreVendedor = "Juan",
                apellidoVendedor = "Martin"
            };
            paramAplicativo.vendedor = vendedor;
            
            #endregion
            #region Creación de tipo de prenda.
            paramAplicativo.tiposPrendas = new List<TipoPrenda>();
            TipoPrenda camisa = new TipoPrenda
            {
                idTipoPrenda = GenerarID(),
                nombreTipoPrenda = "Camisa",
                fechaAlta = DateTime.Now,
                fechaBaja = DateTime.MinValue,
                fechaUltimaModificacion = DateTime.MinValue
            
            };
            TipoPrenda pantalon = new TipoPrenda
            {
                idTipoPrenda = GenerarID(),
                nombreTipoPrenda = "Pantalón",
                fechaAlta = DateTime.Now,
                fechaBaja = DateTime.MinValue,
                fechaUltimaModificacion = DateTime.MinValue
            };
            paramAplicativo.tiposPrendas.Add(camisa);
            paramAplicativo.tiposPrendas.Add(pantalon);
            #endregion
            #region Creación de Característica del tipo de prenda.
            paramAplicativo.caracteristicas = new List<CaracteristicaTipoPrenda>();
            CaracteristicaTipoPrenda camisaMangaCorta = new CaracteristicaTipoPrenda
            {
                idCaracteristicaTipoPrenda = GenerarID(),
                nombreCaracteristicaTipoPrenda = "Manga Corta",
                porcentajeAumentoRebaja = -10,
                fechaAlta = DateTime.Now,
                fechaUltimaModificacion = DateTime.MinValue,
                fechaBaja = DateTime.MinValue
            };
            CaracteristicaTipoPrenda camisaMangaLarga = new CaracteristicaTipoPrenda
            {
                idCaracteristicaTipoPrenda = GenerarID(),
                nombreCaracteristicaTipoPrenda = "Manga Larga",
                porcentajeAumentoRebaja = 0,
                fechaAlta = DateTime.Now,
                fechaBaja = DateTime.MinValue,
                fechaUltimaModificacion = DateTime.MinValue
            };
            CaracteristicaTipoPrenda camisaConCuelloMao = new CaracteristicaTipoPrenda
            {
                idCaracteristicaTipoPrenda = GenerarID(),
                nombreCaracteristicaTipoPrenda = "Cuello Mao",
                porcentajeAumentoRebaja = 3,
                fechaAlta = DateTime.Now,
                fechaBaja = DateTime.MinValue,
                fechaUltimaModificacion = DateTime.MinValue
            };
            CaracteristicaTipoPrenda camisaCuelloNormal = new CaracteristicaTipoPrenda
            {
                idCaracteristicaTipoPrenda = GenerarID(),
                nombreCaracteristicaTipoPrenda = "Cuello Normal",
                porcentajeAumentoRebaja = 0,
                fechaAlta = DateTime.Now,
                fechaBaja = DateTime.MinValue,
                fechaUltimaModificacion = DateTime.MinValue
            };
            CaracteristicaTipoPrenda pantalonChupin = new CaracteristicaTipoPrenda
            {
                idCaracteristicaTipoPrenda = GenerarID(),
                nombreCaracteristicaTipoPrenda = "Chupin",
                porcentajeAumentoRebaja = -12,
                fechaAlta = DateTime.Now,
                fechaBaja = DateTime.MinValue,
                fechaUltimaModificacion = DateTime.MinValue
            };
            CaracteristicaTipoPrenda pantalonNormal = new CaracteristicaTipoPrenda
            {
                idCaracteristicaTipoPrenda = GenerarID(),
                nombreCaracteristicaTipoPrenda = "Normal clásico",
                porcentajeAumentoRebaja = 0,
                fechaAlta = DateTime.Now,
                fechaBaja = DateTime.MinValue,
                fechaUltimaModificacion = DateTime.MinValue
            };
            paramAplicativo.caracteristicas.Add(camisaMangaCorta);
            paramAplicativo.caracteristicas.Add(camisaMangaLarga);
            paramAplicativo.caracteristicas.Add(camisaConCuelloMao);
            paramAplicativo.caracteristicas.Add(camisaCuelloNormal);
            paramAplicativo.caracteristicas.Add(pantalonNormal);
            paramAplicativo.caracteristicas.Add(pantalonChupin);
            #endregion
            #region Creación de Calidad de la prenda.
            paramAplicativo.calidades = new List<CalidadPrenda>();
            CalidadPrenda standard = new CalidadPrenda
            {
                idCalidadPrenda = GenerarID(),
                nombreCalidadPrenda = "Standard",
                porcentajeAumentoRebaja = 0
               
            };
            CalidadPrenda premium = new CalidadPrenda
            {
                idCalidadPrenda = GenerarID(),
                nombreCalidadPrenda = "Premium",
                porcentajeAumentoRebaja = 30
            };
            paramAplicativo.calidades.Add(standard);
            paramAplicativo.calidades.Add(premium);
            #endregion
            
            #region Relación entre vendedor y tienda
            paramAplicativo.tienda.vendedores = new List<Vendedor>();
            paramAplicativo.tienda.vendedores.Add(vendedor);

            #endregion
            #region Relación entre tipos de prendas y sus características.
            foreach (var tipoPrenda in paramAplicativo.tiposPrendas) {
                tipoPrenda.caracteristicaTipoPrenda = new List<CaracteristicaTipoPrenda>();
                switch (tipoPrenda.nombreTipoPrenda) {
                    case "Camisa":
                        foreach (var caracteristica in paramAplicativo.caracteristicas) {
                            switch (caracteristica.nombreCaracteristicaTipoPrenda) {
                                case "Manga Corta":
                                    caracteristica.idTipoPrenda = tipoPrenda.idTipoPrenda;
                                    tipoPrenda.caracteristicaTipoPrenda.Add(caracteristica);
                                    break;
                                case "Manga Larga":
                                    caracteristica.idTipoPrenda = tipoPrenda.idTipoPrenda;
                                    tipoPrenda.caracteristicaTipoPrenda.Add(caracteristica);
                                    break;
                                case "Cuello Normal":
                                    caracteristica.idTipoPrenda = tipoPrenda.idTipoPrenda;
                                    tipoPrenda.caracteristicaTipoPrenda.Add(caracteristica);
                                    break;
                                case "Cuello Mao":
                                    caracteristica.idTipoPrenda = tipoPrenda.idTipoPrenda;
                                    tipoPrenda.caracteristicaTipoPrenda.Add(caracteristica);
                                    break;
                            }
                        }
                        break;
                    case "Pantalón":
                        foreach (var caracteristica in paramAplicativo.caracteristicas) {
                            switch (caracteristica.nombreCaracteristicaTipoPrenda) {
                                case "Chupin":
                                    caracteristica.idTipoPrenda = tipoPrenda.idTipoPrenda;
                                    tipoPrenda.caracteristicaTipoPrenda.Add(caracteristica);
                                    break;
                                case "Normal clásico":
                                    caracteristica.idTipoPrenda = tipoPrenda.idTipoPrenda;
                                    tipoPrenda.caracteristicaTipoPrenda.Add(caracteristica);
                                    break;
                            }
                        }
                        break;
                }
            }

            #endregion
            

            #region Crear prendas.
            paramAplicativo.prendas = new List<Prenda>();
            paramAplicativo.pantalones = new List<Prenda>();
            paramAplicativo.camisas = new List<Prenda>();
            var random = new Random();
            //Crear las 500 camisas mangas cortas.
            for (int i=0;i<500;i++) {
                Prenda prenda = new Prenda
                {
                    idPrenda = GenerarID(),
                    nombrePrenda = "Camisa Manga Corta" + i,
                    tipoPrenda = paramAplicativo.tiposPrendas.Where(x => x.nombreTipoPrenda == "Camisa").First(),

                    cantidadStockDisponible = 500,
                    idCalidadPrenda = paramAplicativo.calidades[random.Next(0, paramAplicativo.calidades.Count)].idCalidadPrenda,
                    calidad = paramAplicativo.calidades[random.Next(0, paramAplicativo.calidades.Count)],
                    fechaAlta = DateTime.Now,
                    fechaBaja = DateTime.MinValue,
                    fechaUltimaModificacion = DateTime.MinValue,
                    precioPrenda = random.Next(5,6000),
                };
                paramAplicativo.camisas.Add(prenda);

            }
            //De las 500 camisas solo 200 tienen cuello mao
            for (int i = 0;i<200;i++) {
                paramAplicativo.camisas[i].caracteristica = paramAplicativo.caracteristicas.Where(x => x.nombreCaracteristicaTipoPrenda == "Cuello Mao").First();
            }
            //De las 500 camisas solo 300 tienen cuello normal
            for (int i=199;i<500;i++) {
                paramAplicativo.camisas[i].caracteristica = paramAplicativo.caracteristicas.Where(x => x.nombreCaracteristicaTipoPrenda == "Cuello Normal").First();
            }
            //Crear las 500 camisas mangas largas.
            for (int i=500;i<1000;i++) {
                Prenda prenda = new Prenda
                {
                    idPrenda = GenerarID(),
                    nombrePrenda = "Camisa Manga Larga " + i,
                    tipoPrenda = paramAplicativo.tiposPrendas.Where(x => x.nombreTipoPrenda == "Camisa").First(),
                    calidad = paramAplicativo.calidades[random.Next(0, paramAplicativo.calidades.Count)],
                    cantidadStockDisponible = 500,
                    idCalidadPrenda = paramAplicativo.calidades[random.Next(0, paramAplicativo.calidades.Count)].idCalidadPrenda,
                    fechaAlta = DateTime.Now,
                    fechaBaja = DateTime.MinValue,
                    fechaUltimaModificacion = DateTime.MinValue,
                    precioPrenda = random.Next(5, 6000),
                };
                //paramAplicativo.prendas.Add(prenda);
                paramAplicativo.camisas.Add(prenda);
            }
            //De las 500 camisas mangas largas solo 150 tienen cuello mao.
            for (int i=500;i<650;i++) {
                paramAplicativo.camisas[i].caracteristica = paramAplicativo.caracteristicas.Where(x => x.nombreCaracteristicaTipoPrenda == "Cuello Mao").First();
            }
            //De las 500 camisas mangas largas solo 350 tienen cuello normal.
            for (int i = 650; i<1000;i++) {
                paramAplicativo.camisas[i].caracteristica = paramAplicativo.caracteristicas.Where(x => x.nombreCaracteristicaTipoPrenda == "Cuello Normal").First();
            }
            //Crear los 2000 pantalones.
            for (int i=0;i<2000;i++) {
                Prenda prenda = new Prenda
                {
                    idPrenda = GenerarID(),
                    nombrePrenda = "Pantalón " + i,
                    tipoPrenda = paramAplicativo.tiposPrendas.Where(x => x.nombreTipoPrenda == "Pantalón").First(),
                    calidad = paramAplicativo.calidades[random.Next(0, paramAplicativo.calidades.Count)],
                    cantidadStockDisponible = 2000,
                    idCalidadPrenda = paramAplicativo.calidades[random.Next(0, paramAplicativo.calidades.Count)].idCalidadPrenda,
                    fechaAlta = DateTime.Now,
                    fechaBaja = DateTime.MinValue,
                    fechaUltimaModificacion = DateTime.MinValue,
                    precioPrenda = random.Next(5, 6000),
                };
                //paramAplicativo.prendas.Add(prenda);
                paramAplicativo.pantalones.Add(prenda);
            }
            //De los 2000 pantalones solo 1500 son chupines.
            for (int i=0;i<1500;i++) {
                paramAplicativo.pantalones[i].caracteristica = paramAplicativo.caracteristicas.Where(x=>x.nombreCaracteristicaTipoPrenda=="Chupin").First();
            }
            //De los 2000 pantalones solo 500 son normales.
            for (int i=1500;i<2000;i++) {
                paramAplicativo.pantalones[i].caracteristica = paramAplicativo.caracteristicas.Where(x => x.nombreCaracteristicaTipoPrenda == "Normal clásico").First();
            }
            #endregion
            return paramAplicativo;
        }
        public static int GenerarID() {
            return id+=1;
        }
    }
}
