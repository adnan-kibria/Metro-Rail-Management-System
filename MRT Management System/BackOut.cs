using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MRT_Management_System
{
    internal class BackOut
    {
        public BackOut() { }
        public void Back()
        {
            Admin_Panel admin_Panel = new Admin_Panel();
            admin_Panel.Show();
        }
        public void Out()
        {
            MRT mRT = new MRT();
            mRT.Show();
        }
    }
}
