using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tengyu.ZDERP.Data
{
    public class SalesOrder
    {
        /// <summary>
        /// Id
        /// </summary>	
        public int Id { get; set; }
        /// <summary>
        /// CustomerId
        /// </summary>	
        public string CustomerId { get; set; }
        /// <summary>
        /// OrderTypeId
        /// </summary>	
        public string OrderTypeId { get; set; }
        /// <summary>
        /// OrderNumber
        /// </summary>	
        public string OrderNumber { get; set; }
        /// <summary>
        /// OrderFileName
        /// </summary>	
        public string OrderFileName { get; set; }
        /// <summary>
        /// 服务器上文件名字
        /// </summary>
        public string ServerFileName { get; set; }
        /// <summary>
        /// ConfirmId
        /// </summary>	
        public string ConfirmId { get; set; }
        /// <summary>
        /// ConfirmStatus
        /// </summary>	
        public bool ConfirmStatus { get; set; }
        /// <summary>
        /// CreatedTime
        /// </summary>	
        public DateTime CreatedTime { get; set; }
        /// <summary>
        /// CreatedId
        /// </summary>	
        public string CreatedId { get; set; }
        /// <summary>
        /// UpdateTime
        /// </summary>	
        public DateTime UpdateTime { get; set; }
        /// <summary>
        /// UpdateId
        /// </summary>	
        public string UpdateId { get; set; }
        /// <summary>
        /// Remark
        /// </summary>	
        public string Remark { get; set; }
        /// <summary>
        /// Recycled
        /// </summary>	
        public bool Recycled { get; set; }

    }
}
