namespace StudentGroups
{
    using System;

    class Group
    {
        private int groupNumber;
        private string departmentName;

        public Group(int groupNumber, string departmentName)
        {
            this.GroupNumber = groupNumber;
            this.DepartmentName = departmentName;
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Group number cannot be negative or zero");
                }

                this.groupNumber = value;
            }
        }

        public string DepartmentName
        {
            get
            {
                return this.departmentName;
            }

            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Department name cannot be empty");
                }

                this.departmentName = value;
            }
        }
    }
}
