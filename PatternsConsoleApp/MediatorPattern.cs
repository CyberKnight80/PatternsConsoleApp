using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PatternsConsoleApp
{
    public class Teacher
    {
        public Headman headman;

        public void Notice(string data)
        {
            headman.NoticeStudent(data);
        }

        public List<string> GetNotice()
        {
            return headman.GetNoticeTeacher();
        }
    }

    public class Headman
    {
        public List<string> messagesForTeacher = new List<string>();
        public List<string> messagesForStudent = new List<string>();

        public void NoticeTeacher(string data)
        {
            messagesForTeacher.Add(data);
        }

        public List<string> GetNoticeTeacher()
        {
            try
            {
                return messagesForTeacher;
            }
            finally
            {
                messagesForTeacher = new List<string>();
            }
        }

        public void NoticeStudent(string data)
        {
            messagesForStudent.Add(data);
        }

        public List<string> GetNoticeStudent()
        {
            try
            {
                return messagesForStudent;
            }
            finally
            {
                messagesForStudent = new List<string>();  
            }
        }
    }

    public class Student
    {
        public Headman headman;
        
        public void Notice(string data)
        {
            headman.NoticeTeacher(data);
        }

        public List<string> GetNotice()
        {
            return headman.GetNoticeStudent();
        }
    }
}
