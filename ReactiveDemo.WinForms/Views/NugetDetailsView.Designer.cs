
namespace ReactiveDemo.Views
{
	partial class NugetDetailsView
	{
		/// <summary> 
		/// 必需的设计器变量。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary> 
		/// 清理所有正在使用的资源。
		/// </summary>
		/// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region 组件设计器生成的代码

		/// <summary> 
		/// 设计器支持所需的方法 - 不要修改
		/// 使用代码编辑器修改此方法的内容。
		/// </summary>
		private void InitializeComponent()
		{
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.IconImage = new System.Windows.Forms.PictureBox();
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.DescriptionRun = new System.Windows.Forms.Label();
			this.TitleRun = new System.Windows.Forms.LinkLabel();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.IconImage)).BeginInit();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Name = "splitContainer1";
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.Controls.Add(this.IconImage);
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.tableLayoutPanel1);
			this.splitContainer1.Size = new System.Drawing.Size(150, 150);
			this.splitContainer1.TabIndex = 0;
			// 
			// iconImage
			// 
			this.IconImage.Dock = System.Windows.Forms.DockStyle.Fill;
			this.IconImage.Location = new System.Drawing.Point(0, 0);
			this.IconImage.MaximumSize = new System.Drawing.Size(200, 200);
			this.IconImage.Name = "IconImage";
			this.IconImage.Size = new System.Drawing.Size(50, 150);
			this.IconImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
			this.IconImage.TabIndex = 0;
			this.IconImage.TabStop = false;
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.ColumnCount = 1;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.Controls.Add(this.DescriptionRun, 0, 1);
			this.tableLayoutPanel1.Controls.Add(this.TitleRun, 0, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 3;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(96, 150);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// descriptionRun
			// 
			this.DescriptionRun.AutoSize = true;
			this.DescriptionRun.Location = new System.Drawing.Point(3, 20);
			this.DescriptionRun.Name = "DescriptionRun";
			this.DescriptionRun.Size = new System.Drawing.Size(35, 13);
			this.DescriptionRun.TabIndex = 1;
			this.DescriptionRun.Text = "label2";
			// 
			// titleRun
			// 
			this.TitleRun.AutoSize = true;
			this.TitleRun.Location = new System.Drawing.Point(3, 0);
			this.TitleRun.Name = "TitleRun";
			this.TitleRun.Size = new System.Drawing.Size(55, 13);
			this.TitleRun.TabIndex = 2;
			this.TitleRun.TabStop = true;
			this.TitleRun.Text = "linkLabel1";
			// 
			// NugetDetailsView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.splitContainer1);
			this.Name = "NugetDetailsView";
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.IconImage)).EndInit();
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
		}

		#endregion

		private System.Windows.Forms.SplitContainer splitContainer1;
		private System.Windows.Forms.PictureBox IconImage;
		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label DescriptionRun;
		private System.Windows.Forms.LinkLabel TitleRun;
	}
}
