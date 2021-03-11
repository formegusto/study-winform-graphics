
namespace study_winform_graphics.view
{
	partial class TableLayoutComponent
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
			this.tableLayoutPanal = new System.Windows.Forms.TableLayoutPanel();
			this.SuspendLayout();
			// 
			// tableLayoutPanal
			// 
			this.tableLayoutPanal.ColumnCount = 2;
			this.tableLayoutPanal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanal.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanal.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tableLayoutPanal.Location = new System.Drawing.Point(0, 0);
			this.tableLayoutPanal.Name = "tableLayoutPanal";
			this.tableLayoutPanal.RowCount = 2;
			this.tableLayoutPanal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanal.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
			this.tableLayoutPanal.Size = new System.Drawing.Size(828, 461);
			this.tableLayoutPanal.TabIndex = 0;
			// 
			// TableLayoutComponent
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ControlLightLight;
			this.Controls.Add(this.tableLayoutPanal);
			this.Name = "TableLayoutComponent";
			this.Size = new System.Drawing.Size(828, 461);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.TableLayoutPanel tableLayoutPanal;
	}
}
