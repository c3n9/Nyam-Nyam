using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nyam_Nyam.Models
{
    public partial class Dish
    {
        public int AllTime
        {
            get
            {
                return this.RecipeSteps.Sum(s => s.Time);
            }
        }
    }
}
