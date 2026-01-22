using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace ViewInformation
{
    public class FieldView : ObjectView
    {
        public FieldView()
        {
        }

        public FieldView(IObject obj) : base(obj)
        {
        }

        protected override void GeneratePanel()
        {
            m_panel.Controls.Clear();
            m_panel.AutoSize = true;
            m_panel.AutoSizeMode = AutoSizeMode.GrowAndShrink;

            TableLayoutPanel maintlp = new TableLayoutPanel();
            maintlp.ColumnCount = 1;
            maintlp.AutoSize = true;
            maintlp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            m_panel.Controls.Add(maintlp);

            Label lbl = new Label();
            lbl.Text = m_obj.GetObjectType();   // ✅ FIXED
            lbl.Font = new Font(lbl.Font, FontStyle.Bold);
            lbl.AutoSize = true;
            maintlp.Controls.Add(lbl);

            TableLayoutPanel tlp = new TableLayoutPanel();
            tlp.ColumnCount = 2;
            tlp.AutoSize = true;
            tlp.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            tlp.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            maintlp.Controls.Add(tlp);

            List<DataItem> lstItems = m_obj.GetObjectItems();

            foreach (DataItem item in lstItems)
            {
                // Field name
                Label lblField = new Label();
                lblField.Text = item.Field;
                lblField.TextAlign = ContentAlignment.MiddleRight;
                lblField.AutoSize = true;
                lblField.Anchor = AnchorStyles.Right;
                tlp.Controls.Add(lblField);

                // Field value
                string strFormat = string.Format("{0}{1}{2}", "{0:", item.Format, "}");
                Label lblValue = new Label();
                lblValue.Text = string.Format(strFormat, item.Data);
                lblValue.TextAlign = ContentAlignment.MiddleLeft;
                lblValue.BorderStyle = BorderStyle.FixedSingle;
                lblValue.AutoSize = true;
                tlp.Controls.Add(lblValue);
            }
        }

        public override string ViewType
        {
            get
            {
                return "Field View";
            }
        }
    }
}
