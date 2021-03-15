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
			this.FurnacesView = new System.Windows.Forms.ListView();
			this.ProductsView = new System.Windows.Forms.ListView();
			this.OrdersView = new System.Windows.Forms.ListView();
			this.ExcelLoadButton = new System.Windows.Forms.Button();
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
			// FurnacesView
			// 
			this.FurnacesView.HideSelection = false;
			this.FurnacesView.Location = new System.Drawing.Point(22, 49);
			this.FurnacesView.Name = "FurnacesView";
			this.FurnacesView.Size = new System.Drawing.Size(890, 150);
			this.FurnacesView.TabIndex = 1;
			this.FurnacesView.UseCompatibleStateImageBehavior = false;
			this.FurnacesView.View = System.Windows.Forms.View.Details;
			// 
			// ProductsView
			// 
			this.ProductsView.HideSelection = false;
			this.ProductsView.Location = new System.Drawing.Point(22, 216);
			this.ProductsView.Name = "ProductsView";
			this.ProductsView.Size = new System.Drawing.Size(890, 150);
			this.ProductsView.TabIndex = 2;
			this.ProductsView.UseCompatibleStateImageBehavior = false;
			this.ProductsView.View = System.Windows.Forms.View.Details;
			// 
			// OrdersView
			// 
			this.OrdersView.HideSelection = false;
			this.OrdersView.Location = new System.Drawing.Point(20, 384);
			this.OrdersView.Name = "OrdersView";
			this.OrdersView.Size = new System.Drawing.Size(890, 150);
			this.OrdersView.TabIndex = 3;
			this.OrdersView.UseCompatibleStateImageBehavior = false;
			this.OrdersView.View = System.Windows.Forms.View.Details;
			// 
			// ExcelLoadButton
			// 
			this.ExcelLoadButton.BackColor = System.Drawing.SystemColors.Control;
			this.ExcelLoadButton.Cursor = System.Windows.Forms.Cursors.Default;
			this.ExcelLoadButton.Font = new System.Drawing.Font("나눔고딕", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
			this.ExcelLoadButton.ForeColor = System.Drawing.Color.Black;
			this.ExcelLoadButton.Location = new System.Drawing.Point(117, 4);
			this.ExcelLoadButton.Name = "ExcelLoadButton";
			this.ExcelLoadButton.Size = new System.Drawing.Size(188, 39);
			this.ExcelLoadButton.TabIndex = 4;
			this.ExcelLoadButton.Text = "파일불러오기";
			this.ExcelLoadButton.UseVisualStyleBackColor = false;
			this.ExcelLoadButton.Click += new System.EventHandler(this.ExcelLoadButton_Click);
			// 
			// SchedulingView
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.Controls.Add(this.ExcelLoadButton);
			this.Controls.Add(this.OrdersView);
			this.Controls.Add(this.ProductsView);
			this.Controls.Add(this.FurnacesView);
			this.Controls.Add(this.TitleLabel);
			this.Name = "SchedulingView";
			this.Size = new System.Drawing.Size(940, 567);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label TitleLabel;
		private System.Windows.Forms.ListView FurnacesView;
		private System.Windows.Forms.ListView ProductsView;
		private System.Windows.Forms.ListView OrdersView;
		private System.Windows.Forms.Button ExcelLoadButton;
	}
}
