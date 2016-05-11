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
        public void LoadMap(string[] path)
        {
            string name,date;
            foreach (var map in path)
            {
                if (File.Exists(map + @"\level.dat"))
                {
                    name = Path.GetFileNameWithoutExtension(map);
                    date = Directory.GetLastAccessTime(map).ToString();
                    ListViewItem name_item = new ListViewItem();
                    name_item.Text = name;
                    name_item.Tag = name;
                    name_item.SubItems.Add(date);
                    MapList.Items.Add(name_item);
                }
            }
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            ExportPath.Text = "N/A";
            string AppDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData) + @"\.minecraft\saves";
            if (Directory.Exists(AppDataPath) == true)
            {
                MapPath.Text = AppDataPath;
                //如預設位置有地圖存檔，將在表單載入時顯示清單
                string[] MapFolderList = Directory.GetDirectories(AppDataPath);
                LoadMap(MapFolderList);
            }
            else
            {
                MapPath.Text = "N/A";
            }
        }

        private void MapChoose_Click(object sender, EventArgs e)
        {
            MapFolder.ShowDialog();
            //如有地圖存檔，將載入清單
            if (MapFolder.SelectedPath != "")
            {
                MapPath.Text = MapFolder.SelectedPath;
                string[] MapFolderList = Directory.GetDirectories(MapFolder.SelectedPath);
                MapList.Items.Clear();
                LoadMap(MapFolderList);
            }
            else
            {
                MapPath.Text = "N/A";
            }
        }

        private void ExportChoose_Click(object sender, EventArgs e)
        {
            ExportFolder.ShowDialog();
            if (ExportFolder.SelectedPath != "")
            {
                ExportPath.Text = ExportFolder.SelectedPath;
            }
            else
            {
                ExportPath.Text = "N/A";
            }
        }

        private void ExportButton_Click(object sender, EventArgs e)
        {
            if (ExportPath.Text==""||textBox1.Text=="")
            {
                MessageBox.Show("Missing The File Name Or Path", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(File.Exists(ExportPath.Text + @"\" + textBox1.Text + ".zip"))
            {
                MessageBox.Show("Confirm File Replace", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (MapList.SelectedItems.Count != 0)
                {
                    ListView.SelectedListViewItemCollection select = MapList.SelectedItems;
                    ZipFile.CreateFromDirectory(MapPath.Text + "\\" + select[0].Text, ExportPath.Text + "\\" + textBox1.Text + ".zip", CompressionLevel.Optimal, true, UTF8Encoding.UTF8);
                    MessageBox.Show("Success！");


                }
                else
                {
                    MessageBox.Show("Please Choose A Map", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
