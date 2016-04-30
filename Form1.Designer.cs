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
            this.MapChoose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.MapPath = new System.Windows.Forms.TextBox();
            this.ExportPath = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.ExportChoose = new System.Windows.Forms.Button();
            this.MapFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.ExportFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.MapList = new System.Windows.Forms.ListView();
            this.SuspendLayout();
            // 
            // MapChoose
            // 
            this.MapChoose.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MapChoose.Location = new System.Drawing.Point(284, 9);
            this.MapChoose.Name = "MapChoose";
            this.MapChoose.Size = new System.Drawing.Size(59, 29);
            this.MapChoose.TabIndex = 0;
            this.MapChoose.Text = "瀏覽";
            this.MapChoose.UseVisualStyleBackColor = true;
            this.MapChoose.Click += new System.EventHandler(this.MapChoose_Click);
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label1.Location = new System.Drawing.Point(8, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "地圖路徑：";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // MapPath
            // 
            this.MapPath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.MapPath.Location = new System.Drawing.Point(100, 9);
            this.MapPath.Name = "MapPath";
            this.MapPath.ReadOnly = true;
            this.MapPath.Size = new System.Drawing.Size(178, 29);
            this.MapPath.TabIndex = 2;
            // 
            // ExportPath
            // 
            this.ExportPath.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ExportPath.Location = new System.Drawing.Point(100, 48);
            this.ExportPath.Name = "ExportPath";
            this.ExportPath.ReadOnly = true;
            this.ExportPath.Size = new System.Drawing.Size(178, 29);
            this.ExportPath.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("微軟正黑體", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.label2.Location = new System.Drawing.Point(8, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(99, 29);
            this.label2.TabIndex = 3;
            this.label2.Text = "匯出位置：";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExportChoose
            // 
            this.ExportChoose.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
            this.ExportChoose.Location = new System.Drawing.Point(284, 50);
            this.ExportChoose.Name = "ExportChoose";
            this.ExportChoose.Size = new System.Drawing.Size(59, 29);
            this.ExportChoose.TabIndex = 5;
            this.ExportChoose.Text = "瀏覽";
            this.ExportChoose.UseVisualStyleBackColor = true;
            this.ExportChoose.Click += new System.EventHandler(this.ExportChoose_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 344);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(729, 22);
            this.statusStrip1.TabIndex = 7;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // MapList
            // 
            this.MapList.Location = new System.Drawing.Point(12, 121);
            this.MapList.Name = "MapList";
            this.MapList.Size = new System.Drawing.Size(331, 220);
            this.MapList.TabIndex = 6;
            this.MapList.UseCompatibleStateImageBehavior = false;
            this.MapList.View = System.Windows.Forms.View.Details;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 366);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.MapList);
            this.Controls.Add(this.ExportChoose);
            this.Controls.Add(this.ExportPath);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.MapPath);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MapChoose);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
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
    }
}

