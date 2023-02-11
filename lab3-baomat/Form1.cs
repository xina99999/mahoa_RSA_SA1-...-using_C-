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

namespace lab3_baomat
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
       
        private void btnCalculate_Click(object sender, EventArgs e)
        {
            hextoString hst = new hextoString();
            Class1 cl1 = new Class1();
            MEthod mt = new MEthod();
            Sha1 s1 = new Sha1();
            Sha2 s2 = new Sha2();

            //ma text
            if (cbcheckbox.Text == "Text String")
            {
                if (checkHMAC.Checked == true)
                {

                    //them vao ma md5 cua day input do
                    textDataHMAC.Text = (mt.conversion(textData.Text).ToUpper());

                }
                if (checkSha1.Checked == true)
                {
                    //them vao ma SHA1 cua day input do
                    textDataSha1.Text = (s1.Hash(textData.Text).ToUpper());

                }
                if (checkSha2.Checked == true)
                {
                    //them vao ma SHA2 cua day input do
                    textDataSha2.Text = (s2.CreateSHAHash(textData.Text).ToUpper());
                }
            }

            //ma file 
            if (cbcheckbox.Text == "File text")
            {

                if (checkHMAC.Checked == true)
                {

                    //them vao ma md5 cua day input do
                    textDataHMAC.Text = (mt.conversion(textData.Text).ToUpper());

                }
                if (checkSha1.Checked == true)
                {
                    //them vao ma SHA1 cua day input do
                    textDataSha1.Text = (s1.Hash(textData.Text).ToUpper());

                }
                if (checkSha2.Checked == true)
                {
                    //them vao ma SHA2 cua day input do
                    textDataSha2.Text = (s2.CreateSHAHash(textData.Text).ToUpper());
                }
            }

            //file nhi phan 
            if(cbcheckbox.Text=="File nhị phân")
            {
                txtchange.Text = (cl1.BinaryToString(textData.Text).ToUpper());
                if (checkHMAC.Checked == true)
                {

                    //them vao ma md5 cua day input do
                    textDataHMAC.Text = (mt.conversion(txtchange.Text).ToUpper());

                }
                if (checkSha1.Checked == true)
                {
                    //them vao ma SHA1 cua day input do
                    textDataSha1.Text = (s1.Hash(txtchange.Text).ToUpper());

                }
                if (checkSha2.Checked == true)
                {
                    //them vao ma SHA2 cua day input do
                    textDataSha2.Text = (s2.CreateSHAHash(txtchange.Text).ToUpper());
                }
            }

            //ma hex
            if(cbcheckbox.Text== "Hex String")
            {
                
                txtchange.Text = (hextoString.ToHexString(textData.Text).ToUpper());
                if (checkHMAC.Checked == true)
                {

                    //them vao ma md5 cua day input do
                    textDataHMAC.Text = (mt.conversion(txtchange.Text).ToUpper());

                }
                if (checkSha1.Checked == true)
                {
                    //them vao ma SHA1 cua day input do
                    textDataSha1.Text = (s1.Hash(txtchange.Text).ToUpper());

                }
                if (checkSha2.Checked == true)
                {
                    //them vao ma SHA2 cua day input do
                    textDataSha2.Text = (s2.CreateSHAHash(txtchange.Text).ToUpper());
                }
            }
        }
       


        private void btnopen_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "|*.txt";
            if(open.ShowDialog()==DialogResult.OK)
            {
                StreamReader st = new StreamReader(open.FileName);
                textData.Text = st.ReadToEnd();
                st.Close();
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pOpen_Paint(object sender, PaintEventArgs e)
        {
            pOpen.Visible = true;
        }

        private void cbcheckbox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbcheckbox.Text == "File text") //Kiểm tra xem đã 
            {
                btnopen.Visible = true;
            }
            else if(cbcheckbox.Text=="File nhị phân") { btnopen.Visible = true; }
                else
                btnopen.Visible = false;

           
        }
    }
}
