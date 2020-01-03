using DAM_ORMFramework;
using DAM_ORMFramework.Attribute;

namespace DemoDAMFramework
{
    [Table("Price")]
    public class Price
    {
       [PrimaryKey("ID",true)]
       [Column("ID",DataType.INT)]
       public string ID { get; set; }

       [Column("CellPhoneID",DataType.VARCHAR)]
       public string CellPhoneID { get; set; }

       [Column("Price",DataType.FLOAT)]
       public float Prices { get; set; }

    }
}
