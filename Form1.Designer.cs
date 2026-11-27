namespace SGBDJOSEPH
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panel1 = new Panel();
            panel3 = new Panel();
            lblMenu = new Label();
            btnEmployesProjets = new Button();
            btnEmployesDepartements = new Button();
            btnProjets = new Button();
            btnDepartements = new Button();
            btnEmployes = new Button();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ControlDarkDark;
            panel1.BorderStyle = BorderStyle.Fixed3D;
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(btnEmployesProjets);
            panel1.Controls.Add(btnEmployesDepartements);
            panel1.Controls.Add(btnProjets);
            panel1.Controls.Add(btnDepartements);
            panel1.Controls.Add(btnEmployes);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(304, 570);
            panel1.TabIndex = 0;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblMenu);
            panel3.ForeColor = SystemColors.ControlLightLight;
            panel3.Location = new Point(47, 25);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 55);
            panel3.TabIndex = 6;
            // 
            // lblMenu
            // 
            lblMenu.AutoSize = true;
            lblMenu.Font = new Font("Goudy Stout", 21.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMenu.ForeColor = SystemColors.ControlLightLight;
            lblMenu.Location = new Point(16, 9);
            lblMenu.Name = "lblMenu";
            lblMenu.Size = new Size(172, 40);
            lblMenu.TabIndex = 4;
            lblMenu.Text = "Menu";
            // 
            // btnEmployesProjets
            // 
            btnEmployesProjets.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployesProjets.ForeColor = SystemColors.ControlDarkDark;
            btnEmployesProjets.Location = new Point(29, 451);
            btnEmployesProjets.Name = "btnEmployesProjets";
            btnEmployesProjets.Size = new Size(239, 48);
            btnEmployesProjets.TabIndex = 5;
            btnEmployesProjets.Text = "Employes par projets";
            btnEmployesProjets.UseVisualStyleBackColor = true;
            // 
            // btnEmployesDepartements
            // 
            btnEmployesDepartements.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployesDepartements.ForeColor = SystemColors.ControlDarkDark;
            btnEmployesDepartements.Location = new Point(29, 366);
            btnEmployesDepartements.Name = "btnEmployesDepartements";
            btnEmployesDepartements.Size = new Size(239, 48);
            btnEmployesDepartements.TabIndex = 3;
            btnEmployesDepartements.Text = "Employés par Départements";
            btnEmployesDepartements.UseVisualStyleBackColor = true;
            // 
            // btnProjets
            // 
            btnProjets.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnProjets.ForeColor = SystemColors.ControlDarkDark;
            btnProjets.Location = new Point(29, 279);
            btnProjets.Name = "btnProjets";
            btnProjets.Size = new Size(239, 48);
            btnProjets.TabIndex = 2;
            btnProjets.Text = "Projets";
            btnProjets.UseVisualStyleBackColor = true;
            // 
            // btnDepartements
            // 
            btnDepartements.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDepartements.ForeColor = SystemColors.ControlDarkDark;
            btnDepartements.Location = new Point(29, 196);
            btnDepartements.Name = "btnDepartements";
            btnDepartements.Size = new Size(239, 48);
            btnDepartements.TabIndex = 1;
            btnDepartements.Text = "Départements";
            btnDepartements.UseVisualStyleBackColor = true;
            // 
            // btnEmployes
            // 
            btnEmployes.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEmployes.ForeColor = SystemColors.ControlDarkDark;
            btnEmployes.Location = new Point(29, 112);
            btnEmployes.Name = "btnEmployes";
            btnEmployes.Size = new Size(239, 48);
            btnEmployes.TabIndex = 0;
            btnEmployes.Text = "Employés";
            btnEmployes.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            panel2.BackColor = SystemColors.ControlLightLight;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Location = new Point(325, 12);
            panel2.Name = "panel2";
            panel2.Size = new Size(812, 570);
            panel2.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1146, 594);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private Label lblMenu;
        private Button btnEmployes;
        private Button btnDepartements;
        private Button btnProjets;
        private Button btnEmployesDepartements;
        private Button btnEmployesProjets;
        private Panel panel3;
    }
}
