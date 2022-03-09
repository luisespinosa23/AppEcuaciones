using AppCalculadoraEcuaciones.Estructura;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppCalculadoraEcuaciones.Servicio
{
    class Servicios
    {

        public static String quitarParentesis(String ecuacion)
        {
            String cad = ecuacion;
            if (comprobarParentesisExT(ecuacion))
            {
                cad = ecuacion.Substring(1, ecuacion.Length - 2);
                cad = quitarParentesis(cad);
                return cad;
            }

            return cad;            
        }

        public static int obtenerPosicion(String ecuacion)
        {
            int operadorCentral = 0;
            int contadorParentesis = 0;

            for (int i = 0; i < ecuacion.Length; i++)
            {
                if (ecuacion.Substring(i, 1).Equals("("))
                {
                    contadorParentesis++;
                }
                else if (ecuacion.Substring(i, 1).Equals(")"))
                {
                    contadorParentesis--;
                }
                if ((ecuacion.Substring(i, 1) == "+" || ecuacion.Substring(i, 1) == "-" ||ecuacion.Substring(i, 1) == "*" ||
                   ecuacion.Substring(i, 1) == "/" || ecuacion.Substring(i,1)== "math.pow") && contadorParentesis == 0)
                {

                    operadorCentral = i;
                }
            }
            return operadorCentral;
        }

        public static String[] retornarPartes(String ecuacion)
        {
            String[] partes = new string[3];
            String parte1, operador, parte2;
            if (!operadores(ecuacion))
            {
                partes[0] = ecuacion;
                partes[1] = null;
                partes[2] = null;
            }
            else {
                int posOperador = obtenerPosicion(ecuacion);
                parte1 = (ecuacion.Substring(0, posOperador));
                operador = ecuacion.Substring(posOperador, 1);
                parte2 = (ecuacion.Substring(posOperador + 1));
                partes[0] = parte1;
                partes[1] = operador;
                partes[2] = parte2;
            }
            return partes;
        }

        public static Boolean estaBienFormada(String ecuacion)
        {
            int contadorParentesis = 0;

            contadorParentesis = contarParentesis(ecuacion);
            
            if(contadorParentesis == 0)
            {
                return true;
            }

            return false;
        }

        public static int contarParentesis(string ecuacion)
        {
            int contadorParentesis = 0;

            for (int i = 0; i < ecuacion.Length; i++)
            {
                if (ecuacion.Substring(i, 1).Equals("("))
                {
                    contadorParentesis++;
                }
                else if (ecuacion.Substring(i, 1).Equals(")"))
                {
                    contadorParentesis--;
                }
            }

            return contadorParentesis;
        }

        public static Boolean comprobarParentesisExT(string ecuacion)
        {
            int contadorParentesis = 0;
            Boolean estado = false;
            for(int i =0; i<ecuacion.Length; i++)
            {
                if (ecuacion.Substring(i, 1).Equals("("))
                {
                    contadorParentesis++;
                }
                else if (ecuacion.Substring(i, 1).Equals(")"))
                {
                    contadorParentesis--;
                }

                if(contadorParentesis == 0 && i==ecuacion.Length-1)
                {
                    estado = true;
                    break;
                }else if(contadorParentesis == 0 && i<ecuacion.Length )
                {
                    break;
                }      
            }
            return estado;
        }

        public static Boolean atomico(String ecuacion)
        {
            int contadorOperadores = 0;
            for (int i=0; i<ecuacion.Length; i++)
            {
                if(ecuacion.Substring(i, 1) == "+" ||ecuacion.Substring(i, 1) == "-" || ecuacion.Substring(i, 1) == "*" ||
                    ecuacion.Substring(i, 1) == "/" || ecuacion.Substring(i,1) == "math.pow")
                {
                    contadorOperadores++;
                }
            }
            if(contadorOperadores == 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public static Nodo generarArbol(string ecuacion)
        {
            if (operadores(ecuacion))
            {
                ecuacion = quitarParentesis(ecuacion);
            }
            string[] partes = retornarPartes(ecuacion);
            string ope1 = partes[0];
            string ope = partes[1];
            string ope2 = partes[2];
            Nodo nodo = new Nodo(ope);
            if (atomico(ecuacion))
            {                
                nodo.setIzquierdo(new Nodo(ope1));
                nodo.setDerecho(new Nodo(ope2));
            }
            else if(!operadores(ecuacion))
            {
                return new Nodo(ecuacion);
            }
            else
            {
                nodo.setIzquierdo(generarArbol(ope1));
                nodo.setDerecho(generarArbol(ope2));                
            }

            return nodo;
        }

     

        public static string recorrerArbolINT(Nodo recorrer, string cad)
        {
            if (recorrer == null)
            {
                return cad;
            }
            cad = recorrerArbolINT(recorrer.getIzquierdo(), cad);
            cad = cad + recorrer.getCadena();
            cad = recorrerArbolINT(recorrer.getDerecho(), cad);
            return cad;
        }
        public static string recorrerArbolPREO(Nodo recorrer, string cad)
        {
            if (recorrer == null)
            {
                return cad;
            }
            cad = cad + recorrer.getCadena();
            cad = recorrerArbolPREO(recorrer.getIzquierdo(), cad);
            cad = recorrerArbolPREO(recorrer.getDerecho(), cad);
            return cad;
        }
        public static string recorrerArbolPOSI(Nodo recorrer, string cad)
        {
            if (recorrer == null)
            {
                return cad;
            }
            cad = recorrerArbolPOSI(recorrer.getIzquierdo(), cad);
            cad = recorrerArbolPOSI(recorrer.getDerecho(), cad);
            cad = cad + recorrer.getCadena();
            return cad;
        }

        public static Boolean operadores(string ecuacion)
        {
            Boolean resp = false;
            for (int i = 0; i < ecuacion.Length; i++)
            {
                if (ecuacion.Substring(i, 1) == "+" || ecuacion.Substring(i, 1) == "-" ||ecuacion.Substring(i, 1) == "*" ||
                   ecuacion.Substring(i, 1) == "/" || ecuacion.Substring(i,1) ==  "math.pow" )
                {
                    resp = true;
                    break;
                }
            }
            return resp;
        }
        public static Nodo nodoResultado = new Nodo("aiuda");
        
        }
        }
    

