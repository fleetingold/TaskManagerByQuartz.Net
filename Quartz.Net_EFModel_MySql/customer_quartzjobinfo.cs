
//------------------------------------------------------------------------------
// <auto-generated>
//    此代码是根据模板生成的。
//
//    手动更改此文件可能会导致应用程序中发生异常行为。
//    如果重新生成代码，则将覆盖对此文件的手动更改。
// </auto-generated>
//------------------------------------------------------------------------------


namespace Quartz.Net_EFModel_MySql
{

using System;
    using System.Collections.Generic;
    
public partial class customer_quartzjobinfo
{

    public int Id { get; set; }

    public string JobName { get; set; }

    public string JobGroupName { get; set; }

    public string TriggerName { get; set; }

    public string TriggerGroupName { get; set; }

    public string Cron { get; set; }

    public int TriggerState { get; set; }

    public string DLLName { get; set; }

    public string FullJobName { get; set; }

    public string Exception { get; set; }

    public string RequestUrl { get; set; }

    public Nullable<System.DateTime> JobStartTime { get; set; }

    public Nullable<System.DateTime> PreTime { get; set; }

    public Nullable<System.DateTime> EndTime { get; set; }

    public Nullable<System.DateTime> NextTime { get; set; }

    public string Description { get; set; }

    public bool Deleted { get; set; }

    public System.DateTime CreateTime { get; set; }

    public Nullable<int> Cycle { get; set; }

    public Nullable<int> RepeatCount { get; set; }

    public string TriggerType { get; set; }

}

}
