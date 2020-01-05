using DAM_ORMFramework;
using DAM_ORMFramework.Attribute;

namespace DemoDAMFramework
{
    [Table("CellPhone_Color")]
    public class CellPhone_Color
    {
        [PrimaryKey("ID",true)]
        [Column("ID",DataType.INT)]
        public int ID { get; set; }

        [ForeignKey("3", "CellPhoneID", "ID")]
        [Column("CellPhoneID",DataType.VARCHAR)]
        public string CellPhoneID { get; set; }

        [ManyToOne("3","CellPhone")]
    
        [ForeignKey("2","ID","ColorID")]

        [Column("ColorID",DataType.INT)]
        public int ColorID { get; set; }
    }
}
