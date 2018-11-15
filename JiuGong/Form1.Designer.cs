namespace JiuGong
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
        protected override void Dispose ( bool disposing )
        {
            if ( disposing && ( components != null ) )
            {
                components.Dispose( );
            }
            base.Dispose( disposing );
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent ( )
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPageOne = new System.Windows.Forms.TabPage();
            this.tabPageTwo = new System.Windows.Forms.TabPage();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.button5 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.RCC001 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RCA004 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RCC002 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RCC010 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.RCB004 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEA002 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEA057 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DEA003 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.HYL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TLL = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LPA005 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LP = new DevExpress.XtraGrid.Columns.GridColumn();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.RCB018 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.tabControl1.SuspendLayout();
            this.tabPageOne.SuspendLayout();
            this.tabPageTwo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(98, 158);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "日    期：";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarForeColor = System.Drawing.Color.Red;
            this.dateTimePicker1.CustomFormat = "yyyy年MM月";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(200, 151);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(180, 26);
            this.dateTimePicker1.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(288, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(92, 25);
            this.button1.TabIndex = 2;
            this.button1.Text = "取  消";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.Red;
            this.button2.Location = new System.Drawing.Point(101, 208);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(92, 25);
            this.button2.TabIndex = 3;
            this.button2.Text = "确  认";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(101, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(527, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "1、每月生产成本计算完成后，执行本程序，即在系统生成一张调整单";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(101, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(221, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "2、每月此调整单只生成一张";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(20, 30);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(93, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "功能说明：";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPageTwo);
            this.tabControl1.Controls.Add(this.tabPageOne);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1228, 488);
            this.tabControl1.TabIndex = 7;
            // 
            // tabPageOne
            // 
            this.tabPageOne.Controls.Add(this.label4);
            this.tabPageOne.Controls.Add(this.label1);
            this.tabPageOne.Controls.Add(this.label3);
            this.tabPageOne.Controls.Add(this.dateTimePicker1);
            this.tabPageOne.Controls.Add(this.label2);
            this.tabPageOne.Controls.Add(this.button1);
            this.tabPageOne.Controls.Add(this.button2);
            this.tabPageOne.Location = new System.Drawing.Point(4, 26);
            this.tabPageOne.Name = "tabPageOne";
            this.tabPageOne.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageOne.Size = new System.Drawing.Size(1220, 458);
            this.tabPageOne.TabIndex = 0;
            this.tabPageOne.Text = "生成调整单";
            this.tabPageOne.UseVisualStyleBackColor = true;
            // 
            // tabPageTwo
            // 
            this.tabPageTwo.Controls.Add(this.splitContainer1);
            this.tabPageTwo.Location = new System.Drawing.Point(4, 26);
            this.tabPageTwo.Name = "tabPageTwo";
            this.tabPageTwo.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTwo.Size = new System.Drawing.Size(1220, 458);
            this.tabPageTwo.TabIndex = 1;
            this.tabPageTwo.Text = "生产成本材料明细表";
            this.tabPageTwo.UseVisualStyleBackColor = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.button7);
            this.splitContainer1.Panel1.Controls.Add(this.button6);
            this.splitContainer1.Panel1.Controls.Add(this.button5);
            this.splitContainer1.Panel1.Controls.Add(this.button4);
            this.splitContainer1.Panel1.Controls.Add(this.button3);
            this.splitContainer1.Panel1.Controls.Add(this.textBox1);
            this.splitContainer1.Panel1.Controls.Add(this.label5);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.gridControl1);
            this.splitContainer1.Size = new System.Drawing.Size(1214, 452);
            this.splitContainer1.SplitterDistance = 39;
            this.splitContainer1.TabIndex = 0;
            // 
            // button5
            // 
            this.button5.Location = new System.Drawing.Point(379, 6);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 26);
            this.button5.TabIndex = 6;
            this.button5.Text = "清空";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(298, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 26);
            this.button4.TabIndex = 5;
            this.button4.Text = "查询";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Green;
            this.button3.Location = new System.Drawing.Point(265, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(27, 26);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(94, 6);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(165, 26);
            this.textBox1.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(76, 16);
            this.label5.TabIndex = 0;
            this.label5.Text = "主件品号";
            // 
            // gridControl1
            // 
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControl1.Location = new System.Drawing.Point(0, 0);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(1214, 409);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.ColumnPanelRowHeight = 25;
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.RCC001,
            this.RCA004,
            this.RCC002,
            this.RCC010,
            this.RCB004,
            this.DEA002,
            this.DEA057,
            this.DEA003,
            this.HYL,
            this.TLL,
            this.LPA005,
            this.LP,
            this.RCB018});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.GroupCount = 1;
            this.gridView1.GroupSummary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridGroupSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LP", this.LP, "{0:N2}")});
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.AutoExpandAllGroups = true;
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsView.ColumnAutoWidth = false;
            this.gridView1.OptionsView.ShowFooter = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.SortInfo.AddRange(new DevExpress.XtraGrid.Columns.GridColumnSortInfo[] {
            new DevExpress.XtraGrid.Columns.GridColumnSortInfo(this.RCC010, DevExpress.Data.ColumnSortOrder.Ascending)});
            // 
            // RCC001
            // 
            this.RCC001.AppearanceCell.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.RCC001.AppearanceCell.Options.UseFont = true;
            this.RCC001.AppearanceHeader.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.RCC001.AppearanceHeader.Options.UseFont = true;
            this.RCC001.AppearanceHeader.Options.UseTextOptions = true;
            this.RCC001.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RCC001.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.RCC001.Caption = "类别";
            this.RCC001.FieldName = "RCC001";
            this.RCC001.Name = "RCC001";
            this.RCC001.Visible = true;
            this.RCC001.VisibleIndex = 1;
            // 
            // RCA004
            // 
            this.RCA004.AppearanceCell.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.RCA004.AppearanceCell.Options.UseFont = true;
            this.RCA004.AppearanceHeader.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.RCA004.AppearanceHeader.Options.UseFont = true;
            this.RCA004.AppearanceHeader.Options.UseTextOptions = true;
            this.RCA004.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RCA004.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.RCA004.Caption = "日期";
            this.RCA004.FieldName = "RCA004";
            this.RCA004.Name = "RCA004";
            this.RCA004.Visible = true;
            this.RCA004.VisibleIndex = 2;
            this.RCA004.Width = 131;
            // 
            // RCC002
            // 
            this.RCC002.AppearanceCell.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.RCC002.AppearanceCell.Options.UseFont = true;
            this.RCC002.AppearanceHeader.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.RCC002.AppearanceHeader.Options.UseFont = true;
            this.RCC002.AppearanceHeader.Options.UseTextOptions = true;
            this.RCC002.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RCC002.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.RCC002.Caption = "来源单号";
            this.RCC002.FieldName = "RCC002";
            this.RCC002.Name = "RCC002";
            this.RCC002.Visible = true;
            this.RCC002.VisibleIndex = 0;
            this.RCC002.Width = 167;
            // 
            // RCC010
            // 
            this.RCC010.AppearanceCell.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.RCC010.AppearanceCell.Options.UseFont = true;
            this.RCC010.AppearanceHeader.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.RCC010.AppearanceHeader.Options.UseFont = true;
            this.RCC010.AppearanceHeader.Options.UseTextOptions = true;
            this.RCC010.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RCC010.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.RCC010.Caption = "主件品号";
            this.RCC010.FieldName = "RCC010";
            this.RCC010.Name = "RCC010";
            this.RCC010.Visible = true;
            this.RCC010.VisibleIndex = 4;
            // 
            // RCB004
            // 
            this.RCB004.AppearanceCell.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.RCB004.AppearanceCell.Options.UseFont = true;
            this.RCB004.AppearanceHeader.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.RCB004.AppearanceHeader.Options.UseFont = true;
            this.RCB004.AppearanceHeader.Options.UseTextOptions = true;
            this.RCB004.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RCB004.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.RCB004.Caption = "子件品号";
            this.RCB004.FieldName = "RCB004";
            this.RCB004.Name = "RCB004";
            this.RCB004.Visible = true;
            this.RCB004.VisibleIndex = 3;
            this.RCB004.Width = 114;
            // 
            // DEA002
            // 
            this.DEA002.AppearanceCell.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.DEA002.AppearanceCell.Options.UseFont = true;
            this.DEA002.AppearanceHeader.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.DEA002.AppearanceHeader.Options.UseFont = true;
            this.DEA002.AppearanceHeader.Options.UseTextOptions = true;
            this.DEA002.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DEA002.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.DEA002.Caption = "品名";
            this.DEA002.FieldName = "DEA002";
            this.DEA002.Name = "DEA002";
            this.DEA002.Visible = true;
            this.DEA002.VisibleIndex = 4;
            this.DEA002.Width = 127;
            // 
            // DEA057
            // 
            this.DEA057.AppearanceCell.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.DEA057.AppearanceCell.Options.UseFont = true;
            this.DEA057.AppearanceHeader.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.DEA057.AppearanceHeader.Options.UseFont = true;
            this.DEA057.AppearanceHeader.Options.UseTextOptions = true;
            this.DEA057.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DEA057.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.DEA057.Caption = "规格";
            this.DEA057.FieldName = "DEA057";
            this.DEA057.Name = "DEA057";
            this.DEA057.Visible = true;
            this.DEA057.VisibleIndex = 5;
            // 
            // DEA003
            // 
            this.DEA003.AppearanceCell.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.DEA003.AppearanceCell.Options.UseFont = true;
            this.DEA003.AppearanceHeader.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.DEA003.AppearanceHeader.Options.UseFont = true;
            this.DEA003.AppearanceHeader.Options.UseTextOptions = true;
            this.DEA003.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.DEA003.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.DEA003.Caption = "单位";
            this.DEA003.FieldName = "DEA003";
            this.DEA003.Name = "DEA003";
            this.DEA003.Visible = true;
            this.DEA003.VisibleIndex = 6;
            // 
            // HYL
            // 
            this.HYL.AppearanceCell.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.HYL.AppearanceCell.Options.UseFont = true;
            this.HYL.AppearanceHeader.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.HYL.AppearanceHeader.Options.UseFont = true;
            this.HYL.AppearanceHeader.Options.UseTextOptions = true;
            this.HYL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.HYL.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.HYL.Caption = "耗用量";
            this.HYL.DisplayFormat.FormatString = "N2";
            this.HYL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.HYL.FieldName = "HYL";
            this.HYL.Name = "HYL";
            this.HYL.Visible = true;
            this.HYL.VisibleIndex = 7;
            this.HYL.Width = 120;
            // 
            // TLL
            // 
            this.TLL.AppearanceCell.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.TLL.AppearanceCell.Options.UseFont = true;
            this.TLL.AppearanceCell.Options.UseTextOptions = true;
            this.TLL.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TLL.AppearanceCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TLL.AppearanceHeader.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.TLL.AppearanceHeader.Options.UseFont = true;
            this.TLL.AppearanceHeader.Options.UseTextOptions = true;
            this.TLL.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.TLL.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.TLL.Caption = "退料量";
            this.TLL.DisplayFormat.FormatString = "N2";
            this.TLL.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TLL.FieldName = "TLL";
            this.TLL.Name = "TLL";
            this.TLL.Visible = true;
            this.TLL.VisibleIndex = 8;
            this.TLL.Width = 109;
            // 
            // LPA005
            // 
            this.LPA005.AppearanceCell.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.LPA005.AppearanceCell.Options.UseFont = true;
            this.LPA005.AppearanceHeader.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.LPA005.AppearanceHeader.Options.UseFont = true;
            this.LPA005.AppearanceHeader.Options.UseTextOptions = true;
            this.LPA005.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LPA005.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LPA005.Caption = "平均成本";
            this.LPA005.DisplayFormat.FormatString = "N2";
            this.LPA005.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.LPA005.FieldName = "LPA005";
            this.LPA005.Name = "LPA005";
            this.LPA005.Visible = true;
            this.LPA005.VisibleIndex = 10;
            this.LPA005.Width = 109;
            // 
            // LP
            // 
            this.LP.AppearanceCell.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.LP.AppearanceCell.Options.UseFont = true;
            this.LP.AppearanceHeader.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.LP.AppearanceHeader.Options.UseFont = true;
            this.LP.AppearanceHeader.Options.UseTextOptions = true;
            this.LP.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.LP.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.LP.Caption = "小计";
            this.LP.DisplayFormat.FormatString = "N2";
            this.LP.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.LP.FieldName = "LP";
            this.LP.Name = "LP";
            this.LP.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "LP", "{0:N2}")});
            this.LP.ToolTip = "([耗用量] - [退料量] + [报废耗用]) * [平均成本]";
            this.LP.UnboundExpression = "([HYL] - [TLL] + [RCB018]) * [LPA005]";
            this.LP.UnboundType = DevExpress.Data.UnboundColumnType.Decimal;
            this.LP.Visible = true;
            this.LP.VisibleIndex = 11;
            this.LP.Width = 109;
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(460, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 26);
            this.button6.TabIndex = 7;
            this.button6.Text = "打印";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(541, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 26);
            this.button7.TabIndex = 8;
            this.button7.Text = "导出";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // RCB018
            // 
            this.RCB018.AppearanceCell.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.RCB018.AppearanceCell.Options.UseFont = true;
            this.RCB018.AppearanceHeader.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold);
            this.RCB018.AppearanceHeader.Options.UseFont = true;
            this.RCB018.AppearanceHeader.Options.UseTextOptions = true;
            this.RCB018.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.RCB018.AppearanceHeader.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.RCB018.Caption = "报废耗用";
            this.RCB018.DisplayFormat.FormatString = "N2";
            this.RCB018.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.RCB018.FieldName = "RCB018";
            this.RCB018.Name = "RCB018";
            this.RCB018.Visible = true;
            this.RCB018.VisibleIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1228, 488);
            this.Controls.Add(this.tabControl1);
            this.Font = new System.Drawing.Font("宋体", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "生产成本管理";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPageOne.ResumeLayout(false);
            this.tabPageOne.PerformLayout();
            this.tabPageTwo.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.PerformLayout();
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPageOne;
        private System.Windows.Forms.TabPage tabPageTwo;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button4;
        private DevExpress.XtraGrid.Columns.GridColumn RCC001;
        private DevExpress.XtraGrid.Columns.GridColumn RCA004;
        private DevExpress.XtraGrid.Columns.GridColumn RCC002;
        private DevExpress.XtraGrid.Columns.GridColumn RCC010;
        private DevExpress.XtraGrid.Columns.GridColumn RCB004;
        private DevExpress.XtraGrid.Columns.GridColumn DEA002;
        private DevExpress.XtraGrid.Columns.GridColumn DEA057;
        private DevExpress.XtraGrid.Columns.GridColumn DEA003;
        private DevExpress.XtraGrid.Columns.GridColumn HYL;
        private DevExpress.XtraGrid.Columns.GridColumn TLL;
        private DevExpress.XtraGrid.Columns.GridColumn LPA005;
        private DevExpress.XtraGrid.Columns.GridColumn LP;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button6;
        private DevExpress.XtraGrid.Columns.GridColumn RCB018;
    }
}

