using Esercitazione.Models.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Esercitazione.Models
{
    public class IndexModel
    {
        public string Title { get; set; }

        public string LabelTitleProblem { get; set; }
        public string LabelNameUser { get; set; }
        public string LabelEmailUser { get; set; }
        public string LabelDescription { get; set; }
        public string LabelButton { get; set; }
        

        public Contatto Contatto { get; set; }

        public string ErrorMessage{ get; set; }
    }
}