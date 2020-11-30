
namespace ReactiveDemo
{
	partial class MainWindow
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
			this.label1 = new System.Windows.Forms.Label();
			this.SearchTextBox = new System.Windows.Forms.TextBox();
			this.SearchResultsListBox = new System.Windows.Forms.TableLayoutPanel();
			this.tableLayoutPanel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// tableLayoutPanel1
			// 
			this.tableLayoutPanel1.AutoSize = true;
			this.tableLayoutPanel1.ColumnCount = 2;
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.375F));
			this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 79.625F));
			this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
			this.tableLayoutPanel1.Controls.Add(this.SearchTextBox, 1, 0);
			this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanel1.Name = "tableLayoutPanel1";
			this.tableLayoutPanel1.RowCount = 1;
			this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 23F));
			this.tableLayoutPanel1.Size = new System.Drawing.Size(800, 23);
			this.tableLayoutPanel1.TabIndex = 0;
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.label1.Location = new System.Drawing.Point(3, 0);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(157, 23);
			this.label1.TabIndex = 0;
			this.label1.Text = "Search For:";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// searchTextBox
			// 
			this.SearchTextBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SearchTextBox.Location = new System.Drawing.Point(166, 3);
			this.SearchTextBox.Name = "SearchTextBox";
			this.SearchTextBox.Size = new System.Drawing.Size(631, 21);
			this.SearchTextBox.TabIndex = 1;
			// 
			// searchResultsListBox
			// 
			this.SearchResultsListBox.AutoScroll = true;
			this.SearchResultsListBox.ColumnCount = 1;
			this.SearchResultsListBox.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.SearchResultsListBox.Dock = System.Windows.Forms.DockStyle.Fill;
			this.SearchResultsListBox.Location = new System.Drawing.Point(0, 23);
			this.SearchResultsListBox.Name = "SearchResultsListBox";
			this.SearchResultsListBox.RowCount = 1;
			this.SearchResultsListBox.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
			this.SearchResultsListBox.Size = new System.Drawing.Size(800, 392);
			this.SearchResultsListBox.TabIndex = 1;
			// 
			// MainWindow
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(800, 415);
			this.Controls.Add(this.SearchResultsListBox);
			this.Controls.Add(this.tableLayoutPanel1);
			this.Name = "MainWindow";
			this.Text = "ReactiveUI WinForms NuGet Demo";
			this.tableLayoutPanel1.ResumeLayout(false);
			this.tableLayoutPanel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox SearchTextBox;
		private System.Windows.Forms.TableLayoutPanel SearchResultsListBox;
	}
}

