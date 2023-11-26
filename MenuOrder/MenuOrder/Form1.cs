using System.IO;
using System;
using System.Collections.Generic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Oracle.DataAccess.Client;

namespace MenuOrder
{
    public partial class Form1 : Form
    {
        private const string ConnectionString = "User Id=scott; Password=scott; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL= TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)));";
        private OracleConnection connection;
        private OracleDataAdapter dataAdapter;
        private DataSet dataSet;
        private decimal totalPrice;

        public Form1()
        {
            InitializeComponent();
            InitializeDatabase();
            InitializeUI();
        }

        private void InitializeDatabase()
        {
            connection = new OracleConnection(ConnectionString);
            dataAdapter = new OracleDataAdapter("SELECT * FROM MENU_INFO", connection);
            dataSet = new DataSet();

            dataAdapter.Fill(dataSet, "MENU_INFO");
        }

        private void InitializeUI()
        {
            // 버튼 및 이벤트 핸들러 설정
            ALL.Click += (sender, e) => ShowMenu("All");
            라면.Click += (sender, e) => ShowMenu("라면");
            덮밥.Click += (sender, e) => ShowMenu("덮밥");
            간식.Click += (sender, e) => ShowMenu("간식");
            튀김.Click += (sender, e) => ShowMenu("튀김");
            음료.Click += (sender, e) => ShowMenu("음료");
            삭제.Click += DeleteSelectedItem;

            // TotalPrice 초기화
            TotalPrice.Text = "0";

            // FlowLayoutPanel 설정
            flowLayoutPanelMenu.AutoScroll = true;

            // 초기에 모든 메뉴 보여주기
            ShowMenu("All");
        }

        private void ShowMenu(string menuType)
        {
            // FlowLayoutPanel 초기화
            flowLayoutPanelMenu.Controls.Clear();

            foreach (DataRow row in dataSet.Tables["MENU_INFO"].Rows)
            {
                // 선택한 메뉴 타입에 따라 필터링
                if (menuType == "All" || menuType == row["MENU_TYPE"].ToString())
                {
                    // 이미지 데이터를 PictureBox에 표시
                    PictureBox pictureBox = new PictureBox
                    {
                        Image = ByteArrayToImage(row["MENU_IMAGE"] as byte[]),
                        Size = new Size(100, 100),
                        SizeMode = PictureBoxSizeMode.StretchImage
                    };

                    // 이미지 클릭 이벤트 핸들러 추가
                    pictureBox.Click += (sender, e) => AddToOrder(row);

                    // 메뉴 이름을 나타내는 레이블 추가
                    Label label = new Label
                    {
                        Text = row["MENU_NAME"].ToString(),
                        TextAlign = ContentAlignment.MiddleCenter,
                        Dock = DockStyle.Bottom
                    };

                    // 패널을 이용하여 이미지와 레이블을 묶어서 FlowLayoutPanel에 추가
                    Panel panel = new Panel
                    {
                        Width = 100,
                        Height = 130,
                        BorderStyle = BorderStyle.FixedSingle
                    };

                    panel.Controls.Add(pictureBox);
                    panel.Controls.Add(label);

                    flowLayoutPanelMenu.Controls.Add(panel);
                }
            }
        }

        private void AddToOrder(DataRow menuRow)
        {
            // listBoxOrder에 음식 이름 및 가격 추가
            listBoxOrder.Items.Add($"{menuRow["MENU_NAME"]} - {menuRow["MENU_COST"]}");

            // 총 가격 증가
            totalPrice += Convert.ToDecimal(menuRow["MENU_COST"]);
            TotalPrice.Text = totalPrice.ToString();
        }

        private void DeleteSelectedItem(object sender, EventArgs e)
        {
            if (listBoxOrder.SelectedIndex != -1)
            {
                // 선택된 메뉴의 가격을 찾아서 TotalPrice 감소
                string selectedItem = listBoxOrder.SelectedItem.ToString();
                int index = selectedItem.LastIndexOf('-');
                decimal itemPrice = Convert.ToDecimal(selectedItem.Substring(index + 1).Trim());
                totalPrice -= itemPrice;

                // listBoxOrder에서 선택된 메뉴 삭제
                listBoxOrder.Items.RemoveAt(listBoxOrder.SelectedIndex);

                // TotalPrice 업데이트
                TotalPrice.Text = totalPrice.ToString();
            }
        }

        private Image ByteArrayToImage(byte[] byteArray)
        {
            MemoryStream memoryStream = new MemoryStream(byteArray);
            Image image = Image.FromStream(memoryStream);
            return image;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void ALL_Click(object sender, EventArgs e)
        {
            
        }

        private void 라면_Click(object sender, EventArgs e)
        {
            
        }

        private void 덮밥_Click(object sender, EventArgs e)
        {
            
        }

        private void 간식_Click(object sender, EventArgs e)
        {
            
        }

        private void 튀김_Click(object sender, EventArgs e)
        {
            
        }

        private void 음료_Click(object sender, EventArgs e)
        {
            
        }

        private void 삭제_Click(object sender, EventArgs e)
        {
            
        }
    }
}
