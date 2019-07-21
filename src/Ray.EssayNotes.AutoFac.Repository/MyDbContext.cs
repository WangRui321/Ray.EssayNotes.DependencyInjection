﻿using System;
using System.Data.Entity;


namespace Ray.EssayNotes.AutoFac.Repository
{
    public class MyDbContext
    {
        public MyDbContext()
        {
            Tag = Guid.NewGuid();
        }

        /// <summary>
        /// 实例化时间
        /// </summary>
        public Guid Tag { get; set; }
    }
}
