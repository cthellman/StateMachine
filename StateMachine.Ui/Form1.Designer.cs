
namespace StateMachine.Ui
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
            this.btn_play = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.btn_pause = new System.Windows.Forms.Button();
            this.btn_rew = new System.Windows.Forms.Button();
            this.btn_ff = new System.Windows.Forms.Button();
            this.btn_rec = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_play
            // 
            this.btn_play.Location = new System.Drawing.Point(14, 39);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(75, 23);
            this.btn_play.TabIndex = 0;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = true;
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(95, 39);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 1;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            // 
            // btn_pause
            // 
            this.btn_pause.Location = new System.Drawing.Point(257, 39);
            this.btn_pause.Name = "btn_pause";
            this.btn_pause.Size = new System.Drawing.Size(75, 23);
            this.btn_pause.TabIndex = 2;
            this.btn_pause.Text = "Pause";
            this.btn_pause.UseVisualStyleBackColor = true;
            // 
            // btn_rew
            // 
            this.btn_rew.Location = new System.Drawing.Point(419, 39);
            this.btn_rew.Name = "btn_rew";
            this.btn_rew.Size = new System.Drawing.Size(75, 23);
            this.btn_rew.TabIndex = 3;
            this.btn_rew.Text = "REW";
            this.btn_rew.UseVisualStyleBackColor = true;
            // 
            // btn_ff
            // 
            this.btn_ff.Location = new System.Drawing.Point(338, 39);
            this.btn_ff.Name = "btn_ff";
            this.btn_ff.Size = new System.Drawing.Size(75, 23);
            this.btn_ff.TabIndex = 4;
            this.btn_ff.Text = "FF";
            this.btn_ff.UseVisualStyleBackColor = true;
            // 
            // btn_rec
            // 
            this.btn_rec.Location = new System.Drawing.Point(176, 39);
            this.btn_rec.Name = "btn_rec";
            this.btn_rec.Size = new System.Drawing.Size(75, 23);
            this.btn_rec.TabIndex = 5;
            this.btn_rec.Text = "Rec";
            this.btn_rec.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.WindowText;
            this.textBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.textBox1.Location = new System.Drawing.Point(12, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(482, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.SystemColors.Desktop;
            this.textBox2.Font = new System.Drawing.Font("Fira Code", 8.249999F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.ForeColor = System.Drawing.Color.Lime;
            this.textBox2.Location = new System.Drawing.Point(14, 69);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(480, 169);
            this.textBox2.TabIndex = 7;
            this.textBox2.Text = "Log";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(506, 250);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_rec);
            this.Controls.Add(this.btn_ff);
            this.Controls.Add(this.btn_rew);
            this.Controls.Add(this.btn_pause);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_play);
            this.Name = "Form1";
            this.Text = "Transport";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.Button btn_pause;
        private System.Windows.Forms.Button btn_rew;
        private System.Windows.Forms.Button btn_ff;
        private System.Windows.Forms.Button btn_rec;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}

