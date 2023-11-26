using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Oracle.DataAccess.Client;
namespace ADD_MENU
{
    public partial class Form1 : Form
    {
        string connectionString = "User Id=scott; Password=scott; Data Source=(DESCRIPTION = (ADDRESS = (PROTOCOL= TCP)(HOST = localhost)(PORT = 1521)) (CONNECT_DATA = (SERVER = DEDICATED)(SERVICE_NAME = xe)) ); ";

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // "메뉴추가" 버튼 클릭 시 이벤트 처리
            string menuID = MenuID.Text;
            string menuName = MenuName.Text;
            string menuCost = MenuCost.Text;
            string menuType = MenuType.Text;
            string imagePath = MenuImage.Text;

            // 이미지 경로에서 이미지 읽어오기
            Image menuImage = Image.FromFile(imagePath);

            // 추가된 메뉴를 데이터베이스에 삽입
            if (InsertMenuIntoDatabase(menuID, menuName, menuCost, menuType, menuImage))
            {
                MessageBox.Show("메뉴가 추가되었습니다.", "성공", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("메뉴 추가에 실패했습니다.", "오류", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool InsertMenuIntoDatabase(string menuID, string menuName, string menuCost, string menuType, Image menuImage)
        {
            // Oracle 연결 생성
            using (OracleConnection connection = new OracleConnection(connectionString))
            {
                try
                {
                    connection.Open();

                    // OracleCommand 생성 (MENU_INFO 테이블에 새로운 튜플 추가)
                    string query = "INSERT INTO MENU_INFO (MENU_ID, MENU_NAME, MENU_COST, MENU_TYPE, MENU_IMAGE) " +
                                   "VALUES (:menuID, :menuName, :menuCost, :menuType, :menuImage)";

                    using (OracleCommand command = new OracleCommand(query, connection))
                    {
                        // 바인딩 변수 설정
                        command.Parameters.Add(":menuID", OracleDbType.Varchar2).Value = menuID;
                        command.Parameters.Add(":menuName", OracleDbType.Varchar2).Value = menuName;
                        command.Parameters.Add(":menuCost", OracleDbType.Decimal).Value = menuCost;
                        command.Parameters.Add(":menuType", OracleDbType.Varchar2).Value = menuType;

                        // 이미지를 바이트 배열로 변환
                        byte[] imageBytes = ImageToByteArray(menuImage);
                        command.Parameters.Add(":menuImage", OracleDbType.Blob).Value = imageBytes;

                        // 쿼리 실행
                        command.ExecuteNonQuery();
                    }

                    return true;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                    return false;
                }
            }
        }
        private byte[] ImageToByteArray(Image image)
        {
            // 이미지를 바이트 배열로 변환
            using (MemoryStream ms = new MemoryStream())
            {
                image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                return ms.ToArray();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            // 이미지 브라우저 버튼 클릭 시 이벤트 처리
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Image Files (*.png;*.jpeg;*.jpg;*.gif;*.bmp)|*.png;*.jpeg;*.jpg;*.gif;*.bmp";
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    MenuImage.Text = openFileDialog.FileName;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void MenuID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
