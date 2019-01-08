/*
 * Created by SharpDevelop.
 * User: pham huynh
 * Date: 1/8/2019
 * Time: 8:31 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.ComponentModel;
using System.IO;
using System.Web.Script.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhamVanHuynh_baithicuoiky
{
	/// <summary>
	/// Description of MainForm.
	/// </summary>
	public partial class MainForm : Form
	{
		BindingList<ClsPoint> point;
		BindingSource source;
		ClsPoint d1 = new ClsPoint();
		ClsPoint d2 = new ClsPoint();
		duongthang line = new duongthang();
		bool isDrawing = false;
		ClsPoint cs = new ClsPoint();
		public MainForm()
		{
			//
			// The InitializeComponent() call is required for Windows Forms designer support.
			//
			InitializeComponent();
			
			//
			// TODO: Add constructor code after the InitializeComponent() call.
			//
		}
		 void paper_MouseDown(object sender, MouseEventArgs e)
        {
            isDrawing = true;
			d1.ix = e.X;
			d1.iy = e.Y;
      
            
        }
		 void paper_MouseMove(object sender, MouseEventArgs e)
        {
          System.Drawing.Graphics g = paper.CreateGraphics();
			if(isDrawing == true)
			{
			g.DrawLine(new Pen(Color.White),d1.ix,d1.iy,d2.ix,d2.iy);
			d2.ix = e.X;
			d2.iy = e.Y;
			g.DrawLine( new Pen(Color.Black),d1.ix,d1.iy,d2.ix,d2.iy);
			}    
			            
        }
		 void paper_MouseUp(object sender, MouseEventArgs e)
        {
            d2.ix = e.X;
			d2.iy = e.Y;
			System.Drawing.Graphics g = paper.CreateGraphics();
			g.DrawLine(new Pen(Color.Black,3),d1.ix,d1.iy,d2.ix,d2.iy);
			isDrawing = false;
            
        }
		void SaveClick(object sender, EventArgs e)
		{
			SaveFileDialog Save = new SaveFileDialog();
			Save.Filter = "Json Files|*.json|All Files|*.*";
			if(Save.ShowDialog() == DialogResult.OK)
			{
				string sFileName = Save.FileName;
				JavaScriptSerializer serializer = new JavaScriptSerializer();
				var json = serializer.Serialize(cs);
				StreamWriter writer ;
				writer = new StreamWriter(sFileName);
				writer.Write(json);
				writer.Close();
				MessageBox.Show("Saved !");
			}
		}
		void LoadClick(object sender, EventArgs e)
		{
           	OpenFileDialog open = new OpenFileDialog();
			open.Filter = "Json Files|*.json|All Files|*.*";
			if(open.ShowDialog() == DialogResult.OK)
			{
				string sFileName = open.FileName;
				JavaScriptSerializer serializer = new JavaScriptSerializer();
				StreamReader reader = new StreamReader(sFileName);
				string json = reader.ReadToEnd();
				reader.Close();
				var deserializeObject = serializer.Deserialize<List<ClsPoint>>(json);
				reader.Close();
				foreach (var element in deserializeObject) {
					source.Add(element);
				}
				
				MessageBox.Show("Load OK !");
			}
		}
		 
	}
}

