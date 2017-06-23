namespace SilcoSedonaCustomApi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class AR_Userdef_9
    {
        [Key]
        public int Userdef_9_Id { get; set; }

        [StringLength(25)]
        public string Userdef_9_Code { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(1)]
        public string Inactive { get; set; }
    }
}
