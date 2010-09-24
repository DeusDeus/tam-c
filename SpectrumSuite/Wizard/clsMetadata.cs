using System;
using System.Collections.Generic;
using System.Text;

namespace Wizard
{
    public class clsMetadata
    {
        private string nombre;

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string tipo;

        public string Tipo
        {
            get { return tipo; }
            set { tipo = value; }
        }
        private string parent;

        public string Parent
        {
            get { return parent; }
            set { parent = value; }
        }
        private string indVisible;

        public string IndVisible
        {
            get { return indVisible; }
            set { indVisible = value; }
        }
        private string indObligatorio;

        public string IndObligatorio
        {
            get { return indObligatorio; }
            set { indObligatorio = value; }
        }
        private string indCalculado;

        public string IndCalculado
        {
            get { return indCalculado; }
            set { indCalculado = value; }
        }
        private string formula;

        public string Formula
        {
            get { return formula; }
            set { formula = value; }
        }
        private string nombreCampoBD;

        public string NombreCampoBD
        {
            get { return nombreCampoBD; }
            set { nombreCampoBD = value; }
        }
        private string valor;

        public string Valor
        {
            get { return valor; }
            set { valor = value; }
        }
        private string tipoDato;

        public string TipoDato
        {
            get { return tipoDato; }
            set { tipoDato = value; }
        }
        private string longitud;

        public string Longitud
        {
            get { return longitud; }
            set { longitud = value; }
        }
        private string precision;

        public string Precision
        {
            get { return precision; }
            set { precision = value; }
        }
        private string io;

        public string Io
        {
            get { return io; }
            set { io = value; }
        }
        private string calculo;

        public string Calculo
        {
            get { return calculo; }
            set { calculo = value; }
        }
        private string tagXML;

        public string TagXML
        {
            get { return tagXML; }
            set { tagXML = value; }
        }
    }
}
