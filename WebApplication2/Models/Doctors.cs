﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication2.Models
{
    public class Doctors
    {

        [Key]
        public int DoctorId { get; set; }

        //[Required]
        public string DoctorUserID { get; set; }

        [Required]
        [StringLength(5)]
        public string DoctorCode { get; set; }

        [Required]
        [StringLength(100)]
        public string NameAr { get; set; }

        [Required]
        [StringLength(100)]
        public string NameEn { get; set; }


        //[Required]
        //public byte SpecialtyId { get; set; }
        ////public Specialties Specialties { get; set; }

        //[Required]
        //public int CountryId { get; set; }
        ////public Countries Countries { get; set; }

        //[Required]
        //public int CityId { get; set; }
        ////public Cities Cities { get; set; }

        //[Required]
        //public int AreaId { get; set; }
        ////public Areas Areas { get; set; }

        //[Required]
        //[StringLength(1)]
        //public string Gender { get; set; }

        //[Required]
        //public double TickerPrice { get; set; }

        //[StringLength(100)]
        //public string AboutDoctorShortDescription { get; set; }

        //[StringLength(1000)]
        //public string AboutDoctorLongDescription { get; set; }

        //[Display(Name = "Birth Date")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        //public DateTime BirthDate { get; set; }

        //[Display(Name = "Register Date")]
        //[DataType(DataType.Date)]
        //[DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:MM/dd/yyyy}")]
        //public DateTime RegisterDate { get; set; }

        //[Required]
        //[StringLength(225)]
        //public string SearchName { get; set; }

        //[StringLength(225)]
        //public string CreatedBy { get; set; }

        //[DataType(DataType.Date)]
        //public DateTime CreadtedDateTime { get; set; }

        //[StringLength(225)]
        //public string ModifiedBy { get; set; }

        //[DataType(DataType.Date)]
        //public DateTime ModifiedDateTime { get; set; }
    }
}