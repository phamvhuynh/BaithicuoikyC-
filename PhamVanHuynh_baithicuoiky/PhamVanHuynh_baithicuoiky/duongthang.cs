/*
 * Created by SharpDevelop.
 * User: pham huynh
 * Date: 1/8/2019
 * Time: 9:31 AM
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
	/// Description of duongthang.
	/// </summary>
	public class duongthang : vehinh
	{
		public ClsPoint begin = new ClsPoint();
        public ClsPoint end = new ClsPoint();
        public duongthang()
		{
			begin = new ClsPoint(0,0);
        	end = new ClsPoint(0,0);
		}
        	public duongthang (ClsPoint A , ClsPoint B )
        	{
        		begin = A;
        		end = B;
        	}
        	 /// <summary>
	        /// </summary>
	        /// <param name="g"></param>
	        /// <param name="pen"></param>
        	public  void Draw(Graphics g, Pen pen)
        	{
            	foreach (var item in save)
            	{
                	for (int i = 0; i < save.Count - 1; i += 2)
                	{
                    g.DrawLine(pen, save[i].ix, save[i].iy, save[i + 1].ix, save[i + 1].iy);
                	}
            	}
        	}
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
