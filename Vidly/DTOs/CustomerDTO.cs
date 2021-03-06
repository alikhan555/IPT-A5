﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using Vidly.Models;

namespace Vidly.DTOs
{
    public class CustomerDTO
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
        //[Min18IfAMember]
        public DateTime? BirthDate { get; set; }

        public MembershipTypeDTO MembershipType { get; set; }

        public bool IsSubcribedToNwesLatter { get; set; }
        
        public byte MembershipTypeId { get; set; }
    }
}