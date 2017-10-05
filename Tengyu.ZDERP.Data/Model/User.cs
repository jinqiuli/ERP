using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tengyu.ZDERP.Data
{
    public class User
    {
        /// <summary>
        /// Id
        /// </summary>	
        public string Id { get; set; }
        /// <summary>
        /// BaseOrganizationId
        /// </summary>	
        public string BaseOrganizationId { get; set; }
        /// <summary>
        /// No
        /// </summary>	
        public string No { get; set; }
        /// <summary>
        /// UserName
        /// </summary>	
        public string UserName { get; set; }
        /// <summary>
        /// Nickname
        /// </summary>	
        public string Nickname { get; set; }
        /// <summary>
        /// PasswordHash
        /// </summary>	
        public string PasswordHash { get; set; }
        /// <summary>
        /// IsStoped
        /// </summary>	
        public bool IsStoped { get; set; }
        /// <summary>
        /// StopedTime
        /// </summary>	
        public DateTime StopedTime { get; set; }
        /// <summary>
        /// CreatedTime
        /// </summary>	
        public DateTime CreatedTime { get; set; }
        /// <summary>
        /// UpdatedTime
        /// </summary>	
        public DateTime UpdatedTime { get; set; }
        /// <summary>
        /// Recycled
        /// </summary>	
        public bool Recycled { get; set; }
        /// <summary>
        /// Remark
        /// </summary>	
        public string Remark { get; set; }
    }
}
