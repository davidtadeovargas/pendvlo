using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Pendvlo.HttpModels
{
    public class EditProductRequestModel
    {
        public int ID { get; set; }
        public string code { get; set; }                        //suaje
        public double medidaEje { get; set; }                     //suaje
        public double medidaDesarrollo { get; set; }              //suaje
        public double repeticionesEje { get; set; }                     //suaje
        public double repeticionesDesarrollo { get; set; }              //suaje
        public double separacionEje { get; set; }                     //suaje
        public double separacionDesarrollo { get; set; }              //suaje
        public int numero { get; set; }              //Engrane/TH/Dientes
        public double existencia { get; set; }  //Engrane/TH/Dientes
        public double existenciaRodillos { get; set; }  //rodillos
        public double papelCoucheMillar { get; set; }  //Papel (Couche)
        public double papelCoucheMVMillar { get; set; }  //Papel (Couche) - Minimo venta
        public double papelCoucheMVCosto { get; set; }  //Papel (Couche) - Minimo venta
        public double papelCoucheLMMillar { get; set; }  //Papel (Couche) - Laminado mate
        public double papelCoucheLMMinimo { get; set; }  //Papel (Couche) - Laminado mate
        public double papelCoucheD10AMillar { get; set; }  //Papel (Couche) - 10% desc aplicado
        public double papelCoucheD10AMinimo { get; set; }  //Papel (Couche) - 10% desc aplicado
        public double papelCoucheD15AMillar { get; set; }  //Papel (Couche) - 15% desc aplicado
        public double papelCoucheD15AMinimo { get; set; }  //Papel (Couche) - 15% desc aplicado
        public double papelCouchePlataMillar { get; set; }  //Papel (Couche) Plata     
        public double papelCouchePlataMVMillar { get; set; }  //Papel (Couche) Plata - Minimo venta
        public double papelCouchePlataMVCosto { get; set; }  //Papel (Couche) Plata - Minimo venta
        public double papelCouchePlataLMMillar { get; set; }  //Papel (Couche) Plata - Laminado mate
        public double papelCouchePlataLMMinimo { get; set; }  //Papel (Couche) Plata - Laminado mate
        public double papelCouchePlataD10AMillar { get; set; }  //Papel (Couche) Plata - 10% desc aplicado
        public double papelCouchePlataD10AMinimo { get; set; }  //Papel (Couche) Plata - 10% desc aplicado
        public double papelCouchePlataD15AMillar { get; set; }  //Papel (Couche) Plata - 15% desc aplicado
        public double papelCouchePlataD15AMinimo { get; set; }  //Papel (Couche) Plata- 15% desc aplicado
        public double boppPoliesterBlancoTransMillar { get; set; }  //BOPP (Poliester) Blanco Transparente
        public double boppPoliesterBlancoTransMVMillar { get; set; }  //BOPP (Poliester) Blanco Transparente - Minimo venta
        public double boppPoliesterBlancoTransMVCosto { get; set; }  //BOPP (Poliester) Blanco Transparente - Minimo venta
        public double boppPoliesterBlancoTransLMMillar { get; set; }  //BOPP (Poliester) Blanco Transparente - Laminado mate
        public double boppPoliesterBlancoTransLMMinimo { get; set; }  //BOPP (Poliester) Blanco Transparente - Laminado mate
        public double boppPoliesterBlancoTransD10AMillar { get; set; }  //BOPP (Poliester) Blanco Transparente - 10% desc aplicado
        public double boppPoliesterBlancoTransD10AMinimo { get; set; }  //BOPP (Poliester) Blanco Transparente - 10% desc aplicado
        public double boppPoliesterBlancoTransD15AMillar { get; set; }  //BOPP (Poliester) Blanco Transparente - 15% desc aplicado
        public double boppPoliesterBlancoTransD15AMinimo { get; set; }  //BOPP (Poliester) Blanco Transparente - 15% desc aplicado
        public double boppPoliesterPlataMillar { get; set; }  //BOPP (Poliester) Plata
        public double boppPoliesterPlataMVMillar { get; set; }  //BOPP (Poliester) Plata - Minimo venta
        public double boppPoliesterPlataMVCosto { get; set; }  //BOPP (Poliester) Plata - Minimo venta
        public double boppPoliesterPlataLMMillar { get; set; }  //BOPP (Poliester) Plata - Laminado mate
        public double boppPoliesterPlataLMMinimo { get; set; }  //BOPP (Poliester) Plata - Laminado mate
        public double boppPoliesterPlataD10AMillar { get; set; }  //BOPP (Poliester) Plata - 10% desc aplicado
        public double boppPoliesterPlataD10AMinimo { get; set; }  //BOPP (Poliester) Plata - 10% desc aplicado
        public double boppPoliesterPlataD15AMillar { get; set; }  //BOPP (Poliester) Plata - 15% desc aplicado
        public double boppPoliesterPlataD15AMinimo { get; set; }  //BOPP (Poliester) Plata - 15% desc aplicado
    }
}