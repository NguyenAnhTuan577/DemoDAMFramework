using DAM_ORMFramework;
using DAM_ORMFramework.Attribute;


namespace DemoDAMFramework
{
    [Table("Color")]
    public class Color
    {
        [PrimaryKey("ID", true)]
        [Column("ID",DataType.INT)]
        public int ID { get; set; }

        [Column("Name",DataType.NVARCHAR)]
        public string Name { get; set; }
    }
}
