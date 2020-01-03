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
using DAM_ORMFramework.Attribute;

namespace DemoDAMFramework
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            OneToMany oneToMany = new OneToMany("1","user");
        }
    }
}
