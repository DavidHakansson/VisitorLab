using System;
using System.Collections.Generic;
using System.Text;

namespace Lab_3_CSD
{
    interface IElement
    {
        public void Accept(IVisitor visitor)
        {
        }
    }
}
