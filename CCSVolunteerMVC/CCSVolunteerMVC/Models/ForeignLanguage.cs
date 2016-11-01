using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CCSVolunteerMVC.Models
{
    public class ForeignLanguage
    {
        public int foreignLanguageID { get; set; }

        public string foreignLangName { get; set; }
        public ICollection<VolunteerLanguage> volunteerLanguages { get; set; }
    }
}