using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using IniFIleG;

namespace lab14
{
    public enum Sex
    {
        MALE,
        FEMALE
    }
    public struct Student
    {
        public string name;
        public string surname;
        public Sex sex;
        public string group;
        public List<List<int>> grades;
        public string photoPath;
    }
    public partial class Form1 : Form
    {
        Student studentEdit = new Student
        {
            name = "",
            surname = "",
            sex = Sex.MALE,
            group = "",
            grades = new List<List<int>>(),
            photoPath = ""
        };
        Student student = new Student
        {
            name = "",
            surname = "",
            sex = Sex.MALE,
            group = "",
            grades = new List<List<int>>(),
            photoPath = ""
        };

        bool autosave = false;
        IniFilee iniFile;

        public Form1()
        {
            InitializeComponent();
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox2.SizeMode = PictureBoxSizeMode.Zoom;

            iniFile = new IniFilee();
            iniFile.IniFile(@"./Settings.ini");
            initData();
        }

        public void initData()
        {
            dataGrid.Rows.Clear();
            dataGrid.Columns.Clear();

            string dataGridData = iniFile.Read("dataGrid");
            bool flag = true;
            string column = "";
            string digital = "";
            int y = 0;
            int u = 0;
            for (int i = 0; i < dataGridData.Length; i++)
            {
                if (flag && dataGridData[i] == ' ')
                {
                    u++;
                    listBox1.Items.Add(column);

                    dataGrid.ColumnCount = dataGrid.ColumnCount + 1;
                    dataGrid.Columns[dataGrid.ColumnCount - 1].Name = column;

                    if (dataGrid.ColumnCount == 1)
                    {
                        for (int j = 0; j < 4; j++)
                        {
                            var str = new String[1];
                            str[0] = "";
                            dataGrid.Rows.Add(str);
                        }
                        for (int j = 0; j < 4; j++)
                        {
                            dataGrid.Rows[j].HeaderCell.Value = (j + 1).ToString();
                        }
                    }
                    flag = false;
                    continue;
                }
                if (dataGridData[i] == '|')
                {
                    column = "";
                    y = 0;
                    flag = true;
                    continue;
                }
                if (flag)
                {
                    column += dataGridData[i];
                } 
                else
                {
                    if (dataGridData[i] == ' ')
                    {
                        dataGrid.Rows[y].Cells[u - 1].Value = digital;
                        digital = "";
                        y++;
                    } else
                    {
                        digital += dataGridData[i];
                    }
                }
            }

            student.name = iniFile.Read("name");
            student.surname = iniFile.Read("surname");
            student.sex = iniFile.Read("sex") == "MALE" ? Sex.MALE : Sex.FEMALE;
            student.group = iniFile.Read("group");
            student.photoPath = iniFile.Read("photoPath");

            studentEdit.name = student.name;
            studentEdit.surname = student.surname;
            studentEdit.sex = student.sex;
            studentEdit.group = student.group;
            studentEdit.photoPath = student.photoPath;
            updateEditPage();
            updateProfilePage();
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<List<Tuple<int, string>>> dataGridList = new List<List<Tuple<int, string>>>();
            for (int i = 0; i < dataGrid.Columns.Count; i++)
            {
                dataGridList.Add(new List<Tuple<int, string>>());
                for (int j = 0; j < dataGrid.Rows.Count; j++)
                {
                    dataGridList[i].Add(new Tuple<int, string>(Convert.ToInt32(dataGrid.Rows[j].Cells[i].Value), dataGrid.Columns[i].Name));
                }
            }
            Form2 f2 = new Form2(dataGridList);
            f2.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            saveProfileInfo();
        }
        public void saveProfileInfo()
        {
            student.name = studentEdit.name;
            student.surname = studentEdit.surname;
            student.sex = studentEdit.sex;
            student.group = studentEdit.group;
            student.photoPath = studentEdit.photoPath;
            iniFile.Write("name", student.name);
            iniFile.Write("surname", student.surname);
            iniFile.Write("sex", student.sex.ToString());
            iniFile.Write("group", student.group);
            iniFile.Write("photoPath", student.photoPath);
            updateProfilePage();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            studentEdit.sex = Sex.MALE;
            if (autosave)
                saveProfileInfo();
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            studentEdit.sex = Sex.FEMALE;
            if (autosave)
                saveProfileInfo();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            studentEdit.name = textBox6.Text;
            if (autosave)
                saveProfileInfo();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            studentEdit.surname = textBox5.Text;
            if (autosave)
                saveProfileInfo();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            studentEdit.group = textBox4.Text;
            if (autosave)
                saveProfileInfo();
        }

        private void tabPage4_Click(object sender, EventArgs e)
        {

        }

        private void updateEditPage()
        {
            textBox4.Text = studentEdit.name;
            textBox5.Text = studentEdit.surname;
            textBox6.Text = studentEdit.group;
            radioButton1.Checked = studentEdit.sex == Sex.MALE;
            radioButton2.Checked = studentEdit.sex == Sex.FEMALE;
            if (studentEdit.photoPath != null && studentEdit.photoPath != "")
            {
                pictureBox2.Image = Image.FromFile(studentEdit.photoPath);
            }
        }

        private void updateProfilePage()
        {
            textBox1.Text = student.name;
            textBox2.Text = student.surname;
            textBox3.Text = student.group;
            if (student.photoPath != null && student.photoPath != "")
            {
                pictureBox1.Image = Image.FromFile(student.photoPath);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SaveFileDialog sf = new SaveFileDialog();
            if (sf.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = Image.FromFile(sf.FileName);
                studentEdit.photoPath = sf.FileName;
                if (autosave)
                {
                    saveProfileInfo();
                }
            }
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (textBox7.Text != "")
            {
                listBox1.Items.Add(textBox7.Text);

                dataGrid.ColumnCount = dataGrid.ColumnCount + 1;
                dataGrid.Columns[dataGrid.ColumnCount - 1].Name = textBox7.Text;

                if (dataGrid.ColumnCount == 1)
                {
                    for (int j = 0; j < 4; j++) {
                        var str = new String[1];
                        str[0] = "";
                        dataGrid.Rows.Add(str);
                    }
                    for (int j = 0; j < 4; j++)
                    {
                        dataGrid.Rows[j].HeaderCell.Value = (j + 1).ToString();
                    }
                }

                textBox7.Text = "";
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null)
            {
                return;
            }
            dataGrid.Columns.RemoveAt(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
        }

        private void toolStripLabel1_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3(autoSaveCallBack, autosave);
            f3.Show();
        }
        public string autoSaveCallBack(bool flag)
        {
            autosave = flag;
            return "";
        }

        private void dataGrid_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (autosave)
            {
                string res = "";
                for (int i = 0; i < dataGrid.Columns.Count; i++)
                {
                    res += dataGrid.Columns[i].Name;
                    for (int j = 0; j < dataGrid.Rows.Count; j++)
                    {
                        if (dataGrid.Rows[j].Cells[i].Value == null)
                        {
                            continue;
                        }
                        res += " " + dataGrid.Rows[j].Cells[i].Value.ToString();
                    }
                    res += " |";
                }
                iniFile.Write("dataG rid", res);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            string res = "";
            for (int i = 0; i < dataGrid.Columns.Count; i++)
            {
                res += dataGrid.Columns[i].Name;
                for (int j = 0; j < dataGrid.Rows.Count; j++)
                {
                    if (dataGrid.Rows[j].Cells[i].Value == null)
                    {
                        continue;
                    }
                    res += " " + dataGrid.Rows[j].Cells[i].Value.ToString();
                }
                res += " |";
            }

            iniFile.Write("dataGrid", res);
        }

        private void toolStripLabel2_Click(object sender, EventArgs e)
        {
            initData();
        }
    }
}
