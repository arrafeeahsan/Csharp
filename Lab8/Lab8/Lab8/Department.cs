using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace Lab8
{
    class Department
    {

        private string name;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        private string id;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }
        ArrayList faculties;
        public Department()
        {
            faculties = new ArrayList();
        }
        public Department(string name, string id)
        {
            Name = name;
            Id = id;
            faculties = new ArrayList();
        }
        public void AddFaculty(params Faculty[] faculties)
        {
            foreach (Faculty f in faculties)
            {
                this.faculties.Add(f);
            }
        }
        public void ShowAllFaculties()
        {
            foreach (Faculty faculty in this.faculties)
            {
                faculty.ShowInfo();
            }
        }
        public Faculty SearchFaculty(string id)
        {
            Faculty t = null;
            foreach (Faculty faculty in faculties)
            {
                if (faculty.Id.Equals(id))
                {
                    t = faculty;
                }
            }
            return t;
        }
        public void RemoveFaculty(Faculty faculty)
        {
            faculties.Remove(faculty);
        }
      
    }
}
