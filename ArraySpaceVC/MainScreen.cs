namespace ArraySpaceVC
{

    public partial class MainScreen : Form
    {

        private CustomArray<Spaceship> spaceshipFleet;
        private Custom2DArray<Spaceship> map;
        public MainScreen()
        {
            InitializeComponent();
            initializeSpaceshipFleet();
        }

        //initializeSpaceshipFleet() method initializes the spaceship fleet with some spaceship objects.
        private void initializeSpaceshipFleet()
        {
            //Creates a CustomArray of type Spaceship and initializes the array with a size of 10.
            spaceshipFleet = new CustomArray<Spaceship>(10);

            //Creates Spaceship objects.
            Spaceship spaceship1 = new Spaceship("Nebula Explorer", "NX-2000", 8, 120, "Active", DateOnly.Parse("2022-03-15"), "Research");
            Spaceship spaceship2 = new Spaceship("Galactic Transporter", "GT-450", 20, 90.5, "Inactive", DateOnly.Parse("2020-11-01"), "Transport");
            Spaceship spaceship3 = new Spaceship("Star Communicator", "SC-100", 6, 85, "Active", DateOnly.Parse("2023-01-30"), "Communications");
            Spaceship spaceship4 = new Spaceship("Luna Researcher", "LR-750", 10, 95.8, "Active", DateOnly.Parse("2019-05-14"), "Research");
            Spaceship spaceship5 = new Spaceship("Orion Defender", "OD-5000", 12, 110.6, "Maintenance", DateOnly.Parse("2021-07-22"), "Military");

            //Adds 5 spaceships to custom array using Add() method.
            spaceshipFleet.Add(spaceship1);
            spaceshipFleet.Add(spaceship2);
            spaceshipFleet.Add(spaceship3);
            spaceshipFleet.Add(spaceship4);
            spaceshipFleet.Add(spaceship5);

            loadSpaceshipFleet();
        }


        //loadSpaceshipFleet() prints the array of spaceships to view in richedit.
        private void loadSpaceshipFleet()
        {
            int count = 0;
            //Loops through spaceships in array and prints to output.
            foreach (Spaceship spaceship in spaceshipFleet.Print())
            {
                if (spaceship != null)
                {
                    richOutputFleet.AppendText($"Spaceship {(count++) + 1}" + spaceship.ToString());
                }
            }


        }


        //btnAdd_Click() event handler uses input boxes to get information about the spaceship and once successful,
        //adds this spaceship object to the array and prints the array again.
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string nameInput = Microsoft.VisualBasic.Interaction.InputBox("Enter Spaceship Name:", "Spaceship Details");

            string modelInput = Microsoft.VisualBasic.Interaction.InputBox("Enter Spaceship Model:", "Spaceship Details");

            string crewCapacityInput = Microsoft.VisualBasic.Interaction.InputBox("Enter Crew Capacity:", "Spaceship Details");
            int crewCapacity = int.Parse(crewCapacityInput);

            string maxSpeedInput = Microsoft.VisualBasic.Interaction.InputBox("Enter Max Speed:", "Spaceship Details");
            double maxSpeed = double.Parse(maxSpeedInput);

            string statusInput = Microsoft.VisualBasic.Interaction.InputBox("Select Status:\n 1) Active\n 2) Inactive\n 3) Maintenance", "Spaceship Details");
            string status = "";
            switch (statusInput)
            {
                case "1":
                    {
                        status = "Active";
                        break;
                    }
                case "2":
                    {
                        status = "Inactive";
                        break;
                    }
                case "3":
                    {
                        status = "Maintenance";
                        break;
                    }
                default:
                    {
                        break;
                    }
            }//end of SWITCH STATEMENT.


            string launchDateInput = Microsoft.VisualBasic.Interaction.InputBox("Enter Launch Date In Format (yyyy-mm-dd):", "Spaceship Details");
            DateOnly launchDate = new DateOnly();
            launchDate = DateOnly.Parse(launchDateInput);

            string missionTypeInput = Microsoft.VisualBasic.Interaction.InputBox("Select Mission Type:\n 1) Research\n 2) Transport\n 3) Military\n 4) Communications", "Spaceship Details");
            string missionType = "";
            switch (missionTypeInput)
            {
                case "1":
                    {
                        missionType = "Research";
                        break;
                    }
                case "2":
                    {
                        missionType = "Transport";
                        break;
                    }
                case "3":
                    {
                        missionType = "Military";
                        break;
                    }
                case "4":
                    {
                        missionType = "Communications";
                        break;
                    }
                default:
                    {
                        break;
                    }
            }//end of SWITCH STATEMENT

            Spaceship spaceship = new Spaceship(nameInput, modelInput, crewCapacity, maxSpeed, status, launchDate, missionType);
            spaceshipFleet.Add(spaceship);
            loadSpaceshipFleet();
        }


        //btnRemove_Click() event handler uses an input box to get spaceship the user wants to remove and once successful,
        //removes the specified spaceship and prints the array again.
        private void btnRemove_Click(object sender, EventArgs e)
        {
            string spaceshipIndexInput = Microsoft.VisualBasic.Interaction.InputBox("Enter Spaceship Number To Remove:", "Remove Spaceship");
            int index = int.Parse(spaceshipIndexInput);
            spaceshipFleet.RemoveAt(index - 1);
            richOutputFleet.Clear();
            loadSpaceshipFleet();
        }

        //btnGet_Click() event handler uses an input box to get spaceship the user wants to view and once successful,
        //retrieves the specified spaceship and prints it.
        private void btnGet_Click(object sender, EventArgs e)
        {
            string spaceshipIndexInput = Microsoft.VisualBasic.Interaction.InputBox("Enter Spaceship Number To Get:", "Get Spaceship");
            int index = int.Parse(spaceshipIndexInput);
            richOutputFleet.Clear();
            richOutputFleet.AppendText($"Spaceship {index}" + spaceshipFleet.GetAt(index - 1).ToString());
        }

        //btnSearch_Click() event handler uses input boxes to get the search criteria user wants to search the spaceships by and once
        //successful, retrieves the specified spaceship and prints it through using a Predicate delegate.
        private void btnSearch_Click(object sender, EventArgs e)
        {

            string searchInput = Microsoft.VisualBasic.Interaction.InputBox("Search By:\n 1) Name\n 2) Model\n 3) Crew Capacity\n 4) Max Speed", "Search Spaceship Fleet");
            switch (searchInput)
            {
                case "1":
                    {
                        string spaceshipNameInput = Microsoft.VisualBasic.Interaction.InputBox("Enter Spaceship Name To Search For:", "Search Spaceship Fleet");

                        Spaceship foundSpaceship = spaceshipFleet.Search(spaceship => spaceship.spaceshipName == spaceshipNameInput);

                        richOutputFleet.Clear();
                        richOutputFleet.AppendText($"{foundSpaceship}");
                        break;
                    }
                case "2":
                    {
                        string spaceshipModelInput = Microsoft.VisualBasic.Interaction.InputBox("Enter Spaceship Model To Search For:", "Search Spaceship Fleet");

                        Spaceship foundSpaceship = spaceshipFleet.Search(spaceship => spaceship.model == spaceshipModelInput);

                        richOutputFleet.Clear();
                        richOutputFleet.AppendText($"{foundSpaceship}");
                        break;
                    }
                case "3":
                    {
                        string crewCapacityInput = Microsoft.VisualBasic.Interaction.InputBox("Enter Spaceship Crew Capacity To Search For:", "Search Spaceship Fleet");
                        int crewCapacity = int.Parse(crewCapacityInput);

                        Spaceship foundSpaceship = spaceshipFleet.Search(spaceship => spaceship.crewCapacity == crewCapacity);

                        richOutputFleet.Clear();
                        richOutputFleet.AppendText($"{foundSpaceship}");
                        break;
                    }
                case "4":
                    {
                        string maxSpeedInput = Microsoft.VisualBasic.Interaction.InputBox("Enter Spaceship Max Speed To Search For:", "Search Spaceship Fleet");
                        double maxSpeed = int.Parse(maxSpeedInput);

                        Spaceship foundSpaceship = spaceshipFleet.Search(spaceship => spaceship.maxSpeed == maxSpeed);

                        richOutputFleet.Clear();
                        richOutputFleet.AppendText($"{foundSpaceship}");
                        break;
                    }
                default:
                    {
                        break;
                    }
            }//end of SWITCH STATEMENT

        }

        //btnResize_Click() event handler uses input boxes to get the search criteria user wants to search the spaceships by and once
        //successful, retrieves the specified spaceship and prints it through using a Predicate delegate.
        private void btnResize_Click(object sender, EventArgs e)
        {
            string spaceshipNewSizeInput = Microsoft.VisualBasic.Interaction.InputBox("Enter New Spaceship Fleet Size:", "Resize Spaceship Fleet");
            int newSize = int.Parse(spaceshipNewSizeInput);
            spaceshipFleet.Resize(newSize);
            MessageBox.Show($"Spaceship fleet has succesfully been resized to {spaceshipFleet.arrayLength}!");
        }

        private void btnViewMap_Click(object sender, EventArgs e)
        {
            map = new Custom2DArray<Spaceship>(10, 10);
            int maprow = 0;
            int mapcol = 0;

            foreach (Spaceship spaceship in spaceshipFleet.Print())
            {
                map.Add(maprow++, mapcol++, spaceship);
            }

            for (int r = 0; r < map.arrayRowLength; r++)
            {
                richMap.AppendText("\n");
                for (int c = 0; c < map.arrayColumnLength; c++)
                {
                    if (map.GetAt(r, c) != null)
                    {
                        richMap.AppendText("*  ");
                    }
                    else
                    {
                        richMap.AppendText(".  ");
                    }

                }
            }
        }
    }
}
