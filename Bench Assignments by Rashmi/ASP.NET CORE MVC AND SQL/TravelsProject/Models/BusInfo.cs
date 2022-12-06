using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace TravelsProject.Models
{
    public partial class BusInfo
    {
        [DisplayName("Bus Id")]
        [Key]
        public int BusId { get; set; }

        [DisplayName("Boarding Point")]
        public string BoardingPoint { get; set; }

        [DisplayName("Travel Date")]
        public DateTime TravelDate { get; set; }

        public double? Amount { get; set; }

        [Range(1,5,ErrorMessage ="Rating should be between 1 to 5")]
        public int? Rating { get; set; }
    }
}
