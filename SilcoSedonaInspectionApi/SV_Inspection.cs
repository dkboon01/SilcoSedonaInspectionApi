namespace SilcoSedonaCustomApi
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SV_Inspection
    {
        ////[Key]
        [Key]
        [Column(Order = 0)]
        public int Inspection_Id { get; set; }

       // [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Customer_System_Id { get; set; }

      //  [Key]
        [Column(Order = 2)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Inspection_Cycle_Id { get; set; }

        //[Key]
        [Column(Order = 3)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Problem_Id { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

      //  [Key]
        [Column(Order = 4)]
        public DateTime Next_Inspection_Date { get; set; }

     //   [Key]
        [Column(Order = 5)]
        public DateTime Last_Inspection_Date { get; set; }

      //  [Key]
        [Column(Order = 6)]
        [StringLength(1024)]
        public string Notes { get; set; }

      //  [Key]
        [Column(Order = 7)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Last_Service_Ticket_Id { get; set; }

        public int? Service_Level_id { get; set; }

        public int? Job_Id { get; set; }

        public int? Route_Id { get; set; }

     //   [Key]
        [Column(Order = 8)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Service_Company_Id { get; set; }

     //   [Key]
        [Column(Order = 9)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Inspection_Item_Id { get; set; }

      //  [Key]
        [Column(Order = 10, TypeName = "money")]
        public decimal Inspection_Charge_Amount { get; set; }

      //  [Key]
        [Column(Order = 11)]
        public byte Group_Number { get; set; }

      //  [Key]
        [Column(Order = 12)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public short Estimated_Hours { get; set; }

      //  [Key]
        [Column(Order = 13)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Service_Tech_Id { get; set; }

      //  [Key]
        [Column(Order = 14)]
        [StringLength(1)]
        public string High_Frequency_Omit { get; set; }

     //   [Key]
        [Column(Order = 15)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Customer_Recurring_Id { get; set; }

     //   [Key]
        [Column(Order = 16, TypeName = "money")]
        public decimal Cycle_Amount { get; set; }

     //   [Key]
        [Column(Order = 17)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Recurring_Item_Id { get; set; }

     //   [Key]
        [Column(Order = 18)]
        public bool Terminated { get; set; }

        [Column(TypeName = "smalldatetime")]
        public DateTime? Terminated_Date { get; set; }

        [StringLength(30)]
        public string Terminated_By { get; set; }

     //   [Key]
        [Column(Order = 19)]
        [StringLength(1)]
        public string Exclude_In_Frequency_Omit { get; set; }

     //   [Key]
        [Column(Order = 20)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Increment_Code_Id { get; set; }
    }
}
