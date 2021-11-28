using DataAccess.Entities.MDCG_Entities;
using System;
using System.Collections.Generic;

namespace DataAccess.Entities.Generales
{
    public partial class GlobPais
    {

        public GlobPais()
        {
            MdcgDependientes = new HashSet<MdcgDependiente>();
            MdcgFuncionarioNacionalidadAdquiridaNavigations = new HashSet<MdcgFuncionario>();
            MdcgFuncionarioPaisOrigenNavigations = new HashSet<MdcgFuncionario>();
        }

        public int code { get; set; }
        public string name { get; set; }
        public int HusoHorario { get; set; }
        public string CodigoIsoAlpha3 { get; set; }
        public int CodigoRegion { get; set; }
        public int CodigoMoneda { get; set; }
        public DateTime? FechaInicioRelaciones { get; set; }
        public string Nacionalidad { get; set; }
        public byte[] ImgBandera { get; set; }
        public string CategoriaOrdinaria { get; set; }
        public string CategoriaOficial { get; set; }
        public byte[] ImgMapa { get; set; }
        public string HtmlReloj { get; set; }
        public int? Prioridad { get; set; }

        public virtual ICollection<MdcgDependiente> MdcgDependientes { get; set; }
        public virtual ICollection<MdcgFuncionario> MdcgFuncionarioNacionalidadAdquiridaNavigations { get; set; }
        public virtual ICollection<MdcgFuncionario> MdcgFuncionarioPaisOrigenNavigations { get; set; }
    }
}
