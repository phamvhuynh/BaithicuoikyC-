/*
 * Created by SharpDevelop.
 * User: pham huynh
 * Date: 1/8/2019
 * Time: 8:31 AM
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace PhamVanHuynh_baithicuoiky
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.ToolStrip toolStrip1;
		private System.Windows.Forms.ToolStripButton save;
		private System.Windows.Forms.ToolStripButton duongthang;
		private System.Windows.Forms.ToolStripButton txthinhthoi;
		private System.Windows.Forms.ToolStripButton txttamgiac;
		private System.Windows.Forms.PictureBox paper;
		private System.Windows.Forms.ToolStripButton Load;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
			this.toolStrip1 = new System.Windows.Forms.ToolStrip();
			this.save = new System.Windows.Forms.ToolStripButton();
			this.Load = new System.Windows.Forms.ToolStripButton();
			this.duongthang = new System.Windows.Forms.ToolStripButton();
			this.txthinhthoi = new System.Windows.Forms.ToolStripButton();
			this.txttamgiac = new System.Windows.Forms.ToolStripButton();
			this.paper = new System.Windows.Forms.PictureBox();
			this.toolStrip1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.paper)).BeginInit();
			this.SuspendLayout();
			// 
			// toolStrip1
			// 
			this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.save,
			this.Load,
			this.duongthang,
			this.txthinhthoi,
			this.txttamgiac});
			this.toolStrip1.Location = new System.Drawing.Point(0, 0);
			this.toolStrip1.Name = "toolStrip1";
			this.toolStrip1.Size = new System.Drawing.Size(636, 38);
			this.toolStrip1.TabIndex = 0;
			this.toolStrip1.Text = "toolStrip1";
			// 
			// save
			// 
			this.save.Image = ((System.Drawing.Image)(resources.GetObject("save.Image")));
			this.save.ImageTransparentColor = System.Drawing.Color.Crimson;
			this.save.Name = "save";
			this.save.Size = new System.Drawing.Size(35, 35);
			this.save.Text = "Save";
			this.save.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.save.Click += new System.EventHandler(this.SaveClick);
			// 
			// Load
			// 
			this.Load.Image = ((System.Drawing.Image)(resources.GetObject("Load.Image")));
			this.Load.ImageTransparentColor = System.Drawing.Color.Crimson;
			this.Load.Name = "Load";
			this.Load.Size = new System.Drawing.Size(37, 35);
			this.Load.Text = "Load";
			this.Load.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			this.Load.Click += new System.EventHandler(this.LoadClick);
			// 
			// duongthang
			// 
			this.duongthang.Image = ((System.Drawing.Image)(resources.GetObject("duongthang.Image")));
			this.duongthang.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.duongthang.Name = "duongthang";
			this.duongthang.Size = new System.Drawing.Size(77, 35);
			this.duongthang.Text = "duongthang";
			this.duongthang.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// txthinhthoi
			// 
			this.txthinhthoi.Image = ((System.Drawing.Image)(resources.GetObject("txthinhthoi.Image")));
			this.txthinhthoi.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.txthinhthoi.Name = "txthinhthoi";
			this.txthinhthoi.Size = new System.Drawing.Size(56, 35);
			this.txthinhthoi.Text = "hinhthoi";
			this.txthinhthoi.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// txttamgiac
			// 
			this.txttamgiac.Image = ((System.Drawing.Image)(resources.GetObject("txttamgiac.Image")));
			this.txttamgiac.ImageTransparentColor = System.Drawing.Color.Magenta;
			this.txttamgiac.Name = "txttamgiac";
			this.txttamgiac.Size = new System.Drawing.Size(54, 35);
			this.txttamgiac.Text = "tamgiac";
			this.txttamgiac.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
			// 
			// paper
			// 
			this.paper.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
			this.paper.Cursor = System.Windows.Forms.Cursors.Cross;
			this.paper.Location = new System.Drawing.Point(12, 41);
			this.paper.Name = "paper";
			this.paper.Size = new System.Drawing.Size(600, 219);
			this.paper.TabIndex = 1;
			this.paper.TabStop = false;
			this.paper.MouseDown += new System.Windows.Forms.MouseEventHandler(this.paper_MouseDown);
			this.paper.MouseMove += new System.Windows.Forms.MouseEventHandler(this.paper_MouseMove);
			this.paper.MouseUp += new System.Windows.Forms.MouseEventHandler(this.paper_MouseUp);
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(636, 311);
			this.Controls.Add(this.paper);
			this.Controls.Add(this.toolStrip1);
			this.Name = "MainForm";
			this.Text = "PhamVanHuynh_baithicuoiky";
			this.toolStrip1.ResumeLayout(false);
			this.toolStrip1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.paper)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
