using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Savory.LogService.Contract.WriteLog
{
    /// <summary>
    /// 记录日志请求
    /// </summary>
    [DataContract]
    public class WriteLogRequest
    {
        /// <summary>
        /// 消息编号
        /// </summary>
        [DataMember]
        public Guid Guid { get; set; }

        /// <summary>
        /// 日志标题
        /// </summary>
        [DataMember]
        public string Title { get; set; }

        /// <summary>
        /// 日志详细内容
        /// </summary>
        [DataMember]
        public string Message { get; set; }

        /// <summary>
        /// 应用程序编号
        /// </summary>
        [DataMember]
        public int AppId { get; set; }

        /// <summary>
        /// 事件源
        /// </summary>
        [DataMember]
        public string Source { get; set; }

        /// <summary>
        /// 日志类型
        /// </summary>
        [DataMember]
        public LogType LogType { get; set; }

        /// <summary>
        /// 创建日志的时间
        /// </summary>
        [DataMember]
        public DateTime CreateTime { get; set; }
    }
}
