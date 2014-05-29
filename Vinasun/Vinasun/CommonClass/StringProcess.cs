using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vinasun.CommonClass
{
    class StringProcess
    {
        public Dictionary<int, string> getMultiChoiseFromListBox(ListBox lb)
        {
            Dictionary<int, string> choises = new Dictionary<int, string>();
            IList il = lb.SelectedItems;
            string[] separators = { ",", "[", "]", " " };
            string temp;
            string[] strings;
            for (int i = 0; i < il.Count; i++)
            {
                temp = il[i].ToString();
                strings = il[i].ToString().Split(separators, StringSplitOptions.RemoveEmptyEntries);
                MessageBox.Show(strings[0]);
                MessageBox.Show(strings[1]);
                choises.Add(int.Parse(strings[0]), strings[1]);
            }
            return choises;
        }

        public int getIdOfComboboxCell(ComboBox cb, string s)
        {
            int index = cb.Items.IndexOf(s);
            return index;
        }
    }
}
