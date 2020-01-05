using DAM_ORMFramework;
using DAM_ORMFramework.Attribute;

namespace DemoDAMFramework
{
    [Table("Price")]
    public class Phone_Price
    {
       [PrimaryKey("ID",true)]
       [Column("ID",DataType.INT)]
       public int ID { get; set; }

       [Column("CellPhoneID",DataType.VARCHAR)]
       public string CellPhoneID { get; set; }

       [Column("Price",DataType.FLOAT)]
       public double Price { get; set; }

    }
}
