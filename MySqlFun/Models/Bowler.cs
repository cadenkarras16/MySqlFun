﻿using System;
using System.ComponentModel.DataAnnotations;

namespace MySqlFun.Models
{
    public class Bowler
    {

        [Key]
        [Required]
        public int BowlerID { get; set; } //if it only has a get that is a readonly variable

        public string BowlerLastName { get; set; }

        public string BowlerFirstName { get; set; }

        public string BowlerMiddleInit { get; set; }

        public string BowlerAddress { get; set; }

        public string BowlerCity { get; set; }

        public string BowlerState { get; set; }

        public string BowlerZip { get; set; }

        public string BowlerPhoneNumber {get; set;}

        //foreign Key uh oh!
        public int TeamID { get; set; }





    }
}
