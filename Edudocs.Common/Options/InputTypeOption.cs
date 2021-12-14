using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edudocs.Common.Options
{
    /// <summary>
    /// Available HTML input types
    /// </summary>
    public enum InputTypeOption
    {
        [Display(Name = "hidden")]
        Hidden,
        [Display(Name = "text")]
        Text,
        [Display(Name = "date")]
        Date,
        [Display(Name = "datetime-local")]
        DatetimeLocal,
        [Display(Name = "email")]
        Email,
        [Display(Name = "number")]
        Number,
        [Display(Name = "password")]
        Password,
        [Display(Name = "tel")]
        Tel
    }
}
