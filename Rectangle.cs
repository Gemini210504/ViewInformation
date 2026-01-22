using System;
using System.Collections.Generic;

namespace ViewInformation
{
    public class Rectangle : IObject
    {
        protected double m_width = 0;
        protected double m_length = 0;

        public Rectangle()
        {
        }

        public Rectangle(double width, double length)
        {
            m_width = width;
            m_length = length;
        }

        public List<DataItem> GetObjectItems()
        {
            List<DataItem> items = new List<DataItem>();
            items.Add(new DataItem("Width", m_width, "N2"));
            items.Add(new DataItem("Length", m_length, "N2"));
            items.Add(new DataItem("Area", Area, "N3"));
            return items;
        }

        public string GetObjectType()
        {
            return "Rectangle";
        }

        public double Width
        {
            get
            {
                return m_width;
            }
            set
            {
                m_width = value;
            }
        }

        public double Length
        {
            get
            {
                return m_length;
            }
            set
            {
                m_length = value;
            }
        }

        public double Area
        {
            get
            {
                return m_width * m_length;
            }
        }
    }
}
