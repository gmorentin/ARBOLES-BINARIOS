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
        public void Evaluar(string Datos)
        {

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
                    int num= Convert.ToInt16(Pila.Pop());
                    int num2 = Convert.ToInt16(Pila.Pop());
                    double res = num / num2;
                    Pila.Push(Convert.ToString(res));
                }
                else if (ch == '*')
                {
                    int num =Convert.ToInt16(Pila.Pop());
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
            Queue<string> Cola = new Queue<string>();

            char[] cadena = Datos.ToCharArray();
            foreach (char ch in cadena)
            {
                if (char.IsNumber(ch))
                {
                    Cola.Enqueue(Convert.ToString(ch));
                }
                else if (ch == '/')
                {
                    int num = Convert.ToInt16(Cola.Dequeue());
                    int num2 = Convert.ToInt16(Cola.Dequeue());
                    double res = num2/num;
                    Cola.Enqueue(Convert.ToString(res));
                }
                else if (ch == '*')
                {
                    int num = Convert.ToInt16(Cola.Dequeue());
                    int num2 = Convert.ToInt16(Cola.Dequeue());
                    double res = num2*num;
                    Cola.Enqueue(Convert.ToString(res));
                }
                else if (ch == '+')
                {
                    int num = Convert.ToInt16(Cola.Dequeue());
                    int num2 = Convert.ToInt16(Cola.Dequeue());
                    double res = num2+num;
                    Cola.Enqueue(Convert.ToString(res));
                }
                else if (ch == '-')
                {
                    int num = Convert.ToInt16(Cola.Dequeue());
                    int num2 = Convert.ToInt16(Cola.Dequeue());
                    double res = num2-num;
                    Cola.Enqueue(Convert.ToString(res));
                }
            }
            return Convert.ToString(Cola.Dequeue());
        }

        public string PostOrden2(string Datos)
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
