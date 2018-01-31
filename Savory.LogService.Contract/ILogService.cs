using Savory.LogService.Contract.WriteLog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Savory.LogService.Contract
{
    /// <summary>
    /// 日志服务
    /// </summary>
    [ServiceContract]
    public interface ILogService
    {
        /// <summary>
        /// 写日志
        /// </summary>
        [OperationContract]
        WriteLogResponse WriteLog(WriteLogRequest writeLogRequest);
    }
}
