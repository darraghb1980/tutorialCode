﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace safeprojectname
{
    public class Staff : Person
    {
        int officeNum;

        public int getOfficeNum()
        {
            return this.officeNum;
        }

        public void setOfficeNum(int officeNum)
        {
            this.officeNum = officeNum;
        }
    }
}
