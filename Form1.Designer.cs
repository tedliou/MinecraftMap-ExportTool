namespace Minecraft_地圖匯出工具
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置 Managed 資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MapChoose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MapPath = new System.Windows.Forms.TextBox();
            this.ExportPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExportChoose = new System.Windows.Forms.Button();
            this.MapFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.ExportFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.MapList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ExportButton = new System.Windows.Forms.Button();
            this.FN = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.statusStrip1.SuspendLayout();
            this.FN.SuspendLayout();
            this.SuspendLayout();
            // 
            // MapChoose
            // 
            resources.ApplyResources(this.MapChoose, "MapChoose");
            this.MapChoose.Name = "MapChoose";
            this.MapChoose.UseVisualStyleBackColor = true;
            this.MapChoose.Click += new System.EventHandler(this.MapChoose_Click);
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // MapPath
            // 
            resources.ApplyResources(this.MapPath, "MapPath");
            this.MapPath.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.MapPath.Name = "MapPath";
            this.MapPath.ReadOnly = true;
            // 
            // ExportPath
            // 
            resources.ApplyResources(this.ExportPath, "ExportPath");
            this.ExportPath.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.ExportPath.Name = "ExportPath";
            this.ExportPath.ReadOnly = true;
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.Name = "label2";
            // 
            // ExportChoose
            // 
            resources.ApplyResources(this.ExportChoose, "ExportChoose");
            this.ExportChoose.Name = "ExportChoose";
            this.ExportChoose.UseVisualStyleBackColor = true;
            this.ExportChoose.Click += new System.EventHandler(this.ExportChoose_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1});
            resources.ApplyResources(this.statusStrip1, "statusStrip1");
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.SizingGrip = false;
            // 
            // toolStripStatusLabel1
            // 
            resources.ApplyResources(this.toolStripStatusLabel1, "toolStripStatusLabel1");
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            // 
            // MapList
            // 
            this.MapList.BackColor = System.Drawing.SystemColors.Info;
            this.MapList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            resources.ApplyResources(this.MapList, "MapList");
            this.MapList.FullRowSelect = true;
            this.MapList.GridLines = true;
            this.MapList.HideSelection = false;
            this.MapList.MultiSelect = false;
            this.MapList.Name = "MapList";
            this.MapList.TabStop = false;
            this.MapList.UseCompatibleStateImageBehavior = false;
            this.MapList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            resources.ApplyResources(this.columnHeader1, "columnHeader1");
            // 
            // columnHeader2
            // 
            resources.ApplyResources(this.columnHeader2, "columnHeader2");
            // 
            // ExportButton
            // 
            resources.ApplyResources(this.ExportButton, "ExportButton");
            this.ExportButton.Name = "ExportButton";
            this.ExportButton.UseVisualStyleBackColor = true;
            this.ExportButton.Click += new System.EventHandler(this.ExportButton_Click);
            // 
            // FN
            // 
            this.FN.Controls.Add(this.label3);
            this.FN.Controls.Add(this.textBox1);
            resources.ApplyResources(this.FN, "FN");
            this.FN.Name = "FN";
            this.FN.TabStop = false;
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // textBox1
            // 
            resources.ApplyResources(this.textBox1, "textBox1");
            this.textBox1.Name = "textBox1";
            // 
            // Form1
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FN);
            this.Controls.Add(this.ExportButton);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MapList);
            this.Controls.Add(this.ExportChoose);
            this.Controls.Add(this.ExportPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MapPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MapChoose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.FN.ResumeLayout(false);
            this.FN.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MapChoose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox MapPath;
        private System.Windows.Forms.TextBox ExportPath;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ExportChoose;
        private System.Windows.Forms.FolderBrowserDialog MapFolder;
        private System.Windows.Forms.FolderBrowserDialog ExportFolder;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ListView MapList;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.Button ExportButton;
        private System.Windows.Forms.GroupBox FN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

