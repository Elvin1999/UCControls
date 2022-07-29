using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace UCControls
{
    class Student
    {
        public int No { get; set; }
        public string Fullname { get; set; }
        public string ImagePath { get; set; }
        public int Age { get; set; }
    }
    public partial class Form1 : Form
    {
        UserControl1 userControl1 = new UserControl1();
        public Form1()
        {
            InitializeComponent();

            List<Student> students = new List<Student>
            {
                new Student
                {
                    No=1,
                     Age=20,
                      Fullname="Mike Eliyev",

                },
                new Student
                {
                    No=2,
                     Age=20,
                      Fullname="Coshqun Eliyev",

                },
                new Student
                {
                    No=3,
                     Age=20,
                      Fullname="Rafiq Eliyev",

                },
            };

            int y = 0;
            y = 100;
            foreach (var s in students)
            {
                StudentUC uc = new StudentUC();
                uc.No = s.No.ToString();
                uc.Age = s.Age.ToString();  
                uc.Fullname=s.Fullname.ToString();
                uc.Location = new Point(uc.Location.X, y);
                y += 100;
                this.Controls.Add(uc);  
            }

        }
        UserControl2 userControl2 = new UserControl2();

        private void button2_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(userControl1);
            this.Controls.Add(userControl2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Controls.Remove(userControl2);
            this.Controls.Add(userControl1);
        }
    }
}
