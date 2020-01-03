using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DAM_ORMFramework;
using DAM_ORMFramework.Query;
using DAM_ORMFramework.Attribute;
using DAM_ORMFramework.Mapping;
using System.Configuration;

namespace DemoDAMFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            OneToMany oneToMany = new OneToMany("1","user");
            SqlServerConnection cnn = new SqlServerConnection(ConfigurationManager.ConnectionStrings["DemoDAMFramework.Properties.Settings.Setting"].ConnectionString);
        }
    }
}
