
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------


namespace Session1
{

using System;
    using System.Collections.Generic;
    
public partial class Request
{

    public int Request_ID { get; set; }

    public string Request_Number { get; set; }

    public System.DateTime Creation_Date { get; set; }

    public string Service { get; set; }

    public int Service_ID { get; set; }

    public string Service_Type { get; set; }

    public string Status { get; set; }

    public int Hardware_ID { get; set; }

    public string Problem { get; set; }

    public Nullable<System.DateTime> Closure_Date { get; set; }

    public string Problem_Type { get; set; }

    public int Worker_ID { get; set; }

    public int District_ID { get; set; }

    public int User_ID { get; set; }



    public virtual District District { get; set; }

    public virtual Hardware_Port Hardware_Port { get; set; }

    public virtual Maintenance_Staff Maintenance_Staff { get; set; }

    public virtual Service_Type Service_Type1 { get; set; }

    public virtual User User { get; set; }

}

}
