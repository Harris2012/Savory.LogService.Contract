using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Savory.LogService.Contract.WriteLog
{
    /// <summary>
    /// 事件级别
    /// </summary>
    public enum LogType
    {
        /// <summary>
        /// 调试
        /// </summary>
        Debug = 0,

        /// <summary>
        /// 信息
        /// </summary>
        Info = 1,

        /// <summary>
        /// 警告
        /// </summary>
        Warn = 2,

        /// <summary>
        /// 错误
        /// </summary>
        Error = 3,

        /// <summary>
        /// 挂了
        /// </summary>
        Fault = 4
    }
}
