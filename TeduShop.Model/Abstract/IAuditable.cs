using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TeduShop.Model.Abstract
{
    public interface IAuditable
    { 
        DateTime? CreateDate { get; set; }
        string  CreatedBy { get; set; }
        DateTime? UpdateDate { get; set; }
        string UpdateBy { get; set; }

        string MetaKeyWord { get; set; }
        string MetaDescription { get; set; }

        bool Status { get; set; }

    }
}
