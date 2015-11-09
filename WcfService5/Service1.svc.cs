using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace WcfService5
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class Service1 : IService1
    {

        public bool insertuserformobile(int id,string f, string l, string e, string p, string a)
        {
            onlinetestingEntities4 userData = new onlinetestingEntities4();
            userdata newuser = new userdata();
           newuser.user_id = id;
            newuser.firstName = f;
            newuser.lastName = l;
            newuser.email = e;
            newuser.passwor = p;
            newuser.about = a;

            //string str = string.Empty;
            //int k = 0;
            //onlinetestingEntities getUser = new onlinetestingEntities();
            //foreach (var i in getUser.userdatas.ToList())
            //{
            //    if (newuser.email == i.email)
            //    {
            //        str = "This email is already registered";
            //    }
            //    else
            //    {
            //        k++;
            //    }
            //}


            userData.userdatas.Add(newuser);
            userData.SaveChanges();
            return true;
        }
        public bool insertuser(users userInsert)
        {
            onlinetestingEntities4 userData = new onlinetestingEntities4();
            userdata newuser = new userdata();
            newuser.user_id = userInsert.userId;
            newuser.firstName = userInsert.first_name;
            newuser.lastName = userInsert.last_name;
            newuser.email = userInsert.Email;
            newuser.passwor = userInsert.Password;
            newuser.about = userInsert.About;

            //string str = string.Empty;
            //int k = 0;
            //onlinetestingEntities getUser = new onlinetestingEntities();
            //foreach (var i in getUser.userdatas.ToList())
            //{
            //    if (newuser.email == i.email)
            //    {
            //        str = "This email is already registered";
            //    }
            //    else
            //    {
            //        k++;
            //    }
            //}


            userData.userdatas.Add(newuser);
            userData.SaveChanges();
            return true;
        }

        public bool insertTest(tests testInsert)
        {
            onlinetestingEntities4 t1 = new onlinetestingEntities4();
            test newt = new test();
            newt.id = testInsert.Id;
            newt.test_id = testInsert.test_id;
            newt.question = testInsert.Ques;
            newt.option1 = testInsert.option1;
            newt.option2 = testInsert.option2;
            newt.option3 = testInsert.option3;
            newt.option4 = testInsert.option4;
            newt.right_ans = testInsert.Right_ans;
            t1.tests.Add(newt);
            t1.SaveChanges();

            return true;
        }

        public bool insertuserandmarks(marks_users insertMarks)
        {
            onlinetestingEntities4 tests = new onlinetestingEntities4();
            mark newuser = new mark();
            newuser.id = insertMarks.ID;
            newuser.test_id = insertMarks.Test_ID;
            newuser.Name = insertMarks.Name;
            newuser.Email = insertMarks.Email;
            newuser.sch_colg = insertMarks.School_Colg;
            newuser.obtained_marks = insertMarks.Obtained_Marks;
            tests.marks.Add(newuser);
            tests.SaveChanges();
            return true;
        }
        public bool inserttestDetails(testsinfo testInsert)
        {
            onlinetestingEntities4 tests = new onlinetestingEntities4();
            testData newtest = new testData();
            newtest.test_id = testInsert.test_ID;
            newtest.user_id = testInsert.user_ID;
            newtest.testName = testInsert.test_name;
            newtest.testSubject = testInsert.test_Sub;
            newtest.testTime = testInsert.test_time;
            newtest.testMaxMarks = testInsert.test_max;
            newtest.testDetails = testInsert.test_details;

            tests.testDatas.Add(newtest);
            tests.SaveChanges();
            return true;
        }
        public List<marks_users> getallusermarks(int k)
        {
            var Emplist = new List<marks_users>();
            onlinetestingEntities4 gt = new onlinetestingEntities4();
            foreach (var i in gt.marks.ToList())
            {
                if (i.test_id == k)
                {
                    marks_users m1 = new marks_users();
                    m1.ID = i.id;
                    m1.Test_ID = i.test_id;
                    m1.Name = i.Name;
                    m1.Email = i.Email;
                    m1.School_Colg = i.sch_colg;
                    m1.Obtained_Marks = i.obtained_marks;

                    Emplist.Add(m1);

                }
            }
            return Emplist;
        }


        public List<testsinfo> gettestinfo()
        {
            var Emplist = new List<testsinfo>();
            onlinetestingEntities4 gettest = new onlinetestingEntities4();
            foreach( var i in gettest.testDatas.ToList())
            {
                testsinfo t1 = new testsinfo();
                t1.test_ID = i.test_id;
                t1.user_ID = i.user_id;
                t1.test_name = i.testName;
                t1.test_Sub = i.testSubject;
                t1.test_max = i.testMaxMarks;
                t1.test_time = i.testTime;
                t1.test_details = i.testDetails;

                Emplist.Add(t1);


            }
            return Emplist;
        }

        public List<tests> getspecifictest(int k)
        {
            var Emplist = new List<tests>();
            onlinetestingEntities4 newt = new onlinetestingEntities4();
            foreach (var i in newt.tests.ToList())
            {
                if (i.test_id == k)
                {
                    tests t1 = new tests();
                    t1.test_id = i.test_id;
                    t1.Id = i.id;
                    t1.Ques = i.question;
                    t1.option1 = i.option1;
                    t1.option2 = i.option2;
                    t1.option3 = i.option3;
                    t1.option4 = i.option4;
                    t1.Right_ans = i.right_ans;

                    Emplist.Add(t1);
                }
            }
            return Emplist;
        }

        public List<testsinfo> getspecifictestinfo(int k)
        {
            var Emplist = new List<testsinfo>();
            onlinetestingEntities4 gettest = new onlinetestingEntities4();
            foreach (var i in gettest.testDatas.ToList())
            {
                if (i.user_id == k)
                {
                    testsinfo t1 = new testsinfo();
                    t1.test_ID = i.test_id;
                    t1.user_ID = i.user_id;
                    t1.test_name = i.testName;
                    t1.test_Sub = i.testSubject;
                    t1.test_max = i.testMaxMarks;
                    t1.test_time = i.testTime;
                    t1.test_details = i.testDetails;

                    Emplist.Add(t1);
                }

            }
            return Emplist;
        }

        public List<tests> gettest()
        {
            var Emplist = new List<tests>();
            onlinetestingEntities4 t1 = new onlinetestingEntities4();
            foreach( var i in t1.tests.ToList())
            {
                tests obj1 = new tests();
                obj1.Id = i.id;
                obj1.test_id = i.test_id;
                obj1.Ques = i.question;
                obj1.option1 = i.option1;
                obj1.option2 = i.option2;
                obj1.option3 = i.option3;
                obj1.option4 = i.option4;

                Emplist.Add(obj1);
            }
            return Emplist;
        }
        public List<users> getUsers()
        {
            var EmpList = new List<users>();
            onlinetestingEntities4 getuser = new onlinetestingEntities4();
            foreach ( var i in getuser.userdatas.ToList())
            {
                users user1 = new users();
                user1.userId = i.user_id;
                user1.first_name = i.firstName;
                user1.last_name = i.lastName;
                user1.Email = i.email;
                user1.Password = i.passwor;
                user1.About = i.about;

                EmpList.Add(user1);
            }

            return EmpList;
        }

        public CompositeType GetDataUsingDataContract(CompositeType composite)
        {
            if (composite == null)
            {
                throw new ArgumentNullException("composite");
            }
            if (composite.BoolValue)
            {
                composite.StringValue += "Suffix";
            }
            return composite;
        }
    }
}
