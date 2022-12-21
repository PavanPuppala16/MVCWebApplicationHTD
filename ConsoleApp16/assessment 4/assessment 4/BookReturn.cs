﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace assessment_4
{
    public partial class BookReturn : Form
    {
        public BookReturn()
        {
            InitializeComponent();
            GetSno();
            GetSno1();
            GetSno3();
        }
        public void GetSno()
        {
            SqlConnection con = new SqlConnection("Data Source=PAVANKUMAR;Initial catalog=PAVANKUMAR;user id=sa;password=123456");
            try
            {


                SqlDataAdapter da = new SqlDataAdapter("SP_TB_LABRARY1", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                dataGridView1.DataSource = dt;


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            public void GetSno1()
            {

                SqlConnection con = new SqlConnection("Data Source=PAVANKUMAR;Initial catalog=PAVANKUMAR;user id=sa;password=123456");
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT *  FROM LibraryStudent", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboStuId.DisplayMember = "StudentId";
                comboStuId.ValueMember = "StudentId";
                comboStuId.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }


        private void comboBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection("Data Source=PAVANKUMAR;Initial catalog=PAVANKUMAR;user id=sa;password=123456");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM  LibraryStudent  WHERE StudentId=@StudentId", con);
                cmd.Parameters.AddWithValue("@StudentId", comboStuId.SelectedValue);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    textBox1.Text = dr["StudentName"].ToString();
                    


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }
        }
        public void GetSno3()
        {
            SqlConnection con = new SqlConnection("Data Source=PAVANKUMAR;Initial catalog=PAVANKUMAR;user id=sa;password=123456");
            try
            {
                SqlDataAdapter da = new SqlDataAdapter("SELECT *  FROM  TB_LABRARY1 ", con);
                DataTable dt = new DataTable();
                da.Fill(dt);
                comboBUid.DisplayMember = "BookUid";
                comboBUid.ValueMember = "BookUid";
                comboBUid.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
            private void comboBUid_SelectedIndexChanged(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PAVANKUMAR;Initial catalog=PAVANKUMAR;user id=sa;password=123456");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TB_LABRARY1  WHERE BookUid=@BookUid", con);
                cmd.Parameters.AddWithValue("@BookUid", comboBUid.SelectedValue);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtbook.Text = dr["BookName"].ToString();
                   

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }

        }

        private void BookReturn_Load(object sender, EventArgs e)
        {

        }

        private void comboBUid_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Data Source=PAVANKUMAR;Initial catalog=PAVANKUMAR;user id=sa;password=123456");
            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand("SELECT * FROM TB_LABRARY1  WHERE BookUid=@BookUid", con);
                cmd.Parameters.AddWithValue("@BookUid", comboBUid.SelectedValue);
                SqlDataReader dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    txtbook.Text = dr["BookName"].ToString();


                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            finally
            {
                con.Close();
            }

        }
    }
    

}
