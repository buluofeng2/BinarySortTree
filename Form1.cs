using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BinarySortTree
{
    public partial class Form1 : Form
    {
        BinaryTree t;
        public Form1()
        {
            InitializeComponent();
        }
        //提交
        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string val=txtValues.Text.ToString();
            char[] ss = { ',', ' ',' ' };
            string[] s=val.Split(ss);
            
            int[] values2,values;
            values2 = new int[s.Length];
            int i = 0,jk= s.Length;
            for(i=0;i<s.Length;i++)
            {
                if (string.IsNullOrEmpty(s[i]) == false) values2[i] = Convert.ToInt32(s[i]);
                else jk--;
            }
            values = new int[jk];
            for (i = 0; i < jk; i++)
            {
                values[i] = values2[i];
            }
            t =new BinaryTree(values);       
            string str = "";
            t.PrintTree(ref str,0,0);   
            txtTree.Text =str;
            
        }
        //搜索
        private void btnSearch_Click(object sender, EventArgs e)
        {
            int va=0;
            va = Convert.ToInt32(txtFindPoint.Text.ToString());
            TreeNode tTmp=t.SearchData(va);
            string str = "";
            if (tTmp!=null)
            {              
                t.PrintTree(ref str, tTmp .data , 1);
                txtSearchResult.ForeColor = Color.Black ;
            }
            else
            {
                str = "Sorry, there is no \"" + va.ToString() + "\" in the tree!!!";
                txtSearchResult.ForeColor = Color.Red;
            }
            
            txtSearchResult.Text = str;
        }
        //删除结点
        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int va = 0;
            va = Convert.ToInt32(txtDelPoint.Text.ToString());
            int tTmp = t.DeleteNode(va);
            string str = "";
            if (tTmp == 1)//找到了
            {

                t.PrintTree(ref str, 0, 0);
                txtDelResult.ForeColor = Color.Black;
                txtTree.Text = str;
                str = "We delete the point \"" + va.ToString() + "\" syuccessfully!!!\r\n" + str;
            }
            else
            {
                str = "Sorry, there is no \"" + va.ToString() + "\" in the tree!!!";
                txtDelResult.ForeColor = Color.Red;
            }

            txtDelResult.Text = str;
        }

        private void txtValues_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
