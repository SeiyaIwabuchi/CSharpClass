namespace CS07_05_10
{
    partial class Form1
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.aToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.乗用車ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.トラックToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.オープンカーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.タクシーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.サブ2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.スポーツカーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ミニカーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.メイン3ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.パトカーToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.消防車ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.label1.Location = new System.Drawing.Point(0, 129);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.label1.Size = new System.Drawing.Size(85, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "いらっしゃいませ。";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aToolStripMenuItem,
            this.cToolStripMenuItem,
            this.メイン3ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(234, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // aToolStripMenuItem
            // 
            this.aToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.乗用車ToolStripMenuItem,
            this.トラックToolStripMenuItem});
            this.aToolStripMenuItem.Name = "aToolStripMenuItem";
            this.aToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.aToolStripMenuItem.Text = "メイン1";
            this.aToolStripMenuItem.Click += new System.EventHandler(this.mi_click);
            // 
            // 乗用車ToolStripMenuItem
            // 
            this.乗用車ToolStripMenuItem.Name = "乗用車ToolStripMenuItem";
            this.乗用車ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.乗用車ToolStripMenuItem.Text = "乗用車";
            this.乗用車ToolStripMenuItem.Click += new System.EventHandler(this.mi_click);
            // 
            // トラックToolStripMenuItem
            // 
            this.トラックToolStripMenuItem.Name = "トラックToolStripMenuItem";
            this.トラックToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.トラックToolStripMenuItem.Text = "トラック";
            this.トラックToolStripMenuItem.Click += new System.EventHandler(this.mi_click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dToolStripMenuItem,
            this.toolStripSeparator1,
            this.サブ2ToolStripMenuItem});
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.cToolStripMenuItem.Text = "メイン2";
            this.cToolStripMenuItem.Click += new System.EventHandler(this.mi_click);
            // 
            // dToolStripMenuItem
            // 
            this.dToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.オープンカーToolStripMenuItem,
            this.タクシーToolStripMenuItem});
            this.dToolStripMenuItem.Name = "dToolStripMenuItem";
            this.dToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.dToolStripMenuItem.Text = "サブ1";
            this.dToolStripMenuItem.Click += new System.EventHandler(this.mi_click);
            // 
            // オープンカーToolStripMenuItem
            // 
            this.オープンカーToolStripMenuItem.Name = "オープンカーToolStripMenuItem";
            this.オープンカーToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.オープンカーToolStripMenuItem.Text = "オープンカー";
            this.オープンカーToolStripMenuItem.Click += new System.EventHandler(this.mi_click);
            // 
            // タクシーToolStripMenuItem
            // 
            this.タクシーToolStripMenuItem.Name = "タクシーToolStripMenuItem";
            this.タクシーToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.タクシーToolStripMenuItem.Text = "タクシー";
            this.タクシーToolStripMenuItem.Click += new System.EventHandler(this.mi_click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(177, 6);
            // 
            // サブ2ToolStripMenuItem
            // 
            this.サブ2ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.スポーツカーToolStripMenuItem,
            this.ミニカーToolStripMenuItem});
            this.サブ2ToolStripMenuItem.Name = "サブ2ToolStripMenuItem";
            this.サブ2ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.サブ2ToolStripMenuItem.Text = "サブ2";
            this.サブ2ToolStripMenuItem.Click += new System.EventHandler(this.mi_click);
            // 
            // スポーツカーToolStripMenuItem
            // 
            this.スポーツカーToolStripMenuItem.Name = "スポーツカーToolStripMenuItem";
            this.スポーツカーToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.スポーツカーToolStripMenuItem.Text = "スポーツカー";
            this.スポーツカーToolStripMenuItem.Click += new System.EventHandler(this.mi_click);
            // 
            // ミニカーToolStripMenuItem
            // 
            this.ミニカーToolStripMenuItem.Name = "ミニカーToolStripMenuItem";
            this.ミニカーToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.ミニカーToolStripMenuItem.Text = "ミニカー";
            this.ミニカーToolStripMenuItem.Click += new System.EventHandler(this.mi_click);
            // 
            // メイン3ToolStripMenuItem
            // 
            this.メイン3ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.パトカーToolStripMenuItem,
            this.消防車ToolStripMenuItem});
            this.メイン3ToolStripMenuItem.Name = "メイン3ToolStripMenuItem";
            this.メイン3ToolStripMenuItem.Size = new System.Drawing.Size(51, 20);
            this.メイン3ToolStripMenuItem.Text = "メイン3";
            this.メイン3ToolStripMenuItem.Click += new System.EventHandler(this.mi_click);
            // 
            // パトカーToolStripMenuItem
            // 
            this.パトカーToolStripMenuItem.Name = "パトカーToolStripMenuItem";
            this.パトカーToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.パトカーToolStripMenuItem.Text = "パトカー";
            this.パトカーToolStripMenuItem.Click += new System.EventHandler(this.mi_click);
            // 
            // 消防車ToolStripMenuItem
            // 
            this.消防車ToolStripMenuItem.Name = "消防車ToolStripMenuItem";
            this.消防車ToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.消防車ToolStripMenuItem.Text = "消防車";
            this.消防車ToolStripMenuItem.Click += new System.EventHandler(this.mi_click);
            // 
            // bToolStripMenuItem
            // 
            this.bToolStripMenuItem.Name = "bToolStripMenuItem";
            this.bToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.bToolStripMenuItem.Text = "b";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(234, 161);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "サンプル";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem aToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem bToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 乗用車ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem トラックToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem オープンカーToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem タクシーToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem サブ2ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem メイン3ToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem スポーツカーToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ミニカーToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem パトカーToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 消防車ToolStripMenuItem;
    }
}

