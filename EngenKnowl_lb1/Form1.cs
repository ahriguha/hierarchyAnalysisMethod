using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EngenKnowl_lb1
{
    public partial class Form1 : Form
    {
        public static bool endInit = false;
        public static float[,] critTable;
        public static int criteriaAmount = 7;
        public static int itemsAmount = 3;
        public static int criteriaCounter = 0;
        DataGridView dataGridView2;
        public static Dictionary<int, float> CrValues = new Dictionary<int, float>
        {
            { 1, 0},
            { 2, 0},
            { 3, 0.58f},
            { 4, 0.9f},
            { 5, 1.12f},
            { 6, 1.24f},
            { 7, 1.32f},
            { 8, 1.41f},
            { 9, 1.45f},
            { 10, 1.49f}
        };

        public static List<float[,]> desigionList = new List<float[,]>();

        public Form1()
        {
            InitializeComponent();
            for (int i = 0; i < criteriaAmount + 1; i++)
            {
                dataGridView1.Rows.Add();
            }
            for(int i = 0; i < criteriaAmount; i++)
            {
                dataGridView1.Rows[i].Cells[i].Value = 1;
            }
            dataGridView1.Rows[criteriaAmount].DefaultCellStyle.BackColor = Color.AliceBlue;
            endInit = true;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
        }

      

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            if (endInit)
            {
                dataGridView1.Rows[dataGridView1.CurrentCell.ColumnIndex].Cells[dataGridView1.CurrentCell.RowIndex].Value =
                    1/(float.Parse(dataGridView1.CurrentCell.Value.ToString()));
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            endInit = false;
            //BB calculating
            for(int i = 0; i < criteriaAmount; i++)
            {
                float mul = 1;
                for(int j = 0; j < criteriaAmount; j++)
                {
                    mul *= float.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString());
                }
                dataGridView1.Rows[i].Cells["BB"].Value = Math.Pow(mul, 1.0/criteriaAmount);
            }

            //each column sum calculating
            float sum = 0;
            for (int i = 0; i < criteriaAmount + 1; i++)
            {
                sum = 0;
                for (int j = 0; j < criteriaAmount; j++)
                {
                    sum += float.Parse(dataGridView1.Rows[j].Cells[i].Value.ToString());
                }
                dataGridView1.Rows[criteriaAmount].Cells[i].Value = sum;
            }

            //BP counting
            for (int i = 0; i < criteriaAmount; i++)
            {
                dataGridView1.Rows[i].Cells["BP"].Value =
                    float.Parse(dataGridView1.Rows[i].Cells["BB"].Value.ToString()) /
                    float.Parse(dataGridView1.Rows[criteriaAmount].Cells["BB"].Value.ToString());
            }

            //BP sum counting(BP = 1)
            sum = 0;
            for (int i = 0; i < criteriaAmount; i++)
            {
                sum += float.Parse(dataGridView1.Rows[i].Cells["BP"].Value.ToString());
            }
            dataGridView1.Rows[criteriaAmount].Cells["BP"].Value = Math.Round(sum,1);

            //lambdamax counting
            float res = 0;
            for(int i = 0; i < criteriaAmount; i++)
            {
                res += float.Parse(dataGridView1.Rows[i].Cells["BP"].Value.ToString()) *
                    float.Parse(dataGridView1.Rows[criteriaAmount].Cells[i].Value.ToString());
            }
            label1.Text = $"lambda MAX = {res}";
            label2.Text = $"Cr = {(res - criteriaAmount)/(criteriaAmount - 1)/CrValues[criteriaAmount]*100}";

            //data saving
            critTable = new float[criteriaAmount + 1, criteriaAmount + 2];
            for(int i = 0; i < criteriaAmount + 1; i++)
            {
                for(int j = 0; j < criteriaAmount + 2; j++)
                {
                    critTable[i, j] = float.Parse(dataGridView1.Rows[i].Cells[j].Value.ToString());
                }
            }
            
            
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            endInit = true;
        }

        private void smallTablesProcess(int criteriaIndex)
        {
            panel1.Controls.Clear();
            desigionList.Add(new float[itemsAmount + 1, itemsAmount + 2]);
            dataGridView2 = new DataGridView();
            endInit = false;
            
            dataGridView2.Width = 600;
            dataGridView2.Height = 150;
            dataGridView2.AllowUserToAddRows = false;

            dataGridView2.CellValueChanged += (object sender, DataGridViewCellEventArgs e) =>
            {
                if (endInit)
                {
                    dataGridView2.Rows[dataGridView2.CurrentCell.ColumnIndex].Cells[dataGridView2.CurrentCell.RowIndex].Value =
                        1 / (float.Parse(dataGridView2.CurrentCell.Value.ToString()));
                }
            };

            for (int i = 0; i < itemsAmount + 2; i++)
            {
                dataGridView2.Columns.Add($"A{i}", $"A{i}");
                dataGridView2.Columns[i].SortMode = DataGridViewColumnSortMode.NotSortable;
            }
            dataGridView2.Columns[itemsAmount].HeaderCell.Value = "BB";
            dataGridView2.Columns[itemsAmount].Name = "BB";
            dataGridView2.Columns[itemsAmount + 1].HeaderCell.Value = "BP";
            dataGridView2.Columns[itemsAmount + 1].Name = "BP";
            for (int i = 0; i < itemsAmount + 1; i++)
            {
                dataGridView2.Rows.Add();
            }
            dataGridView2.Columns[itemsAmount].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192);
            dataGridView2.Columns[itemsAmount + 1].DefaultCellStyle.BackColor = Color.FromArgb(255, 255, 192);
            dataGridView2.Rows[itemsAmount].DefaultCellStyle.BackColor = Color.AliceBlue;
            for (int i = 0; i < itemsAmount; i++)
            {
                dataGridView2.Rows[i].Cells[i].Value = 1;
            }
            endInit = true;
            panel1.Controls.Add(dataGridView2);

          
        }

        private void button2_Click(object sender, EventArgs e)
        {
            endInit = false;
            //BB calculating
            for (int i = 0; i < itemsAmount; i++)
            {
                float mul = 1;
                for (int j = 0; j < itemsAmount; j++)
                {
                    mul *= float.Parse(dataGridView2.Rows[i].Cells[j].Value.ToString());
                }
                dataGridView2.Rows[i].Cells["BB"].Value = Math.Pow(mul, 1.0 / itemsAmount);
            }

            //each column sum calculating
            float sum = 0;
            for (int i = 0; i < itemsAmount + 1; i++)
            {
                sum = 0;
                for (int j = 0; j < itemsAmount; j++)
                {
                    sum += float.Parse(dataGridView2.Rows[j].Cells[i].Value.ToString());
                }
                dataGridView2.Rows[itemsAmount].Cells[i].Value = sum;
            }

            //BP counting
            for (int i = 0; i < itemsAmount; i++)
            {
                dataGridView2.Rows[i].Cells["BP"].Value =
                    float.Parse(dataGridView2.Rows[i].Cells["BB"].Value.ToString()) /
                    float.Parse(dataGridView2.Rows[itemsAmount].Cells["BB"].Value.ToString());
            }

            //BP sum counting(BP = 1)
            sum = 0;
            for (int i = 0; i < itemsAmount; i++)
            {
                sum += float.Parse(dataGridView2.Rows[i].Cells["BP"].Value.ToString());
            }
            dataGridView2.Rows[itemsAmount].Cells["BP"].Value = Math.Round(sum, 1);

            //lambdamax counting
            float res = 0;
            for (int i = 0; i < itemsAmount; i++)
            {
                res += float.Parse(dataGridView2.Rows[i].Cells["BP"].Value.ToString()) *
                    float.Parse(dataGridView2.Rows[itemsAmount].Cells[i].Value.ToString());
            }
            label1.Text = $"lambda MAX = {res}";
            label2.Text = $"Cr = {(res - itemsAmount) / (itemsAmount - 1) / CrValues[itemsAmount] * 100}";

            //data saving
            
            for (int i = 0; i < itemsAmount + 1; i++)
            {
                for (int j = 0; j < itemsAmount + 2; j++)
                {
                    desigionList[criteriaCounter][i,j] = float.Parse(dataGridView2.Rows[i].Cells[j].Value.ToString());
                }
            }
            criteriaCounter++;
            if(criteriaCounter == criteriaAmount)
            {
                 button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = true;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
                smallTablesProcess(criteriaCounter);
            
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float[] desigion = new float[3];
            for (int i = 0; i < itemsAmount; i++) 
            {
                float sum = 0;
                for (int j = 0; j < criteriaAmount; j++)
                {
                    sum += desigionList[j][i, itemsAmount + 1] * critTable[j, criteriaAmount + 1];
                }
                desigion[i] = sum;
            }
            MessageBox.Show(desigion[0] + "\t" + desigion[1] + "\t" + desigion[2]);
            MessageBox.Show(desigion.Max().ToString());
        }
    }
}
