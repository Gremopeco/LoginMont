
namespace grecia
{
    partial class forlogin
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.texuser = new System.Windows.Forms.TextBox();
            this.texcontra = new System.Windows.Forms.TextBox();
            this.butingresar = new System.Windows.Forms.Button();
            this.butcancelar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 124);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "USER";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "password";
            // 
            // texuser
            // 
            this.texuser.Location = new System.Drawing.Point(53, 121);
            this.texuser.Name = "texuser";
            this.texuser.Size = new System.Drawing.Size(100, 20);
            this.texuser.TabIndex = 2;
            // 
            // texcontra
            // 
            this.texcontra.Location = new System.Drawing.Point(70, 154);
            this.texcontra.Name = "texcontra";
            this.texcontra.Size = new System.Drawing.Size(100, 20);
            this.texcontra.TabIndex = 3;
            // 
            // butingresar
            // 
            this.butingresar.Location = new System.Drawing.Point(13, 201);
            this.butingresar.Name = "butingresar";
            this.butingresar.Size = new System.Drawing.Size(75, 23);
            this.butingresar.TabIndex = 4;
            this.butingresar.Text = "ENTER";
            this.butingresar.UseVisualStyleBackColor = true;
            this.butingresar.Click += new System.EventHandler(this.butingresar_Click);
            // 
            // butcancelar
            // 
            this.butcancelar.Location = new System.Drawing.Point(95, 201);
            this.butcancelar.Name = "butcancelar";
            this.butcancelar.Size = new System.Drawing.Size(75, 23);
            this.butcancelar.TabIndex = 5;
            this.butcancelar.Text = "Cancel";
            this.butcancelar.UseVisualStyleBackColor = true;
            this.butcancelar.Click += new System.EventHandler(this.butcancelar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::grecia.Properties.Resources.uuu;
            this.pictureBox1.Location = new System.Drawing.Point(41, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // forlogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.OrangeRed;
            this.ClientSize = new System.Drawing.Size(176, 230);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.butcancelar);
            this.Controls.Add(this.butingresar);
            this.Controls.Add(this.texcontra);
            this.Controls.Add(this.texuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "forlogin";
            this.Text = "Foinicio";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texuser;
        private System.Windows.Forms.TextBox texcontra;
        private System.Windows.Forms.Button butingresar;
        private System.Windows.Forms.Button butcancelar;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}