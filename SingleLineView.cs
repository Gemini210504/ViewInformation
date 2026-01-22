using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ViewInformation
{
    public class SingleLineView : ObjectView
    {
        public SingleLineView()
        {
        }

        public SingleLineView(IObject obj) : base(obj)
        {
        }

        protected override void GeneratePanel()
        {
            m_panel.Controls.Clear();
            m_panel.AutoSize = true;
            m_panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            Label lbl = new Label();
            lbl.AutoSize = true;

            string line = m_obj.GetObjectType();
            List<DataItem> lstItems = m_obj.GetObjectItems();

            if (lstItems.Count > 0)
            {
                line += ": ";
            }

            bool first = true;

            foreach (DataItem item in lstItems)
            {
                if (!first)
                {
                    line += ", ";
                }

                string strFormat = string.Format(
                    "{0}{1}{2}",
                    "{0}={1:",
                    item.Format,
                    "}"
                );

                line += string.Format(strFormat, item.Field, item.Data);
                first = false;
            }

            lbl.Text = line;
            m_panel.Controls.Add(lbl);
        }

        public override string ViewType
        {
            get
            {
                return "Single Line";
            }
        }
    }
}
