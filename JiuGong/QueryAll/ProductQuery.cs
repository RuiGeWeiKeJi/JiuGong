using Mulaolao.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace JiuGong.QueryAll
{
    public partial class ProductQuery : Form
    {
        public ProductQuery ( )
        {
            InitializeComponent( );
        }

        public delegate void PassDataBetweenFormHandler ( object sender ,PassDataWinFormEventArgs e );
        public event PassDataBetweenFormHandler PassDataBetweenForm;
        JiuGongBll.Bll.FormBll bll = new JiuGongBll.Bll.FormBll( );


        private void ProductQuery_Load ( object sender ,EventArgs e )
        {
            GridViewMoHuSelect.SetFilter( gridView1 );
            query( );
        }

        void query ( )
        {
            DataTable tableQuery = bll.GetDataTableQuery( );
            gridControl1.DataSource = tableQuery;
        }

        //Value
        string cn1 = "";
        private void gridView1_DoubleClick ( object sender ,EventArgs e )
        {
            cn1 = gridView1.GetFocusedRowCellValue( "RCC010" ).ToString( );
            PassDataWinFormEventArgs args = new PassDataWinFormEventArgs( cn1 );
            if ( PassDataBetweenForm != null )
            {
                PassDataBetweenForm( this ,args );
            }
            this.Close( );
        }


    }
}
