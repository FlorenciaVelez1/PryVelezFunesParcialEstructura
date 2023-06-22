using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PryVelezFunesParcialEstructura
{
    internal class clsListaDoble
    {
        //declaro las variables
        private clsNodo pri;
        private clsNodo ult;
        public clsNodo Primero
        {
            get { return pri; }
            set { pri = value; }
        }
        public clsNodo Ultimo
        {
            get { return ult; }
            set { ult = value; }
        }
        public void Agregar(clsNodo Nuevo)
        {
            if (Primero == null)
            {
                Primero = Nuevo;
                Ultimo = Nuevo;
            }
            else
            {
                if (Nuevo.NumeroLegajo < Primero.NumeroLegajo)
                {
                    Nuevo.Siguiente = Primero;
                    Primero.Anterior = Nuevo;
                    Primero = Nuevo;
                }
                else
                {
                    if (Nuevo.NumeroLegajo > Ultimo.NumeroLegajo)
                    {
                        Ultimo.Siguiente = Nuevo;
                        Nuevo.Anterior = Ultimo;
                        Ultimo = Nuevo;
                    }
                    else
                    {
                        clsNodo Aux = Primero;
                        clsNodo Ant = Primero;
                        while (Aux.NumeroLegajo < Nuevo.NumeroLegajo)
                        {
                            Ant = Aux;
                            Aux = Aux.Siguiente;
                        }
                        Ant.Siguiente = Nuevo;
                        Nuevo.Siguiente = Aux;
                        Aux.Anterior = Nuevo;
                        Nuevo.Anterior = Ant;
                    }
                }
            }
        }
        public void RecorrerAsc(DataGridView Grilla)
        {
            clsNodo aux = Primero;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.NumeroLegajo, aux.NombreCompleto, aux.Categoria, aux.SueldoBasico);
                aux = aux.Siguiente;
            }
        }
        public void RecorrerAsc(ComboBox Combo)
        {
            clsNodo aux = Primero;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.NumeroLegajo);
                aux = aux.Siguiente;
            }
        }
        public void RecorrerDes(DataGridView Grilla)
        {
            clsNodo aux = Ultimo;
            Grilla.Rows.Clear();
            while (aux != null)
            {
                Grilla.Rows.Add(aux.NumeroLegajo, aux.NombreCompleto, aux.Categoria, aux.SueldoBasico);
                aux = aux.Anterior;
            }
        }
        public void RecorrerDes(ComboBox Combo)
        {
            clsNodo aux = Ultimo;
            Combo.Items.Clear();
            while (aux != null)
            {
                Combo.Items.Add(aux.NumeroLegajo);
                aux = aux.Anterior;
            }
        }
        public void RecorrerPorSueldoAsc(DataGridView Grilla, Int32 Sueldo)
        {
            clsNodo aux = Primero;
            while(aux!= null)
            {
                if(aux.SueldoBasico > Sueldo) 
                {
                    Grilla.Rows.Add(aux.NumeroLegajo, aux.NombreCompleto, aux.Categoria, aux.SueldoBasico);
                    aux = aux.Siguiente;
                }
                else
                {
                    aux = aux.Siguiente;
                }
            }
        }
        public void RecorrerPorSueldoDes(DataGridView Grilla, Int32 Sueldo)
        {
            clsNodo aux = Ultimo;
            while (aux != null)
            {
                if (aux.SueldoBasico > Sueldo)
                {
                    Grilla.Rows.Add(aux.NumeroLegajo, aux.NombreCompleto, aux.Categoria, aux.SueldoBasico);
                    aux = aux.Anterior;
                }
                else
                {
                    aux = aux.Anterior;
                }
            }
        }
        public void Eliminar(Int32 NumeroLegajo)
        {
            if (Primero.NumeroLegajo == NumeroLegajo && Ultimo == Primero)
            {
                Primero = null;
                Ultimo = null;
            }
            else
            {
                if (Primero.NumeroLegajo == NumeroLegajo)
                {
                    Primero = Primero.Siguiente;
                    Primero.Anterior = null;
                }
                else
                {
                    if (Ultimo.NumeroLegajo == NumeroLegajo)
                    {
                        Ultimo = Ultimo.Anterior;
                        Ultimo.Siguiente = null;
                    }
                    else
                    {
                        clsNodo Aux = Primero;
                        clsNodo Ant = Primero;
                        while (Aux.NumeroLegajo < NumeroLegajo)
                        {
                            Ant = Aux;
                            Aux = Aux.Siguiente;
                        }
                        Ant.Siguiente = Aux.Siguiente;
                        Aux = Aux.Siguiente;
                        Aux.Anterior = Ant;
                    }
                }
            }
        }
    }
}
