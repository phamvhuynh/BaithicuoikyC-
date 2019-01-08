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
	/// Description of hinhthoi.
	/// </summary>
	public class hinhthoi : vehinh
	{
		public ClsPoint begin = new ClsPoint();
        public ClsPoint end = new ClsPoint();
        public hinhthoi()
		{
			begin = new ClsPoint(0,0);
        	end = new ClsPoint(0,0);
		}
        	public hinhthoi (ClsPoint X , ClsPoint Y )
        	{
        		begin = X;
        		end = Y;
        	}
		
	}
}
