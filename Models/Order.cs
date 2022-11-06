using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BuyOrder.Models
{
    public class Order
    {   
        [Key]
        public int OrderId { get; set; }
        [Column(TypeName="varchar (10)")]
        //Descrição
        [Display(Name = "Descrição:")]
        public string? Description { get; set; }
        [Column(TypeName="nvarchar (250)")]
        //Modelo
        [Display(Name = "Modelo:")]
        public string? EquipamentModel { get; set; }
        [Column(TypeName="varchar (100)")]
        //Modelo
        [Display(Name = "Fabricante:")]
        public string? EquipamentManufacture { get; set; }
        [Column(TypeName="varchar (100)")]
        //Nº OS
        [Display(Name = "Nª Solicitação")]
        public int RequestId { get; set; }
        [Column(TypeName="varchar (10)")]
        //Urgente
        [Display(Name = "Urgente")]
        public bool IsEmergency { get; set; }
        [Column(TypeName="varchar (1)")]
         //Qtde
        [Display(Name = "Quantidade:")]
        public int Amount { get; set; }
        [Column(TypeName="varchar (10)")]
        //Nº OS
        [Display(Name = "Nº Ordem de Serviço:")]
        public int OSNumber { get; set; }
        [Column(TypeName="varchar (20)")]
        //TAG
        [Display(Name = "Tag do equipamento:")]
        public string? OrbisTag { get; set; }
        [Column(TypeName="varchar (40)")]
        //Nº Localização do Equipamento:
        [Display(Name = "Nº Localização do Equipamento:")]
        public string? Location { get; set; }

    }
}