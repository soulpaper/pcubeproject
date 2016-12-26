namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다.
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.lkkkkToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.appContainer2 = new SmileWei.EmbeddedApp.AppContainer(this.components);
            this.appContainer1 = new SmileWei.EmbeddedApp.AppContainer(this.components);
            this.Miexdatalinear_button = new System.Windows.Forms.Button();
            this.Miexdatalinear_dir = new System.Windows.Forms.TextBox();
            this.ind_text = new System.Windows.Forms.TextBox();
            this.ind_button = new System.Windows.Forms.Button();
            this.Calculate_button = new System.Windows.Forms.Button();
            this.contextMenuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lkkkkToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(102, 26);
            // 
            // lkkkkToolStripMenuItem
            // 
            this.lkkkkToolStripMenuItem.Name = "lkkkkToolStripMenuItem";
            this.lkkkkToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.lkkkkToolStripMenuItem.Text = "lkkkk";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tableLayoutPanel1);
            this.panel1.Controls.Add(this.Miexdatalinear_button);
            this.panel1.Controls.Add(this.Miexdatalinear_dir);
            this.panel1.Controls.Add(this.ind_text);
            this.panel1.Controls.Add(this.ind_button);
            this.panel1.Controls.Add(this.Calculate_button);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1538, 558);
            this.panel1.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70.19438F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 29.80562F));
            this.tableLayoutPanel1.Controls.Add(this.appContainer2, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.appContainer1, 0, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(8, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(1515, 512);
            this.tableLayoutPanel1.TabIndex = 21;
            // 
            // appContainer2
            // 
            this.appContainer2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appContainer2.AppFilename = "";
            this.appContainer2.AppProcess = null;
            this.appContainer2.AutoScroll = true;
            this.appContainer2.Location = new System.Drawing.Point(1073, 10);
            this.appContainer2.Margin = new System.Windows.Forms.Padding(10);
            this.appContainer2.Name = "appContainer2";
            this.appContainer2.Size = new System.Drawing.Size(432, 492);
            this.appContainer2.TabIndex = 20;
            // 
            // appContainer1
            // 
            this.appContainer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.appContainer1.AppFilename = "";
            this.appContainer1.AppProcess = null;
            this.appContainer1.AutoScroll = true;
            this.appContainer1.AutoScrollMargin = new System.Drawing.Size(10, 10);
            this.appContainer1.AutoSize = true;
            this.appContainer1.Location = new System.Drawing.Point(3, 3);
            this.appContainer1.Name = "appContainer1";
            this.appContainer1.Size = new System.Drawing.Size(1057, 506);
            this.appContainer1.TabIndex = 19;
            // 
            // Miexdatalinear_button
            // 
            this.Miexdatalinear_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Miexdatalinear_button.Location = new System.Drawing.Point(736, 530);
            this.Miexdatalinear_button.Name = "Miexdatalinear_button";
            this.Miexdatalinear_button.Size = new System.Drawing.Size(114, 23);
            this.Miexdatalinear_button.TabIndex = 15;
            this.Miexdatalinear_button.Text = "Select Miexdatalinear";
            this.Miexdatalinear_button.UseVisualStyleBackColor = true;
            this.Miexdatalinear_button.Click += new System.EventHandler(this.Miexdatalinear_button_Click);
            // 
            // Miexdatalinear_dir
            // 
            this.Miexdatalinear_dir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Miexdatalinear_dir.Location = new System.Drawing.Point(650, 530);
            this.Miexdatalinear_dir.Name = "Miexdatalinear_dir";
            this.Miexdatalinear_dir.Size = new System.Drawing.Size(80, 21);
            this.Miexdatalinear_dir.TabIndex = 14;
            // 
            // ind_text
            // 
            this.ind_text.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ind_text.Location = new System.Drawing.Point(856, 532);
            this.ind_text.Name = "ind_text";
            this.ind_text.Size = new System.Drawing.Size(80, 21);
            this.ind_text.TabIndex = 17;
            // 
            // ind_button
            // 
            this.ind_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ind_button.Location = new System.Drawing.Point(942, 532);
            this.ind_button.Name = "ind_button";
            this.ind_button.Size = new System.Drawing.Size(114, 23);
            this.ind_button.TabIndex = 18;
            this.ind_button.Text = "Min Ind is 500";
            this.ind_button.UseVisualStyleBackColor = true;
            // 
            // Calculate_button
            // 
            this.Calculate_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.Calculate_button.Location = new System.Drawing.Point(1062, 534);
            this.Calculate_button.Name = "Calculate_button";
            this.Calculate_button.Size = new System.Drawing.Size(89, 21);
            this.Calculate_button.TabIndex = 16;
            this.Calculate_button.Text = "Set";
            this.Calculate_button.UseVisualStyleBackColor = true;
            this.Calculate_button.Click += new System.EventHandler(this.Calculate_button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1562, 582);
            this.Controls.Add(this.panel1);
            this.Name = "Form1";
            this.Text = "P-Cube";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.contextMenuStrip1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem lkkkkToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private SmileWei.EmbeddedApp.AppContainer appContainer2;
        private System.Windows.Forms.Button Miexdatalinear_button;
        private SmileWei.EmbeddedApp.AppContainer appContainer1;
        public System.Windows.Forms.TextBox Miexdatalinear_dir;
        public System.Windows.Forms.TextBox ind_text;
        private System.Windows.Forms.Button ind_button;
        private System.Windows.Forms.Button Calculate_button;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    }
}

