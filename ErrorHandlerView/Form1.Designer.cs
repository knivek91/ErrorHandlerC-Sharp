namespace ErrorHandlerView
{
    partial class frmErrorHandlerView
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
            this.btnGenerarError = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnGenerarError
            // 
            this.btnGenerarError.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerarError.Location = new System.Drawing.Point(13, 13);
            this.btnGenerarError.Name = "btnGenerarError";
            this.btnGenerarError.Size = new System.Drawing.Size(230, 130);
            this.btnGenerarError.TabIndex = 0;
            this.btnGenerarError.Text = "Generar Error";
            this.btnGenerarError.UseVisualStyleBackColor = true;
            this.btnGenerarError.Click += new System.EventHandler(this.btnGenerarError_Click);
            // 
            // frmErrorHandlerView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(255, 155);
            this.Controls.Add(this.btnGenerarError);
            this.Name = "frmErrorHandlerView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Error Handler View";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnGenerarError;
    }
}

