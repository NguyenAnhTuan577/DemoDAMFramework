using DAM_ORMFramework;
using DAM_ORMFramework.Attribute;

namespace DemoDAMFramework
{
    [Table("CellPhone_Color")]
    public class CellPhone_Color
    {
        [PrimaryKey("ID",true)]
        [Column("ID",DataType.INT)]
        [ForeignKey("3","CellPhoneID","ID")]
        public int ID { get; set; }
        
        [Column("CellPhoneID",DataType.VARCHAR)]
        public string CellPhoneID { get; set; }

        [Column("ColorID",DataType.INT)]
        public string ColorID { get; set; }
    }
}
