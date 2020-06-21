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
using System.IO.Ports;

namespace Baitap1_COM
{
    public partial class Form1 : Form
    {
        string ReceiveData = String.Empty;
        string TransmitData = String.Empty;
        public Form1()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            DialogResult answer = MessageBox.Show("Có muốn thoát hay không", "Thoát?", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (answer == DialogResult.Yes)
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();

                }
                this.Close();
            }
        }
        //ON1---------------------------
        private void Button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    TransmitData = "A";
                    serialPort1.Write(TransmitData);
                }
                else
                {
                    TextBox1.BackColor = Color.Red;
                    TextBox1.Text = "Disconnected!";
                    MessageBox.Show("Cổng COM đã mất kết nối. Vui lòng kết nối lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Loi", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        //connect---------------------
        private void Button1_Click(object sender, EventArgs e)
        {
            if (ComboBox1.Text == "")
                MessageBox.Show("Chọn cổng COM", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else if (ComboBox2.Text == "")
                MessageBox.Show("Chọn baudrate", "Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            else
            {
                try
                {
                    if (serialPort1.IsOpen)
                        MessageBox.Show("Cổng COM đã kết nối", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    else
                    {
                        serialPort1.Open();
                        TextBox1.BackColor = Color.Lime;
                        TextBox1.Text = "Connected!";
                        ComboBox1.Enabled = false;
                        ComboBox2.Enabled = false;
                        ReceiveData = string.Empty;
                        TransmitData = string.Empty;
                    }
                }
                catch (Exception)
                {
                    TextBox1.BackColor = Color.Red;
                    TextBox1.Text = "Disconnected!";
                    MessageBox.Show("Không tìm thấy cổng COM. Kiểm tra lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
         
        //disconnect------------------
        private void Button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    serialPort1.Close();
                    TextBox1.BackColor = Color.Red;
                    TextBox1.Text = "Disconnected!";
                    ComboBox1.Enabled = true;
                    ComboBox2.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Cổng COM đã ngắt kết nối", "Thong bao", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Xảy ra lỗi", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        // OFF1-------------------------
        private void Button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    TransmitData = "H";
                    serialPort1.Write(TransmitData);
                }
                else
                {
                    TextBox1.BackColor = Color.Red;
                    TextBox1.Text = "Disconnected!";
                    MessageBox.Show("Cổng COM đã mất kết nối. Vui lòng kết nối lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Loi", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //ON2-----------------------
        private void Button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    TransmitData = "B";
                    serialPort1.Write(TransmitData);
                }
                else
                {
                    TextBox1.BackColor = Color.Red;
                    TextBox1.Text = "Disconnected!";
                    MessageBox.Show("Cổng COM đã mất kết nối. Vui lòng kết nối lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Loi", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //OFF2---------------------------
        private void Button6_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    TransmitData = "J";
                    serialPort1.Write(TransmitData);
                }
                else
                {
                    TextBox1.BackColor = Color.Red;
                    TextBox1.Text = "Disconnected!";
                    MessageBox.Show("Cổng COM đã mất kết nối. Vui lòng kết nối lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Loi", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //ON3----------------------------
        private void Button9_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    TransmitData = "C";
                    serialPort1.Write(TransmitData);
                }
                else
                {
                    TextBox1.BackColor = Color.Red;
                    TextBox1.Text = "Disconnected!";
                    MessageBox.Show("Cổng COM đã mất kết nối. Vui lòng kết nối lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Loi", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //OFF3---------------------------
        private void Button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    TransmitData = "K";
                    serialPort1.Write(TransmitData);
                }
                else
                {
                    TextBox1.BackColor = Color.Red;
                    TextBox1.Text = "Disconnected!";
                    MessageBox.Show("Cổng COM đã mất kết nối. Vui lòng kết nối lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Loi", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Thuan1---------------------
        private void Button10_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    TransmitData = "D";
                    serialPort1.Write(TransmitData);
                   
                }
                else
                {
                    TextBox1.BackColor = Color.Red;
                    TextBox1.Text = "Disconnected!";
                    MessageBox.Show("Cổng COM đã mất kết nối. Vui lòng kết nối lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Loi", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //Thuan2------------------------------
        private void Button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    TransmitData = "L";
                    serialPort1.Write(TransmitData);
                    



                }
                else
                {
                    TextBox1.BackColor = Color.Red;
                    TextBox1.Text = "Disconnected!";
                    MessageBox.Show("Cổng COM đã mất kết nối. Vui lòng kết nối lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Loi", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Nghich1---------------------
        private void Button11_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    TransmitData = "E";
                    serialPort1.Write(TransmitData);
                   
                }
                else
                {
                    TextBox1.BackColor = Color.Red;
                    TextBox1.Text = "Disconnected!";
                    MessageBox.Show("Cổng COM đã mất kết nối. Vui lòng kết nối lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Loi", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Nghich2-----------------------------------------
        private void Button14_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    TransmitData = "Z";
                    serialPort1.Write(TransmitData);
                    
                }
                else
                {
                    TextBox1.BackColor = Color.Red;
                    TextBox1.Text = "Disconnected!";
                    MessageBox.Show("Cổng COM đã mất kết nối. Vui lòng kết nối lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Loi", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Dung1------------------------
        private void Button12_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    TransmitData = "F";
                    serialPort1.Write(TransmitData);
                   
                }
                else
                {
                    TextBox1.BackColor = Color.Red;
                    TextBox1.Text = "Disconnected!";
                    MessageBox.Show("Cổng COM đã mất kết nối. Vui lòng kết nối lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Loi", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //Dung2-------------------------
        private void Button15_Click(object sender, EventArgs e)
        {
            try
            {
                if (serialPort1.IsOpen)
                {
                    TransmitData = "M";
                    serialPort1.Write(TransmitData);
                   
                }
                else
                {
                    TextBox1.BackColor = Color.Red;
                    TextBox1.Text = "Disconnected!";
                    MessageBox.Show("Cổng COM đã mất kết nối. Vui lòng kết nối lại", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Loi", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (serialPort1.IsOpen) serialPort1.Close();
        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;
            ReceiveData = serialPort1.ReadExisting();
            if (ReceiveData == "1")
            {
                pictureBox2.Image = Baitap1_COM.Properties.Resources.on;
            }
            if (ReceiveData == "2")
            {
                pictureBox3.Image = Baitap1_COM.Properties.Resources.on;
            }
            if (ReceiveData == "3")
            {
                pictureBox4.Image = Baitap1_COM.Properties.Resources.on;
            }

            if (ReceiveData == "6")
            {
                pictureBox2.Image = Baitap1_COM.Properties.Resources.off;
            }
            if (ReceiveData == "7")
            {
                pictureBox3.Image = Baitap1_COM.Properties.Resources.off;
            }
            if (ReceiveData == "8")
            {
                pictureBox4.Image = Baitap1_COM.Properties.Resources.off;
            }


            if (ReceiveData == "4")
            {

                {
                    pictureBox5.Image = Baitap1_COM.Properties.Resources.Untitled11;
                }
            }
            if (ReceiveData == "5")
            {

                {
                    pictureBox5.Image = Baitap1_COM.Properties.Resources.Untitled2;
                }
            }


            if (ReceiveData == "Q" )
            {

                {
                    pictureBox5.Image = Baitap1_COM.Properties.Resources.Untitled;
                }
            }


            if (ReceiveData == "9")
            {

                {
                    pictureBox1.Image = Baitap1_COM.Properties.Resources.Untitled11;
                }
            }
            if (ReceiveData == "0")
            {

                {
                    pictureBox1.Image = Baitap1_COM.Properties.Resources.Untitled2;
                }
            }


            if (ReceiveData == "I")
            {

                {
                    pictureBox1.Image = Baitap1_COM.Properties.Resources.Untitled;
                }
            }

           /*if (ReceiveData == "4")
            {
               if(ReceiveData == "Q")
               {
                    pictureBox5.Image=Baitap1_COM.Properties.Resources.Untitled11;
               }


               if (ReceiveData == "I")
                {
                    pictureBox5.Image = Baitap1_COM.Properties.Resources.Untitled21;
                }
            }



            if (ReceiveData == "5")
            {
                if (ReceiveData == "W")
                {
                    pictureBox1.Image = Baitap1_COM.Properties.Resources.Untitled11;
                }


                if (ReceiveData == "P")
                {
                    pictureBox1.Image = Baitap1_COM.Properties.Resources.Untitled21;
                }
            }



            if (ReceiveData == "0")
            {
                if (ReceiveData == "P")
                {
                    pictureBox1.Image = Baitap1_COM.Properties.Resources.Untitled;
                }
            }


            if (ReceiveData == "9")
            {
                if (ReceiveData == "I")
                {
                    pictureBox5.Image = Baitap1_COM.Properties.Resources.Untitled;
                }
            }
           
          
            */

           

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
        string[] ports = SerialPort.GetPortNames();

            foreach (string port in ports)
            {
                ComboBox1.Items.Add(port);
            }
        }

        private void ComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.Close();
            TextBox1.BackColor = Color.Red;
            TextBox1.Text = "Disconnected!";
            serialPort1.PortName = ComboBox1.Text;
        }

        private void ComboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            serialPort1.Close();
            TextBox1.BackColor = Color.Red;
            TextBox1.Text = "Disconnected!";
            serialPort1.BaudRate = Convert.ToInt32(ComboBox2.Text);
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

       

        

        
    }
}

