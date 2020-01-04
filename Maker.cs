using DAM_ORMFramework;
using DAM_ORMFramework.Attribute;
using System.Collections.Generic;
namespace DemoDAMFramework
{
    [Table("Maker")]
    public class Maker
    {   
        [PrimaryKey("ID",true)]
        [Column("ID",DataType.INT)]
        public int ID { get; set; }
 
        [Column("Name",DataType.NVARCHAR)]
        public string Name { get; set; }

        [OneToMany("1","CellPhone")]

        public List<CellPhone> CellPhoneList { get; set; }
    }
}
