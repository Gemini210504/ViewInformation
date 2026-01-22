using System;
using System.Collections.Generic;

namespace ViewInformation
{
    public class Student : IObject
    {
        protected string m_name = "";
        protected string m_age = "";
        protected double m_score = 0.0;

        public Student()
        {
        }

        public Student(string name, string age, double score)
        {
            m_name = name;
            m_age = age;
            m_score = score;
        }

        public List<DataItem> GetObjectItems()
        {
            List<DataItem> items = new List<DataItem>();
            items.Add(new DataItem("Name", m_name, null));
            items.Add(new DataItem("Age", m_age, null));
            items.Add(new DataItem("Score", m_score, "N2"));
            return items;
        }

        public string GetObjectType()
        {
            return "Student";
        }

        public string Name
        {
            get
            {
                return m_name;
            }
            set
            {
                m_name = value;
            }
        }

        public string Age
        {
            get
            {
                return m_age;
            }
            set
            {
                m_age = value;
            }
        }

        public double Score
        {
            get
            {
                return m_score;
            }
            set
            {
                m_score = value;
            }
        }

        public override string ToString()
        {
            return string.Format(
                "Name={0}, Age={1}, Score={2:N2}",
                m_name, m_age, m_score
            );
        }
    }
}
