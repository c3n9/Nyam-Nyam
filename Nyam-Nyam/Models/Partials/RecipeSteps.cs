using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Nyam_Nyam.Models
{
    public partial class RecipeSteps
    {
        public string Steps
        {
            get
            {
                return $" - {ProcessDescription}";
            }
        }
    }
}
