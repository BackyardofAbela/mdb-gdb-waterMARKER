using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace WaterMarkerAE
{
    public partial class WaterMarkerEmbed : Form
    {
        public WaterMarkerEmbed()
        {
            InitializeComponent();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            DataRead dataRead = new DataRead();
            List<string> mdbfiles = new List<string>();
            mdbfiles.Add(@"F:\02.Data\水印测试\mdb+gdb - 副本\中央投资矢量.mdb");
            dataRead.ReadLayerFromAccess(mdbfiles);
            List<string> gdbfile = new List<string>();
            gdbfile.Add(@"F:\02.Data\水印测试\mdb+gdb_去除点\全国100万DLGMerge.gdb");
            dataRead.ReadLayerFromGDB(gdbfile);
        }


    }
}
