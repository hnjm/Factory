﻿namespace FactorySys
{
    partial class frmORDENES
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmORDENES));
            this.dgvORDENES = new System.Windows.Forms.DataGridView();
            this.btnAGREGAR = new System.Windows.Forms.Button();
            this.btnMODIFICAR = new System.Windows.Forms.Button();
            this.btnSALIR = new System.Windows.Forms.Button();
            this.btnELIMINAR = new System.Windows.Forms.Button();
            this.btnBUSCAR = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btnVERIFICAR = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvORDENES)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvORDENES
            // 
            this.dgvORDENES.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvORDENES.Location = new System.Drawing.Point(8, 23);
            this.dgvORDENES.Margin = new System.Windows.Forms.Padding(4);
            this.dgvORDENES.Name = "dgvORDENES";
            this.dgvORDENES.Size = new System.Drawing.Size(1119, 442);
            this.dgvORDENES.TabIndex = 2;
            // 
            // btnAGREGAR
            // 
            this.btnAGREGAR.Image = global::FactorySys.Properties.Resources.add;
            this.btnAGREGAR.Location = new System.Drawing.Point(163, 473);
            this.btnAGREGAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnAGREGAR.Name = "btnAGREGAR";
            this.btnAGREGAR.Size = new System.Drawing.Size(147, 55);
            this.btnAGREGAR.TabIndex = 3;
            this.btnAGREGAR.Text = "Agregar";
            this.btnAGREGAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnAGREGAR.UseVisualStyleBackColor = true;
            this.btnAGREGAR.Click += new System.EventHandler(this.btnAGREGAR_Click);
            // 
            // btnMODIFICAR
            // 
            this.btnMODIFICAR.Image = global::FactorySys.Properties.Resources.file_edit;
            this.btnMODIFICAR.Location = new System.Drawing.Point(317, 473);
            this.btnMODIFICAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnMODIFICAR.Name = "btnMODIFICAR";
            this.btnMODIFICAR.Size = new System.Drawing.Size(147, 55);
            this.btnMODIFICAR.TabIndex = 4;
            this.btnMODIFICAR.Text = "Modificar";
            this.btnMODIFICAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnMODIFICAR.UseVisualStyleBackColor = true;
            this.btnMODIFICAR.Click += new System.EventHandler(this.btnMODIFICAR_Click);
            // 
            // btnSALIR
            // 
            this.btnSALIR.Image = global::FactorySys.Properties.Resources.home;
            this.btnSALIR.Location = new System.Drawing.Point(980, 473);
            this.btnSALIR.Margin = new System.Windows.Forms.Padding(4);
            this.btnSALIR.Name = "btnSALIR";
            this.btnSALIR.Size = new System.Drawing.Size(147, 55);
            this.btnSALIR.TabIndex = 5;
            this.btnSALIR.Text = "Salir";
            this.btnSALIR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSALIR.UseVisualStyleBackColor = true;
            this.btnSALIR.Click += new System.EventHandler(this.btnSALIR_Click);
            // 
            // btnELIMINAR
            // 
            this.btnELIMINAR.Image = global::FactorySys.Properties.Resources.delete;
            this.btnELIMINAR.Location = new System.Drawing.Point(472, 473);
            this.btnELIMINAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnELIMINAR.Name = "btnELIMINAR";
            this.btnELIMINAR.Size = new System.Drawing.Size(147, 55);
            this.btnELIMINAR.TabIndex = 6;
            this.btnELIMINAR.Text = "Eliminar";
            this.btnELIMINAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnELIMINAR.UseVisualStyleBackColor = true;
            this.btnELIMINAR.Click += new System.EventHandler(this.btnELIMINAR_Click);
            // 
            // btnBUSCAR
            // 
            this.btnBUSCAR.Image = global::FactorySys.Properties.Resources.find;
            this.btnBUSCAR.Location = new System.Drawing.Point(8, 473);
            this.btnBUSCAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnBUSCAR.Name = "btnBUSCAR";
            this.btnBUSCAR.Size = new System.Drawing.Size(147, 55);
            this.btnBUSCAR.TabIndex = 4;
            this.btnBUSCAR.Text = "BUSCAR";
            this.btnBUSCAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnBUSCAR.UseVisualStyleBackColor = true;
            this.btnBUSCAR.Click += new System.EventHandler(this.btnBUSCAR_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.btnVERIFICAR);
            this.groupBox2.Controls.Add(this.btnBUSCAR);
            this.groupBox2.Controls.Add(this.btnELIMINAR);
            this.groupBox2.Controls.Add(this.btnSALIR);
            this.groupBox2.Controls.Add(this.btnMODIFICAR);
            this.groupBox2.Controls.Add(this.btnAGREGAR);
            this.groupBox2.Controls.Add(this.dgvORDENES);
            this.groupBox2.Location = new System.Drawing.Point(16, 6);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1137, 544);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            // 
            // btnVERIFICAR
            // 
            this.btnVERIFICAR.Image = global::FactorySys.Properties.Resources.file_apply;
            this.btnVERIFICAR.Location = new System.Drawing.Point(627, 473);
            this.btnVERIFICAR.Margin = new System.Windows.Forms.Padding(4);
            this.btnVERIFICAR.Name = "btnVERIFICAR";
            this.btnVERIFICAR.Size = new System.Drawing.Size(147, 55);
            this.btnVERIFICAR.TabIndex = 17;
            this.btnVERIFICAR.Text = "Verificar";
            this.btnVERIFICAR.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnVERIFICAR.UseVisualStyleBackColor = true;
            this.btnVERIFICAR.Click += new System.EventHandler(this.btnVERIFICAR_Click);
            // 
            // frmORDENES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1163, 562);
            this.Controls.Add(this.groupBox2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmORDENES";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion Orden de Compra";
            ((System.ComponentModel.ISupportInitialize)(this.dgvORDENES)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvORDENES;
        private System.Windows.Forms.Button btnAGREGAR;
        private System.Windows.Forms.Button btnMODIFICAR;
        private System.Windows.Forms.Button btnSALIR;
        private System.Windows.Forms.Button btnELIMINAR;
        private System.Windows.Forms.Button btnBUSCAR;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnVERIFICAR;
    }
}