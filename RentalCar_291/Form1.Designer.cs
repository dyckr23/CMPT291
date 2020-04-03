using System.Windows.Forms;

namespace RentalCar_291
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.sql_connection = new System.Windows.Forms.TabPage();
            this.connect_button = new System.Windows.Forms.Button();
            this.connection_status_label = new System.Windows.Forms.Label();
            this.label0 = new System.Windows.Forms.Label();
            this.branches_tab = new System.Windows.Forms.TabPage();
            this.remove_branch = new System.Windows.Forms.Button();
            this.button_branch_clear = new System.Windows.Forms.Button();
            this.insert_branch = new System.Windows.Forms.Button();
            this.update_branch = new System.Windows.Forms.Button();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.branch_row_select = new System.Windows.Forms.Button();
            this.branchView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addr1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Addr2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.city_branchView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.province_branchView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.postal_code_branchView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone_branchView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.email_branchView = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.list_button = new System.Windows.Forms.Button();
            this.cars_tab = new System.Windows.Forms.TabPage();
            this.remove_car = new System.Windows.Forms.Button();
            this.clear_car = new System.Windows.Forms.Button();
            this.insert_cars = new System.Windows.Forms.Button();
            this.update_cars = new System.Windows.Forms.Button();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.textBox14 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.car_row_select = new System.Windows.Forms.Button();
            this.carView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.car_query = new System.Windows.Forms.Button();
            this.customers_tab = new System.Windows.Forms.TabPage();
            this.remove_customer = new System.Windows.Forms.Button();
            this.clear_customer = new System.Windows.Forms.Button();
            this.insert_customer = new System.Windows.Forms.Button();
            this.update_customer = new System.Windows.Forms.Button();
            this.textBox15 = new System.Windows.Forms.TextBox();
            this.textBox16 = new System.Windows.Forms.TextBox();
            this.textBox17 = new System.Windows.Forms.TextBox();
            this.textBox18 = new System.Windows.Forms.TextBox();
            this.textBox19 = new System.Windows.Forms.TextBox();
            this.textBox20 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.customer_row_select = new System.Windows.Forms.Button();
            this.customerView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customer_query = new System.Windows.Forms.Button();
            this.booking_tab = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bookingView = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.returnDatePicker = new System.Windows.Forms.DateTimePicker();
            this.customerBox = new System.Windows.Forms.ComboBox();
            this.pickupDatePicker = new System.Windows.Forms.DateTimePicker();
            this.label24 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.label23 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.carBox = new System.Windows.Forms.ComboBox();
            this.check_booking = new System.Windows.Forms.Button();
            this.make_booking = new System.Windows.Forms.Button();
            this.remove_booking = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.availableLabel = new System.Windows.Forms.Label();
            this.notAvailableLabel = new System.Windows.Forms.Label();
            this.branchBox = new System.Windows.Forms.ComboBox();
            this.label25 = new System.Windows.Forms.Label();
            this.dataGridViewTextBoxColumn13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.booking_clear = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.sql_connection.SuspendLayout();
            this.branches_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchView)).BeginInit();
            this.cars_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carView)).BeginInit();
            this.customers_tab.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerView)).BeginInit();
            this.booking_tab.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bookingView)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.sql_connection);
            this.tabControl1.Controls.Add(this.branches_tab);
            this.tabControl1.Controls.Add(this.cars_tab);
            this.tabControl1.Controls.Add(this.customers_tab);
            this.tabControl1.Controls.Add(this.booking_tab);
            this.tabControl1.Location = new System.Drawing.Point(13, 13);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1070, 486);
            this.tabControl1.TabIndex = 0;
            // 
            // sql_connection
            // 
            this.sql_connection.Controls.Add(this.groupBox4);
            this.sql_connection.Location = new System.Drawing.Point(4, 22);
            this.sql_connection.Name = "sql_connection";
            this.sql_connection.Padding = new System.Windows.Forms.Padding(3);
            this.sql_connection.Size = new System.Drawing.Size(1062, 460);
            this.sql_connection.TabIndex = 0;
            this.sql_connection.Text = "SQL Connection";
            this.sql_connection.UseVisualStyleBackColor = true;
            this.sql_connection.Enter += new System.EventHandler(this.sql_connection_Enter);
            // 
            // connect_button
            // 
            this.connect_button.Location = new System.Drawing.Point(6, 66);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(75, 23);
            this.connect_button.TabIndex = 2;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // connection_status_label
            // 
            this.connection_status_label.AutoSize = true;
            this.connection_status_label.ForeColor = System.Drawing.Color.Firebrick;
            this.connection_status_label.Location = new System.Drawing.Point(107, 34);
            this.connection_status_label.Name = "connection_status_label";
            this.connection_status_label.Size = new System.Drawing.Size(79, 13);
            this.connection_status_label.TabIndex = 1;
            this.connection_status_label.Text = "Not Connected";
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.Location = new System.Drawing.Point(6, 34);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(94, 13);
            this.label0.TabIndex = 0;
            this.label0.Text = "Connection Status";
            // 
            // branches_tab
            // 
            this.branches_tab.Controls.Add(this.remove_branch);
            this.branches_tab.Controls.Add(this.button_branch_clear);
            this.branches_tab.Controls.Add(this.insert_branch);
            this.branches_tab.Controls.Add(this.update_branch);
            this.branches_tab.Controls.Add(this.textBox8);
            this.branches_tab.Controls.Add(this.textBox7);
            this.branches_tab.Controls.Add(this.textBox6);
            this.branches_tab.Controls.Add(this.textBox5);
            this.branches_tab.Controls.Add(this.textBox4);
            this.branches_tab.Controls.Add(this.textBox3);
            this.branches_tab.Controls.Add(this.textBox2);
            this.branches_tab.Controls.Add(this.textBox1);
            this.branches_tab.Controls.Add(this.label8);
            this.branches_tab.Controls.Add(this.label7);
            this.branches_tab.Controls.Add(this.label6);
            this.branches_tab.Controls.Add(this.label5);
            this.branches_tab.Controls.Add(this.label4);
            this.branches_tab.Controls.Add(this.label3);
            this.branches_tab.Controls.Add(this.label2);
            this.branches_tab.Controls.Add(this.label1);
            this.branches_tab.Controls.Add(this.branch_row_select);
            this.branches_tab.Controls.Add(this.branchView);
            this.branches_tab.Controls.Add(this.list_button);
            this.branches_tab.Location = new System.Drawing.Point(4, 22);
            this.branches_tab.Name = "branches_tab";
            this.branches_tab.Padding = new System.Windows.Forms.Padding(3);
            this.branches_tab.Size = new System.Drawing.Size(1062, 461);
            this.branches_tab.TabIndex = 1;
            this.branches_tab.Text = "Branches";
            this.branches_tab.UseVisualStyleBackColor = true;
            this.branches_tab.Click += new System.EventHandler(this.branches_tab_Click);
            this.branches_tab.Enter += new System.EventHandler(this.branches_tab_Enter);
            // 
            // remove_branch
            // 
            this.remove_branch.Location = new System.Drawing.Point(169, 335);
            this.remove_branch.Name = "remove_branch";
            this.remove_branch.Size = new System.Drawing.Size(75, 23);
            this.remove_branch.TabIndex = 24;
            this.remove_branch.Text = "Remove";
            this.remove_branch.UseVisualStyleBackColor = true;
            this.remove_branch.Click += new System.EventHandler(this.remove_branch_Click);
            // 
            // button_branch_clear
            // 
            this.button_branch_clear.Location = new System.Drawing.Point(104, 41);
            this.button_branch_clear.Name = "button_branch_clear";
            this.button_branch_clear.Size = new System.Drawing.Size(75, 23);
            this.button_branch_clear.TabIndex = 23;
            this.button_branch_clear.Text = "Clear";
            this.button_branch_clear.UseVisualStyleBackColor = true;
            this.button_branch_clear.Click += new System.EventHandler(this.button_branch_clear_Click);
            // 
            // insert_branch
            // 
            this.insert_branch.Location = new System.Drawing.Point(87, 336);
            this.insert_branch.Name = "insert_branch";
            this.insert_branch.Size = new System.Drawing.Size(75, 23);
            this.insert_branch.TabIndex = 22;
            this.insert_branch.Text = "Insert";
            this.insert_branch.UseVisualStyleBackColor = true;
            this.insert_branch.Click += new System.EventHandler(this.insert_branch_Click);
            // 
            // update_branch
            // 
            this.update_branch.Location = new System.Drawing.Point(3, 336);
            this.update_branch.Name = "update_branch";
            this.update_branch.Size = new System.Drawing.Size(75, 23);
            this.update_branch.TabIndex = 21;
            this.update_branch.Text = "Update";
            this.update_branch.UseVisualStyleBackColor = true;
            this.update_branch.Click += new System.EventHandler(this.update_branch_Click);
            // 
            // textBox8
            // 
            this.textBox8.Location = new System.Drawing.Point(83, 303);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(174, 20);
            this.textBox8.TabIndex = 20;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(83, 272);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(174, 20);
            this.textBox7.TabIndex = 19;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(83, 241);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(174, 20);
            this.textBox6.TabIndex = 18;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(83, 210);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(174, 20);
            this.textBox5.TabIndex = 17;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(83, 179);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(174, 20);
            this.textBox4.TabIndex = 16;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(83, 148);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(174, 20);
            this.textBox3.TabIndex = 15;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(83, 117);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(174, 20);
            this.textBox2.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(83, 86);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(174, 20);
            this.textBox1.TabIndex = 13;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(2, 303);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 12;
            this.label8.Text = "Email";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(2, 272);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(38, 13);
            this.label7.TabIndex = 11;
            this.label7.Text = "Phone";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(2, 241);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Postal Code";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(2, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Province";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(2, 179);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(24, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "City";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(2, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Address 2";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(2, 117);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(2, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(17, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "lD";
            // 
            // branch_row_select
            // 
            this.branch_row_select.Location = new System.Drawing.Point(3, 42);
            this.branch_row_select.Name = "branch_row_select";
            this.branch_row_select.Size = new System.Drawing.Size(94, 23);
            this.branch_row_select.TabIndex = 4;
            this.branch_row_select.Text = "Get Selected";
            this.branch_row_select.UseVisualStyleBackColor = true;
            this.branch_row_select.Click += new System.EventHandler(this.branch_row_select_Click);
            // 
            // branchView
            // 
            this.branchView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.branchView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.branchView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Addr1,
            this.Addr2,
            this.city_branchView,
            this.province_branchView,
            this.postal_code_branchView,
            this.phone_branchView,
            this.email_branchView});
            this.branchView.Location = new System.Drawing.Point(267, 3);
            this.branchView.MultiSelect = false;
            this.branchView.Name = "branchView";
            this.branchView.RowHeadersVisible = false;
            this.branchView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.branchView.ShowCellErrors = false;
            this.branchView.Size = new System.Drawing.Size(792, 454);
            this.branchView.TabIndex = 3;
            this.branchView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.branchView_CellContentClick);
            // 
            // ID
            // 
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 43;
            // 
            // Addr1
            // 
            this.Addr1.HeaderText = "Address";
            this.Addr1.Name = "Addr1";
            this.Addr1.ReadOnly = true;
            this.Addr1.Width = 70;
            // 
            // Addr2
            // 
            this.Addr2.HeaderText = "Address 2";
            this.Addr2.Name = "Addr2";
            this.Addr2.ReadOnly = true;
            this.Addr2.Width = 79;
            // 
            // city_branchView
            // 
            this.city_branchView.HeaderText = "City";
            this.city_branchView.Name = "city_branchView";
            this.city_branchView.ReadOnly = true;
            this.city_branchView.Width = 49;
            // 
            // province_branchView
            // 
            this.province_branchView.HeaderText = "Province";
            this.province_branchView.Name = "province_branchView";
            this.province_branchView.ReadOnly = true;
            this.province_branchView.Width = 74;
            // 
            // postal_code_branchView
            // 
            this.postal_code_branchView.HeaderText = "Postal Code";
            this.postal_code_branchView.Name = "postal_code_branchView";
            this.postal_code_branchView.ReadOnly = true;
            this.postal_code_branchView.Width = 89;
            // 
            // phone_branchView
            // 
            this.phone_branchView.HeaderText = "Phone";
            this.phone_branchView.Name = "phone_branchView";
            this.phone_branchView.ReadOnly = true;
            this.phone_branchView.Width = 63;
            // 
            // email_branchView
            // 
            this.email_branchView.HeaderText = "Email";
            this.email_branchView.Name = "email_branchView";
            this.email_branchView.ReadOnly = true;
            this.email_branchView.Width = 57;
            // 
            // list_button
            // 
            this.list_button.Location = new System.Drawing.Point(3, 6);
            this.list_button.Name = "list_button";
            this.list_button.Size = new System.Drawing.Size(75, 23);
            this.list_button.TabIndex = 0;
            this.list_button.Text = "Query";
            this.list_button.UseVisualStyleBackColor = true;
            this.list_button.Click += new System.EventHandler(this.list_button_Click);
            // 
            // cars_tab
            // 
            this.cars_tab.Controls.Add(this.remove_car);
            this.cars_tab.Controls.Add(this.clear_car);
            this.cars_tab.Controls.Add(this.insert_cars);
            this.cars_tab.Controls.Add(this.update_cars);
            this.cars_tab.Controls.Add(this.textBox9);
            this.cars_tab.Controls.Add(this.textBox10);
            this.cars_tab.Controls.Add(this.textBox11);
            this.cars_tab.Controls.Add(this.textBox12);
            this.cars_tab.Controls.Add(this.textBox13);
            this.cars_tab.Controls.Add(this.textBox14);
            this.cars_tab.Controls.Add(this.label11);
            this.cars_tab.Controls.Add(this.label12);
            this.cars_tab.Controls.Add(this.label13);
            this.cars_tab.Controls.Add(this.label14);
            this.cars_tab.Controls.Add(this.label15);
            this.cars_tab.Controls.Add(this.label16);
            this.cars_tab.Controls.Add(this.car_row_select);
            this.cars_tab.Controls.Add(this.carView);
            this.cars_tab.Controls.Add(this.car_query);
            this.cars_tab.Location = new System.Drawing.Point(4, 22);
            this.cars_tab.Name = "cars_tab";
            this.cars_tab.Size = new System.Drawing.Size(1062, 461);
            this.cars_tab.TabIndex = 2;
            this.cars_tab.Text = "Cars";
            this.cars_tab.UseVisualStyleBackColor = true;
            this.cars_tab.Enter += new System.EventHandler(this.cars_tab_Enter);
            // 
            // remove_car
            // 
            this.remove_car.Location = new System.Drawing.Point(169, 278);
            this.remove_car.Name = "remove_car";
            this.remove_car.Size = new System.Drawing.Size(75, 23);
            this.remove_car.TabIndex = 46;
            this.remove_car.Text = "Remove";
            this.remove_car.UseVisualStyleBackColor = true;
            this.remove_car.Click += new System.EventHandler(this.remove_car_Click);
            // 
            // clear_car
            // 
            this.clear_car.Location = new System.Drawing.Point(104, 41);
            this.clear_car.Name = "clear_car";
            this.clear_car.Size = new System.Drawing.Size(75, 23);
            this.clear_car.TabIndex = 45;
            this.clear_car.Text = "Clear";
            this.clear_car.UseVisualStyleBackColor = true;
            this.clear_car.Click += new System.EventHandler(this.clear_car_Click);
            // 
            // insert_cars
            // 
            this.insert_cars.Location = new System.Drawing.Point(87, 279);
            this.insert_cars.Name = "insert_cars";
            this.insert_cars.Size = new System.Drawing.Size(75, 23);
            this.insert_cars.TabIndex = 44;
            this.insert_cars.Text = "Insert";
            this.insert_cars.UseVisualStyleBackColor = true;
            this.insert_cars.Click += new System.EventHandler(this.insert_cars_Click);
            // 
            // update_cars
            // 
            this.update_cars.Location = new System.Drawing.Point(3, 279);
            this.update_cars.Name = "update_cars";
            this.update_cars.Size = new System.Drawing.Size(75, 23);
            this.update_cars.TabIndex = 43;
            this.update_cars.Text = "Update";
            this.update_cars.UseVisualStyleBackColor = true;
            this.update_cars.Click += new System.EventHandler(this.update_cars_Click);
            // 
            // textBox9
            // 
            this.textBox9.Location = new System.Drawing.Point(83, 241);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(174, 20);
            this.textBox9.TabIndex = 40;
            // 
            // textBox10
            // 
            this.textBox10.Location = new System.Drawing.Point(83, 210);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(174, 20);
            this.textBox10.TabIndex = 39;
            // 
            // textBox11
            // 
            this.textBox11.Location = new System.Drawing.Point(83, 179);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(174, 20);
            this.textBox11.TabIndex = 38;
            // 
            // textBox12
            // 
            this.textBox12.Location = new System.Drawing.Point(83, 148);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(174, 20);
            this.textBox12.TabIndex = 37;
            // 
            // textBox13
            // 
            this.textBox13.Location = new System.Drawing.Point(83, 117);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(174, 20);
            this.textBox13.TabIndex = 36;
            // 
            // textBox14
            // 
            this.textBox14.Location = new System.Drawing.Point(83, 86);
            this.textBox14.Name = "textBox14";
            this.textBox14.Size = new System.Drawing.Size(174, 20);
            this.textBox14.TabIndex = 35;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(2, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(44, 13);
            this.label11.TabIndex = 32;
            this.label11.Text = "Mileage";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(2, 210);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(31, 13);
            this.label12.TabIndex = 31;
            this.label12.Text = "Color";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(2, 179);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(29, 13);
            this.label13.TabIndex = 30;
            this.label13.Text = "Year";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(2, 148);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(36, 13);
            this.label14.TabIndex = 29;
            this.label14.Text = "Model";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(2, 117);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(34, 13);
            this.label15.TabIndex = 28;
            this.label15.Text = "Make";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(2, 86);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(17, 13);
            this.label16.TabIndex = 27;
            this.label16.Text = "lD";
            // 
            // car_row_select
            // 
            this.car_row_select.Location = new System.Drawing.Point(3, 42);
            this.car_row_select.Name = "car_row_select";
            this.car_row_select.Size = new System.Drawing.Size(94, 23);
            this.car_row_select.TabIndex = 26;
            this.car_row_select.Text = "Get Selected";
            this.car_row_select.UseVisualStyleBackColor = true;
            this.car_row_select.Click += new System.EventHandler(this.car_row_select_Click);
            // 
            // carView
            // 
            this.carView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.carView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.carView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.carView.Location = new System.Drawing.Point(267, 3);
            this.carView.MultiSelect = false;
            this.carView.Name = "carView";
            this.carView.RowHeadersVisible = false;
            this.carView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.carView.ShowCellErrors = false;
            this.carView.Size = new System.Drawing.Size(792, 454);
            this.carView.TabIndex = 25;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "ID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 43;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Make";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 59;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Model";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 61;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Year";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 54;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "Color";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 56;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Mileage";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 69;
            // 
            // car_query
            // 
            this.car_query.Location = new System.Drawing.Point(3, 6);
            this.car_query.Name = "car_query";
            this.car_query.Size = new System.Drawing.Size(75, 23);
            this.car_query.TabIndex = 24;
            this.car_query.Text = "Query";
            this.car_query.UseVisualStyleBackColor = true;
            this.car_query.Click += new System.EventHandler(this.car_query_Click);
            // 
            // customers_tab
            // 
            this.customers_tab.Controls.Add(this.remove_customer);
            this.customers_tab.Controls.Add(this.clear_customer);
            this.customers_tab.Controls.Add(this.insert_customer);
            this.customers_tab.Controls.Add(this.update_customer);
            this.customers_tab.Controls.Add(this.textBox15);
            this.customers_tab.Controls.Add(this.textBox16);
            this.customers_tab.Controls.Add(this.textBox17);
            this.customers_tab.Controls.Add(this.textBox18);
            this.customers_tab.Controls.Add(this.textBox19);
            this.customers_tab.Controls.Add(this.textBox20);
            this.customers_tab.Controls.Add(this.label9);
            this.customers_tab.Controls.Add(this.label10);
            this.customers_tab.Controls.Add(this.label17);
            this.customers_tab.Controls.Add(this.label18);
            this.customers_tab.Controls.Add(this.label19);
            this.customers_tab.Controls.Add(this.label20);
            this.customers_tab.Controls.Add(this.customer_row_select);
            this.customers_tab.Controls.Add(this.customerView);
            this.customers_tab.Controls.Add(this.customer_query);
            this.customers_tab.Location = new System.Drawing.Point(4, 22);
            this.customers_tab.Name = "customers_tab";
            this.customers_tab.Padding = new System.Windows.Forms.Padding(3);
            this.customers_tab.Size = new System.Drawing.Size(1062, 461);
            this.customers_tab.TabIndex = 3;
            this.customers_tab.Text = "Customers";
            this.customers_tab.UseVisualStyleBackColor = true;
            this.customers_tab.Enter += new System.EventHandler(this.customers_tab_Enter);
            // 
            // remove_customer
            // 
            this.remove_customer.Location = new System.Drawing.Point(169, 278);
            this.remove_customer.Name = "remove_customer";
            this.remove_customer.Size = new System.Drawing.Size(75, 23);
            this.remove_customer.TabIndex = 65;
            this.remove_customer.Text = "Remove";
            this.remove_customer.UseVisualStyleBackColor = true;
            this.remove_customer.Click += new System.EventHandler(this.remove_customer_Click);
            // 
            // clear_customer
            // 
            this.clear_customer.Location = new System.Drawing.Point(104, 41);
            this.clear_customer.Name = "clear_customer";
            this.clear_customer.Size = new System.Drawing.Size(75, 23);
            this.clear_customer.TabIndex = 64;
            this.clear_customer.Text = "Clear";
            this.clear_customer.UseVisualStyleBackColor = true;
            this.clear_customer.Click += new System.EventHandler(this.clear_customer_Click);
            // 
            // insert_customer
            // 
            this.insert_customer.Location = new System.Drawing.Point(87, 279);
            this.insert_customer.Name = "insert_customer";
            this.insert_customer.Size = new System.Drawing.Size(75, 23);
            this.insert_customer.TabIndex = 63;
            this.insert_customer.Text = "Insert";
            this.insert_customer.UseVisualStyleBackColor = true;
            this.insert_customer.Click += new System.EventHandler(this.insert_customer_Click);
            // 
            // update_customer
            // 
            this.update_customer.Location = new System.Drawing.Point(3, 279);
            this.update_customer.Name = "update_customer";
            this.update_customer.Size = new System.Drawing.Size(75, 23);
            this.update_customer.TabIndex = 62;
            this.update_customer.Text = "Update";
            this.update_customer.UseVisualStyleBackColor = true;
            this.update_customer.Click += new System.EventHandler(this.update_customer_Click);
            // 
            // textBox15
            // 
            this.textBox15.Location = new System.Drawing.Point(83, 241);
            this.textBox15.Name = "textBox15";
            this.textBox15.Size = new System.Drawing.Size(174, 20);
            this.textBox15.TabIndex = 61;
            // 
            // textBox16
            // 
            this.textBox16.Location = new System.Drawing.Point(83, 210);
            this.textBox16.Name = "textBox16";
            this.textBox16.Size = new System.Drawing.Size(174, 20);
            this.textBox16.TabIndex = 60;
            // 
            // textBox17
            // 
            this.textBox17.Location = new System.Drawing.Point(83, 179);
            this.textBox17.Name = "textBox17";
            this.textBox17.Size = new System.Drawing.Size(174, 20);
            this.textBox17.TabIndex = 59;
            // 
            // textBox18
            // 
            this.textBox18.Location = new System.Drawing.Point(83, 148);
            this.textBox18.Name = "textBox18";
            this.textBox18.Size = new System.Drawing.Size(174, 20);
            this.textBox18.TabIndex = 58;
            // 
            // textBox19
            // 
            this.textBox19.Location = new System.Drawing.Point(83, 117);
            this.textBox19.Name = "textBox19";
            this.textBox19.Size = new System.Drawing.Size(174, 20);
            this.textBox19.TabIndex = 57;
            // 
            // textBox20
            // 
            this.textBox20.Location = new System.Drawing.Point(83, 86);
            this.textBox20.Name = "textBox20";
            this.textBox20.Size = new System.Drawing.Size(174, 20);
            this.textBox20.TabIndex = 56;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(2, 241);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(79, 13);
            this.label9.TabIndex = 55;
            this.label9.Text = "Balance Owing";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(2, 210);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(51, 13);
            this.label10.TabIndex = 54;
            this.label10.Text = "Gold Star";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(2, 179);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(32, 13);
            this.label17.TabIndex = 53;
            this.label17.Text = "Email";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(2, 148);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 52;
            this.label18.Text = "Phone";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(2, 117);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 13);
            this.label19.TabIndex = 51;
            this.label19.Text = "Full name";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(2, 86);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(17, 13);
            this.label20.TabIndex = 50;
            this.label20.Text = "lD";
            // 
            // customer_row_select
            // 
            this.customer_row_select.Location = new System.Drawing.Point(3, 42);
            this.customer_row_select.Name = "customer_row_select";
            this.customer_row_select.Size = new System.Drawing.Size(94, 23);
            this.customer_row_select.TabIndex = 49;
            this.customer_row_select.Text = "Get Selected";
            this.customer_row_select.UseVisualStyleBackColor = true;
            this.customer_row_select.Click += new System.EventHandler(this.customer_row_select_Click);
            // 
            // customerView
            // 
            this.customerView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.customerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9,
            this.dataGridViewTextBoxColumn10,
            this.dataGridViewTextBoxColumn11,
            this.dataGridViewTextBoxColumn12});
            this.customerView.Location = new System.Drawing.Point(267, 3);
            this.customerView.MultiSelect = false;
            this.customerView.Name = "customerView";
            this.customerView.RowHeadersVisible = false;
            this.customerView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.customerView.ShowCellErrors = false;
            this.customerView.Size = new System.Drawing.Size(792, 454);
            this.customerView.TabIndex = 48;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "ID";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            this.dataGridViewTextBoxColumn7.Width = 43;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Full Name";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 73;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.HeaderText = "Phone";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            this.dataGridViewTextBoxColumn9.Width = 63;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.HeaderText = "Email";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.ReadOnly = true;
            this.dataGridViewTextBoxColumn10.Width = 57;
            // 
            // dataGridViewTextBoxColumn11
            // 
            this.dataGridViewTextBoxColumn11.HeaderText = "Gold Star";
            this.dataGridViewTextBoxColumn11.Name = "dataGridViewTextBoxColumn11";
            this.dataGridViewTextBoxColumn11.ReadOnly = true;
            this.dataGridViewTextBoxColumn11.Width = 70;
            // 
            // dataGridViewTextBoxColumn12
            // 
            this.dataGridViewTextBoxColumn12.HeaderText = "Balance Owing";
            this.dataGridViewTextBoxColumn12.Name = "dataGridViewTextBoxColumn12";
            this.dataGridViewTextBoxColumn12.ReadOnly = true;
            this.dataGridViewTextBoxColumn12.Width = 96;
            // 
            // customer_query
            // 
            this.customer_query.Location = new System.Drawing.Point(3, 6);
            this.customer_query.Name = "customer_query";
            this.customer_query.Size = new System.Drawing.Size(75, 23);
            this.customer_query.TabIndex = 47;
            this.customer_query.Text = "Query";
            this.customer_query.UseVisualStyleBackColor = true;
            this.customer_query.Click += new System.EventHandler(this.customer_query_Click);
            // 
            // booking_tab
            // 
            this.booking_tab.Controls.Add(this.groupBox3);
            this.booking_tab.Controls.Add(this.groupBox2);
            this.booking_tab.Controls.Add(this.groupBox1);
            this.booking_tab.Location = new System.Drawing.Point(4, 22);
            this.booking_tab.Name = "booking_tab";
            this.booking_tab.Padding = new System.Windows.Forms.Padding(3);
            this.booking_tab.Size = new System.Drawing.Size(1062, 460);
            this.booking_tab.TabIndex = 4;
            this.booking_tab.Text = "Booking";
            this.booking_tab.UseVisualStyleBackColor = true;
            this.booking_tab.Enter += new System.EventHandler(this.booking_tab_Enter);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox2.Controls.Add(this.bookingView);
            this.groupBox2.Location = new System.Drawing.Point(412, 6);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(643, 451);
            this.groupBox2.TabIndex = 50;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Bookings";
            // 
            // bookingView
            // 
            this.bookingView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.bookingView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn13,
            this.dataGridViewTextBoxColumn14,
            this.dataGridViewTextBoxColumn15,
            this.dataGridViewTextBoxColumn16,
            this.dataGridViewTextBoxColumn17,
            this.Column1});
            this.bookingView.Location = new System.Drawing.Point(12, 19);
            this.bookingView.MultiSelect = false;
            this.bookingView.Name = "bookingView";
            this.bookingView.RowHeadersVisible = false;
            this.bookingView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookingView.ShowCellErrors = false;
            this.bookingView.Size = new System.Drawing.Size(625, 426);
            this.bookingView.TabIndex = 49;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.groupBox1.Controls.Add(this.booking_clear);
            this.groupBox1.Controls.Add(this.branchBox);
            this.groupBox1.Controls.Add(this.label25);
            this.groupBox1.Controls.Add(this.remove_booking);
            this.groupBox1.Controls.Add(this.returnDatePicker);
            this.groupBox1.Controls.Add(this.make_booking);
            this.groupBox1.Controls.Add(this.customerBox);
            this.groupBox1.Controls.Add(this.check_booking);
            this.groupBox1.Controls.Add(this.pickupDatePicker);
            this.groupBox1.Controls.Add(this.label24);
            this.groupBox1.Controls.Add(this.label21);
            this.groupBox1.Controls.Add(this.label23);
            this.groupBox1.Controls.Add(this.label22);
            this.groupBox1.Controls.Add(this.carBox);
            this.groupBox1.Location = new System.Drawing.Point(6, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(225, 451);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Make Booking";
            // 
            // returnDatePicker
            // 
            this.returnDatePicker.Location = new System.Drawing.Point(5, 101);
            this.returnDatePicker.Name = "returnDatePicker";
            this.returnDatePicker.Size = new System.Drawing.Size(200, 20);
            this.returnDatePicker.TabIndex = 1;
            // 
            // customerBox
            // 
            this.customerBox.FormattingEnabled = true;
            this.customerBox.Location = new System.Drawing.Point(5, 204);
            this.customerBox.Name = "customerBox";
            this.customerBox.Size = new System.Drawing.Size(121, 21);
            this.customerBox.TabIndex = 7;
            // 
            // pickupDatePicker
            // 
            this.pickupDatePicker.Location = new System.Drawing.Point(5, 50);
            this.pickupDatePicker.Name = "pickupDatePicker";
            this.pickupDatePicker.Size = new System.Drawing.Size(200, 20);
            this.pickupDatePicker.TabIndex = 0;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(9, 182);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(51, 13);
            this.label24.TabIndex = 6;
            this.label24.Text = "Customer";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(6, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(66, 13);
            this.label21.TabIndex = 2;
            this.label21.Text = "Pickup Date";
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(9, 130);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(23, 13);
            this.label23.TabIndex = 5;
            this.label23.Text = "Car";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(6, 79);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(65, 13);
            this.label22.TabIndex = 3;
            this.label22.Text = "Return Date";
            // 
            // carBox
            // 
            this.carBox.FormattingEnabled = true;
            this.carBox.Location = new System.Drawing.Point(5, 152);
            this.carBox.Name = "carBox";
            this.carBox.Size = new System.Drawing.Size(121, 21);
            this.carBox.TabIndex = 4;
            // 
            // check_booking
            // 
            this.check_booking.Location = new System.Drawing.Point(5, 337);
            this.check_booking.Name = "check_booking";
            this.check_booking.Size = new System.Drawing.Size(107, 23);
            this.check_booking.TabIndex = 51;
            this.check_booking.Text = "Check Availability";
            this.check_booking.UseVisualStyleBackColor = true;
            this.check_booking.Click += new System.EventHandler(this.check_booking_Click);
            // 
            // make_booking
            // 
            this.make_booking.Location = new System.Drawing.Point(5, 379);
            this.make_booking.Name = "make_booking";
            this.make_booking.Size = new System.Drawing.Size(107, 23);
            this.make_booking.TabIndex = 52;
            this.make_booking.Text = "Make Booking";
            this.make_booking.UseVisualStyleBackColor = true;
            this.make_booking.Click += new System.EventHandler(this.make_booking_Click);
            // 
            // remove_booking
            // 
            this.remove_booking.Location = new System.Drawing.Point(5, 422);
            this.remove_booking.Name = "remove_booking";
            this.remove_booking.Size = new System.Drawing.Size(107, 23);
            this.remove_booking.TabIndex = 53;
            this.remove_booking.Text = "Remove Booking";
            this.remove_booking.UseVisualStyleBackColor = true;
            this.remove_booking.Click += new System.EventHandler(this.remove_booking_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.BackColor = System.Drawing.Color.LightYellow;
            this.groupBox3.Controls.Add(this.notAvailableLabel);
            this.groupBox3.Controls.Add(this.availableLabel);
            this.groupBox3.Location = new System.Drawing.Point(238, 7);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(168, 450);
            this.groupBox3.TabIndex = 51;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Messages";
            // 
            // availableLabel
            // 
            this.availableLabel.AutoSize = true;
            this.availableLabel.BackColor = System.Drawing.Color.Green;
            this.availableLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.availableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.availableLabel.ForeColor = System.Drawing.Color.Chartreuse;
            this.availableLabel.Location = new System.Drawing.Point(33, 49);
            this.availableLabel.Name = "availableLabel";
            this.availableLabel.Size = new System.Drawing.Size(103, 28);
            this.availableLabel.TabIndex = 0;
            this.availableLabel.Text = "Available";
            // 
            // notAvailableLabel
            // 
            this.notAvailableLabel.AutoSize = true;
            this.notAvailableLabel.BackColor = System.Drawing.Color.DarkRed;
            this.notAvailableLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.notAvailableLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.notAvailableLabel.ForeColor = System.Drawing.Color.LightSalmon;
            this.notAvailableLabel.Location = new System.Drawing.Point(13, 100);
            this.notAvailableLabel.Name = "notAvailableLabel";
            this.notAvailableLabel.Size = new System.Drawing.Size(143, 28);
            this.notAvailableLabel.TabIndex = 1;
            this.notAvailableLabel.Text = "Not Available";
            // 
            // branchBox
            // 
            this.branchBox.FormattingEnabled = true;
            this.branchBox.Location = new System.Drawing.Point(5, 260);
            this.branchBox.Name = "branchBox";
            this.branchBox.Size = new System.Drawing.Size(121, 21);
            this.branchBox.TabIndex = 55;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(9, 238);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(41, 13);
            this.label25.TabIndex = 54;
            this.label25.Text = "Branch";
            // 
            // dataGridViewTextBoxColumn13
            // 
            this.dataGridViewTextBoxColumn13.HeaderText = "ID";
            this.dataGridViewTextBoxColumn13.Name = "dataGridViewTextBoxColumn13";
            this.dataGridViewTextBoxColumn13.ReadOnly = true;
            this.dataGridViewTextBoxColumn13.Width = 43;
            // 
            // dataGridViewTextBoxColumn14
            // 
            this.dataGridViewTextBoxColumn14.HeaderText = "Rental Date";
            this.dataGridViewTextBoxColumn14.Name = "dataGridViewTextBoxColumn14";
            this.dataGridViewTextBoxColumn14.ReadOnly = true;
            this.dataGridViewTextBoxColumn14.Width = 89;
            // 
            // dataGridViewTextBoxColumn15
            // 
            this.dataGridViewTextBoxColumn15.HeaderText = "Due Date";
            this.dataGridViewTextBoxColumn15.Name = "dataGridViewTextBoxColumn15";
            this.dataGridViewTextBoxColumn15.ReadOnly = true;
            this.dataGridViewTextBoxColumn15.Width = 78;
            // 
            // dataGridViewTextBoxColumn16
            // 
            this.dataGridViewTextBoxColumn16.HeaderText = "Car ID";
            this.dataGridViewTextBoxColumn16.Name = "dataGridViewTextBoxColumn16";
            this.dataGridViewTextBoxColumn16.ReadOnly = true;
            this.dataGridViewTextBoxColumn16.Width = 62;
            // 
            // dataGridViewTextBoxColumn17
            // 
            this.dataGridViewTextBoxColumn17.HeaderText = "Customer ID";
            this.dataGridViewTextBoxColumn17.Name = "dataGridViewTextBoxColumn17";
            this.dataGridViewTextBoxColumn17.ReadOnly = true;
            this.dataGridViewTextBoxColumn17.Width = 90;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Branch ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 80;
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.Color.MintCream;
            this.groupBox4.Controls.Add(this.label0);
            this.groupBox4.Controls.Add(this.connect_button);
            this.groupBox4.Controls.Add(this.connection_status_label);
            this.groupBox4.Location = new System.Drawing.Point(6, 6);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(300, 451);
            this.groupBox4.TabIndex = 3;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Control";
            // 
            // booking_clear
            // 
            this.booking_clear.Location = new System.Drawing.Point(144, 260);
            this.booking_clear.Name = "booking_clear";
            this.booking_clear.Size = new System.Drawing.Size(75, 23);
            this.booking_clear.TabIndex = 56;
            this.booking_clear.Text = "Clear";
            this.booking_clear.UseVisualStyleBackColor = true;
            this.booking_clear.Click += new System.EventHandler(this.booking_clear_Click);
            // 
            // Form1
            // 
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1084, 511);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "291 Rental Car";
            this.tabControl1.ResumeLayout(false);
            this.sql_connection.ResumeLayout(false);
            this.branches_tab.ResumeLayout(false);
            this.branches_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.branchView)).EndInit();
            this.cars_tab.ResumeLayout(false);
            this.cars_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.carView)).EndInit();
            this.customers_tab.ResumeLayout(false);
            this.customers_tab.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customerView)).EndInit();
            this.booking_tab.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.bookingView)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage sql_connection;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label connection_status_label;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.Button list_button;
        private System.Windows.Forms.TabPage branches_tab;
        private System.Windows.Forms.DataGridView branchView;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Addr1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Addr2;
        private System.Windows.Forms.DataGridViewTextBoxColumn city_branchView;
        private System.Windows.Forms.DataGridViewTextBoxColumn province_branchView;
        private System.Windows.Forms.DataGridViewTextBoxColumn postal_code_branchView;
        private System.Windows.Forms.DataGridViewTextBoxColumn phone_branchView;
        private System.Windows.Forms.DataGridViewTextBoxColumn email_branchView;
        private Button branch_row_select;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox8;
        private TextBox textBox7;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox1;
        private Button insert_branch;
        private Button update_branch;
        private Button button_branch_clear;
        private TabPage cars_tab;
        private Button clear_car;
        private Button insert_cars;
        private Button update_cars;
        private TextBox textBox9;
        private TextBox textBox10;
        private TextBox textBox11;
        private TextBox textBox12;
        private TextBox textBox13;
        private TextBox textBox14;
        private Label label11;
        private Label label12;
        private Label label13;
        private Label label14;
        private Label label15;
        private Label label16;
        private Button car_row_select;
        private DataGridView carView;
        private Button car_query;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private Button remove_branch;
        private Button remove_car;
        private TabPage customers_tab;
        private Button remove_customer;
        private Button clear_customer;
        private Button insert_customer;
        private Button update_customer;
        private TextBox textBox15;
        private TextBox textBox16;
        private TextBox textBox17;
        private TextBox textBox18;
        private TextBox textBox19;
        private TextBox textBox20;
        private Label label9;
        private Label label10;
        private Label label17;
        private Label label18;
        private Label label19;
        private Label label20;
        private Button customer_row_select;
        private DataGridView customerView;
        private Button customer_query;
        private TabPage booking_tab;
        private DateTimePicker returnDatePicker;
        private DateTimePicker pickupDatePicker;
        private Label label22;
        private Label label21;
        private Label label23;
        private ComboBox carBox;
        private GroupBox groupBox1;
        private ComboBox customerBox;
        private Label label24;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn11;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn12;
        private GroupBox groupBox2;
        private DataGridView bookingView;
        private Button make_booking;
        private Button check_booking;
        private Button remove_booking;
        private GroupBox groupBox3;
        private Label notAvailableLabel;
        private Label availableLabel;
        private ComboBox branchBox;
        private Label label25;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn13;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn14;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn15;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn16;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn17;
        private DataGridViewTextBoxColumn Column1;
        private GroupBox groupBox4;
        private Button booking_clear;
    }
}

