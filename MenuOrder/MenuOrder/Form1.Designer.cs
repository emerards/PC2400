
namespace MenuOrder
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
            this.ALL = new System.Windows.Forms.Button();
            this.라면 = new System.Windows.Forms.Button();
            this.덮밥 = new System.Windows.Forms.Button();
            this.간식 = new System.Windows.Forms.Button();
            this.튀김 = new System.Windows.Forms.Button();
            this.삭제 = new System.Windows.Forms.Button();
            this.TotalPrice = new System.Windows.Forms.TextBox();
            this.listBoxOrder = new System.Windows.Forms.ListBox();
            this.음료 = new System.Windows.Forms.Button();
            this.flowLayoutPanelMenu = new System.Windows.Forms.FlowLayoutPanel();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ALL
            // 
            this.ALL.Location = new System.Drawing.Point(12, 47);
            this.ALL.Name = "ALL";
            this.ALL.Size = new System.Drawing.Size(126, 41);
            this.ALL.TabIndex = 1;
            this.ALL.Text = "ALL";
            this.ALL.UseVisualStyleBackColor = true;
            this.ALL.Click += new System.EventHandler(this.ALL_Click);
            // 
            // 라면
            // 
            this.라면.Location = new System.Drawing.Point(12, 94);
            this.라면.Name = "라면";
            this.라면.Size = new System.Drawing.Size(126, 42);
            this.라면.TabIndex = 1;
            this.라면.Text = "라면";
            this.라면.UseVisualStyleBackColor = true;
            this.라면.Click += new System.EventHandler(this.라면_Click);
            // 
            // 덮밥
            // 
            this.덮밥.Location = new System.Drawing.Point(12, 142);
            this.덮밥.Name = "덮밥";
            this.덮밥.Size = new System.Drawing.Size(126, 43);
            this.덮밥.TabIndex = 1;
            this.덮밥.Text = "덮밥";
            this.덮밥.UseVisualStyleBackColor = true;
            this.덮밥.Click += new System.EventHandler(this.덮밥_Click);
            // 
            // 간식
            // 
            this.간식.Location = new System.Drawing.Point(12, 191);
            this.간식.Name = "간식";
            this.간식.Size = new System.Drawing.Size(126, 41);
            this.간식.TabIndex = 1;
            this.간식.Text = "간식";
            this.간식.UseVisualStyleBackColor = true;
            this.간식.Click += new System.EventHandler(this.간식_Click);
            // 
            // 튀김
            // 
            this.튀김.Location = new System.Drawing.Point(12, 238);
            this.튀김.Name = "튀김";
            this.튀김.Size = new System.Drawing.Size(126, 38);
            this.튀김.TabIndex = 1;
            this.튀김.Text = "튀김";
            this.튀김.UseVisualStyleBackColor = true;
            this.튀김.Click += new System.EventHandler(this.튀김_Click);
            // 
            // 삭제
            // 
            this.삭제.Location = new System.Drawing.Point(158, 415);
            this.삭제.Name = "삭제";
            this.삭제.Size = new System.Drawing.Size(86, 23);
            this.삭제.TabIndex = 1;
            this.삭제.Text = "삭제";
            this.삭제.UseVisualStyleBackColor = true;
            this.삭제.Click += new System.EventHandler(this.삭제_Click);
            // 
            // TotalPrice
            // 
            this.TotalPrice.Location = new System.Drawing.Point(650, 366);
            this.TotalPrice.Name = "TotalPrice";
            this.TotalPrice.Size = new System.Drawing.Size(112, 21);
            this.TotalPrice.TabIndex = 2;
            // 
            // listBoxOrder
            // 
            this.listBoxOrder.FormattingEnabled = true;
            this.listBoxOrder.ItemHeight = 12;
            this.listBoxOrder.Location = new System.Drawing.Point(18, 350);
            this.listBoxOrder.Name = "listBoxOrder";
            this.listBoxOrder.Size = new System.Drawing.Size(120, 88);
            this.listBoxOrder.TabIndex = 3;
            // 
            // 음료
            // 
            this.음료.Location = new System.Drawing.Point(12, 282);
            this.음료.Name = "음료";
            this.음료.Size = new System.Drawing.Size(126, 43);
            this.음료.TabIndex = 1;
            this.음료.Text = "음료";
            this.음료.UseVisualStyleBackColor = true;
            this.음료.Click += new System.EventHandler(this.음료_Click);
            // 
            // flowLayoutPanelMenu
            // 
            this.flowLayoutPanelMenu.Location = new System.Drawing.Point(158, 47);
            this.flowLayoutPanelMenu.Name = "flowLayoutPanelMenu";
            this.flowLayoutPanelMenu.Size = new System.Drawing.Size(604, 297);
            this.flowLayoutPanelMenu.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(650, 393);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(112, 45);
            this.button1.TabIndex = 6;
            this.button1.Text = "결제";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.flowLayoutPanelMenu);
            this.Controls.Add(this.listBoxOrder);
            this.Controls.Add(this.TotalPrice);
            this.Controls.Add(this.삭제);
            this.Controls.Add(this.튀김);
            this.Controls.Add(this.간식);
            this.Controls.Add(this.덮밥);
            this.Controls.Add(this.라면);
            this.Controls.Add(this.음료);
            this.Controls.Add(this.ALL);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button ALL;
        private System.Windows.Forms.Button 라면;
        private System.Windows.Forms.Button 덮밥;
        private System.Windows.Forms.Button 간식;
        private System.Windows.Forms.Button 튀김;
        private System.Windows.Forms.Button 삭제;
        private System.Windows.Forms.TextBox TotalPrice;
        private System.Windows.Forms.ListBox listBoxOrder;
        private System.Windows.Forms.Button 음료;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelMenu;
        private System.Windows.Forms.Button button1;
    }
}

