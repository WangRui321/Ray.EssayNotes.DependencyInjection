﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ray.EssayNotes.AutoFac.ConsoleApp.Test.TestIntercept
{
    public class TestInterceptFactory : ITestFactory
    {

        public ITest Create(string num)
        {
            string classFullName = $"Ray.EssayNotes.AutoFac.ConsoleApp.Test.TestIntercept.TestIntercept{num}";
            Type type = Type.GetType(classFullName);
            dynamic obj = type?.Assembly.CreateInstance(classFullName);
            return obj;
        }

        public string TestType => "拦截器";

        public string GetSelectionRange => "01-04";
    }
}