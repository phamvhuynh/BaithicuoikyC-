/*
 * Created by SharpDevelop.
 * User: pham huynh
 * Date: 1/8/2019
 * Time: 8:55 AM
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
	/// Description of vehinh.
	/// </summary>
	public class vehinh
	{
		public List<ClsPoint> save = new List<ClsPoint>();
		
		public vehinh()
		{
		}
		/// <summary>
        /// </summary>
        /// <param name="input"></param>
        /// <param name="input_Name"></param>
        public void LoadData(Dictionary<string, List<ClsPoint>> input, string input_Name)
        {
            foreach (var item in input)
            {
                if (item.Key == input_Name)
                {
                    save = item.Value;
                }
            }
        }
        public List<ClsPoint> SaveData()
        {
            List<ClsPoint> temp = new List<ClsPoint>();
            temp = save;
            return temp;
        }
	}
}
