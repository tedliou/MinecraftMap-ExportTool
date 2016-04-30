using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.IO.Compression;

namespace Minecraft_地圖匯出工具
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ExportPath.Text = "未選擇";
            MapList.Columns.Add("地圖名稱", 160);
            MapList.Columns.Add("修改時間", 165);
            string AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\saves";
            if (Directory.Exists(AppDataPath) == true)
            {
                MapPath.Text = AppDataPath;

                //如預設位置有地圖存檔，將在表單載入時顯示清單
                string[] MapFolderList = Directory.GetDirectories(AppDataPath);
                foreach(var map in MapFolderList)
                {

                    string name = Path.GetFileNameWithoutExtension(map);
                    ListViewItem item = new ListViewItem();
                    item.Text = name;
                    MapList.Items.Add(item);

                }
            }
            else
            {
                MapPath.Text = "未選擇";
            }
        }

        private void MapChoose_Click(object sender, EventArgs e)
        {
            MapFolder.ShowDialog();
            string MapChoosePath = MapFolder.SelectedPath;

        }

        private void ExportChoose_Click(object sender, EventArgs e)
        {

        }
    }
}
