using System;
using System.Collections.Generic;

namespace Sem2.Assignment7
{
    public class ListStudent
    {
        private List<Student> listStudent;

        public ListStudent()
        {
            this.listStudent = new List<Student>();
        }

        public void ShowStudent()
        {
            for (int i = 0; i < listStudent.Count; i++)
            {
                System.Console.WriteLine("id :"+ listStudent[i].Id+"name: "+listStudent[i].Name+"age : "+listStudent[i].Age +"address"+listStudent[i].Address+"gpa :"+ listStudent[i].Gpa);
                
            }
            
        }

        public void sortGpa()
        {
            listStudent.Sort((x,y)=> y.Gpa.CompareTo(x.Gpa));
        }

        public void sortName()
        {
            listStudent.Sort((x,y)=> x.Name.CompareTo(y.Name));
        }

        public Student seach(int Id)
        {
            for (int i = 0; i < listStudent.Count; i++)
            {
                if (Id == listStudent[i].Id)
                {
                    return listStudent[i];
                }
            }

            return null;
        }

        public bool DeleteStudent(int id )
        {
            Student st = seach(id);
            if (st != null)
            {
                listStudent.Remove(st);
                return true;
               
            }

            return false;
            
        }

        public bool EditStudent(int id)
        {
            Student st = seach(id);
            if (st ==null)
            {
                st = seach(id);
            }

            return true;
        }
    }
}