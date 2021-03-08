using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ASP.Exo.HelpersData.Infrastructs
{
    public class CustomValidationRegNationalAttribute : ValidationAttribute
    {
        private string _fieldName;
        public CustomValidationRegNationalAttribute(string fieldName)
        {
            _fieldName = fieldName;
        }
        //protected override ValidationResult IsValid(object value, ValidationContext context)
        //{
        //    if (value is null) return false;
        //    string year = value.ToString().Substring(0, 2);
        //    string month = value.ToString().Substring(2, 2);
        //    string day = value.ToString().Substring(4, 2);
        //    int y,m,d;
        //    if (!int.TryParse(year, out y)) return false;
        //    if (!int.TryParse(month, out m)) return false;
        //    if (!int.TryParse(day, out d)) return false;
        //    DateTime dt = new DateTime(1900 + y, m, d);
        //    DateTime bd = DateTime.Parse(context.Items[(object)_fieldName].ToString());
        //    if (dt != bd) return false;
        //    return true;
        //}
    }
}