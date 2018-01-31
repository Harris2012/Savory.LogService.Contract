using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Savory.LogService.Contract.WriteLog
{
    /// <summary>
    /// 记录日志返回
    /// </summary>
    [DataContract]
    public class WriteLogResponse
    {
        /// <summary>
        /// 消息编号
        /// </summary>
        [DataMember]
        public Guid Guid { get; set; }
    }
}
