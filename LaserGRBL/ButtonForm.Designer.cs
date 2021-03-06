﻿/*
 * Created by SharpDevelop.
 * User: Diego
 * Date: 05/12/2016
 * Time: 23:57
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
namespace LaserGRBL
{
	partial class ButtonForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel8;
		private LaserGRBL.UserControls.ImageButton BtnReset;
		private LaserGRBL.UserControls.ImageButton BtnGoHome;
		private LaserGRBL.UserControls.ImageButton BtnStop;
		private LaserGRBL.UserControls.ImageButton BtnResume;
		
		/// <summary>
		/// Disposes resources used by the control.
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ButtonForm));
			this.tableLayoutPanel8 = new System.Windows.Forms.TableLayoutPanel();
			this.BtnReset = new LaserGRBL.UserControls.ImageButton();
			this.BtnGoHome = new LaserGRBL.UserControls.ImageButton();
			this.BtnStop = new LaserGRBL.UserControls.ImageButton();
			this.BtnResume = new LaserGRBL.UserControls.ImageButton();
			this.tableLayoutPanel8.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel8
			// 
			this.tableLayoutPanel8.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
			this.tableLayoutPanel8.BackColor = System.Drawing.SystemColors.Control;
			this.tableLayoutPanel8.ColumnCount = 5;
			this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel8.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
			this.tableLayoutPanel8.Controls.Add(this.BtnReset, 4, 0);
			this.tableLayoutPanel8.Controls.Add(this.BtnGoHome, 0, 0);
			this.tableLayoutPanel8.Controls.Add(this.BtnStop, 1, 0);
			this.tableLayoutPanel8.Controls.Add(this.BtnResume, 2, 0);
			this.tableLayoutPanel8.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel8.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel8.Margin = new System.Windows.Forms.Padding(1);
			this.tableLayoutPanel8.Name = "tableLayoutPanel8";
			this.tableLayoutPanel8.RowCount = 1;
			this.tableLayoutPanel8.RowStyles.Add(new System.Windows.Forms.RowStyle());
			this.tableLayoutPanel8.Size = new System.Drawing.Size(419, 56);
			this.tableLayoutPanel8.TabIndex = 4;
			// 
			// BtnReset
			// 
			this.BtnReset.AltImage = null;
			this.BtnReset.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.BtnReset.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BtnReset.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BtnReset.Coloration = System.Drawing.Color.Empty;
			this.BtnReset.Enabled = false;
			this.BtnReset.Image = ((System.Drawing.Image)(resources.GetObject("BtnReset.Image")));
			this.BtnReset.Location = new System.Drawing.Point(367, 3);
			this.BtnReset.Name = "BtnReset";
			this.BtnReset.Size = new System.Drawing.Size(49, 49);
			this.BtnReset.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
			this.BtnReset.TabIndex = 4;
			this.BtnReset.UseAltImage = false;
			this.BtnReset.Click += new System.EventHandler(this.BtnResetClick);
			// 
			// BtnGoHome
			// 
			this.BtnGoHome.AltImage = null;
			this.BtnGoHome.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.BtnGoHome.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BtnGoHome.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BtnGoHome.Coloration = System.Drawing.Color.Empty;
			this.BtnGoHome.Enabled = false;
			this.BtnGoHome.Image = ((System.Drawing.Image)(resources.GetObject("BtnGoHome.Image")));
			this.BtnGoHome.Location = new System.Drawing.Point(3, 3);
			this.BtnGoHome.Name = "BtnGoHome";
			this.BtnGoHome.Size = new System.Drawing.Size(49, 49);
			this.BtnGoHome.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
			this.BtnGoHome.TabIndex = 3;
			this.BtnGoHome.UseAltImage = false;
			this.BtnGoHome.Click += new System.EventHandler(this.BtnGoHomeClick);
			// 
			// BtnStop
			// 
			this.BtnStop.AltImage = ((System.Drawing.Image)(resources.GetObject("BtnStop.AltImage")));
			this.BtnStop.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.BtnStop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BtnStop.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BtnStop.Coloration = System.Drawing.Color.Empty;
			this.BtnStop.Enabled = false;
			this.BtnStop.Image = ((System.Drawing.Image)(resources.GetObject("BtnStop.Image")));
			this.BtnStop.Location = new System.Drawing.Point(58, 3);
			this.BtnStop.Name = "BtnStop";
			this.BtnStop.Size = new System.Drawing.Size(49, 49);
			this.BtnStop.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
			this.BtnStop.TabIndex = 5;
			this.BtnStop.UseAltImage = false;
			this.BtnStop.Click += new System.EventHandler(this.BtnStopClick);
			// 
			// BtnResume
			// 
			this.BtnResume.AltImage = null;
			this.BtnResume.Anchor = System.Windows.Forms.AnchorStyles.None;
			this.BtnResume.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
			this.BtnResume.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.BtnResume.Coloration = System.Drawing.Color.Empty;
			this.BtnResume.Enabled = false;
			this.BtnResume.Image = ((System.Drawing.Image)(resources.GetObject("BtnResume.Image")));
			this.BtnResume.Location = new System.Drawing.Point(113, 3);
			this.BtnResume.Name = "BtnResume";
			this.BtnResume.Size = new System.Drawing.Size(49, 49);
			this.BtnResume.SizingMode = LaserGRBL.UserControls.ImageButton.SizingModes.FixedSize;
			this.BtnResume.TabIndex = 6;
			this.BtnResume.UseAltImage = false;
			this.BtnResume.Click += new System.EventHandler(this.BtnResumeClick);
			// 
			// ButtonForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(419, 56);
			this.CloseButton = false;
			this.CloseButtonVisible = false;
			this.Controls.Add(this.tableLayoutPanel8);
			this.DockAreas = ((LaserGRBL.UserControls.DockingManager.DockAreas)(((((LaserGRBL.UserControls.DockingManager.DockAreas.Float | LaserGRBL.UserControls.DockingManager.DockAreas.DockLeft) 
			| LaserGRBL.UserControls.DockingManager.DockAreas.DockRight) 
			| LaserGRBL.UserControls.DockingManager.DockAreas.DockTop) 
			| LaserGRBL.UserControls.DockingManager.DockAreas.DockBottom)));
			this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "ButtonForm";
			this.ShowHint = LaserGRBL.UserControls.DockingManager.DockState.DockBottom;
			this.tableLayoutPanel8.ResumeLayout(false);
			this.ResumeLayout(false);

		}
	}
}
