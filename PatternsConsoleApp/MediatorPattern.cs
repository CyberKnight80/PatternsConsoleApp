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

        public void GetNotice(string data)
        {
            headman.GetNoticeStudent();
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

        public List<string> GetNoticeTeacher(string data)
        {
            try
            {
                return messagesForTeacher;
            }
            catch
            {

            }

            finally
            {
                messagesForStudent = new List<string>();
            }
            return null;
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
            catch
            {

            }

            finally
            {
                messagesForStudent = new List<string>();  
            }
            return null;
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
