
namespace XO.Connectors
{
    partial class GameView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txt_Choice1 = new System.Windows.Forms.TextBox();
            this.btn_gamePlay = new System.Windows.Forms.Button();
            this.lbl_matrix = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_Choice1
            // 
            this.txt_Choice1.Location = new System.Drawing.Point(208, 133);
            this.txt_Choice1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txt_Choice1.Name = "txt_Choice1";
            this.txt_Choice1.Size = new System.Drawing.Size(68, 20);
            this.txt_Choice1.TabIndex = 0;
            // 
            // btn_gamePlay
            // 
            this.btn_gamePlay.Location = new System.Drawing.Point(214, 200);
            this.btn_gamePlay.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btn_gamePlay.Name = "btn_gamePlay";
            this.btn_gamePlay.Size = new System.Drawing.Size(50, 34);
            this.btn_gamePlay.TabIndex = 2;
            this.btn_gamePlay.Text = "PLAY";
            this.btn_gamePlay.UseVisualStyleBackColor = true;
            this.btn_gamePlay.Click += new System.EventHandler(this.btn_gamePlay_Click);
            // 
            // lbl_matrix
            // 
            this.lbl_matrix.AutoSize = true;
            this.lbl_matrix.Location = new System.Drawing.Point(221, 55);
            this.lbl_matrix.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbl_matrix.Name = "lbl_matrix";
            this.lbl_matrix.Size = new System.Drawing.Size(35, 13);
            this.lbl_matrix.TabIndex = 3;
            this.lbl_matrix.Text = "label1";
            // 
            // GameView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 352);
            this.Controls.Add(this.lbl_matrix);
            this.Controls.Add(this.btn_gamePlay);
            this.Controls.Add(this.txt_Choice1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "GameView";
            this.Text = "GameView";          
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public  System.Windows.Forms.TextBox txt_Choice1;
        public System.Windows.Forms.Button btn_gamePlay;
        public System.Windows.Forms.Label lbl_matrix;
    }
}