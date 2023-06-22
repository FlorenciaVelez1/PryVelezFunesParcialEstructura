using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PryVelezFunesParcialEstructura
{
    internal class clsNodo
    {
        private Int32 varNumeroLegajo;
        private String varNombreCompleto;
        private String varCategoria;
        private Int32 varSueldoBasico;
        private clsNodo varSiguiente;
        private clsNodo varAnterior;
        public Int32 NumeroLegajo
        {
            get { return varNumeroLegajo; }
            set { varNumeroLegajo = value; }
        }
        public String NombreCompleto
        {
            get { return varNombreCompleto; }
            set { varNombreCompleto = value; }
        }
        public String Categoria
        {
            get { return varCategoria; }
            set { varCategoria = value; }
        }
        public Int32 SueldoBasico
        {
            get { return varSueldoBasico; }
            set { varSueldoBasico = value; }
        }
        public clsNodo Siguiente
        {
            get { return varSiguiente; }
            set { varSiguiente = value; }
        }
        public clsNodo Anterior
        {
            get { return varAnterior; }
            set { varAnterior = value; }
        }
    }
}
