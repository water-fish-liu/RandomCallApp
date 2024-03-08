using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using Newtonsoft.Json;
using ExcelDataReader;

namespace RandomCallApp
{
    public partial class Form : System.Windows.Forms.Form
    {
        private List<string> recentlyCalledStudents = new List<string>();
        private List<string> studentList = new List<string>();

        public Form()
        {
            InitializeComponent();
            LoadStudentList();
            LoadRecentlyCalledStudents();
        }

        private void LoadStudentList()
        {
            try
            {
                using (StreamReader file = File.OpenText("student_list.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    studentList = (List<string>)serializer.Deserialize(file, typeof(List<string>));
                }
            }
            catch (FileNotFoundException)
            {
                studentList = new List<string>();
            }
        }

        private void SaveStudentList()
        {
            using (StreamWriter file = File.CreateText("student_list.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, studentList);
            }
        }

        private List<string> ChooseFileDirectory()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Excel Files|*.xls;*.xlsx";
            openFileDialog.Title = "选择学生名单文件";

            List<string> newStudentList = new List<string>(); // 创建一个新的列表来保存新的学生数据

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                {
                    using (var reader = ExcelReaderFactory.CreateReader(stream))
                    {
                        while (reader.Read())
                        {
                            newStudentList.Add(reader.GetString(0)); // 将新的学生数据添加到新的列表中
                        }
                    }
                }

                return newStudentList; // 返回新的学生数据列表
            }
            else
            {
                MessageBox.Show("未选择学生名单文件！", "错误");
                return new List<string>(); // 返回空的列表
            }
        }

        private void RandomCall(List<string> students)
        {
            if (students.Count > 0)
            {
                var availableStudents = students.Except(recentlyCalledStudents).ToList();
                if (availableStudents.Count == 0)
                {
                    MessageBox.Show("所有同学都已被点名！", "随机点名");
                    return;
                }

                Random random = new Random();
                string randomStudent = availableStudents[random.Next(availableStudents.Count)];
                recentlyCalledStudents.Add(randomStudent);
                if (recentlyCalledStudents.Count > 5)
                {
                    recentlyCalledStudents.RemoveAt(0);
                }
                SaveRecentlyCalledStudents();
                MessageBox.Show($"点名结果：{randomStudent}", "随机点名");
            }
            else
            {
                MessageBox.Show("学生名单为空！", "随机点名");
            }
        }

        private void LoadRecentlyCalledStudents()
        {
            try
            {
                using (StreamReader file = File.OpenText("recently_called_students.json"))
                {
                    JsonSerializer serializer = new JsonSerializer();
                    recentlyCalledStudents = (List<string>)serializer.Deserialize(file, typeof(List<string>));
                }
            }
            catch (FileNotFoundException)
            {
                recentlyCalledStudents = new List<string>();
            }
        }

        private void SaveRecentlyCalledStudents()
        {
            using (StreamWriter file = File.CreateText("recently_called_students.json"))
            {
                JsonSerializer serializer = new JsonSerializer();
                serializer.Serialize(file, recentlyCalledStudents);
            }
        }

        private void PreviewStudentList(List<string> students)
        {
            if (students.Count > 0)
            {
                string studentListStr = string.Join("\n", students);
                int numStudents = students.Count;
                MessageBox.Show($"总人数：{numStudents}\n学生名单预览：\n{studentListStr}\n", "学生名单预览");
            }
            else
            {
                MessageBox.Show("学生名单为空！", "学生名单预览");
            }
        }

        
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonRandomCall_Click_1(object sender, EventArgs e)
        {
            RandomCall(studentList);
        }

        private void buttonChooseFile_Click_1(object sender, EventArgs e)
        {
            studentList = ChooseFileDirectory();

        }

        private void buttonPreviewStudentList_Click_1(object sender, EventArgs e)
        {
            PreviewStudentList(studentList);
        }

        private void buttonViewRecentlyCalled_Click_1(object sender, EventArgs e)
        {
            if (recentlyCalledStudents.Any())
            {
                string recentlyCalledStr = string.Join("\n", recentlyCalledStudents);
                MessageBox.Show($"最近被点名学生：\n{recentlyCalledStr}", "最近被点名学生");
            }
            else
            {
                MessageBox.Show("还没有点名记录！", "最近被点名学生");
            }
        }
        private void Form_Closing(object sender, FormClosingEventArgs e)
        {
            SaveStudentList();
        }

        private void Form_Load(object sender, EventArgs e)
        {

        }

       
    }
}

