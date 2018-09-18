using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CritiqueFoodReviewer.Models
{
    public class AboutModel
    {
        public string Name { get; set; }
        public string Location { get; set; }

        public string jobtitle;

        public string JobTitle {
            get
            {
                return jobtitle;
            }

            set
            {

                if (!String.IsNullOrEmpty(value))
                {
                    jobtitle = "Software Engineer";

                }
            }
        }
    }
}