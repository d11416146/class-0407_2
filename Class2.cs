using System;
using System.Threading.Tasks.Sources;
using System.Xml.Linq;
using System.Xml.Serialization;

class student : Person
{
    private int score;
    //static string name = "base帶入的參數必須要是子類別,不然就帶入或欄位";
    public student(int id, string name, int score) : base(id, name)
    {
        score = score;
    }
    public int Grade
    {
        get
        {
            return score;
        }
    }
    public string studentInfo()
    {
        return "學生的新方法";
    }
    public string Info()
    {
        return "學生類別自己的Info";
    }
}
    class Person
    {
        public string name;
        public int id;
        

        public Person(int id,string name)
        {
        id = id;
        this.name= name;
        }

        public string GetName()
        {
            return "person的Name";
        }
        public vitrual string Info()
        {
            return "person的Info編號:" + id + "姓名:" + name;
        }
    }
    class student.person
    {
        private int score;
        public strdent (int id,string name,int score):base(id, name)
        {
            score = score;
        }
        public string GetName()
        {
            return "學生的Name";
        }
        public vitrual string Info()
        {
            return "學生的Info";
        }
    }


