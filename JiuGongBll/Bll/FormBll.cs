using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JiuGongBll.Bll
{
    public class FormBll
    {
        Dao.FormDao dao = new Dao.FormDao( );



        /// <summary>
        /// 本年本月是否已经生成调整单
        /// </summary>
        /// <param name="dateValue"></param>
        /// <returns></returns>
        public bool ExistsLba ( string dateValue )
        {
            return dao.ExistsLba( dateValue );
        }

        /// <summary>
        /// 入库单记录是否存在
        /// </summary>
        /// <returns></returns>
        public bool Exists (string dateValue )
        {
            return dao.Exists( dateValue );
        }

        /// <summary>
        /// 分流单中是否有入库单的记录
        /// </summary>
        /// <returns></returns>
        public bool ExistsThr ( string dateValue )
        {
            return dao.ExistsThr( dateValue );
        }


        /// <summary>
        /// 插入JSKLBA数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool InsertTranLba ( JiuGongEntity.FormEntity model )
        {
            return dao.InsertTranLba( model );
        }


        /// <summary>
        /// 插入JSKLBB数据
        /// </summary>
        /// <param name="model"></param>
        /// <returns></returns>
        public bool InsertTranLbb ( JiuGongEntity.FormEntity model )
        {
            return dao.InsertTranLbb( model );
        }


        /// <summary>
        /// 删除插入失败的LBA数据
        /// </summary>
        /// <param name="strWhere"></param>
        public void DeleteTranLba ( string strWhere )
        {
             dao.DeleteTranLba( strWhere );
        }


        /// <summary>
        /// 删除插入失败的LBB数据
        /// </summary>
        /// <param name="strWhere"></param>
        public void DeleteTranLbb ( string strWhere )
        {
            dao.DeleteTranLbb( strWhere );
        }


        /// <summary>
        /// 产生LBA001
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableLba ( )
        {
            return dao.GetDataTableLba( );
        }

        /// <summary>
        /// 获取LBB
        /// </summary>
        /// <param name="dataValue"></param>
        /// <returns></returns>
        public DataTable GetDataTableLbb ( string dataValue )
        {
            return dao.GetDataTableLbb( dataValue );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <returns></returns>
        public DataTable GetDataTableQuery ( )
        {
            return dao.GetDataTableQuery( );
        }

        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable GetDataTableReport ( string strWhere )
        {
            return dao.GetDataTableReport( strWhere );
        }


        /// <summary>
        /// 获取数据列表
        /// </summary>
        /// <param name="strWhere"></param>
        /// <returns></returns>
        public DataTable GetDataTablePrint ( string strWhere )
        {
            return dao.GetDataTablePrint( strWhere );
        }
    }
}
