using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ARBOLES_BINARIOS
{
    class Arbol
    {
       private Nodo inicio;
       private  Nodo ultimo;
       private Nodo raiz;

        public void Agregar(Nodo nuevo)
        {

           if (inicio == null)
           {
                inicio = nuevo;
                ultimo = inicio;
           }
           else
           {
                ultimo._siguiente = nuevo;
                nuevo._anterior = ultimo;
                ultimo = nuevo;
           }
        }

        public void Evaluar()
        {

            Nodo temp = inicio;
            while (temp != null)
            {
                if (temp._dato == '/'|| temp._dato == '*')
                {
                    temp._hizq=temp._anterior;
                    temp._hder = temp._siguiente;
                    if (temp._anterior == inicio)
                        inicio = temp;
                    
                    temp._anterior = temp._anterior._anterior;
                    if(temp._anterior!=null)
                    temp._anterior._siguiente = temp;
                    temp._siguiente = temp._siguiente._siguiente;
                    if(temp._siguiente!=null)
                    temp._siguiente._anterior = temp;
                    
                }
                temp = temp._siguiente;
            }

            temp = inicio;
            while (temp != null)
            {
                if (temp._dato == '+' || temp._dato == '-')
                {
                    temp._hizq = temp._anterior;
                    temp._hder = temp._siguiente;
                    if (temp._anterior == inicio)
                        inicio = temp;

                    temp._anterior = temp._anterior._anterior;
                    if (temp._anterior != null)
                        temp._anterior._siguiente = temp;
                    temp._siguiente = temp._siguiente._siguiente;
                    if (temp._siguiente != null)
                        temp._siguiente._anterior = temp;
                }
                temp = temp._siguiente;
            }
            raiz = inicio;
        }

        public string PreOrden()
        {
            if (raiz == null)
                return "Vacio";
            else
                return PreOrden(raiz);
        }

        private string PreOrden(Nodo r)
        {
            string res = "";
            res += r.ToString();
            if (r._hizq != null)
                res += PreOrden(r._hizq);
            if (r._hder != null)
                res += PreOrden(r._hder);
            return res;
        }

        public string PostOrden()
        {
            if (raiz == null)
                return "Vacio";
            else
                return PostOrden(raiz);
        }

        private string PostOrden(Nodo r)
        {
            string res = "";
            if (r._hizq != null)
                res += PostOrden(r._hizq);
            if (r._hder != null)
                res += PostOrden(r._hder);
            res += r.ToString();
            return res;
        }

        public string PreOrden(string Datos)
        {
            Stack<string> Pila = new Stack<string>();

            char[] cadena = Datos.ToCharArray();
            Array.Reverse(cadena);
            foreach (char ch in cadena)
            {
                if (char.IsNumber(ch))
                {
                    Pila.Push(Convert.ToString(ch));
                }
                else if (ch == '/')
                {
                    int num = Convert.ToInt16(Pila.Pop());
                    int num2 = Convert.ToInt16(Pila.Pop());
                    double res = num / num2;
                    Pila.Push(Convert.ToString(res));
                }
                else if (ch == '*')
                {
                    int num = Convert.ToInt16(Pila.Pop());
                    int num2 = Convert.ToInt16(Pila.Pop());
                    int res = num * num2;
                    Pila.Push(Convert.ToString(res));
                }
                else if (ch == '+')
                {
                    int num = Convert.ToInt16(Pila.Pop());
                    int num2 = Convert.ToInt16(Pila.Pop());
                    int res = num + num2;
                    Pila.Push(Convert.ToString(res));
                }
                else if (ch == '-')
                {
                    int num = Convert.ToInt16(Pila.Pop());
                    int num2 = Convert.ToInt16(Pila.Pop());
                    int res = num - num2;
                    Pila.Push(Convert.ToString(res));
                }
            }
            return Convert.ToString(Pila.Pop());
        }

        public string PostOrden(string Datos)
        {
            Stack<string> Pila = new Stack<string>();

            char[] cadena = Datos.ToCharArray();
            foreach (char ch in cadena)
            {
                if (char.IsNumber(ch))
                {
                    Pila.Push(Convert.ToString(ch));
                }
                else if (ch == '/')
                {
                    int num = Convert.ToInt16(Pila.Pop());
                    int num2 = Convert.ToInt16(Pila.Pop());
                    double res = num2/num;
                    Pila.Push(Convert.ToString(res));
                }
                else if (ch == '*')
                {
                    int num = Convert.ToInt16(Pila.Pop());
                    int num2 = Convert.ToInt16(Pila.Pop());
                    int res = num2*num;
                    Pila.Push(Convert.ToString(res));
                }
                else if (ch == '+')
                {
                    int num = Convert.ToInt16(Pila.Pop());
                    int num2 = Convert.ToInt16(Pila.Pop());
                    int res = num2+num;
                    Pila.Push(Convert.ToString(res));
                }
                else if (ch == '-')
                {
                    int num = Convert.ToInt16(Pila.Pop());
                    int num2 = Convert.ToInt16(Pila.Pop());
                    int res = num2 - num;
                    Pila.Push(Convert.ToString(res));
                }
            }
            return Convert.ToString(Pila.Pop());

        }

    }
}

//public string PostOrden2(string Datos)
//{
//    Queue<string> Cola = new Queue<string>();

//    char[] cadena = Datos.ToCharArray();
//    foreach (char ch in cadena)
//    {
//        if (char.IsNumber(ch))
//        {
//            Cola.Enqueue(Convert.ToString(ch));
//        }
//        else if (ch == '/')
//        {
//            int num = Convert.ToInt16(Cola.Dequeue());
//            int num2 = Convert.ToInt16(Cola.Dequeue());
//            double res = num2/num;
//            Cola.Enqueue(Convert.ToString(res));
//        }
//        else if (ch == '*')
//        {
//            int num = Convert.ToInt16(Cola.Dequeue());
//            int num2 = Convert.ToInt16(Cola.Dequeue());
//            double res = num2*num;
//            Cola.Enqueue(Convert.ToString(res));
//        }
//        else if (ch == '+')
//        {
//            int num = Convert.ToInt16(Cola.Dequeue());
//            int num2 = Convert.ToInt16(Cola.Dequeue());
//            double res = num2+num;
//            Cola.Enqueue(Convert.ToString(res));
//        }
//        else if (ch == '-')
//        {
//            int num = Convert.ToInt16(Cola.Dequeue());
//            int num2 = Convert.ToInt16(Cola.Dequeue());
//            double res = num2-num;
//            Cola.Enqueue(Convert.ToString(res));
//        }
//    }
//    return Convert.ToString(Cola.Dequeue());
//}

 //public string PreOrden2(string Datos)
 //       {
 //           Stack<double> Pila = new Stack<double>();

 //           char[] cadena = Datos.ToCharArray();
 //           Array.Reverse(cadena);
 //           foreach (char ch in cadena)
 //           {
 //               if (char.IsNumber(ch))
 //               {
 //                   Pila.Push(Convert.ToInt16(ch));
 //               }
 //               else if (ch == '/')
 //               {
 //                   double num= Convert.ToDouble(Pila.Pop());
 //                   double num2 = Convert.ToDouble(Pila.Pop());
 //                   double res = num / num2;
 //                   Pila.Push(Convert.ToDouble(res));
 //               }
 //               else if (ch == '*')
 //               {
 //                   double num =Convert.ToDouble(Pila.Pop());
 //                   double num2 = Convert.ToDouble(Pila.Pop());
 //                   double res = num * num2;
 //                   Pila.Push(Convert.ToDouble(res));
 //               }
 //               else if (ch == '+')
 //               {
 //                   double num = Convert.ToDouble(Pila.Pop());
 //                   double num2 = Convert.ToDouble(Pila.Pop());
 //                   double res = num + num2;
 //                   Pila.Push(Convert.ToDouble(res));
 //               }
 //               else if (ch == '-')
 //               {
 //                   double num = Convert.ToDouble(Pila.Pop());
 //                   double num2 = Convert.ToDouble(Pila.Pop());
 //                   double res = num - num2;
 //                   Pila.Push(Convert.ToDouble(res));
 //               }
 //           }
 //           return Convert.ToString(Pila.Pop());   
 //       }
