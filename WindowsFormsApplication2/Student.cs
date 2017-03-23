﻿using System;

namespace Sandy_style

{
    public class Student
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public DateTime BirthDate { get; set; }
        public string Address { get; set; }

        private int fullName;
        public int FullName
        {
            get { return fullName; }
            set { fullName = value; }
        }
    }
}
