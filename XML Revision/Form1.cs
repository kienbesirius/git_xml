using System;
using System.Data;
using System.Windows.Forms;
using System.Xml.Linq;

namespace XML_Revision
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            setVisibleFalse();
            setButtonVisibleFalse();
            dataGridViewAll.Visible = false;
         
        }
        // ! BAI 04
        private void bai04ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            setVisibleFalse();
            bai04DataGridViewSetUp(dataGridViewAll);
        }

        private void bai04DataGridViewSetUp(DataGridView gridView)
        {
            clearDataGridView(gridView);
            gridView.Visible = true;
            gridView.Columns.Add("STTColumn", "STT");
            gridView.Columns.Add("MaNhanVienColumn", "Mã Nhân Viên");
            gridView.Columns.Add("HoTenNhanVienColumn", "Họ Tên");
            gridView.Columns.Add("SoNgayCongColumn", "Số Ngày Công");
            gridView.Columns.Add("GhiChuColumn", "Ghi Chú");
            // Set the width of the ID column to 100 pixels
            // dgv.Columns["IDColumn"].Width = 100;
            gridView.Columns["MaNhanVienColumn"].Width = 200;
            gridView.Columns["SoNgayCongColumn"].Width = 200;
            gridView.Columns["HoTenNhanVienColumn"].Width = 200;
            // Set the width of the Name column to 200 pixels
            // dgv.Columns["NameColumn"].Width = 200;
            ////////////////////////////////////////////////////////////////////////////////
            // Load the XML data
            XDocument doc = XDocument.Load("C:\\Users\\bechj\\OneDrive\\second_semester_dec_2023_2024\\XML_LEARN\\visual_microsoft_code\\repos\\XML Revision\\bai04.xml");

            // Find the BangChamCong element
            XElement bangChamCongElement = doc.Descendants("BangChamCong").FirstOrDefault();

            // Create a DataTable to hold the data
            DataTable dataTable = new DataTable();
            int stt = 1;
            int index = 0;
            // Add columns to the DataTable
         /*   dataTable.Columns.Add("STT", typeof(int));
            dataTable.Columns.Add("MaNhanVien", typeof(string));
            dataTable.Columns.Add("HoTenNhanVien", typeof(string));
            dataTable.Columns.Add("SoNgayCong", typeof(int));
            dataTable.Columns.Add("GhiChu", typeof(string));
            */
            // Loop through each CongNhanVien element under BangChamCong
            foreach (XElement congNhanVienElement in bangChamCongElement.Elements("CongNhanVien"))
            {
                // Extract data from each CongNhanVien element
                string maNhanVien = congNhanVienElement.Attribute("MaNhanVien").Value;
                string hoTenNhanVien = congNhanVienElement.Element("HoTenNhanVien").Value;
                int soNgayCong = int.Parse(congNhanVienElement.Element("SoNgayCong").Value);
                string ghiChu = congNhanVienElement.Element("GhiChu").Value;

                // Add a row to the DataTable
                //dataTable.Rows.Add(stt, maNhanVien, hoTenNhanVien, soNgayCong, ghiChu);


                // lấy giá trị của thuộc tính masach gán vào cột đầu tiên trên dòng thứ sd
                gridView.Rows.Add();
                gridView.Rows[index].Cells[0].Value = stt;
                gridView.Rows[index].Cells[1].Value = maNhanVien;
                gridView.Rows[index].Cells[2].Value = hoTenNhanVien;
                gridView.Rows[index].Cells[3].Value = soNgayCong;
                gridView.Rows[index].Cells[4].Value = ghiChu;
                stt++;
                index++; 
    
            }

            // Bind the DataTable to the DataGridView
            //gridView.DataSource = dataTable;
        }




        private void clearDataGridView(DataGridView gridView) 
        {
            gridView.Columns.Clear();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void setButtonVisibleFalse()
        {
            buttonAdd.Visible = false;
            buttonDelete.Visible = false;
            buttonUpdate.Visible = false;
            buttonSearch.Visible = false;
            buttonRefresh.Visible = false;
        }
        private void setButtonVisibleTrue()
        {
            buttonAdd.Visible = true;
            buttonDelete.Visible = true;
            buttonUpdate.Visible = true;
            buttonSearch.Visible = true;
            buttonRefresh.Visible = true;
        }
        private void setVisibleFalse()
        {
            label1.Visible = false;
            label2.Visible = false;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            label6.Visible = false;
            label7.Visible = false;
            label8.Visible = false;
            label9.Visible = false;
            textBox1.Visible = false;
            textBox2.Visible = false;
            textBox3.Visible = false;
            textBox4.Visible = false;
            textBox5.Visible = false;
            textBox6.Visible = false;
            textBox7.Visible = false;
            textBox8.Visible = false;
            textBox9.Visible = false;
        }
        private void setVisibleTrue()
        {
            label1.Visible = true;
            label2.Visible = true;
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            label6.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            textBox1.Visible = true;
            textBox2.Visible = true;
            textBox3.Visible = true;
            textBox4.Visible = true;
            textBox5.Visible = true;
            textBox6.Visible = true;
            textBox7.Visible = true;
            textBox8.Visible = true;
            textBox9.Visible = true;
        }
        
    }
}
