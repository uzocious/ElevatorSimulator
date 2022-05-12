using System;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace ElevatorSimulator
{
    public partial class Form1 : Form
    {
        // Constant variables
        private const int y_axis_go_up = 38;
        private const int y_axis_go_down = 398;
        private const int x_axis_leftdoor_open = 51;
        private const int x_axis_rightdoor_open = 271;
        private const int x_axis_leftdoor_close = 125;
        private const int x_axis_rightdoor_close = 198;

        // Primary variable
        private int present_floor = 0; // 0 (GoundFloor), 1 (FirstFloor)

        // Key variables for tracking elevator activities
        // Default is set to false
        private bool going_up_initiated = false;
        private bool going_down_initiated = false;
        private bool ff_doors_open_completed = false;
        private bool gf_doors_open_completed = false;

        // Elevator image and GIF variables
        Image image_going_up = Image.FromFile(@".\images\elev_going_up.gif");
        Image image_going_down = Image.FromFile(@".\images\elev_going_down.gif");
        Image image_first_floor = Image.FromFile(@".\images\elev_first_floor.png");
        Image image_ground_floor = Image.FromFile(@".\images\elev_ground_floor.png");

        // Database connection string
        private const string dbConnection = "Provider=Microsoft.ACE.OLEDB.12.0;" + @"Data Source=.\ElevatorSimulatorDB.accdb;";



        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DisplayWindowGroundFloor();
        }



        //
        // Display windows methods
        //
        private void DisplayWindowGoingUp()
        {
            picElevatorCarDisplayWindow.Image = image_going_up;
            pic1stFloorDisplayWindow.Image = image_going_up;
            picGroundFloorDisplayWindow.Image = image_going_up;
        }

        private void DisplayWindowGoingDown()
        {
            picElevatorCarDisplayWindow.Image = image_going_down;
            pic1stFloorDisplayWindow.Image = image_going_down;
            picGroundFloorDisplayWindow.Image = image_going_down;
        }

        private void DisplayWindowFirstFloor()
        {
            picElevatorCarDisplayWindow.Image = image_first_floor;
            pic1stFloorDisplayWindow.Image = image_first_floor;
            picGroundFloorDisplayWindow.Image = image_first_floor;
        }

        private void DisplayWindowGroundFloor()
        {
            picElevatorCarDisplayWindow.Image = image_ground_floor;
            pic1stFloorDisplayWindow.Image = image_ground_floor;
            picGroundFloorDisplayWindow.Image = image_ground_floor;
        }




        //
        // Elevator database status strings
        //
        string db_firstFloor = "First Floor";
        string db_groundFloor = "Ground Floor";
        string db_goingUp = "Going Up";
        string db_goingDown = "Going Down";
        string db_doorsOpened_gf = "Doors Opened @ Ground Floor";
        string db_doorsClosed_gf = "Doors Closed @ Ground Floor";
        string db_doorsOpened_ff = "Doors Opened @ First Floor";
        string db_doorClosed_ff = "Doors Closed @ First Floor";

        //
        // Elevator database list box items string methods
        //
        private string DBFirstFloor()
        {
            string time = string.Format("{0:hh:mm:ss tt}", DateTime.Now);
            string date = string.Format("{0:dd/MM/yyyy}", DateTime.Now);
            string firstFloor = string.Format($"{time} \t\t {date} \t {db_firstFloor}");
            return firstFloor;
        }

        private string DBGroundFloor()
        {
            string time = string.Format("{0:hh:mm:ss tt}", DateTime.Now);
            string date = string.Format("{0:dd/MM/yyyy}", DateTime.Now);
            string groundFloor = string.Format($"{time} \t\t {date} \t {db_groundFloor}");
            return groundFloor;
        }

        private string DBGoingUp()
        {
            string time = string.Format("{0:hh:mm:ss tt}", DateTime.Now);
            string date = string.Format("{0:dd/MM/yyyy}", DateTime.Now);
            string goingUp = string.Format($"{time} \t\t {date} \t {db_goingUp}");
            return goingUp;
        }

        private string DBGoingDown()
        {
            string time = string.Format("{0:hh:mm:ss tt}", DateTime.Now);
            string date = string.Format("{0:dd/MM/yyyy}", DateTime.Now);
            string goingDown = string.Format($"{time} \t\t {date} \t {db_goingDown}");
            return goingDown;
        }

        private string DBDoorsOpened_GF()
        {
            string time = string.Format("{0:hh:mm:ss tt}", DateTime.Now);
            string date = string.Format("{0:dd/MM/yyyy}", DateTime.Now);
            string doorsOpened_gf = string.Format($"{time} \t\t {date} \t {db_doorsOpened_gf}");
            return doorsOpened_gf;
        }

        private string DBDoorsClosed_GF()
        {
            string time = string.Format("{0:hh:mm:ss tt}", DateTime.Now);
            string date = string.Format("{0:dd/MM/yyyy}", DateTime.Now);
            string doorsClosed_gf = string.Format($"{time} \t\t {date} \t {db_doorsClosed_gf}");
            return doorsClosed_gf;
        }

        private string DBDoorsOpened_FF()
        {
            string time = string.Format("{0:hh:mm:ss tt}", DateTime.Now);
            string date = string.Format("{0:dd/MM/yyyy}", DateTime.Now);
            string doorsOpened_ff = string.Format($"{time} \t\t {date} \t {db_doorsOpened_ff}");
            return doorsOpened_ff;
        }

        private string DBDoorsClosed_FF()
        {
            string time = string.Format("{0:hh:mm:ss tt}", DateTime.Now);
            string date = string.Format("{0:dd/MM/yyyy}", DateTime.Now);
            string doorsClosed_ff = string.Format($"{time} \t\t {date} \t {db_doorClosed_ff}");
            return doorsClosed_ff;
        }





        //
        // Elevator Button Delegations (Click Event Handlers)
        //
        private void btn1stFloorRequestButton_Click(object sender, EventArgs e)
        {
            // _validation: Prevents interruptions while elevator process is in motion
            if (tmrElevatorCar_InMotion_Controller.Enabled == true || tmrDoorsOpening_Controller.Enabled == true
                || tmrElevCar_InMotion_after_DoorsClosed_Controller.Enabled == true)
            { return; }


            // _validation: opens the first floor doors when doors are closed
            if (present_floor == 1 && ff_doors_open_completed == false)
            {
                tmrDoorsClosing_Controller.Stop();
                tmrDoorsOpening_Controller.Start();
                btn1stFloorRequestButton.ForeColor = Color.Red; // change button colour
                tmrAutomatic_DoorsClosing_Controller.Start(); // doors close automatically after a period of time
            }

            // _validation: Opens doors at first floor when automatic doors is closing
            if (present_floor == 1 && tmrAutomatic_DoorsClosing_Controller.Enabled == true
                && tmrDoorsClosing_Controller.Enabled == true)
            {
                tmrAutomatic_DoorsClosing_Controller.Stop();
                tmrDoorsClosing_Controller.Stop();
                tmrDoorsOpening_Controller.Start();
                tmrAutomatic_DoorsClosing_Controller.Start();
                return;
            }

            // Request for the lift presently in the ground floor to the first floor
            if (present_floor == 0 && gf_doors_open_completed == false)
            {
                going_up_initiated = true;
                tmrElevatorCar_InMotion_Controller.Start();
                btn1stFloorRequestButton.ForeColor = Color.Red; // change button colour
                DisplayWindowGoingUp(); // sets display window to going up
                InsertToDB(db_goingUp, DBGoingUp()); // inserts to database

            }
            else if (present_floor == 0 && gf_doors_open_completed == true)
            {
                tmrDoorsClosing_Controller.Start();
                tmrElevCar_InMotion_after_DoorsClosed_Controller.Start();
                btn1stFloorRequestButton.ForeColor = Color.Red; // change button colour
                DisplayWindowGoingUp(); // sets display window to going up
            }
        }


        private void btnGroundFloorRequestButton_Click(object sender, EventArgs e)
        {
            // _validation: Prevents interruptions while elevator process is in motion
            if (tmrElevatorCar_InMotion_Controller.Enabled == true || tmrDoorsOpening_Controller.Enabled == true
                || tmrElevCar_InMotion_after_DoorsClosed_Controller.Enabled == true)
            { return; }

            // _validation: opens the ground floor doors when doors are closed
            if (present_floor == 0 && gf_doors_open_completed == false)
            {
                tmrDoorsClosing_Controller.Stop();
                tmrDoorsOpening_Controller.Start();
                btnGroundFloorRequestButton.ForeColor = Color.Red; // change button colour
                tmrAutomatic_DoorsClosing_Controller.Start(); // doors close automatically after a period of time
            }

            // _validation: Opens doors at ground floor when automatic doors is closing
            if (present_floor == 0 && tmrAutomatic_DoorsClosing_Controller.Enabled == true
                && tmrDoorsClosing_Controller.Enabled == true)
            {
                tmrAutomatic_DoorsClosing_Controller.Stop();
                tmrDoorsClosing_Controller.Stop();
                tmrDoorsOpening_Controller.Start();
                tmrAutomatic_DoorsClosing_Controller.Start();
                return;
            }

            // Request for the lift presently in the first floor to the ground floor
            if (present_floor == 1 && ff_doors_open_completed == false)
            {
                going_down_initiated = true;
                tmrElevatorCar_InMotion_Controller.Start();
                btnGroundFloorRequestButton.ForeColor = Color.Red; // change button colour
                DisplayWindowGoingDown(); // sets display window to going down
                InsertToDB(db_goingDown, DBGoingDown()); // inserts to database
            }
            else if (present_floor == 1 && ff_doors_open_completed == true)
            {
                tmrDoorsClosing_Controller.Start();
                tmrElevCar_InMotion_after_DoorsClosed_Controller.Start();
                btnGroundFloorRequestButton.ForeColor = Color.Red; // change button colour
                DisplayWindowGoingDown(); // sets display window to going down
            }
        }


        private void btnGoingUp_FirstFloor_Click(object sender, EventArgs e)
        {
            // _validations: Prevents interruptions while elevator process is in motion
            if (tmrElevatorCar_InMotion_Controller.Enabled == true || tmrDoorsOpening_Controller.Enabled == true
                || tmrElevCar_InMotion_after_DoorsClosed_Controller.Enabled == true)
            { return; }

            // _validation: opens the first floor doors when doors are closed
            if (present_floor == 1 && ff_doors_open_completed == false)
            {
                tmrDoorsClosing_Controller.Stop();
                tmrDoorsOpening_Controller.Start();
                btnGoingUp_FirstFloor.ForeColor = Color.Red; // change button colour
                tmrAutomatic_DoorsClosing_Controller.Start(); // doors close automatically after a period of time
            }

            // _validation: Opens doors at first floor when automatic doors is closing
            if (present_floor == 1 && tmrAutomatic_DoorsClosing_Controller.Enabled == true
                && tmrDoorsClosing_Controller.Enabled == true)
            {
                tmrAutomatic_DoorsClosing_Controller.Stop();
                tmrDoorsClosing_Controller.Stop();
                tmrDoorsOpening_Controller.Start();
                tmrAutomatic_DoorsClosing_Controller.Start();
                return;
            }

            // Elevator going up
            if (gf_doors_open_completed == false && present_floor == 0)
            {
                going_up_initiated = true;
                tmrElevatorCar_InMotion_Controller.Start();

                btnGoingUp_FirstFloor.ForeColor = Color.Red;// change button colour
                DisplayWindowGoingUp(); // sets display window to going up
                InsertToDB(db_goingUp, DBGoingUp()); // inserts to database
            }
            else if (gf_doors_open_completed == true)
            {
                tmrDoorsClosing_Controller.Start();
                tmrElevCar_InMotion_after_DoorsClosed_Controller.Start();

                btnGoingUp_FirstFloor.ForeColor = Color.Red;// change button colour
                DisplayWindowGoingUp(); // sets display window to going up
            }
        }


        private void btnGoingDown_GroundFloor_Click(object sender, EventArgs e)
        {
            // _validation: Prevents interruptions while elevator process is in motion
            if (tmrElevatorCar_InMotion_Controller.Enabled == true || tmrDoorsOpening_Controller.Enabled == true
                || tmrElevCar_InMotion_after_DoorsClosed_Controller.Enabled == true)
            { return; }

            // _validation: opens the ground floor doors when doors are closed
            if (present_floor == 0 && gf_doors_open_completed == false)
            {
                tmrDoorsClosing_Controller.Stop();
                tmrDoorsOpening_Controller.Start();
                btnGoingDown_GroundFloor.ForeColor = Color.Red; // change button colour
                tmrAutomatic_DoorsClosing_Controller.Start(); // doors close automatically after a period of time
            }

            // _validation: Opens doors at ground floor when automatic doors is closing
            if (present_floor == 0 && tmrAutomatic_DoorsClosing_Controller.Enabled == true 
                && tmrDoorsClosing_Controller.Enabled == true)
            {
                tmrAutomatic_DoorsClosing_Controller.Stop();
                tmrDoorsClosing_Controller.Stop();
                tmrDoorsOpening_Controller.Start();
                tmrAutomatic_DoorsClosing_Controller.Start();
                return;
            }

            // Elevator going down
            if (ff_doors_open_completed == false && present_floor == 1)
            {
                going_down_initiated = true;
                tmrElevatorCar_InMotion_Controller.Start();

                btnGoingDown_GroundFloor.ForeColor = Color.Red; // change button colour
                DisplayWindowGoingDown(); // sets display window to going down
                InsertToDB(db_goingDown, DBGoingDown()); // inserts to database
            }
            else if (ff_doors_open_completed == true)
            {
                tmrDoorsClosing_Controller.Start();
                tmrElevCar_InMotion_after_DoorsClosed_Controller.Start();

                btnGoingDown_GroundFloor.ForeColor = Color.Red; // change button colour
                DisplayWindowGoingDown(); // sets display window to going 
            }
        }






        //
        // Elevator Timer Controller Delegations (Tick Event Handlers)
        //
        private void tmrElevatorCar_InMotion_Controller_Tick(object sender, EventArgs e)
        {
            if (going_up_initiated == true)
            {
                if (picElevatorCarClosed.Top > y_axis_go_up) { picElevatorCarClosed.Top -= 1; } // going up
                else
                {
                    // stops timer | reset to default setting | sets present floor to 1
                    tmrElevatorCar_InMotion_Controller.Stop();
                    going_up_initiated = false;
                    present_floor = 1;

                    // stops timer for elevator car in motion after doors have close
                    tmrElevCar_InMotion_after_DoorsClosed_Controller.Stop();

                    // sets display windows to first floor
                    DisplayWindowFirstFloor();

                    InsertToDB(db_firstFloor, DBFirstFloor()); // inserts to database

                    // sets buttons to the default colour
                    btnGoingUp_FirstFloor.ForeColor = Color.Black;
                    btn1stFloorRequestButton.ForeColor = Color.Black;

                    // opens first floor doors (as well as stopping first floor doors from closing)
                    tmrDoorsClosing_Controller.Stop();
                    tmrDoorsOpening_Controller.Start();

                    // 1st floor doors closing automatically after a period of time
                    tmrAutomatic_DoorsClosing_Controller.Start();
                }
            }



            if (going_down_initiated == true)
            {
                if (picElevatorCarClosed.Top < y_axis_go_down) { picElevatorCarClosed.Top += 1; } // going down
                else
                {
                    // stops timer | reset to default setting | sets present floor to 0
                    tmrElevatorCar_InMotion_Controller.Stop();
                    going_down_initiated = false;
                    present_floor = 0;

                    // stops timer for elevator car in motion after doors have close
                    tmrElevCar_InMotion_after_DoorsClosed_Controller.Stop();

                    // sets display windows to ground floor
                    DisplayWindowGroundFloor();

                    InsertToDB(db_groundFloor, DBGroundFloor()); // inserts to database

                    // sets buttons to the default colour
                    btnGoingDown_GroundFloor.ForeColor = Color.Black;
                    btnGroundFloorRequestButton.ForeColor = Color.Black;

                    // opens ground floor doors (as well as stopping ground floor doors from closing)
                    tmrDoorsClosing_Controller.Stop();
                    tmrDoorsOpening_Controller.Start();

                    // ground floor doors closing automatically after a period of time
                    tmrAutomatic_DoorsClosing_Controller.Start();
                }
            }
        }


        private void tmrDoorsOpening_Controller_Tick(object sender, EventArgs e)
        {
            if (present_floor == 1)
            {
                if (pic1stFloorDoorLeft.Left > x_axis_leftdoor_open && pic1stFloorDoorRight.Left < x_axis_rightdoor_open) // Doors open on 1st floor
                {
                    pic1stFloorDoorLeft.Left -= 1;
                    pic1stFloorDoorRight.Left += 1;
                }
                else
                {
                    // stops timer | sets first floor doors to be opened
                    tmrDoorsOpening_Controller.Stop();
                    ff_doors_open_completed = true;

                    InsertToDB(db_doorsOpened_ff, DBDoorsOpened_FF()); // inserts to database
                }
            }



            if (present_floor == 0)
            {
                if (picGroundFloorDoorLeft.Left > x_axis_leftdoor_open && picGroundFloorDoorRight.Left < x_axis_rightdoor_open) // Doors open on ground floor
                {
                    picGroundFloorDoorLeft.Left -= 1;
                    picGroundFloorDoorRight.Left += 1;
                }
                else
                {
                    // stops timer | sets ground floor doors to be opened
                    tmrDoorsOpening_Controller.Stop();
                    gf_doors_open_completed = true;

                    InsertToDB(db_doorsOpened_gf, DBDoorsOpened_GF()); // inserts to database
                }
            }
        }


        private void tmrDoorsClosing_Controller_Tick(object sender, EventArgs e)
        {
            if (present_floor == 1)
            {
                if (pic1stFloorDoorLeft.Left < x_axis_leftdoor_close && pic1stFloorDoorRight.Left > x_axis_rightdoor_close) // Doors close on 1st floor
                {
                    pic1stFloorDoorLeft.Left += 1;
                    pic1stFloorDoorRight.Left -= 1;
                }
                else
                {
                    // stops automatic doors closing controller timer
                    tmrAutomatic_DoorsClosing_Controller.Stop();

                    // stops timer | sets first floor doors to be closed
                    tmrDoorsClosing_Controller.Stop();
                    ff_doors_open_completed = false;

                    // change button colour
                    btn1stFloorRequestButton.ForeColor = Color.Black;
                    btnGoingUp_FirstFloor.ForeColor = Color.Black;

                    InsertToDB(db_doorClosed_ff, DBDoorsClosed_FF()); // inserts to database


                    // Inserts string "Going Down" into the database after doors have been closed
                    if (tmrDoorsClosing_Controller.Enabled == false && tmrElevCar_InMotion_after_DoorsClosed_Controller.Enabled == true)
                    {
                        InsertToDB(db_goingDown, DBGoingDown()); // inserts to database
                    }

                }
            }



            if (present_floor == 0)
            {
                if (picGroundFloorDoorLeft.Left < x_axis_leftdoor_close && picGroundFloorDoorRight.Left > x_axis_rightdoor_close) // Doors close on ground floor
                {
                    picGroundFloorDoorLeft.Left += 1;
                    picGroundFloorDoorRight.Left -= 1;
                }
                else
                {
                    // stops automatic doors closing controller timer
                    tmrAutomatic_DoorsClosing_Controller.Stop();

                    // stops timer | sets ground floor doors to be closed
                    tmrDoorsClosing_Controller.Stop();
                    gf_doors_open_completed = false;

                    // change button colour
                    btnGroundFloorRequestButton.ForeColor = Color.Black;
                    btnGoingDown_GroundFloor.ForeColor = Color.Black;

                    InsertToDB(db_doorsClosed_gf, DBDoorsClosed_GF()); // inserts to database

                    // Inserts string "Going Up" into the database after doors have been closed
                    if (tmrDoorsClosing_Controller.Enabled == false && tmrElevCar_InMotion_after_DoorsClosed_Controller.Enabled == true)
                    {
                        InsertToDB(db_goingUp, DBGoingUp()); // inserts to database
                    }

                }
            }
        }


        private void tmrElevCar_InMotion_after_DoorsClosed_Controller_Tick(object sender, EventArgs e)
        {
            if (present_floor == 1)
            {
                // go to ground floor
                going_down_initiated = true;
                tmrElevatorCar_InMotion_Controller.Start();
            }

            if (present_floor == 0)
            {
                // go to first floor
                going_up_initiated = true;
                tmrElevatorCar_InMotion_Controller.Start();
            }
        }


        private void tmrAutomatic_DoorsClosing_Controller_Tick(object sender, EventArgs e)
        {
            // 4 seconds waiting period before execution (interval = 4000)
            if (present_floor == 1)
            {
                tmrDoorsClosing_Controller.Start();
            }

            if (present_floor == 0)
            {
                tmrDoorsClosing_Controller.Start();
            }
        }






        //
        // Elevator Database Log Delegations (Click Event Handler) and insert method
        //
        private void btnDisplayFullLog_Click(object sender, EventArgs e)
        {
            // Clears list box
            lstElevatorDBLog.Items.Clear();

            // Database select statement command
            string dbCommand = "Select * from ElevatorLog";

            // Prepares dataset
            DataSet dataset = new DataSet();

            // Prepares adaptor
            OleDbConnection dbcon = new OleDbConnection(dbConnection);
            OleDbCommand dbcom = new OleDbCommand(dbCommand, dbcon);

            // Error Handler (try catch finally)
            try
            {
                OleDbDataAdapter dbadapter = new OleDbDataAdapter(dbcom);

                // Opens connection
                dbcon.Open();

                dbadapter.Fill(dataset);
                DataTable datatable = dataset.Tables[0];

                // Refresh interface
                foreach (DataRow row in datatable.Rows)
                {
                    lstElevatorDBLog.Items.Add(row["TimeOfDay"] + " \t\t " + row["DateOfDay"] + " \t " + row["Status"]);
                }
            }
            catch (Exception ex)
            {
                string message = "Error present in connection. " + ex.Message;
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            finally
            {
                // Closes connection
                dbcon.Close();
            }
        }


        private void InsertToDB(string dbStatus, string lstBoxStatus)
        {
            // Database insert command
            string dbInsertCommand = "insert into [ElevatorLog] ([TimeOfDay],[DateOfDay],[Status]) values(@TimeOfDay, @DateOfDay, @Status)";

            // Sets current date and time
            string time = string.Format("{0:hh:mm:ss tt}", DateTime.Now);
            string date = string.Format("{0:dd/MM/yyyy}", DateTime.Now);

            // Prepares adaptor
            OleDbConnection dbcon = new OleDbConnection(dbConnection);
            OleDbCommand dbcom = new OleDbCommand(dbInsertCommand, dbcon);

            // Error Handler (try catch finally)
            try
            {
                OleDbDataAdapter adapter = new OleDbDataAdapter(dbcom);

                // Database connection parameters
                dbcom.Parameters.AddWithValue("@TimeOfDay", time);
                dbcom.Parameters.AddWithValue("@DateOfDay", date);
                dbcom.Parameters.AddWithValue("@Status", dbStatus);

                // Opens connection
                dbcon.Open();

                // Executes query
                dbcom.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                string message = "Error present in connection. " + ex.Message;
                string caption = "Error";
                MessageBoxButtons buttons = MessageBoxButtons.OK;
                MessageBox.Show(message, caption, buttons);
            }
            finally
            {
                // Closes connection
                dbcon.Close();
            }

            // Refresh list box
            lstElevatorDBLog.Items.Add(lstBoxStatus);
        }


        private void btnClearLog_Click(object sender, EventArgs e)
        {
            // Clears list box
            lstElevatorDBLog.Items.Clear();
        }






        //
        // Exit Application
        //
        private void btnExit_Click(object sender, EventArgs e)
        {
            // Exits application
            Application.Exit();
        }



    }
}
