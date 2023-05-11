
namespace AnimalInheritance
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
            this.lblAnimal = new System.Windows.Forms.Label();
            this.btnplay = new System.Windows.Forms.Button();
            this.cmbAnimal = new System.Windows.Forms.ComboBox();
            this.picAnimal = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picAnimal)).BeginInit();
            this.SuspendLayout();
            // 
            // lblAnimal
            // 
            this.lblAnimal.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAnimal.Location = new System.Drawing.Point(21, 38);
            this.lblAnimal.Name = "lblAnimal";
            this.lblAnimal.Size = new System.Drawing.Size(186, 31);
            this.lblAnimal.TabIndex = 0;
            this.lblAnimal.Text = "Select an Animal :";
            // 
            // btnplay
            // 
            this.btnplay.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnplay.Location = new System.Drawing.Point(302, 95);
            this.btnplay.Name = "btnplay";
            this.btnplay.Size = new System.Drawing.Size(96, 42);
            this.btnplay.TabIndex = 1;
            this.btnplay.Text = "Play";
            this.btnplay.UseVisualStyleBackColor = true;
            this.btnplay.Click += new System.EventHandler(this.button1_Click);
            // 
            // cmbAnimal
            // 
            this.cmbAnimal.Font = new System.Drawing.Font("Georgia", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbAnimal.FormattingEnabled = true;
            this.cmbAnimal.Location = new System.Drawing.Point(229, 38);
            this.cmbAnimal.Name = "cmbAnimal";
            this.cmbAnimal.Size = new System.Drawing.Size(461, 31);
            this.cmbAnimal.TabIndex = 2;
            // 
            // picAnimal
            // 
            this.picAnimal.Location = new System.Drawing.Point(25, 161);
            this.picAnimal.Name = "picAnimal";
            this.picAnimal.Size = new System.Drawing.Size(661, 245);
            this.picAnimal.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picAnimal.TabIndex = 3;
            this.picAnimal.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 450);
            this.Controls.Add(this.picAnimal);
            this.Controls.Add(this.cmbAnimal);
            this.Controls.Add(this.btnplay);
            this.Controls.Add(this.lblAnimal);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picAnimal)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblAnimal;
        private System.Windows.Forms.Button btnplay;
        private System.Windows.Forms.ComboBox cmbAnimal;
        private System.Windows.Forms.PictureBox picAnimal;
    }
}

