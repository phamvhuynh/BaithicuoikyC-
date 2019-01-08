/*
 * Created by SharpDevelop.
 * User: pham huynh
 * Date: 1/8/2019
 * Time: 9:34 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Drawing;
namespace PhamVanHuynh_baithicuoiky
{
	/// <summary>
	/// Description of tamgiac.
	/// </summary>
	public class tamgiac:vehinh
	{
		public ClsPoint begin = new ClsPoint();
        public ClsPoint end = new ClsPoint();
      
        public tamgiac()
		{
			
		}
        public tamgiac (ClsPoint  a, ClsPoint b)
        {
        	begin = a;
        	end = b;
    
        }
		 public void Draw_tamgiac(Graphics g, Pen pen)
        {
            Rectangle rect = new Rectangle();
            rect.Size = new Size(end.ix - begin.ix, begin.iy-end.iy);
            rect.X = begin.ix;
		 	rect.Y = end.iy;
		 	g.DrawLine(pen,rect.X, rect.Y +rect.Height, end.ix,end.iy);
		 	g.DrawLine(pen,rect.X, rect.Y ,end.ix, end.iy);
		 	g.DrawLine(pen,rect.X, rect.Y ,end.ix - rect.Width, end.iy);
        }
//		 public override void Draw(Pen pen , Graphics g)
//		 {
//		 	
//		 	for (int i = 0; i < save.Count - 1; i += 2){
//		 		Rectangle rect = new Rectangle();
//		 		rect.Size = new Size(save[i + 1].ix - save[i].ix, save[i+1].iy-save[i].iy);
//		 		rect.X = save[i].ix;
//		 		rect.Y = save[i].iy;
//		 		g.DrawLine(pen,rect.X, rect.Y +rect.Height, save[i+1].ix, save[i+1].iy);
//		 		g.DrawLine(pen,rect.X, rect.Y , save[i+1].ix, save[i+1].iy);
//		 		g.DrawLine(pen,rect.X, rect.Y ,save[i+1].ix - rect.Width, save[i+1].iy);
//		 	}
//		 }
		 public void AddPoint()
        	{
	            try
	            {
	                save.Add(begin);
	                save.Add(end);
	            }
	            catch (Exception)
	            {
	            }
        	}
	}
}
