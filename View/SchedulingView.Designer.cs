namespace mvc_pattern.View
{
	partial class SchedulingView
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

		#region 구성 요소 디자이너에서 생성한 코드

		/// <summary> 
		/// 디자이너 지원에 필요한 메서드입니다. 
		/// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
		/// </summary>
		private void InitializeComponent()
		{
			this.TitleLabel = new System.Windows.Forms.Label();
			this.listView1 = new System.Windows.Forms.ListView();
			this.listView2 = new System.Windows.Forms.ListView();
			this.listView3 = new System.Windows.Forms.ListView();
			this.SuspendLayout();
			// 
			// TitleLabel
			// 
			this.TitleLabel.AutoSize = true;
			this.TitleLabel.Font = new System.Drawing.Font("나눔손글씨 붓", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.TitleLabel.Location = new System.Drawing.Point(18, 14);
			this.TitleLabel.Name = "TitleLabel";
			this.TitleLabel.Size = new System.Drawing.Size(83, 21);
			this.TitleLabel.TabIndex = 0;
			this.TitleLabel.Text = "스케줄링 View";
			// 
			// listView1
			// 
			this.listView1.HideSelection = false;
			this.listView1.Location = new System.Drawing.Point(22, 49);
			this.listView1.Name = "listView1";
			this.listView1.Size = new System.Drawing.Size(890, 150);
			this.listView1.TabIndex = 1;
			this.listView1.UseCompatibleStateImageBehavior = false;
			// 
			// listView2
			// 
			this.listView2.HideSelection = false;
			this.listView2.Location = new System.Drawing.Point(22, 216);
			this.listView2.Name = "listView2";
			this.listView2.Size = new System.Drawing.Size(890, 150);
			this.listView2.TabIndex = 2;
			this.listView2.UseCompatibleStateImageBehavior = false;
			// 
			// listView3
			// 
			this.listView3.HideSelection = false;
			this.listView3.Location = new System.Drawing.Point(20, 384);
			this.listView3.Name = "listView3";
			this.listView3.Size = new System.Drawing.Size(890, 150);
			this.listView3.TabIndex = 3;
			this.listView3.UseCompatibleStateImageBehavior = false;
			// 
			// SchedulingView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.listView3);
			this.Controls.Add(this.listView2);
			this.Controls.Add(this.listView1);
			this.Controls.Add(this.TitleLabel);
			this.Name = "SchedulingView";
			this.Size = new System.Drawing.Size(940, 567);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.ListView listView1;
		private System.Windows.Forms.ListView listView2;
		private System.Windows.Forms.ListView listView3;
	}
}
