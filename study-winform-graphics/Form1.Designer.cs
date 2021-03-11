
namespace study_winform_graphics
{
	partial class Form1
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
			this.btn_changeScheduling = new System.Windows.Forms.Button();
			this.btn_changeSchedule = new System.Windows.Forms.Button();
			this.titleBox = new System.Windows.Forms.TextBox();
			this.userView = new System.Windows.Forms.Panel();
			this.btn_changeTableLayout = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// btn_changeScheduling
			// 
			this.btn_changeScheduling.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btn_changeScheduling.Font = new System.Drawing.Font("배달의민족 주아", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btn_changeScheduling.Location = new System.Drawing.Point(12, 12);
			this.btn_changeScheduling.Name = "btn_changeScheduling";
			this.btn_changeScheduling.Size = new System.Drawing.Size(213, 69);
			this.btn_changeScheduling.TabIndex = 0;
			this.btn_changeScheduling.Text = "스케줄 생성";
			this.btn_changeScheduling.UseVisualStyleBackColor = false;
			this.btn_changeScheduling.Click += new System.EventHandler(this.componentChange);
			// 
			// btn_changeSchedule
			// 
			this.btn_changeSchedule.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btn_changeSchedule.Font = new System.Drawing.Font("배달의민족 주아", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btn_changeSchedule.Location = new System.Drawing.Point(231, 12);
			this.btn_changeSchedule.Name = "btn_changeSchedule";
			this.btn_changeSchedule.Size = new System.Drawing.Size(213, 69);
			this.btn_changeSchedule.TabIndex = 1;
			this.btn_changeSchedule.Text = "스케줄 확인";
			this.btn_changeSchedule.UseVisualStyleBackColor = false;
			this.btn_changeSchedule.Click += new System.EventHandler(this.componentChange);
			// 
			// titleBox
			// 
			this.titleBox.Font = new System.Drawing.Font("배달의민족 도현", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
			this.titleBox.Location = new System.Drawing.Point(450, 12);
			this.titleBox.Multiline = true;
			this.titleBox.Name = "titleBox";
			this.titleBox.Size = new System.Drawing.Size(338, 69);
			this.titleBox.TabIndex = 2;
			this.titleBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
			// 
			// userView
			// 
			this.userView.Location = new System.Drawing.Point(12, 173);
			this.userView.Name = "userView";
			this.userView.Size = new System.Drawing.Size(776, 351);
			this.userView.TabIndex = 3;
			// 
			// btn_changeTableLayout
			// 
			this.btn_changeTableLayout.BackColor = System.Drawing.SystemColors.ButtonFace;
			this.btn_changeTableLayout.Font = new System.Drawing.Font("배달의민족 주아", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
			this.btn_changeTableLayout.Location = new System.Drawing.Point(12, 87);
			this.btn_changeTableLayout.Name = "btn_changeTableLayout";
			this.btn_changeTableLayout.Size = new System.Drawing.Size(213, 69);
			this.btn_changeTableLayout.TabIndex = 4;
			this.btn_changeTableLayout.Text = "레이아웃 공부";
			this.btn_changeTableLayout.UseVisualStyleBackColor = false;
			this.btn_changeTableLayout.Click += new System.EventHandler(this.componentChange);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(797, 536);
			this.Controls.Add(this.btn_changeTableLayout);
			this.Controls.Add(this.userView);
			this.Controls.Add(this.titleBox);
			this.Controls.Add(this.btn_changeSchedule);
			this.Controls.Add(this.btn_changeScheduling);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_changeScheduling;
		private System.Windows.Forms.Button btn_changeSchedule;
		private System.Windows.Forms.TextBox titleBox;
		private System.Windows.Forms.Panel userView;
		private System.Windows.Forms.Button btn_changeTableLayout;
	}
}

