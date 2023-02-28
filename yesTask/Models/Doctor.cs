using System;
using System.Collections.Generic;

namespace yesTask.Models;

public partial class Doctor
{
    public int DocId { get; set; }

    public string? DocName { get; set; }

    public int? ClincId { get; set; }

    public virtual Clinic? Clinc { get; set; }
}
