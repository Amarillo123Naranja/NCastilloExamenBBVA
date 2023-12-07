using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ML
{
    public class Producto
    {

        
        public int IdProducto { get; set; } 

        public string Nombre { get; set; } 

        public int Precio { get; set; } 

        public string Imagen { get; set;} 

        public List<Object> Productos { get; set; } 
        public bool bandera { set; get; }
        public int TotalMoneda { set; get; }
        
        public int Cambio { set; get; } 

        public int Moneda10 { set; get; }   

        public int Moneda50 { set; get; }   

        public int Moneda100 { set; get; }  

        public int ContadorCompraUno { set; get; }  

        public int ContadorCompraDos { set; get; }  

        public int ContadorCompraTres { set; get; } 

        public int ContadorCambioUno { set; get; }  

        public int ContadorCambioDos { set; get; }  

        public int ContadorCambioTres { set; get; }  

        public int Millares { set; get; }   

        public int Centenas { set; get; }   

        public int Decenas { set; get; }    

        public int Unidades { set; get; }   


    }
}
