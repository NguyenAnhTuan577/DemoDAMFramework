using DAM_ORMFramework;
using DAM_ORMFramework.Attribute;
using System.Collections.Generic;

namespace DemoDAMFramework
{
    [Table("CellPhone")]
    public class CellPhone
    {
        [PrimaryKey("ID",true)]
        [Column("ID",DataType.VARCHAR)]
        public string ID { get; set; }

        [Column("Name",DataType.NVARCHAR)]
        public string Name { get; set; }

        [Column("MakerID",DataType.INT)]
        [ForeignKey("1","MakerID","ID")]
        public int MakerID { get; set; }

        [ManyToOne("1","Maker")]
        public Maker Maker { get; set; }
        
        [OneToOne("2","Price")]
        [ForeignKey("2", "ID", "CellPhoneID")]
        public Phone_Price Price { get; set; }

        [OneToMany("3","CellPhone_Color")]
        public List<CellPhone_Color> CellPhone_Colors { get; set; }
    }
}
