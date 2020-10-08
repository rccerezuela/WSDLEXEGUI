namespace WSDLEXEGUI
{
    partial class ParamsForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.wsdlURI = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.wsdlURIUser = new System.Windows.Forms.TextBox();
            this.wsdlURIPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.classOutputNamespace = new System.Windows.Forms.TextBox();
            this.ClassOutputName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.generateClassFromWSDL = new System.Windows.Forms.Button();
            this.classOutputPath = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.wsdlExePath = new System.Windows.Forms.TextBox();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label9 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 119);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5);
            this.label1.Size = new System.Drawing.Size(60, 23);
            this.label1.TabIndex = 4;
            this.label1.Text = "wsdl URI";
            // 
            // wsdlURI
            // 
            this.wsdlURI.Location = new System.Drawing.Point(28, 145);
            this.wsdlURI.Name = "wsdlURI";
            this.wsdlURI.Size = new System.Drawing.Size(445, 20);
            this.wsdlURI.TabIndex = 5;
            this.wsdlURI.Text = "http://192.168.1.5:7047/DynamicsNAV100/WS/SIMEZA%20/Page/CustomerCard";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 181);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(5);
            this.label2.Size = new System.Drawing.Size(110, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "wsdl URI Auth User";
            // 
            // wsdlURIUser
            // 
            this.wsdlURIUser.Location = new System.Drawing.Point(47, 207);
            this.wsdlURIUser.Name = "wsdlURIUser";
            this.wsdlURIUser.Size = new System.Drawing.Size(120, 20);
            this.wsdlURIUser.TabIndex = 7;
            this.wsdlURIUser.Text = "raraavislab";
            // 
            // wsdlURIPassword
            // 
            this.wsdlURIPassword.Location = new System.Drawing.Point(182, 207);
            this.wsdlURIPassword.Name = "wsdlURIPassword";
            this.wsdlURIPassword.Size = new System.Drawing.Size(149, 20);
            this.wsdlURIPassword.TabIndex = 8;
            this.wsdlURIPassword.Text = "SIM-kc80E";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(12, 264);
            this.label4.Name = "label4";
            this.label4.Padding = new System.Windows.Forms.Padding(5);
            this.label4.Size = new System.Drawing.Size(146, 27);
            this.label4.TabIndex = 10;
            this.label4.Text = "Scaffold Parameters";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(17, 349);
            this.label5.Name = "label5";
            this.label5.Padding = new System.Windows.Forms.Padding(5);
            this.label5.Size = new System.Drawing.Size(76, 23);
            this.label5.TabIndex = 12;
            this.label5.Text = "NameSpace";
            // 
            // classOutputNamespace
            // 
            this.classOutputNamespace.Location = new System.Drawing.Point(28, 375);
            this.classOutputNamespace.Name = "classOutputNamespace";
            this.classOutputNamespace.Size = new System.Drawing.Size(163, 20);
            this.classOutputNamespace.TabIndex = 11;
            this.classOutputNamespace.Text = "ProxyNAVCustomerCard ";
            // 
            // ClassOutputName
            // 
            this.ClassOutputName.Location = new System.Drawing.Point(212, 317);
            this.ClassOutputName.Name = "ClassOutputName";
            this.ClassOutputName.Size = new System.Drawing.Size(163, 20);
            this.ClassOutputName.TabIndex = 13;
            this.ClassOutputName.Text = "CustomerCard";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(198, 291);
            this.label6.Name = "label6";
            this.label6.Padding = new System.Windows.Forms.Padding(5);
            this.label6.Size = new System.Drawing.Size(112, 23);
            this.label6.TabIndex = 14;
            this.label6.Text = "Service Class Name";
            // 
            // generateClassFromWSDL
            // 
            this.generateClassFromWSDL.Location = new System.Drawing.Point(413, 416);
            this.generateClassFromWSDL.Name = "generateClassFromWSDL";
            this.generateClassFromWSDL.Size = new System.Drawing.Size(137, 51);
            this.generateClassFromWSDL.TabIndex = 15;
            this.generateClassFromWSDL.Text = "Generate";
            this.generateClassFromWSDL.UseVisualStyleBackColor = true;
            this.generateClassFromWSDL.Click += new System.EventHandler(this.generate_click);
            // 
            // classOutputPath
            // 
            this.classOutputPath.Location = new System.Drawing.Point(28, 317);
            this.classOutputPath.Name = "classOutputPath";
            this.classOutputPath.Size = new System.Drawing.Size(163, 20);
            this.classOutputPath.TabIndex = 16;
            this.classOutputPath.Text = "c:\\Users\\rccer\\source";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(17, 291);
            this.label7.Name = "label7";
            this.label7.Padding = new System.Windows.Forms.Padding(5);
            this.label7.Size = new System.Drawing.Size(92, 23);
            this.label7.TabIndex = 17;
            this.label7.Text = "Output directory";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(12, 9);
            this.label8.Name = "label8";
            this.label8.Padding = new System.Windows.Forms.Padding(5);
            this.label8.Size = new System.Drawing.Size(144, 27);
            this.label8.TabIndex = 18;
            this.label8.Text = "Origin Configuration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 45);
            this.label3.Name = "label3";
            this.label3.Padding = new System.Windows.Forms.Padding(5);
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 19;
            this.label3.Text = "wsdl.exe bin path";
            // 
            // wsdlExePath
            // 
            this.wsdlExePath.Location = new System.Drawing.Point(28, 71);
            this.wsdlExePath.Name = "wsdlExePath";
            this.wsdlExePath.Size = new System.Drawing.Size(445, 20);
            this.wsdlExePath.TabIndex = 20;
            this.wsdlExePath.Text = "c:\\Program Files (x86)\\Microsoft SDKs\\Windows\\v10.0A\\bin\\NETFX 4.8 Tools\\wsdl.exe" +
    "";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(429, 12);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(121, 13);
            this.linkLabel1.TabIndex = 21;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "wsdl.exe documentation";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(170, 181);
            this.label9.Name = "label9";
            this.label9.Padding = new System.Windows.Forms.Padding(5);
            this.label9.Size = new System.Drawing.Size(111, 23);
            this.label9.TabIndex = 22;
            this.label9.Text = "wsdl URI Auth Pass";
            // 
            // ParamsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(574, 490);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.wsdlExePath);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.classOutputPath);
            this.Controls.Add(this.generateClassFromWSDL);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.ClassOutputName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.classOutputNamespace);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.wsdlURIPassword);
            this.Controls.Add(this.wsdlURIUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.wsdlURI);
            this.Controls.Add(this.label1);
            this.Name = "ParamsForm";
            this.Text = "WSDL.EXE gui";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox wsdlURI;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox wsdlURIUser;
        private System.Windows.Forms.TextBox wsdlURIPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox classOutputNamespace;
        private System.Windows.Forms.TextBox ClassOutputName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button generateClassFromWSDL;
        private System.Windows.Forms.TextBox classOutputPath;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox wsdlExePath;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label9;
    }
}

