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
        public string? Description { get; set; }
        [Column(TypeName="nvarchar (250)")]
        public string? EquipamentModel { get; set; }
        [Column(TypeName="varchar (100)")]
        public string? EquipamentManufacture { get; set; }
        [Column(TypeName="varchar (100)")]
        public int RequestId { get; set; }
        [Column(TypeName="varchar (10)")]
        public bool IsEmergency { get; set; }
        [Column(TypeName="varchar (1)")]
        public int Amount { get; set; }
        [Column(TypeName="varchar (10)")]
        public int OSNumber { get; set; }
        [Column(TypeName="varchar (20)")]
        public string? OrbisTag { get; set; }
        [Column(TypeName="varchar (40)")]
        public string? Location { get; set; }

    }
}