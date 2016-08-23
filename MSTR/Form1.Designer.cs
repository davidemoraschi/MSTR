namespace MSTR
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.txt_SessionInfo = new System.Windows.Forms.TextBox();
            this.wb_Resultado = new System.Windows.Forms.WebBrowser();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(22, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(237, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txt_SessionInfo
            // 
            this.txt_SessionInfo.Location = new System.Drawing.Point(22, 41);
            this.txt_SessionInfo.Multiline = true;
            this.txt_SessionInfo.Name = "txt_SessionInfo";
            this.txt_SessionInfo.Size = new System.Drawing.Size(237, 340);
            this.txt_SessionInfo.TabIndex = 1;
            // 
            // wb_Resultado
            // 
            this.wb_Resultado.Location = new System.Drawing.Point(265, 12);
            this.wb_Resultado.MinimumSize = new System.Drawing.Size(20, 20);
            this.wb_Resultado.Name = "wb_Resultado";
            this.wb_Resultado.Size = new System.Drawing.Size(869, 369);
            this.wb_Resultado.TabIndex = 3;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1146, 393);
            this.Controls.Add(this.wb_Resultado);
            this.Controls.Add(this.txt_SessionInfo);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txt_SessionInfo;
        private System.Windows.Forms.WebBrowser wb_Resultado;
    }
}

