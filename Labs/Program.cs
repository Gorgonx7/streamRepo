using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenTK;

namespace Labs
{
    class Program
    {
        

        #region No Changes Required Here Ever!
        /* 
         * By all means look at this code, but you will not be required to change
         * any of this code
         */
       
        static void Main(string[] args)
        {
            GameWindow window = new ACW.BuildWindow();
                   

            if (window != null)
            {
                window.Run();
            }
        }
        #endregion
    }
}
