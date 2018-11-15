using StudentMgr;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuGongBll.Dao
{
    public class FormDao
    {

        /// <summary>
        /// 本年本月是否已经生成调整单
        /// </summary>
        /// <param name="dateValue"></param>
        /// <returns></returns>
        public bool ExistsLba ( string dateValue )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "SELECT COUNT(1) FROM JSKLBA" );
            strSql.Append( " WHERE LBA004='99'" );
            strSql.Append( " AND SUBSTRING(LBA003,0,7)='"+dateValue+"'" );

            return SqlHelper.Exists( strSql.ToString( ) );
        }


        /// <summary>
        /// RCB001=85和工单记录是否存在
        /// </summary>
        /// <returns></returns>
        public bool Exists (string dateValue )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "SELECT COUNT(1) FROM SGMRAA C,SGMRCA A,SGMRCB B,SGMRBB D WHERE A.RCA002=B.RCB002 AND RCB001=85 AND C.RAA001=B.RCB022 AND D.RBB010=C.RAA001" );
            strSql.Append( "  AND SUBSTRING(RCA004,0,7)='" + dateValue + "'" );
            strSql.Append( "  AND SUBSTRING(RAA003,0,7)!='" + dateValue + "'" );

            return SqlHelper.Exists( strSql.ToString( ) );
        }


        /// <summary>
        /// 分流单中是否有入库单的记录
        /// </summary>
        /// <returns></returns>
        public bool ExistsThr ( string dateValue )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "SELECT COUNT(1) FROM SGMQKA E,SGMRAA C,SGMRCA A,SGMRCB B,SGMRBB D WHERE A.RCA002=B.RCB002 AND RCB001=85 AND C.RAA001=B.RCB022 AND D.RBB010=C.RAA001 AND E.QKA001=B.RCB024" );
            strSql.Append( "  AND SUBSTRING(RCA004,0,7)='" + dateValue + "'" );
            strSql.Append( "  AND SUBSTRING(RAA003,0,7)!='" + dateValue + "'" );

            return SqlHelper.Exists( strSql.ToString( ) );
        }


        /// <summary>
        /// 插入JSKLBA数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool InsertTranLba ( JiuGongEntity.FormEntity model)
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "INSERT INTO JSKLBA (LBA001,LBA002,LBA003,LBA004,LBA007,LBA015,LBA905)" );
            strSql.Append( " VALUES(" );
            strSql.Append( " @LBA001,@LBA002,@LBA003,@LBA004,@LBA007,@LBA015,@LBA905)" );

            SqlParameter[] parameter = {
                new SqlParameter("@LBA001",SqlDbType.NVarChar),
                new SqlParameter("@LBA002",SqlDbType.NVarChar),
                new SqlParameter("@LBA003",SqlDbType.NVarChar),
                new SqlParameter("@LBA004",SqlDbType.NVarChar),
                new SqlParameter("@LBA007",SqlDbType.NVarChar),
                new SqlParameter("@LBA015",SqlDbType.NVarChar),
                new SqlParameter("@LBA905",SqlDbType.Int)
            };

            parameter[0].Value = model.LBA001;
            parameter[1].Value = model.LBA002;
            parameter[2].Value = model.LBA003;
            parameter[3].Value = model.LBA004;
            parameter[4].Value = model.LBA007;
            parameter[5].Value = model.LBA015;
            parameter[6].Value = model.LBA905;


            int rows = SqlHelper.ExecuteNonQuery( strSql.ToString( ) ,parameter );
            if ( rows > 0 )
                return true;
            else
                return false;
        }


        /// <summary>
        /// 插入JSKLBB数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool InsertTranLbb ( JiuGongEntity.FormEntity model )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "INSERT INTO JSKLBB (LBB001,LBB002,LBB003,LBB005,LBB006,LBB007,LBB010,LBB019,LBB905)" );
            strSql.Append( " VALUES(" );
            strSql.Append( "@LBB001,@LBB002,@LBB003,@LBB005,@LBB006,@LBB007,@LBB010,@LBB019,@LBB905)" );

            SqlParameter[] parameter = {
                new SqlParameter("@LBB001",SqlDbType.NVarChar),
                new SqlParameter("@LBB002",SqlDbType.NVarChar),
                new SqlParameter("@LBB003",SqlDbType.NVarChar),
                new SqlParameter("@LBB005",SqlDbType.NVarChar),
                new SqlParameter("@LBB007",SqlDbType.Int),
                new SqlParameter("@LBB010",SqlDbType.NVarChar),
                new SqlParameter("@LBB019",SqlDbType.NVarChar),
                new SqlParameter("@LBB905",SqlDbType.Int),
                new SqlParameter("@LBB006",SqlDbType.NVarChar)
            };

            parameter[0].Value = model.LBA001;
            parameter[1].Value = model.LBB002;
            parameter[2].Value = model.LBB003;
            parameter[3].Value = model.LBB005;
            parameter[4].Value = model.LBB007;
            parameter[5].Value = model.LBB010;
            parameter[6].Value = model.LBB019;
            parameter[7].Value = model.LBB905;
            parameter[8].Value = model.LBB006;

            int rows = SqlHelper.ExecuteNonQuery( strSql.ToString( ) ,parameter );
            if ( rows > 0 )
                return true;
            else
                return false;
        }


        /// <summary>
        /// 删除插入失败的LBA数据
        /// </summary>
        /// <param name="strWhere"></param>
        public void DeleteTranLba ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "DELETE FROM JSKLBA" );
            strSql.Append( " WHERE LBA001=@LBA001" );
            SqlParameter[] parameter = {
                new SqlParameter ("@LBA001",SqlDbType.NVarChar)
            };

            parameter[0].Value = strWhere;

           SqlHelper.ExecuteNonQuery( strSql.ToString( ) ,parameter );
        }


        /// <summary>
        /// 删除插入失败的LBB数据
        /// </summary>
        /// <param name="strWhere"></param>
        public void DeleteTranLbb ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "DELETE FROM JSKLBB" );
            strSql.Append( " WHERE LBB001=@LBB001" );
            SqlParameter[] parameter = {
                new SqlParameter ("@LBB001",SqlDbType.NVarChar)
            };

            parameter[0].Value = strWhere;

            SqlHelper.ExecuteNonQuery( strSql.ToString( ) ,parameter );
        }


        /// <summary>
        /// 获取LBA001
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableLba ( )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "SELECT MAX(LBA001) LBA001 FROM JSKLBA WHERE LBA001 LIKE '%WG%'" );

            return SqlHelper.ExecuteDataTable( strSql.ToString( ) );
        }


        /// <summary>
        /// 获取LBB
        /// </summary>
        /// <param name="dataValue"></param>
        /// <returns></returns>
        public DataTable GetDataTableLbb (string dataValue )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "SELECT DISTINCT QKA006,RCB024,RBB021,RBB006,DEA001,DEA008 FROM SGMQKA E,SGMRAA C,SGMRCA A,SGMRCB B,SGMRBB D ,TPADEA F WHERE A.RCA002=B.RCB002 AND C.RAA001=B.RCB022 AND C.RAA001=D.RBB010 AND E.QKA001=B.RCB024 AND B.RCB004=D.RBB004 AND B.RCB024=F.DEA001" );
            strSql.Append( " AND SUBSTRING(RCA004,0,7)=@RCA004" );
            strSql.Append( " AND RCA001=85" );
            strSql.Append( " AND RCB001=85" );
            strSql.Append( " AND SUBSTRING(RAA003,0,7)!=@RAA003" );
            strSql.Append( " AND RBB001=83" );            
            strSql.Append( " AND QKA002=@QKA002" );

            SqlParameter[] parameter = {
                new SqlParameter("@RCA004",SqlDbType.NVarChar),
                new SqlParameter("@RAA003",SqlDbType.NVarChar),
                new SqlParameter("@QKA002",SqlDbType.NVarChar)
            };
            parameter[0].Value = dataValue;
            parameter[1].Value = dataValue;
            parameter[2].Value = dataValue;

            return SqlHelper.ExecuteDataTable( strSql.ToString( ) ,parameter );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableQuery ( )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "SELECT DISTINCT RCC010 FROM SGMRCC" );

            return SqlHelper.ExecuteDataTable( strSql.ToString( ) );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable GetDataTableReport ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "SELECT CASE WHEN RCC001='84' THEN '生产耗用' WHEN RCC001='85' THEN '生产退回' END RCC001,CONVERT(VARCHAR(20),CONVERT(DATE,SGMRCA.RCA004,102),102) RCA004,SGMRCC.RCC002,SGMRCC.RCC010,SGMRCB.RCB004,DEA002,DEA057,DEA003,ISNULL(CASE WHEN RCC001='84' THEN RCB008 END,0) HYL,ISNULL(CASE WHEN RCC001='85' THEN RCB008 END,0) TLL ,ISNULL(LPA005,0) LPA005,RCB018 FROM SGMRCA AS SGMRCA   " );
            strSql.Append( " LEFT JOIN SGMRCC AS SGMRCC ON SGMRCC.RCC001=SGMRCA.RCA001  AND SGMRCC.RCC002=SGMRCA.RCA002 " );
            strSql.Append( " LEFT JOIN SGMRCB AS SGMRCB ON SGMRCB.RCB001=SGMRCA.RCA001  AND SGMRCB.RCB002=SGMRCA.RCA002" );
            strSql.Append( " LEFT JOIN JSKLPA AS JSKLBA ON LPA001=RCB004 AND LPA002=SUBSTRING(RCA004,0,7)" );
            strSql.Append( " LEFT JOIN TPADEA AS TPADEA ON RCB004=DEA001" );
            strSql.Append( " WHERE " + strWhere );

            return SqlHelper.ExecuteDataTable( strSql.ToString( ) );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable GetDataTablePrint ( string strWhere )
        {
            StringBuilder strSql = new StringBuilder( );
            strSql.Append( "WITH CET AS (SELECT CASE WHEN RCC001='84' THEN '生产耗用' WHEN RCC001='85' THEN '生产退回' END RCC001,CONVERT(VARCHAR(20),CONVERT(DATE,SGMRCA.RCA004,102),102) RCA004,SGMRCC.RCC002,SGMRCC.RCC010,SGMRCB.RCB004,DEA002,DEA057,DEA003,ISNULL(CASE WHEN RCC001='84' THEN RCB008 END,0) HYL,ISNULL(CASE WHEN RCC001='85' THEN RCB008 END,0) TLL ,ISNULL(LPA005,0) LPA005,RCB018 FROM SGMRCA AS SGMRCA LEFT JOIN SGMRCC AS SGMRCC ON SGMRCC.RCC001=SGMRCA.RCA001  AND SGMRCC.RCC002=SGMRCA.RCA002 LEFT JOIN SGMRCB AS SGMRCB ON SGMRCB.RCB001=SGMRCA.RCA001  AND SGMRCB.RCB002=SGMRCA.RCA002 LEFT JOIN JSKLPA AS JSKLBA ON LPA001=RCB004 AND LPA002=SUBSTRING(RCA004,0,7) LEFT JOIN TPADEA AS TPADEA ON RCB004=DEA001) " );
            strSql.Append( " SELECT RCC001,RCA004,RCC002,RCC010,RCB004,DEA002,DEA057,DEA003,RCB018,HYL,TLL,LPA005,(HYL-TLL+RCB018)*LPA005 LP FROM CET" );
            strSql.Append( " WHERE " + strWhere );

            return SqlHelper.ExecuteDataTable( strSql.ToString( ) );
        }
    }
}
