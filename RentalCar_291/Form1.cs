using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace RentalCar_291
{
    public partial class Form1 : Form
    {
        public SqlCommand dbCommand;
        public SqlDataReader dbReader;
        public SqlConnection dbConnection = new SqlConnection("user id=sa;" +
                                                              "password=cmpt291rd%;" +
                                                              //"server = localhost;" +
                                                              "data source=(local);" +
                                                              "initial catalog=291-RentalCar");

        public Int32 branch_id = 0;
        public string address_line_1;
        public string address_line_2;
        public string city;
        public string province;
        public string postal_code;
        public string phone;
        public string email;

        public Int32 car_id = 0;
        public string make;
        public string model;
        public Int32 year;
        public string color;
        public Int32 mileage;

        public Int32 customer_id = 0;
        public string full_name;
        public string c_phone;
        public string c_email;
        public string gold_star;
        public decimal balance_owed;

        public bool conn_flag = false;


        public Form1()
        {
            InitializeComponent();

        }

        private void connect_button_Click(object sender, EventArgs e)
        {

            try
            {
                dbConnection.Open();
                dbCommand = new SqlCommand();
                dbCommand.Connection = dbConnection;
                if (dbConnection.State == ConnectionState.Open)
                {
                    connection_status_label.ForeColor = Color.Green;
                    connection_status_label.Text = "Connected!";
                    conn_flag = true;
                }
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString(), "Error");
            }

        }

        private void check_conn()
        {
            if (dbConnection.State == ConnectionState.Open)
            {
                connection_status_label.ForeColor = Color.Green;
                connection_status_label.Text = "Connected";
                conn_flag = true;
            } else
            {
                connection_status_label.ForeColor = Color.Firebrick;
                connection_status_label.Text = "Not Connected";
                conn_flag = false;
            }
        }

        private void sql_connection_Enter(object sender, EventArgs e)
        {
            check_conn();
        }

    /*
    *  BRANCH *******************************************************************
    * 
    */

        private void branches_tab_Click(object sender, EventArgs e)
        {

        }

        private void branches_tab_Enter(object sender, EventArgs e)
        {
            branches_tab_clear();
            branches_tab_query();
        }

        private void list_button_Click(object sender, EventArgs e)
        {
            branches_tab_query();
        }

        private void branches_tab_query()
        {
            check_conn();
            if (conn_flag)
            {
                dbCommand.CommandText = "Select * from branch";
                dbReader = dbCommand.ExecuteReader();

                try
                {
                    branchView.Rows.Clear();
                    while (dbReader.Read())
                    {
                        branchView.Rows.Add(dbReader["branch_id"].ToString(),
                                                dbReader["address_line_1"].ToString(),
                                                dbReader["address_line_2"].ToString(),
                                                dbReader["city"].ToString(),
                                                dbReader["province"].ToString(),
                                                dbReader["postal_code"].ToString(),
                                                dbReader["phone"].ToString().Trim(),
                                                dbReader["email"].ToString().Trim());
                    }
                    branchView.AutoResizeColumns();
                    dbReader.Close();
                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString(), "Error");
                }
            }
        }

        private void branchView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void branch_row_select_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = branchView.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                branch_id = Convert.ToInt32(branchView.SelectedCells[0].Value);
                address_line_1 = branchView.SelectedCells[1].Value.ToString().Trim();
                address_line_2 = branchView.SelectedCells[2].Value.ToString().Trim();
                city = branchView.SelectedCells[3].Value.ToString().Trim();
                province =  branchView.SelectedCells[4].Value.ToString().Trim();
                postal_code = branchView.SelectedCells[5].Value.ToString().Trim();
                phone = branchView.SelectedCells[6].Value.ToString().Trim();
                email = branchView.SelectedCells[7].Value.ToString().Trim();

                textBox1.Text = branch_id.ToString();
                textBox2.Text = address_line_1;
                textBox3.Text = address_line_2;
                textBox4.Text = city;
                textBox5.Text = province;
                textBox6.Text = postal_code;
                textBox7.Text = phone;
                textBox8.Text = email;
            }
        }

        private void button_branch_clear_Click(object sender, EventArgs e)
        {
            branches_tab_clear();
        }

        private void update_branch_Click(object sender, EventArgs e)
        {
            check_conn();
            if (conn_flag)
            {
                address_line_1 = textBox2.Text;
                address_line_2 = textBox3.Text;
                city = textBox4.Text;
                province = textBox5.Text;
                postal_code = textBox6.Text;
                phone = textBox7.Text;
                email = textBox8.Text;

                string insertID = textBox1.Text;
                Int32 intInsertID;

                if (Int32.TryParse(insertID, out intInsertID) && branch_id > 0)

                {
                    try
                    {
                        dbCommand.CommandText = "UPDATE branch SET address_line_1 = '" + address_line_1
                                                + "',address_line_2 = '" + address_line_2
                                                + "', city = '" + city
                                                + "', province = '" + province
                                                + "', postal_code = '" + postal_code
                                                + "', phone = '" + phone
                                                + "', email = '" + email
                                                + "' WHERE branch_id = " + intInsertID;
                        //MessageBox.Show(dbCommand.CommandText.ToString(), "Update statement");
                        dbCommand.ExecuteNonQuery();
                        branches_tab_clear();
                        branches_tab_query();
                    }
                    catch (Exception eU)
                    {
                        MessageBox.Show(eU.ToString(), "Error");
                    }
                }
            }
        }

        private void insert_branch_Click(object sender, EventArgs e)
        {
            check_conn();
            if (conn_flag)
            {
                address_line_1 = textBox2.Text;
                address_line_2 = textBox3.Text;
                city = textBox4.Text;
                province = textBox5.Text;
                postal_code = textBox6.Text;
                phone = textBox7.Text;
                email = textBox8.Text;

                string insertID = textBox1.Text;
                Int32 intInsertID;
                if (Int32.TryParse(insertID, out intInsertID))
                {
                    try
                    {
                        dbCommand.CommandText = "INSERT INTO branch VALUES (" + intInsertID
                                                + ", '" + address_line_1
                                                + "', '" + address_line_2
                                                + "', '" + city
                                                + "', '" + province
                                                + "', '" + postal_code
                                                + "', '" + phone
                                                + "', '" + email
                                                + "')";
                        //MessageBox.Show(dbCommand.CommandText.ToString(), "Insert statement");
                        dbCommand.ExecuteNonQuery();
                        branches_tab_clear();
                        branches_tab_query();
                    }
                    catch (Exception eI)
                    {
                        MessageBox.Show(eI.ToString(), "Error");
                    }
                }
            }

        }

        private void remove_branch_Click(object sender, EventArgs e)
        {
            check_conn();
            if (conn_flag)
            {
                string insertID = textBox1.Text;
                Int32 intInsertID;
                if (Int32.TryParse(insertID, out intInsertID))
                {
                    try
                    {
                        dbCommand.CommandText = "DELETE FROM branch WHERE branch_id = " + intInsertID;
                        //MessageBox.Show(dbCommand.CommandText.ToString(), "Delete statement");
                        dbCommand.ExecuteNonQuery();
                        branches_tab_clear();
                        branches_tab_query();
                    }
                    catch (Exception eI)
                    {
                        MessageBox.Show(eI.ToString(), "Error");
                    }
                }
            }
        }

        private void branches_tab_clear()
        {
            textBox1.Clear();
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
        }

    /*
    * CAR *******************************************************************
    * 
    */

        private void cars_tab_Enter(object sender, EventArgs e)
        {
            car_tab_clear();
            car_tab_query();
        }

        private void car_tab_clear()
        {
            textBox14.Clear();
            textBox13.Clear();
            textBox12.Clear();
            textBox11.Clear();
            textBox10.Clear();
            textBox9.Clear();
        }

        private void car_tab_query()
        {
            check_conn();
            if (conn_flag)
            {
                dbCommand.CommandText = "Select * from car";
                dbReader = dbCommand.ExecuteReader();

                try
                {
                    carView.Rows.Clear();
                    while (dbReader.Read())
                    {
                        carView.Rows.Add(dbReader["car_id"].ToString(),
                                                dbReader["make"].ToString(),
                                                dbReader["model"].ToString(),
                                                dbReader["year"].ToString(),
                                                dbReader["color"].ToString(),
                                                dbReader["mileage"].ToString());
                    }
                    carView.AutoResizeColumns();
                    dbReader.Close();

                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString(), "Error");
                }
            }
        }

        private void car_query_Click(object sender, EventArgs e)
        {
            car_tab_query();
        }

        private void car_row_select_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = carView.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                car_id = Convert.ToInt32(carView.SelectedCells[0].Value);
                make = carView.SelectedCells[1].Value.ToString().Trim();
                model = carView.SelectedCells[2].Value.ToString().Trim();
                year = Convert.ToInt32(carView.SelectedCells[3].Value);
                color = carView.SelectedCells[4].Value.ToString().Trim();
                mileage = Convert.ToInt32(carView.SelectedCells[5].Value);

                textBox14.Text = car_id.ToString();
                textBox13.Text = make;
                textBox12.Text = model;
                textBox11.Text = year.ToString();
                textBox10.Text = color;
                textBox9.Text = mileage.ToString();
            }
        }

        private void clear_car_Click(object sender, EventArgs e)
        {
            car_tab_clear();
        }

        private void update_cars_Click(object sender, EventArgs e)
        {
            check_conn();
            if (conn_flag)
            {
                make = textBox13.Text;
                model = textBox12.Text;
                Int32.TryParse(textBox11.Text, out year);
                color = textBox10.Text;
                Int32.TryParse(textBox9.Text, out mileage);

                string insertID = textBox14.Text;
                Int32 intInsertID;

                if (Int32.TryParse(insertID, out intInsertID) && car_id > 0)

                {
                    try
                    {
                        dbCommand.CommandText = "UPDATE car SET make = '" + make
                                                + "',model = '" + model
                                                + "', year = " + year
                                                + ", color = '" + color
                                                + "', mileage = " + mileage
                                                + " WHERE car_id = " + intInsertID;
                        //MessageBox.Show(dbCommand.CommandText.ToString(), "Update statement");
                        dbCommand.ExecuteNonQuery();
                        car_tab_clear();
                        car_tab_query();
                    }
                    catch (Exception eU)
                    {
                        MessageBox.Show(eU.ToString(), "Error");
                    }
                }
            }
        }

        private void insert_cars_Click(object sender, EventArgs e)
        {
            check_conn();
            if (conn_flag)
            {
                make = textBox13.Text;
                model = textBox12.Text;
                Int32.TryParse(textBox11.Text, out year);
                color = textBox10.Text;
                Int32.TryParse(textBox9.Text, out mileage);

                string insertID = textBox14.Text;
                Int32 intInsertID;

                if (Int32.TryParse(insertID, out intInsertID))
                {
                    try
                    {
                        dbCommand.CommandText = "INSERT INTO car VALUES (" + intInsertID
                                                                        + ", '" + make
                                                                        + "', '" + model
                                                                        + "', " + year
                                                                        + ", '" + color
                                                                        + "', " + mileage
                                                                        + ")";
                        //MessageBox.Show(dbCommand.CommandText.ToString(), "Insert statement");
                        dbCommand.ExecuteNonQuery();
                        car_tab_clear();
                        car_tab_query();
                    }
                    catch (Exception eI)
                    {
                        MessageBox.Show(eI.ToString(), "Error");
                    }
                }
            } else
            {
                MessageBox.Show(conn_flag.ToString(), "Conn?");
            }
        }

        private void remove_car_Click(object sender, EventArgs e)
        {
            check_conn();
            if (conn_flag)
            {
                string insertID = textBox14.Text;
                Int32 intInsertID;
                if (Int32.TryParse(insertID, out intInsertID))
                {
                    try
                    {
                        dbCommand.CommandText = "DELETE FROM car WHERE car_id = " + intInsertID;
                        //MessageBox.Show(dbCommand.CommandText.ToString(), "Delete statement");
                        dbCommand.ExecuteNonQuery();
                        car_tab_clear();
                        car_tab_query();
                    }
                    catch (Exception eI)
                    {
                        MessageBox.Show(eI.ToString(), "Error");
                    }
                }
            }
        }

    /*
    * CUSTOMER *******************************************************************
    * 
    */

         private void customers_tab_Enter(object sender, EventArgs e)
        {
            customer_tab_clear();
            customer_tab_query();
        }

        private void customer_tab_clear()
        {
            textBox20.Clear();
            textBox19.Clear();
            textBox18.Clear();
            textBox17.Clear();
            textBox16.Clear();
            textBox15.Clear();
        }

        private void customer_tab_query()
        {
            check_conn();
            if (conn_flag)
            {
                dbCommand.CommandText = "Select * from customer";
                dbReader = dbCommand.ExecuteReader();

                try
                {
                    customerView.Rows.Clear();
                    while (dbReader.Read())
                    {
                        customerView.Rows.Add(dbReader["customer_id"].ToString(),
                                                dbReader["full_name"].ToString(),
                                                dbReader["phone"].ToString(),
                                                dbReader["email"].ToString(),
                                                dbReader["gold_star"].ToString(),
                                                dbReader["balance_owed"].ToString());
                    }
                    customerView.AutoResizeColumns();
                    dbReader.Close();

                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString(), "Error");
                }
            }
        }

        private void customer_query_Click(object sender, EventArgs e)
        {
            customer_tab_query();
        }

        private void customer_row_select_Click(object sender, EventArgs e)
        {
            Int32 selectedCellCount = customerView.GetCellCount(DataGridViewElementStates.Selected);
            if (selectedCellCount > 0)
            {
                customer_id = Convert.ToInt32(customerView.SelectedCells[0].Value);
                full_name = customerView.SelectedCells[1].Value.ToString().Trim();
                c_phone = customerView.SelectedCells[2].Value.ToString().Trim();
                c_email = customerView.SelectedCells[3].Value.ToString().Trim();
                gold_star = customerView.SelectedCells[4].Value.ToString().Trim();
                Decimal.TryParse(customerView.SelectedCells[5].Value.ToString(), out balance_owed);

                textBox20.Text = customer_id.ToString();
                textBox19.Text = full_name;
                textBox18.Text = c_phone;
                textBox17.Text = c_email;
                textBox16.Text = gold_star;
                textBox15.Text = balance_owed.ToString();
            }
        }

        private void clear_customer_Click(object sender, EventArgs e)
        {
            customer_tab_clear();
        }

        private void update_customer_Click(object sender, EventArgs e)
        {
            check_conn();
            if (conn_flag)
            {
                full_name = textBox19.Text;
                c_phone = textBox18.Text;
                c_email = textBox17.Text;
                gold_star = textBox16.Text;
                Decimal.TryParse(textBox15.Text, out balance_owed);

                string insertID = textBox20.Text;
                Int32 intInsertID;

                if (Int32.TryParse(insertID, out intInsertID) && customer_id > 0)

                {
                    try
                    {
                        dbCommand.CommandText = "UPDATE customer SET full_name = '" + full_name
                                                + "', phone = '" + c_phone
                                                + "', email = '" + c_email
                                                + "', gold_star = '" + gold_star
                                                + "', balance_owed = " + balance_owed
                                                + " WHERE customer_id = " + intInsertID;
                        //MessageBox.Show(dbCommand.CommandText.ToString(), "Update statement");
                        dbCommand.ExecuteNonQuery();
                        customer_tab_clear();
                        customer_tab_query();
                    }
                    catch (Exception eU)
                    {
                        MessageBox.Show(eU.ToString(), "Error");
                    }
                }
            }
        }

        private void insert_customer_Click(object sender, EventArgs e)
        {
            check_conn();
            if (conn_flag)
            {
                full_name = textBox19.Text;
                c_phone = textBox18.Text;
                c_email = textBox17.Text;
                gold_star = textBox16.Text;
                Decimal.TryParse(textBox15.Text, out balance_owed);

                string insertID = textBox20.Text;
                Int32 intInsertID;

                if (Int32.TryParse(insertID, out intInsertID))
                {
                    try
                    {
                        dbCommand.CommandText = "INSERT INTO customer VALUES (" + intInsertID
                                                                        + ", '" + full_name
                                                                        + "', '" + c_phone
                                                                        + "', '" + c_email
                                                                        + "', '" + gold_star
                                                                        + "', " + balance_owed
                                                                        + ")";
                        //MessageBox.Show(dbCommand.CommandText.ToString(), "Insert statement");
                        dbCommand.ExecuteNonQuery();
                        customer_tab_clear();
                        customer_tab_query();
                    }
                    catch (Exception eI)
                    {
                        MessageBox.Show(eI.ToString(), "Error");
                    }
                }
            }
            else
            {
                MessageBox.Show(conn_flag.ToString(), "Conn?");
            }
        }

        private void remove_customer_Click(object sender, EventArgs e)
        {
            check_conn();
            if (conn_flag)
            {
                string insertID = textBox20.Text;
                Int32 intInsertID;
                if (Int32.TryParse(insertID, out intInsertID))
                {
                    try
                    {
                        dbCommand.CommandText = "DELETE FROM customer WHERE customer_id = " + intInsertID;
                        //MessageBox.Show(dbCommand.CommandText.ToString(), "Delete statement");
                        dbCommand.ExecuteNonQuery();
                        customer_tab_clear();
                        customer_tab_query();
                    }
                    catch (Exception eI)
                    {
                        MessageBox.Show(eI.ToString(), "Error");
                    }
                }
            }
        }

        /*
        * BOOKING *******************************************************************
        * 
        */

        private void booking_tab_Enter(object sender, EventArgs e)
        {
            booking_tab_boxpopulate();
            booking_tab_query();
            availableLabel.Visible = false;
            notAvailableLabel.Visible = false;
        }

        private void booking_tab_boxpopulate()
        {
            check_conn();
            if (conn_flag)
            {
                try
                {
                    string car_query = "SELECT car_id, model FROM car";

                    SqlDataAdapter carA = new SqlDataAdapter(car_query, dbConnection);
                    DataSet carSet = new DataSet();
                    carA.Fill(carSet, "Car");

                    carBox.DisplayMember = "model";
                    carBox.ValueMember = "car_id";
                    carBox.DataSource = carSet.Tables["Car"];

                    string customer_query = "SELECT customer_id, trim(full_name) trim_name FROM customer";

                    SqlDataAdapter customerA = new SqlDataAdapter(customer_query, dbConnection);
                    DataSet customerSet = new DataSet();
                    customerA.Fill(customerSet, "Customer");

                    customerBox.DisplayMember = "trim_name";
                    customerBox.ValueMember = "customer_id";
                    customerBox.DataSource = customerSet.Tables["Customer"];

                    string branch_query = "SELECT branch_id, trim(city) trim_city FROM branch";

                    SqlDataAdapter branchA = new SqlDataAdapter(branch_query, dbConnection);
                    DataSet branchSet = new DataSet();
                    branchA.Fill(branchSet, "Branch");

                    branchBox.DisplayMember = "trim_city";
                    branchBox.ValueMember = "branch_id";
                    branchBox.DataSource = branchSet.Tables["Branch"];

                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString(), "Error");
                }
            }
        }

        private void booking_tab_query()
        {
            check_conn();
            if (conn_flag)
            {
                dbCommand.CommandText = "Select * from booking";
                dbReader = dbCommand.ExecuteReader();

                try
                {
                    bookingView.Rows.Clear();
                    while (dbReader.Read())
                    {
                        bookingView.Rows.Add(dbReader["booking_id"].ToString(),
                                                dbReader["rental_date"].ToString(),
                                                dbReader["due_date"].ToString(),
                                                dbReader["car_id"].ToString(),
                                                dbReader["customer_id"].ToString(),
                                                dbReader["branch_id"].ToString());
                    }
                    bookingView.AutoResizeColumns();
                    dbReader.Close();

                }
                catch (Exception e1)
                {
                    MessageBox.Show(e1.ToString(), "Error");
                }
            }
        }

        private void check_booking_Click(object sender, EventArgs e)
        {
            check_availability();
        }

        private void check_availability()
        {
            availableLabel.Visible = false;
            notAvailableLabel.Visible = false;

            DateTime pickupDate = DateTime.Parse(pickupDatePicker.Value.ToShortDateString());
            DateTime returnDate = DateTime.Parse(returnDatePicker.Value.ToShortDateString());

            
            string book_car_id = carBox.SelectedValue.ToString();
            string book_customer_id = customerBox.SelectedValue.ToString();
            //string book_customer_id = customerBox.SelectedItem.ToString();
            //string book_car_id = carBox.GetItemText(carBox.SelectedItem);

            //MessageBox.Show(book_car_id + " " + book_customer_id, "ComboBox Strings");

            Int32 check_car_id = Convert.ToInt32(book_car_id);
            Int32 check_customer_id = Convert.ToInt32(book_customer_id);

            //string booking_query = "SELECT * FROM booking WHERE car_id = " + check_car_id + " AND due_date < '" + pickupDate.ToShortDateString() + "'";
            //MessageBox.Show(booking_query, "Check availability query");

            string booking_query = "SELECT * FROM booking WHERE car_id = " + check_car_id;

            SqlDataAdapter bookingA = new SqlDataAdapter(booking_query, dbConnection);
            DataSet bookingSet = new DataSet();
            bookingA.Fill(bookingSet, "Booking");

            if (bookingSet.Tables["Booking"].Rows.Count == 0)
            {
                availableLabel.Visible = true; 
            }
            else
            {
                /*DataRow[] checkRows;
                checkRows = bookingSet.Tables["Booking"].Select("due_date < '" + pickupDate.ToShortDateString() + "'");
                if (checkRows.Length == 0)
                {
                    notAvailableLabel.Visible = true;
                }*/
                booking_query = "SELECT * FROM booking WHERE car_id = " + check_car_id + " AND due_date < '" + pickupDate.ToShortDateString() + "'";
                bookingA = new SqlDataAdapter(booking_query, dbConnection);
                bookingSet = new DataSet();
                bookingA.Fill(bookingSet, "Booking");

                if (bookingSet.Tables["Booking"].Rows.Count == 0)
                {
                    notAvailableLabel.Visible = true;
                }

                booking_query = "SELECT * FROM booking WHERE car_id = " + check_car_id + " AND rental_date <= '" + returnDate.ToShortDateString() + "'"
                                + " AND due_date >= '" + pickupDate.ToShortDateString() + "'";
                bookingA = new SqlDataAdapter(booking_query, dbConnection);
                bookingSet = new DataSet();
                bookingA.Fill(bookingSet, "Booking");

                if (bookingSet.Tables["Booking"].Rows.Count == 0)
                {
                    notAvailableLabel.Visible = false;
                    availableLabel.Visible = true;
                }



            }

        }

        private void make_booking_Click(object sender, EventArgs e)
        {
            availableLabel.Visible = false;
            notAvailableLabel.Visible = false;

            DateTime pickupDate = DateTime.Parse(pickupDatePicker.Value.ToShortDateString());
            DateTime returnDate = DateTime.Parse(returnDatePicker.Value.ToShortDateString());

            string box_car_id = carBox.SelectedValue.ToString();
            string box_customer_id = customerBox.SelectedValue.ToString();
            string box_branch_id = branchBox.SelectedValue.ToString();

            Int32 make_car_id = Convert.ToInt32(box_car_id);
            Int32 make_customer_id = Convert.ToInt32(box_customer_id);
            Int32 make_branch_id = Convert.ToInt32(box_branch_id);

            string id_query = "SELECT booking_id FROM booking";
            SqlDataAdapter idA = new SqlDataAdapter(id_query, dbConnection);
            DataSet idSet = new DataSet();
            idA.Fill(idSet, "Booking ID");

            Int32 booking_id = idSet.Tables["Booking ID"].Rows.Count + 1;

            check_conn();
            if (conn_flag)
            {
                try
                {
                    dbCommand.CommandText = "INSERT INTO booking VALUES (" + booking_id
                                                                    + ", '" + pickupDate.ToShortDateString()
                                                                    + "', '" + returnDate.ToShortDateString()
                                                                    + "', " + make_car_id
                                                                    + ", " + make_customer_id
                                                                    + ", " + make_branch_id
                                                                    + ")";
                    //MessageBox.Show(dbCommand.CommandText.ToString(), "Insert statement");
                    dbCommand.ExecuteNonQuery();

                    booking_tab_query();
                }
                catch (Exception eI)
                {
                    MessageBox.Show(eI.ToString(), "Error");
                }
            
            }

        }

        private void remove_booking_Click(object sender, EventArgs e)
        {
            check_conn();
            if (conn_flag)
            {
                availableLabel.Visible = false;
                notAvailableLabel.Visible = false;

                try
                {
                    Int32 booking_id = Convert.ToInt32(bookingView.SelectedCells[0].Value);
                    dbCommand.CommandText = "DELETE FROM booking WHERE booking_id = " + booking_id;
                    //MessageBox.Show(dbCommand.CommandText.ToString(), "Delete statement");
                    dbCommand.ExecuteNonQuery();
                    //customer_tab_clear();
                    booking_tab_query();
                }
                catch (Exception eI)
                {
                    MessageBox.Show(eI.ToString(), "Error");
                }
            }
        }

        private void booking_clear_Click(object sender, EventArgs e)
        {
            booking_tab_boxpopulate();
            booking_tab_query();
            availableLabel.Visible = false;
            notAvailableLabel.Visible = false;
            pickupDatePicker.ResetText();
            returnDatePicker.ResetText();
        }
    }
}
