namespace Cinema_Booking_System1
{
    partial class ticketForm
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
            this.components = new System.ComponentModel.Container();
            this.cmbMovie = new System.Windows.Forms.ComboBox();
            this.movieBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingsystemDBDataSet = new Cinema_Booking_System1.BookingsystemDBDataSet();
            this.label12 = new System.Windows.Forms.Label();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtTelephone = new System.Windows.Forms.TextBox();
            this.txtSurname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxTown = new System.Windows.Forms.ComboBox();
            this.cbxGender = new System.Windows.Forms.ComboBox();
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.customerTableAdapter = new Cinema_Booking_System1.BookingsystemDBDataSetTableAdapters.CustomerTableAdapter();
            this.lblRating = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label15 = new System.Windows.Forms.Label();
            this.rchTxtAdress = new System.Windows.Forms.RichTextBox();
            this.movieTableAdapter1 = new Cinema_Booking_System1.BookingsystemDBDataSetTableAdapters.MovieTableAdapter();
            this.label10 = new System.Windows.Forms.Label();
            this.cbxTheatre = new System.Windows.Forms.ComboBox();
            this.theatreBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.theatreTableAdapter = new Cinema_Booking_System1.BookingsystemDBDataSetTableAdapters.TheatreTableAdapter();
            this.label11 = new System.Windows.Forms.Label();
            this.txtTicketAdult = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTicketChild = new System.Windows.Forms.TextBox();
            this.btnMenu = new System.Windows.Forms.Button();
            this.seatBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.seatTableAdapter = new Cinema_Booking_System1.BookingsystemDBDataSetTableAdapters.SeatTableAdapter();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.employeeTableAdapter = new Cinema_Booking_System1.BookingsystemDBDataSetTableAdapters.EmployeeTableAdapter();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsystemDBDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theatreBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // cmbMovie
            // 
            this.cmbMovie.AutoCompleteCustomSource.AddRange(new string[] {
            "Godzilla",
            "Spiderman",
            "Superman"});
            this.cmbMovie.DataSource = this.movieBindingSource;
            this.cmbMovie.DisplayMember = "name";
            this.cmbMovie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMovie.FormattingEnabled = true;
            this.cmbMovie.Location = new System.Drawing.Point(10, 87);
            this.cmbMovie.Name = "cmbMovie";
            this.cmbMovie.Size = new System.Drawing.Size(243, 21);
            this.cmbMovie.TabIndex = 47;
            this.toolTip1.SetToolTip(this.cmbMovie, "Choose Movie Name");
            this.cmbMovie.ValueMember = "name";
            // 
            // movieBindingSource
            // 
            this.movieBindingSource.DataMember = "Movie";
            this.movieBindingSource.DataSource = this.bookingsystemDBDataSet;
            // 
            // bookingsystemDBDataSet
            // 
            this.bookingsystemDBDataSet.DataSetName = "BookingsystemDBDataSet";
            this.bookingsystemDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(9, 69);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(67, 13);
            this.label12.TabIndex = 46;
            this.label12.Text = "Movie Name";
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(334, 483);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(168, 23);
            this.btnConfirm.TabIndex = 41;
            this.btnConfirm.Text = "Confirm Details";
            this.toolTip1.SetToolTip(this.btnConfirm, "Confirm Details");
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "emailAddress", true));
            this.txtEmail.Location = new System.Drawing.Point(129, 215);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(100, 20);
            this.txtEmail.TabIndex = 40;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.bookingsystemDBDataSet;
            // 
            // txtMobile
            // 
            this.txtMobile.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "idNumber", true));
            this.txtMobile.Location = new System.Drawing.Point(129, 189);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(100, 20);
            this.txtMobile.TabIndex = 39;
            // 
            // txtTelephone
            // 
            this.txtTelephone.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "telephoneNumber", true));
            this.txtTelephone.Location = new System.Drawing.Point(129, 111);
            this.txtTelephone.Name = "txtTelephone";
            this.txtTelephone.Size = new System.Drawing.Size(100, 20);
            this.txtTelephone.TabIndex = 36;
            // 
            // txtSurname
            // 
            this.txtSurname.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "surname", true));
            this.txtSurname.Location = new System.Drawing.Point(129, 85);
            this.txtSurname.Name = "txtSurname";
            this.txtSurname.Size = new System.Drawing.Size(100, 20);
            this.txtSurname.TabIndex = 35;
            // 
            // txtName
            // 
            this.txtName.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "name", true));
            this.txtName.Location = new System.Drawing.Point(129, 59);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 20);
            this.txtName.TabIndex = 34;
            // 
            // txtID
            // 
            this.txtID.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "idNumber", true));
            this.txtID.Location = new System.Drawing.Point(129, 33);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(100, 20);
            this.txtID.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(27, 218);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(35, 13);
            this.label9.TabIndex = 32;
            this.label9.Text = "E-mail";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(27, 192);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Mobile Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(27, 166);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(42, 13);
            this.label7.TabIndex = 30;
            this.label7.Text = "Gender";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(27, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 29;
            this.label6.Text = "Town";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(27, 114);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(58, 13);
            this.label5.TabIndex = 28;
            this.label5.Text = "Telephone";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 88);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 13);
            this.label4.TabIndex = 27;
            this.label4.Text = "Surname";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 26;
            this.label3.Text = "Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 36);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "ID Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(235, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 25);
            this.label1.TabIndex = 24;
            this.label1.Text = "Cinema Booking System";
            // 
            // cbxTown
            // 
            this.cbxTown.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "town", true));
            this.cbxTown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTown.FormattingEnabled = true;
            this.cbxTown.Location = new System.Drawing.Point(129, 137);
            this.cbxTown.Name = "cbxTown";
            this.cbxTown.Size = new System.Drawing.Size(100, 21);
            this.cbxTown.TabIndex = 48;
            // 
            // cbxGender
            // 
            this.cbxGender.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "gender", true));
            this.cbxGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxGender.FormattingEnabled = true;
            this.cbxGender.Location = new System.Drawing.Point(129, 163);
            this.cbxGender.Name = "cbxGender";
            this.cbxGender.Size = new System.Drawing.Size(100, 21);
            this.cbxGender.TabIndex = 49;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Location = new System.Drawing.Point(62, 111);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(0, 13);
            this.lblRating.TabIndex = 51;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(451, 69);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(51, 13);
            this.label14.TabIndex = 53;
            this.label14.Text = "Customer";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cbxGender);
            this.panel1.Controls.Add(this.cbxTown);
            this.panel1.Controls.Add(this.txtEmail);
            this.panel1.Controls.Add(this.label15);
            this.panel1.Controls.Add(this.rchTxtAdress);
            this.panel1.Controls.Add(this.txtMobile);
            this.panel1.Controls.Add(this.txtTelephone);
            this.panel1.Controls.Add(this.txtSurname);
            this.panel1.Controls.Add(this.txtName);
            this.panel1.Controls.Add(this.txtID);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(261, 87);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(241, 390);
            this.panel1.TabIndex = 54;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(27, 243);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(45, 13);
            this.label15.TabIndex = 54;
            this.label15.Text = "Address";
            // 
            // rchTxtAdress
            // 
            this.rchTxtAdress.Location = new System.Drawing.Point(30, 259);
            this.rchTxtAdress.Name = "rchTxtAdress";
            this.rchTxtAdress.Size = new System.Drawing.Size(199, 117);
            this.rchTxtAdress.TabIndex = 55;
            this.rchTxtAdress.Text = "";
            // 
            // movieTableAdapter1
            // 
            this.movieTableAdapter1.ClearBeforeFill = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(9, 120);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 56;
            this.label10.Text = "Theatre";
            // 
            // cbxTheatre
            // 
            this.cbxTheatre.AutoCompleteCustomSource.AddRange(new string[] {
            "Godzilla",
            "Spiderman",
            "Superman"});
            this.cbxTheatre.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxTheatre.FormattingEnabled = true;
            this.cbxTheatre.Location = new System.Drawing.Point(12, 141);
            this.cbxTheatre.Name = "cbxTheatre";
            this.cbxTheatre.Size = new System.Drawing.Size(243, 21);
            this.cbxTheatre.TabIndex = 57;
            this.toolTip1.SetToolTip(this.cbxTheatre, "Choose Theatre");
            this.cbxTheatre.SelectedIndexChanged += new System.EventHandler(this.cbxTheatre_SelectedIndexChanged);
            // 
            // theatreBindingSource
            // 
            this.theatreBindingSource.DataMember = "Theatre";
            this.theatreBindingSource.DataSource = this.bookingsystemDBDataSet;
            // 
            // theatreTableAdapter
            // 
            this.theatreTableAdapter.ClearBeforeFill = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(9, 172);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 13);
            this.label11.TabIndex = 58;
            this.label11.Text = "Tickets";
            this.label11.Click += new System.EventHandler(this.label11_Click);
            // 
            // txtTicketAdult
            // 
            this.txtTicketAdult.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "idNumber", true));
            this.txtTicketAdult.Location = new System.Drawing.Point(12, 224);
            this.txtTicketAdult.Name = "txtTicketAdult";
            this.txtTicketAdult.Size = new System.Drawing.Size(100, 20);
            this.txtTicketAdult.TabIndex = 56;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(9, 208);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(36, 13);
            this.label13.TabIndex = 59;
            this.label13.Text = "Adults";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(12, 258);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(45, 13);
            this.label16.TabIndex = 60;
            this.label16.Text = "Children";
            // 
            // txtTicketChild
            // 
            this.txtTicketChild.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.customerBindingSource, "idNumber", true));
            this.txtTicketChild.Location = new System.Drawing.Point(12, 279);
            this.txtTicketChild.Name = "txtTicketChild";
            this.txtTicketChild.Size = new System.Drawing.Size(100, 20);
            this.txtTicketChild.TabIndex = 61;
            // 
            // btnMenu
            // 
            this.btnMenu.Location = new System.Drawing.Point(12, 483);
            this.btnMenu.Name = "btnMenu";
            this.btnMenu.Size = new System.Drawing.Size(168, 23);
            this.btnMenu.TabIndex = 63;
            this.btnMenu.Text = "Menu";
            this.toolTip1.SetToolTip(this.btnMenu, "Go to main menu");
            this.btnMenu.UseVisualStyleBackColor = true;
            this.btnMenu.Click += new System.EventHandler(this.btnMenu_Click);
            // 
            // seatBindingSource
            // 
            this.seatBindingSource.DataMember = "Seat";
            this.seatBindingSource.DataSource = this.bookingsystemDBDataSet;
            // 
            // seatTableAdapter
            // 
            this.seatTableAdapter.ClearBeforeFill = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.bookingsystemDBDataSet;
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // ticketForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 511);
            this.Controls.Add(this.btnMenu);
            this.Controls.Add(this.txtTicketChild);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.txtTicketAdult);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.cbxTheatre);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.cmbMovie);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.label1);
            this.Name = "ticketForm";
            this.Text = "Book Ticket";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.movieBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsystemDBDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.theatreBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.seatBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbMovie;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtTelephone;
        private System.Windows.Forms.TextBox txtSurname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxTown;
        private System.Windows.Forms.ComboBox cbxGender;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private BookingsystemDBDataSet bookingsystemDBDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private BookingsystemDBDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.RichTextBox rchTxtAdress;
        private System.Windows.Forms.BindingSource movieBindingSource;
        private BookingsystemDBDataSetTableAdapters.MovieTableAdapter movieTableAdapter1;
        private System.Windows.Forms.ComboBox cbxTheatre;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.BindingSource theatreBindingSource;
        private BookingsystemDBDataSetTableAdapters.TheatreTableAdapter theatreTableAdapter;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtTicketAdult;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTicketChild;
        private System.Windows.Forms.Button btnMenu;
        private System.Windows.Forms.BindingSource seatBindingSource;
        private BookingsystemDBDataSetTableAdapters.SeatTableAdapter seatTableAdapter;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private BookingsystemDBDataSetTableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}

