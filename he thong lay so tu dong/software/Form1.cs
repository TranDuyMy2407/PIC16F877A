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
using System.Xml;

namespace test
{
    
    public partial class Form1 : Form
    {
        SerialPort P = new SerialPort();
  
        delegate void SetTextCallback(string text); // Khai bao delegate SetTextCallBack voi tham so string
        private void khoitao()
        {
            try
            {
                cmbTencom.DataSource = SerialPort.GetPortNames();
                if (cmbTencom.Items.Count > 0)
                    cmbTencom.SelectedIndex = 0;
            }
            catch(Exception)
            {

            }
        }
        public Form1()
        {
            InitializeComponent();
        }


        String c;
        private void Form1_Load(object sender, EventArgs e)
        {
            khoitao();
            this.P.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.P_DataReceived);
            Control.CheckForIllegalCrossThreadCalls = false;
            
        

        }

        
        String receive_data = "";
        long trans_num=0;
        int count=3;
        char []a = new  char[5] ;


        private void P_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {   
            try
            {

                
                receive_data = P.ReadTo(".");
                a = receive_data.ToCharArray();
               

                    if (a[0] == '&')
                    {
                        trans_num++;
                        if (P.IsOpen == false)
                        {
                            P.Open();
                        }
                        P.Write(trans_num.ToString("#" + "0000"));
                       P.Write(trans_num.ToString("1" + "0000"));

                       txt_service2.Text = trans_num.ToString("0000");
                       receive_char.Text = a[0].ToString();

                    }

                   if (a[0] == '@')
               {
                    trans_num++;
                    if (P.IsOpen == false)
                    {
                        P.Open();
                   }
                   P.Write(trans_num.ToString("@"+"0000"));
                    //P.Write(trans_num.ToString("1" + "0000"));
                    
                    txt_service1.Text = trans_num.ToString("0000");
                    receive_char.Text = a[0].ToString() ;
                                      
               }

                    if (a[0] == '!')
               {
                  count=0;
                   txt_ticket.Text = a[1].ToString() + a[2].ToString() + a[3].ToString() + a[4].ToString();
                   receive_char.Text = a[0].ToString();
                   
               }

                    



              

            }
            catch(Exception)
            {

            }
        }
        

        private void btnKetnoi_Click(object sender, EventArgs e)
        {
            try 
            {
                c = txt_service1.Text + txt_service2.Text;
                if(cmbTencom.Text.Trim().Length==0)
                {
                    MessageBox.Show("Vui long chon cong COM!");
                    return;
                }
                P.PortName = cmbTencom.Text;
                P.Open();
                if(P.IsOpen==true)
                {
                    btnNgatketnoi.Enabled = true;
                    btnKetnoi.Enabled = false;                
                }
                else
                {
                    btnNgatketnoi.Enabled = false;
                    btnKetnoi.Enabled = true;
                }
            }
            catch(Exception)
            {

            }
        }

        private void btnNgatketnoi_Click(object sender, EventArgs e)
        {
            try
            {
                P.Close();
                if(P.IsOpen==true)
                {
                    btnNgatketnoi.Enabled = true;
                    btnKetnoi.Enabled = false;
                }
                else
                {
                    btnNgatketnoi.Enabled = false;
                    btnKetnoi.Enabled = true;
                }

            }
            catch(Exception)
            {

            }
        }

        private void btn_send_Click(object sender, EventArgs e)
        {
            
            P.Write(count.ToString("0000"));
        }

      

        

        
    }
}
