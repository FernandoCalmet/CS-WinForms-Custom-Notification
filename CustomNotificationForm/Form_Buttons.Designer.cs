namespace CustomNotificationForm
{
    partial class Form_Buttons
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSuccess = new System.Windows.Forms.Button();
            this.buttonWarning = new System.Windows.Forms.Button();
            this.buttonError = new System.Windows.Forms.Button();
            this.buttonInfo = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnSuccess
            // 
            this.btnSuccess.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.btnSuccess.FlatAppearance.BorderSize = 0;
            this.btnSuccess.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSuccess.ForeColor = System.Drawing.Color.White;
            this.btnSuccess.Location = new System.Drawing.Point(184, 12);
            this.btnSuccess.Name = "btnSuccess";
            this.btnSuccess.Size = new System.Drawing.Size(220, 79);
            this.btnSuccess.TabIndex = 0;
            this.btnSuccess.Text = "Success";
            this.btnSuccess.UseVisualStyleBackColor = false;
            this.btnSuccess.Click += new System.EventHandler(this.btnSuccess_Click);
            // 
            // buttonWarning
            // 
            this.buttonWarning.BackColor = System.Drawing.Color.DarkOrange;
            this.buttonWarning.FlatAppearance.BorderSize = 0;
            this.buttonWarning.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonWarning.ForeColor = System.Drawing.Color.White;
            this.buttonWarning.Location = new System.Drawing.Point(184, 97);
            this.buttonWarning.Name = "buttonWarning";
            this.buttonWarning.Size = new System.Drawing.Size(220, 79);
            this.buttonWarning.TabIndex = 1;
            this.buttonWarning.Text = "Warning";
            this.buttonWarning.UseVisualStyleBackColor = false;
            this.buttonWarning.Click += new System.EventHandler(this.buttonWarning_Click);
            // 
            // buttonError
            // 
            this.buttonError.BackColor = System.Drawing.Color.DarkRed;
            this.buttonError.FlatAppearance.BorderSize = 0;
            this.buttonError.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonError.ForeColor = System.Drawing.Color.White;
            this.buttonError.Location = new System.Drawing.Point(184, 182);
            this.buttonError.Name = "buttonError";
            this.buttonError.Size = new System.Drawing.Size(220, 79);
            this.buttonError.TabIndex = 2;
            this.buttonError.Text = "Error";
            this.buttonError.UseVisualStyleBackColor = false;
            this.buttonError.Click += new System.EventHandler(this.buttonError_Click);
            // 
            // buttonInfo
            // 
            this.buttonInfo.BackColor = System.Drawing.Color.RoyalBlue;
            this.buttonInfo.FlatAppearance.BorderSize = 0;
            this.buttonInfo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonInfo.ForeColor = System.Drawing.Color.White;
            this.buttonInfo.Location = new System.Drawing.Point(184, 267);
            this.buttonInfo.Name = "buttonInfo";
            this.buttonInfo.Size = new System.Drawing.Size(220, 79);
            this.buttonInfo.TabIndex = 3;
            this.buttonInfo.Text = "Info";
            this.buttonInfo.UseVisualStyleBackColor = false;
            this.buttonInfo.Click += new System.EventHandler(this.buttonInfo_Click);
            // 
            // Form_Buttons
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(601, 361);
            this.Controls.Add(this.buttonInfo);
            this.Controls.Add(this.buttonError);
            this.Controls.Add(this.buttonWarning);
            this.Controls.Add(this.btnSuccess);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form_Buttons";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "github.com/fernandocalmet";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnSuccess;
        private System.Windows.Forms.Button buttonWarning;
        private System.Windows.Forms.Button buttonError;
        private System.Windows.Forms.Button buttonInfo;
    }
}

