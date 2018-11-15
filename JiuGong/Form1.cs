using JiuGong.QueryAll;
using Mulaolao.Class;
using System;
using System.Data;
using System.Windows.Forms;
using FastReport;
using FastReport.Export.Xml;

namespace JiuGong
{
    public partial class Form1 : Form
    {
        public Form1 ( )
        {
            InitializeComponent( );
        }

        JiuGongBll.Bll.FormBll bll = new JiuGongBll.Bll.FormBll( );
        JiuGongEntity.FormEntity model = new JiuGongEntity.FormEntity( );
        private void Form1_Load ( object sender ,EventArgs e )
        {

        }

        string dateValue = "", strWhere = "1=1", file = "";
        DataTable tableQuery;

        Report report = new Report( );
        DataSet RDataSet;

        void jskLba ( )
        {
            DataTable da = bll.GetDataTableLba( );
            if ( da.Rows.Count > 0 )
            {
                if ( !string.IsNullOrEmpty( da.Rows[0]["LBA001"].ToString( ) ) )
                {
                    if ( da.Rows[0]["LBA001"].ToString( ).Substring( 2 ,6 ) == DateTime.Now.ToString( "yyyyMM" ) )
                        model.LBA001 = "WG" + ( Convert.ToInt32( da.Rows[0]["LBA001"].ToString( ).Substring( 2 ,9 ) ) + 1 ).ToString( );
                    else
                        model.LBA001 = "WG" + DateTime.Now.ToString( "yyyyMM" ) + "001";
                }
                else
                    model.LBA001 = "WG" + DateTime.Now.ToString( "yyyyMM" ) + "001";
            }
            else
                model.LBA001 = "WG" + DateTime.Now.ToString( "yyyyMM" ) + "001";
            model.LBA002 = "外挂";
            model.LBA003 = dateTimePicker1.Value.AddMonths( 1 ).AddDays( 0 - dateTimePicker1.Value.Day ).ToString( "yyyyMMdd" );
            model.LBA004 = "99";
            model.LBA007 = "F";
            model.LBA015 = "3";
            model.LBA905 = 3;
        }
        void jskLbb ( bool lbbResult=false)
        {
            DataTable db = bll.GetDataTableLbb( dateValue );
            if ( db.Rows.Count > 0 )
            {
                for ( int i = 0 ; i < db.Rows.Count ; i++ )
                {
                    if ( i < 9 )
                        model.LBB002 = "00" + ( i + 1 ).ToString( );
                    else if ( i >= 9 && i < 99 )
                        model.LBB002 = "0" + ( i + 1 ).ToString( );
                    else if ( i >= 99 )
                        model.LBB002 = ( i + 1 ).ToString( );
                    model.LBB003 = db.Rows[i]["DEA001"].ToString( );
                    model.LBB005 = db.Rows[i]["RBB006"].ToString( );
                    model.LBB006 = db.Rows[i]["DEA008"].ToString( );
                    model.LBB007 = -1;
                    model.LBB010 = string.IsNullOrEmpty( db.Rows[i]["QKA006"].ToString( ) ) == true ? 0 : -Convert.ToDecimal( db.Rows[i]["QKA006"].ToString( ) );
                    model.LBB019 = db.Rows[i]["RBB021"].ToString( );
                    model.LBB905 = 1;

                    lbbResult = bll.InsertTranLbb( model );

                    if ( lbbResult == false )
                    {
                        MessageBox.Show( "生产调整单失败,请重试" );
                        bll.DeleteTranLba( model.LBA001 );
                        bll.GetDataTableLbb( model.LBA001 );
                        break;
                    }
                    else if ( i == db.Rows.Count - 1 )
                    {
                        MessageBox.Show( "生产调整的成功,请查看" );
                    }
                       
                }
            }
        }
        
        private void button2_Click ( object sender ,EventArgs e )
        {
            dateValue = dateTimePicker1.Value.ToString( "yyyyMM" );
            bool lbaResult = bll.ExistsLba( dateValue );
            if ( lbaResult == true )
                MessageBox.Show( "本月已经存在调整单,请核实" );
            else
            {
                bool rcbResult = bll.Exists( dateValue );
                if ( rcbResult == true )
                {
                    bool sqkResult = bll.ExistsThr( dateValue );
                    if ( sqkResult == true )
                    {
                        jskLba( );
                        bool lbaResultTwo = bll.InsertTranLba( model );
                        if ( lbaResultTwo == true )
                        {
                            jskLbb( );
                        }
                        else
                            MessageBox.Show( "生产调整单失败,请重试" );
                    }
                    else
                        MessageBox.Show( "分流表中没有本月入库单的非本月工单存在退回退料想象的入库单记录" );
                }
                else
                    MessageBox.Show( "本月入库单的非本月工单没有退回退料想象" );
            }
        }

        private void button1_Click ( object sender ,EventArgs e )
        {
            this.Close( );
            this.Dispose( );
        }


        //品号
        private void button3_Click ( object sender ,EventArgs e )
        {
            ProductQuery query = new ProductQuery( );
            query.StartPosition = FormStartPosition.CenterScreen;
            query.PassDataBetweenForm += new ProductQuery.PassDataBetweenFormHandler( query_PassDataBetweenForm );
            query.ShowDialog( );
        }
        private void query_PassDataBetweenForm ( object sender ,PassDataWinFormEventArgs e )
        {
            textBox1.Text = e.ConOne;
        }
        //Query
        private void button4_Click ( object sender ,EventArgs e )
        {
            strWhere = "1=1";
            if ( !string.IsNullOrEmpty( textBox1.Text ) )
                strWhere = strWhere + " AND RCC010='" + textBox1.Text + "'";
            tableQuery = bll.GetDataTableReport( strWhere );
            gridControl1.DataSource = tableQuery;
        }
        //Clear
        private void button5_Click ( object sender ,EventArgs e )
        {
            textBox1.Text = "";
        }
        //Print
        private void button6_Click ( object sender ,EventArgs e )
        {
            file = "";
            file = Application.StartupPath + "";
            report.Load( file + "\\jiugong.frx" );
            CreatePrint( );
            report.RegisterData( RDataSet );
            report.Show( );
        }
        //Export
        private void button7_Click ( object sender ,EventArgs e )
        {
            file = "";
            file = Application.StartupPath + "";
            report.Load( file + "\\jiugong.frx" );
            CreatePrint( );
            report.RegisterData( RDataSet );
            report.Prepare( );
            XMLExport exprots = new XMLExport( );
            exprots.Export( report );
        }
        void CreatePrint ( )
        {
            strWhere = "1=1";
            if ( !string.IsNullOrEmpty( textBox1.Text ) )
                strWhere = strWhere + " AND RCC010='" + textBox1.Text + "'";
            DataTable print = bll.GetDataTablePrint( strWhere );
            print.TableName = "SGMRAC";
            RDataSet = new DataSet( );
            RDataSet.Tables.Clear( );
            RDataSet.Tables.Add( print );
        }
    }
}
