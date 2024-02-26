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

        private void bai03ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            bai03DataGridViewSetUp(dataGridViewAll);
        }

        private void bai03DataGridViewSetUp(DataGridView gridView)
        {
            clearDataGridView(gridView);
            setButtonVisibleTrue();
            setVisibleTrue();
            // Text Labels
            label1.Text = "STT";
            label2.Text = "Ma Sinh Vien";
            label3.Text = "Ho Ten";
            label4.Text = "Ngay Sinh";
            label5.Text = "Lop";
            label6.Text = "Thuong Xuyen";
            label7.Text = "Thi";
            label8.Text = "Tong Ket Hoc Phan";
            label9.Text = "Diem He Chu";
            // TextBox
            textBox1.Enabled = false;

            gridView.Visible = true;
            gridView.Columns.Add("STTColumn", "STT");
            gridView.Columns.Add("MaSinhVienColumn", "Mã Sinh Viên");
            gridView.Columns.Add("HoTenColumn", "Họ Tên");
            gridView.Columns.Add("NgaySinhColumn", "Ngày Sinh ");
            gridView.Columns.Add("LopColumn", "Lớp ");
            gridView.Columns.Add("ThuongXuyenColumn", "Thường Xuyên ");
            gridView.Columns.Add("ThiColumn", "Thi ");
            gridView.Columns.Add("TongKetHPColumn", "Tổng Kết Học Phần");
            gridView.Columns.Add("DiemChuColumn", "Điểm Chữ ");
            // Set the width of the ID column to 100 pixels
            // dgv.Columns["IDColumn"].Width = 100;
            gridView.Columns["TongKetHPColumn"].Width = 200;
            gridView.Columns["MaSinhVienColumn"].Width = 200;
            gridView.Columns["HoTenColumn"].Width = 200;
            // Set the width of the Name column to 200 pixels
            // dgv.Columns["NameColumn"].Width = 200;
            ////////////////////////////////////////////////////////////////////////////////
            // Load the XML data
            XDocument doc = XDocument.Load("C:\\Users\\bechj\\OneDrive\\second_semester_dec_2023_2024\\XML_LEARN\\visual_microsoft_code\\repos\\XML Revision\\bai03.xml");

            // Find the BangChamCong element
            XElement danhSachSinhVien = doc.Descendants("DanhSach").FirstOrDefault();

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
            foreach (XElement sinhVien in danhSachSinhVien.Elements("SinhVien"))
            {
                // Extract data from each CongNhanVien element
                string maSinhVien = sinhVien.Attribute("MaSinhVien").Value;
                string hoTen = sinhVien.Element("HoTen").Value;
                string ngaySinh = sinhVien.Element("NgaySinh").Value;
                string lop = sinhVien.Element("Lop").Value;
                string thuongXuyen = sinhVien.Element("ThuongXuyen").Value;
                string thi = sinhVien.Element("Thi").Value;
                string tongKet = sinhVien.Element("TongKetHP").Value;
                string diemChu = sinhVien.Element("DiemHeChu").Value;

                // Add a row to the DataTable
                //dataTable.Rows.Add(stt, maNhanVien, hoTenNhanVien, soNgayCong, ghiChu);


                // lấy giá trị của thuộc tính masach gán vào cột đầu tiên trên dòng thứ sd
                gridView.Rows.Add();
                gridView.Rows[index].Cells[0].Value = stt;
                gridView.Rows[index].Cells[1].Value = maSinhVien;
                gridView.Rows[index].Cells[2].Value = hoTen;
                gridView.Rows[index].Cells[3].Value = ngaySinh;
                gridView.Rows[index].Cells[4].Value = lop;
                gridView.Rows[index].Cells[5].Value = thuongXuyen;
                gridView.Rows[index].Cells[6].Value = thi;
                gridView.Rows[index].Cells[7].Value = tongKet;
                gridView.Rows[index].Cells[8].Value = diemChu;
                stt++;
                index++;

            }

            // Bind the DataTable to the DataGridView
            //gridView.DataSource = dataTable;
        }

        private void bai03AddNewSinhVien(string maSinhVien, string hoTen, string ngaySinh, string lop, double thuongXuyen, double thi, double tongKetHP, string diemHeChu)
        {
            XDocument xmlDoc = XDocument.Load("C:\\Users\\bechj\\OneDrive\\second_semester_dec_2023_2024\\XML_LEARN\\visual_microsoft_code\\repos\\XML Revision\\bai03.xml"); ;
            // Find the DanhSach element
            XElement danhSachElement = xmlDoc.Descendants("DanhSach").FirstOrDefault();

            // Create a new SinhVien element
            XElement sinhVienElement = new XElement("SinhVien",
                new XAttribute("MaSinhVien", maSinhVien),
                new XElement("STT", danhSachElement.Elements("SinhVien").Count() + 1), // STT is auto-incremented
                new XElement("MaSinhVien", maSinhVien),
                new XElement("HoTen", hoTen),
                new XElement("NgaySinh", ngaySinh),
                new XElement("Lop", lop),
                new XElement("ThuongXuyen", thuongXuyen),
                new XElement("Thi", thi),
                new XElement("TongKetHP", tongKetHP),
                new XElement("DiemHeChu", diemHeChu)
            );

            // Add the new SinhVien element to the DanhSach element
            danhSachElement.Add(sinhVienElement);

            // Save the changes to the XML file
            xmlDoc.Save("C:\\Users\\bechj\\OneDrive\\second_semester_dec_2023_2024\\XML_LEARN\\visual_microsoft_code\\repos\\XML Revision\\bai03.xml");
        }
        private void clearDataGridView(DataGridView gridView)
        {
            gridView.Rows.Clear();
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

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            switch (menuStrip1.Text.ToString())
            {
                case "Bài 03":
                    {
                        // Extract data from each CongNhanVien element
                        string maSinhVien = textBox2.Text.ToString();
                        string hoTen = textBox3.Text.ToString();
                        string ngaySinh = textBox4.Text.ToString();
                        string lop = textBox5.Text.ToString();
                        double thuongXuyen = Double.Parse(textBox6.Text.ToString());
                        double thi = Double.Parse(textBox7.Text.ToString());
                        double tongKet = Double.Parse(textBox8.Text.ToString());
                        string diemChu = textBox9.Text.ToString();
                        bai03AddNewSinhVien(
                            maSinhVien, hoTen, ngaySinh, lop, thuongXuyen, thi, tongKet, diemChu
                            );
                        break;
                    }
            }
        }

        private void buttonRefresh_Click(object sender, EventArgs e)
        {

        }
    }
}
