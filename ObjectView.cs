using System;
using System.Windows.Forms;

namespace ViewInformation
{
    public abstract class ObjectView
    {
        protected IObject m_obj = null;
        protected Panel m_panel = new Panel();

        public ObjectView()
        {
        }

        public ObjectView(IObject obj)
        {
            if (obj == null)
            {
                throw new Exception("Object provided is nothing.");
            }
            m_obj = obj;
            RefreshLayout();
        }

        public object ConcreteObject
        {
            get
            {
                return m_obj;
            }
            set
            {
                if (value == m_obj)
                {
                    return;
                }

                if (value == null)
                {
                    throw new Exception("Object provided is nothing.");
                }

                try
                {
                    m_obj = (IObject)value;
                }
                catch
                {
                    throw new Exception("Object provided is not type of IObject.");
                }

                RefreshLayout();
            }
        }

        public void RefreshLayout()
        {
            if (m_obj == null)
            {
                throw new Exception("No Object to be produced its view layout.");
            }

            GeneratePanel();
        }

        public Panel Layout
        {
            get
            {
                return m_panel;
            }
        }

        protected abstract void GeneratePanel();
        public abstract string ViewType { get; }
    }
}
