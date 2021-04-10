﻿namespace Netch.Models.Mode
{
    public enum ModeType : int
    {
        /// <summary>
        ///     进程代理
        /// </summary>
        ProcessMode,

        /// <summary>
        ///     网卡代理
        /// </summary>
        TunMode,

        /// <summary>
        ///     网页代理
        /// </summary>
        WebMode
    }
}
