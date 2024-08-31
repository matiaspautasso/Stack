using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Stack
{
    internal class ClsStack
    {
        private ClsNode first;
        private ClsNode last;
        public ClsNode FIRST
        {
            get { return first; }
            set { first = value; }
        }
        public ClsNode LAST
        {
            get { return last; }
            set { last = value; }
        }

        public void Insert(ClsNode New)
        {
            if (FIRST == null)
            {
                FIRST = New;
            }
            else
            {
                New.NEXT = FIRST;
                FIRST = New;
            }
        }

        public void Delete()
        {
            if (FIRST != null)
            {
                FIRST = FIRST.NEXT;
            }
        }

        public void Navigate(ListBox List)
        {
            ClsNode aux = FIRST;
            List.Items.Clear();
            while (aux != null)
            {
                List.Items.Add(aux.Code);
                aux = aux.NEXT;
            }
        }

        public void Navigate(DataGridView DGV)
        {
            ClsNode aux = FIRST;
            DGV.Rows.Clear();

            while (aux != null)
            {
                DGV.Rows.Add(aux.Code, aux.Name, aux.Proccess);
                aux = aux.NEXT;
            }
        }

        public void Navigate()
        {
            ClsNode aux = FIRST;
            StreamWriter AD = new StreamWriter("Stack.csv", false, Encoding.UTF8);
            AD.WriteLine("Waiting List\n");
            AD.WriteLine("Code;Name;Process");
            while (aux != null)
            {
                AD.Write(aux.Code);
                AD.Write(";");
                AD.Write(aux.Name);
                AD.Write(";");
                AD.WriteLine(aux.Proccess);
                aux = aux.NEXT;

            }
            AD.Close();
        }
    }
}
