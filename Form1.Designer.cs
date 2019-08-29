namespace BinarySortTree
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.txtValues = new System.Windows.Forms.TextBox();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtDelPoint = new System.Windows.Forms.TextBox();
            this.txtDelResult = new System.Windows.Forms.TextBox();
            this.txtSearchResult = new System.Windows.Forms.TextBox();
            this.txtFindPoint = new System.Windows.Forms.TextBox();
            this.txtTree = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("华文隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(13, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "请输入一组关键值";
            // 
            // txtValues
            // 
            this.txtValues.Location = new System.Drawing.Point(13, 34);
            this.txtValues.Name = "txtValues";
            this.txtValues.Size = new System.Drawing.Size(406, 29);
            this.txtValues.TabIndex = 1;
            this.txtValues.TextChanged += new System.EventHandler(this.txtValues_TextChanged);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSubmit.Location = new System.Drawing.Point(494, 36);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(80, 27);
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.BackgroundImage = global::BinarySortTree.Properties.Resources.按钮_1;
            this.btnSearch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSearch.Font = new System.Drawing.Font("Adobe Devanagari", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnSearch.Location = new System.Drawing.Point(87, 45);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(98, 29);
            this.btnSearch.TabIndex = 3;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackgroundImage = global::BinarySortTree.Properties.Resources.按钮_1;
            this.btnDelete.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnDelete.Font = new System.Drawing.Font("Adobe Devanagari", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnDelete.Location = new System.Drawing.Point(87, 286);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 34);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.groupBox1.Controls.Add(this.txtDelPoint);
            this.groupBox1.Controls.Add(this.txtDelResult);
            this.groupBox1.Controls.Add(this.txtSearchResult);
            this.groupBox1.Controls.Add(this.txtFindPoint);
            this.groupBox1.Controls.Add(this.btnSearch);
            this.groupBox1.Controls.Add(this.btnDelete);
            this.groupBox1.Location = new System.Drawing.Point(686, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(302, 542);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Function";
            // 
            // txtDelPoint
            // 
            this.txtDelPoint.Location = new System.Drawing.Point(19, 289);
            this.txtDelPoint.Name = "txtDelPoint";
            this.txtDelPoint.Size = new System.Drawing.Size(62, 29);
            this.txtDelPoint.TabIndex = 8;
            // 
            // txtDelResult
            // 
            this.txtDelResult.Location = new System.Drawing.Point(19, 336);
            this.txtDelResult.Multiline = true;
            this.txtDelResult.Name = "txtDelResult";
            this.txtDelResult.Size = new System.Drawing.Size(277, 177);
            this.txtDelResult.TabIndex = 7;
            // 
            // txtSearchResult
            // 
            this.txtSearchResult.ForeColor = System.Drawing.SystemColors.WindowText;
            this.txtSearchResult.Location = new System.Drawing.Point(19, 93);
            this.txtSearchResult.Multiline = true;
            this.txtSearchResult.Name = "txtSearchResult";
            this.txtSearchResult.Size = new System.Drawing.Size(277, 177);
            this.txtSearchResult.TabIndex = 6;
            // 
            // txtFindPoint
            // 
            this.txtFindPoint.Location = new System.Drawing.Point(19, 45);
            this.txtFindPoint.Name = "txtFindPoint";
            this.txtFindPoint.Size = new System.Drawing.Size(62, 29);
            this.txtFindPoint.TabIndex = 5;
            // 
            // txtTree
            // 
            this.txtTree.AcceptsReturn = true;
            this.txtTree.Font = new System.Drawing.Font("华文宋体", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtTree.Location = new System.Drawing.Point(13, 95);
            this.txtTree.Multiline = true;
            this.txtTree.Name = "txtTree";
            this.txtTree.Size = new System.Drawing.Size(636, 466);
            this.txtTree.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1000, 600);
            this.Controls.Add(this.txtTree);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.txtValues);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("华文隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtValues;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFindPoint;
        private System.Windows.Forms.TextBox txtTree;
        private System.Windows.Forms.TextBox txtDelResult;
        private System.Windows.Forms.TextBox txtSearchResult;
        private System.Windows.Forms.TextBox txtDelPoint;
    }
}

