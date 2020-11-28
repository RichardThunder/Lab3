using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Windows.Forms;
namespace Lab3
{
    public partial class Picture : System.Web.UI.Page
    {

        static string fileName;
        static int count= System.IO.Directory.GetFiles(@"G:/web/Lab3/Image/").Length;//读取文件夹下图片数量来初始化Count计数器
        static int COUNTNOW = count;//当前页面位置
        //int MAX = 100;//
        //static String[] FILENAME = new String[100];//eexb
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Submit_Click(object sender, EventArgs e)
        {
            if(this.Upload.HasFile)
            { 
                count++;
                COUNTNOW = count;
                fileName = Upload.FileName;
                string strExt = System.IO.Path.GetExtension(fileName);
                string savePath = @"G:/web/Lab3/Image/" +count+".jpg";
              
                Upload.SaveAs(savePath);
                Image1.ImageUrl = "http://127.0.0.1:1677/Image/" + count +".jpg";
               
            }
        }
        protected void Former_Click(object sender, EventArgs e)
        {
            if (COUNTNOW == 1)
            {
                System.Windows.Forms.MessageBox.Show("已经是第一个文件了!", "error");///
                return;
            }
            if (count ==0 )
            {
                System.Windows.Forms.MessageBox.Show("没有图片,请上传!", "error");
                return;
            }
            COUNTNOW--;
            Image1.ImageUrl = "http://127.0.0.1:1677/Image/" + COUNTNOW + ".jpg";
           
        }

        protected void Next_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                System.Windows.Forms.MessageBox.Show("没有图片,请上传!", "error");
                return;
            }
            if (COUNTNOW == count)
            {
                System.Windows.Forms.MessageBox.Show("已经是最后一个文件了!", "error");
                return;
            }
            COUNTNOW++;
            Image1.ImageUrl = "http://127.0.0.1:1677/Image/" + COUNTNOW + ".jpg";
        }

        protected void Last_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                System.Windows.Forms.MessageBox.Show("没有图片,请上传!", "error");
                return;
            }
            Image1.ImageUrl = "http://127.0.0.1:1677/Image/" + count + ".jpg";
            COUNTNOW = count;
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (count == 0)
            {
                System.Windows.Forms.MessageBox.Show("没有图片,请上传!", "error");
                return;
            }
            Image1.ImageUrl = "http://127.0.0.1:1677/Image/" + 1 +".jpg";
            COUNTNOW = 1;
        }
    }
}