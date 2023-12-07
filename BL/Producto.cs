using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class Producto
    {

        public static ML.Result Comprar(int moneda10, int moneda50, int moneda100)
        {
            ML.Result result = new ML.Result();

            try
            {
                ML.Producto aux = new ML.Producto();

                aux.ContadorCompraUno = aux.ContadorCompraUno + 1;
                aux.Moneda10 = moneda10 * 10;
                aux.Moneda50 = moneda50 * 50;
                aux.Moneda100 = moneda100 * 100;
                aux.TotalMoneda = aux.Moneda10 + aux.Moneda50 + aux.Moneda100;

                if (aux.TotalMoneda < aux.Precio)
                {
                    result.Correct = false;
                    result.ErrorMessage = "No te alcanza para el producto!!";
                }
                else if (aux.TotalMoneda == aux.Precio)
                {
                    result.Correct = true;
                    result.ErrorMessage = "Monto Exacto!!";
                }
                else
                {
                    result.Correct = true;
                    aux.ContadorCambioUno = aux.ContadorCambioUno + 1;
                    aux.Cambio = aux.TotalMoneda - aux.Precio;


                    aux.Millares = aux.Cambio / 1000;
                    aux.Centenas = (aux.Cambio - (aux.Millares * 1000)) / 100;
                    aux.Decenas = (aux.Cambio - (aux.Millares * 1000 + aux.Centenas * 100)) / 10;
                    aux.Unidades = aux.Cambio - (aux.Millares * 1000 + aux.Centenas * 100 + aux.Decenas * 10);
                   
                    aux.Millares = aux.Millares * 1000;
                    aux.Centenas = aux.Centenas * 100;
                    aux.Decenas = aux.Decenas * 10;
                    
                  
                }

                result.Object = aux;

            }
            catch (Exception ex)
            {
                result.Correct = false;
            }

            return result;

        }
           
        






        public static ML.Result GetById(int IdProducto)
        {
            ML.Result result = new ML.Result();

            try
            {
                using(DL.NCastilloExamenBBVAEntities context = new DL.NCastilloExamenBBVAEntities())
                {
                    var query = context.ProductoGetById(IdProducto).SingleOrDefault();

                    result.Object = new List<Object>();

                    if(query != null)
                    {
                        ML.Producto producto = new ML.Producto();

                        producto.IdProducto = query.IdProducto;

                        producto.Nombre = query.Nombre;

                        producto.Precio = query.Precio.Value;

                        producto.Imagen = query.Imagen;

                        result.Object = producto;

                        result.Correct = true;


                    }
                    else
                    {
                        result.Correct = false; 
                    }


                }
            }
            catch(Exception ex)
            { 
                result.Correct = false;
            }

            return result;
        }

        public static ML.Result GetAll()
        {
            ML.Result result = new ML.Result();

            try
            {
                using(DL.NCastilloExamenBBVAEntities context = new DL.NCastilloExamenBBVAEntities())
                {
                    var query = context.ProductoGetAll().ToList();

                    result.Objects = new List<Object>();

                    if(query != null)
                    {
                        foreach(var registro in query)
                        {
                            ML.Producto producto = new ML.Producto();

                            producto.IdProducto = registro.IdProducto;

                            producto.Nombre = registro.Nombre;

                            producto.Precio = registro.Precio.Value;

                            producto.Imagen = registro.Imagen;

                            result.Objects.Add(producto);
                        }

                        result.Correct = true;

                    }
                    else
                    {
                        result.Correct = false;
                    }
                }
            }
            catch( Exception ex ) 
            {
                result.Correct = false; 
            
            }

            return result;  
        }

}
}


