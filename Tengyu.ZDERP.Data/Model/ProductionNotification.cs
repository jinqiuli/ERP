using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tengyu.ZDERP.Data
{
    public class ProductionNotification
    {
        /// <summary>
        /// Id
        /// </summary>	
        public int Id { get; set; }
        /// <summary>
        /// ProductionOrderNumber
        /// </summary>	
        public string ProductionOrderNumber { get; set; }
        /// <summary>
        /// OrderFileName
        /// </summary>	
        public string ProductionFileName { get; set; }
        /// <summary>
        /// 服务器上文件名
        /// </summary>
        public string ServerFileName { get; set; }
        /// <summary>
        /// MaterialStatus
        /// </summary>	
        public bool MaterialStatus { get; set; }
        /// <summary>
        /// MaterialUserId
        /// </summary>	
        public string MaterialUserId { get; set; }
        /// <summary>
        /// FinishedProductStatus
        /// </summary>	
        public bool FinishedProductStatus { get; set; }
        /// <summary>
        /// FinishedProductUserId
        /// </summary>	
        public string FinishedProductUserId { get; set; }
        /// <summary>
        /// WorkshopStatus
        /// </summary>	
        public bool WorkshopStatus { get; set; }
        /// <summary>
        /// WorkshopUserId
        /// </summary>	
        public string WorkshopUserId { get; set; }
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
