namespace SilcoSedonaCustomApi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AR_Userdef_8
    {
        [Key]
        public int Userdef_8_Id { get; set; }

        [StringLength(25)]
        public string Userdef_8_Code { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(1)]
        public string Inactive { get; set; }
    }
}
