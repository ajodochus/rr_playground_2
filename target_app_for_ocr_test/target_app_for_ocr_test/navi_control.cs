using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


// From https://www.youtube.com/watch?v=-wmt1rrxsi8


namespace target_app_for_ocr_test
{
    public class navi_control
    {
        List<UserControl> userControlList = new List<UserControl>();
        Panel panel;

        public navi_control(List<UserControl> userControlList, Panel panel)
        {
            this.userControlList = userControlList;
            this.panel = panel;
            addUserControls();
        }

        private void addUserControls()
        {
            for (int i = 0; i < userControlList.Count(); i++)
            {
                userControlList[i].Dock = DockStyle.Fill;
                panel.Controls.Add(userControlList[i]);
            }
        }

        public void Display(int index)
        {
            if (index < userControlList.Count())
            {
                userControlList[index].BringToFront();
            }
        }
    }
    
}
