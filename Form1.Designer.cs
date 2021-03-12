namespace study_winform_graphics
{
	partial class Form1
	{
		/// <summary>
		/// 필수 디자이너 변수입니다.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 사용 중인 모든 리소스를 정리합니다.
		/// </summary>
		/// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 디자이너에서 생성한 코드

		/// <summary>
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.FileLoadBtn = new System.Windows.Forms.Button();
			this.MainTableLayout = new System.Windows.Forms.TableLayoutPanel();
			this.SuspendLayout();
			// 
			// FileLoadBtn
			// 
			this.FileLoadBtn.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FileLoadBtn.Location = new System.Drawing.Point(1077, 12);
			this.FileLoadBtn.Name = "FileLoadBtn";
			this.FileLoadBtn.Size = new System.Drawing.Size(207, 60);
			this.FileLoadBtn.TabIndex = 0;
			this.FileLoadBtn.Text = "ScheduleLoad";
			this.FileLoadBtn.UseVisualStyleBackColor = true;
			// 
			// MainTableLayout
			// 
			this.MainTableLayout.ColumnCount = 2;
			this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 8.309726F));
			this.MainTableLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 91.69028F));
			this.MainTableLayout.Location = new System.Drawing.Point(12, 12);
			this.MainTableLayout.Name = "MainTableLayout";
			this.MainTableLayout.RowCount = 3;
			this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 4.892087F));
			this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 5.467626F));
			this.MainTableLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 89.64029F));
			this.MainTableLayout.Size = new System.Drawing.Size(1059, 695);
			this.MainTableLayout.TabIndex = 1;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1296, 719);
			this.Controls.Add(this.MainTableLayout);
			this.Controls.Add(this.FileLoadBtn);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button FileLoadBtn;
		private System.Windows.Forms.TableLayoutPanel MainTableLayout;
	}
}

