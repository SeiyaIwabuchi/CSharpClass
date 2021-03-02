namespace CSDB2
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
            this.resultLists = new System.Windows.Forms.ListBox();
            this.inputProCode = new System.Windows.Forms.TextBox();
            this.inputProName = new System.Windows.Forms.TextBox();
            this.inputProPrice = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.textboxError = new System.Windows.Forms.TextBox();
            this.textBoxSQL = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // resultLists
            // 
            this.resultLists.FormattingEnabled = true;
            this.resultLists.ItemHeight = 12;
            this.resultLists.Location = new System.Drawing.Point(12, 12);
            this.resultLists.Name = "resultLists";
            this.resultLists.Size = new System.Drawing.Size(312, 160);
            this.resultLists.TabIndex = 0;
            // 
            // inputProCode
            // 
            this.inputProCode.Location = new System.Drawing.Point(12, 201);
            this.inputProCode.Name = "inputProCode";
            this.inputProCode.Size = new System.Drawing.Size(100, 19);
            this.inputProCode.TabIndex = 1;
            // 
            // inputProName
            // 
            this.inputProName.Location = new System.Drawing.Point(118, 201);
            this.inputProName.Name = "inputProName";
            this.inputProName.Size = new System.Drawing.Size(100, 19);
            this.inputProName.TabIndex = 2;
            // 
            // inputProPrice
            // 
            this.inputProPrice.Location = new System.Drawing.Point(224, 201);
            this.inputProPrice.Name = "inputProPrice";
            this.inputProPrice.Size = new System.Drawing.Size(100, 19);
            this.inputProPrice.TabIndex = 3;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(12, 242);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 4;
            this.btnSearch.Text = "検索";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(93, 242);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "追加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(174, 242);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 6;
            this.btnUpdate.Text = "更新";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(255, 242);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 7;
            this.btnDelete.Text = "削除";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.button4_Click);
            // 
            // textboxError
            // 
            this.textboxError.Location = new System.Drawing.Point(12, 287);
            this.textboxError.Multiline = true;
            this.textboxError.Name = "textboxError";
            this.textboxError.ReadOnly = true;
            this.textboxError.Size = new System.Drawing.Size(312, 60);
            this.textboxError.TabIndex = 8;
            // 
            // textBoxSQL
            // 
            this.textBoxSQL.Location = new System.Drawing.Point(12, 378);
            this.textBoxSQL.Multiline = true;
            this.textBoxSQL.Name = "textBoxSQL";
            this.textBoxSQL.ReadOnly = true;
            this.textBoxSQL.Size = new System.Drawing.Size(312, 60);
            this.textBoxSQL.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 272);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 12);
            this.label1.TabIndex = 10;
            this.label1.Text = "エラー";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 363);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 12);
            this.label2.TabIndex = 11;
            this.label2.Text = "SQL";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxSQL);
            this.Controls.Add(this.textboxError);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.inputProPrice);
            this.Controls.Add(this.inputProName);
            this.Controls.Add(this.inputProCode);
            this.Controls.Add(this.resultLists);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox resultLists;
        private System.Windows.Forms.TextBox inputProCode;
        private System.Windows.Forms.TextBox inputProName;
        private System.Windows.Forms.TextBox inputProPrice;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox textboxError;
        private System.Windows.Forms.TextBox textBoxSQL;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

