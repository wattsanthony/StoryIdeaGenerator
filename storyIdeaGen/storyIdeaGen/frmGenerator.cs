using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace storyIdeaGen
{
    public partial class frmGenerator : Form
    {
        private List<String> socialTypes; // Holds social type options
        private int socialTypeCount; // Holds count of social type options

        private List<String> collectInformationList; // Holds collect information options
        private int collectInformationCount; // Holds count of collect information options

        private List<String> decisionMakingList; // Holds decision making options
        private int decisionMakingCount; // Holds count of decision making options

        private List<String> environmentOrgList; // Holds environment org options
        private int environmentOrgCount; // Holds count of environment org options

        private List<String> settingPlaceList; // Holds setting place options
        private int settingPlaceCount; // Holds count of setting place options

        private List<String> settingTypeList; // Holds setting type options
        private int settingTypeCount; // Holds count of setting type options

        private List<String> techTypeList; // Holds tech type options
        private int techTypeCount; // Holds count of tech type  options

        private List<String> techUseageList; // Holds tech useage options
        private int techUseageCount; // Holds count of tech useage options

        private List<String> themeList; // Holds theme options
        private int themeCount; // Holds count of theme options

        public frmGenerator()
        {
            InitializeComponent();

            // SOCIAL TYPE LIST POPULATING

            // Read social type txt file
            string[] lines = System.IO.File.ReadAllLines(@"Text Files/socialType.txt");

            // Set up a list
            socialTypes = new List<string>();

            // Go through it to grab lines
            foreach (string line in lines)
            {
                // Process lines to an array
                socialTypes.Add(line);

            }

            // Count the number for the random generator later
            socialTypeCount = socialTypes.Count;

            // COLLECT INFORMATION LIST POPULATING

            // Read collect information txt file
            lines = System.IO.File.ReadAllLines(@"Text Files/informationCollection.txt");

            // Set up a list
            collectInformationList = new List<string>();

            // Go through it to grab lines
            foreach (string line in lines)
            {
                // Process lines to an array
                collectInformationList.Add(line);

            }

            // Count the number for the random generator later
            collectInformationCount = collectInformationList.Count;

            // DECISION MAKING LIST POPULATING

            // Read decision making txt file
            lines = System.IO.File.ReadAllLines(@"Text Files/decisionMaking.txt");

            // Set up a list
            decisionMakingList = new List<string>();

            // Go through it to grab lines
            foreach (string line in lines)
            {
                // Process lines to an array
                decisionMakingList.Add(line);

            }

            // Count the number for the random generator later
            decisionMakingCount = decisionMakingList.Count;

            // ENVIRONMENTAL ORG LIST POPULATING

            // Read environmental org txt file
            lines = System.IO.File.ReadAllLines(@"Text Files/environmentOrganisation.txt");

            // Set up a list
            environmentOrgList = new List<string>();

            // Go through it to grab lines
            foreach (string line in lines)
            {
                // Process lines to an array
                environmentOrgList.Add(line);

            }

            // Count the number for the random generator later
            environmentOrgCount = environmentOrgList.Count;

            // SETTING PLACE LIST POPULATING

            // Read setting place txt file
            lines = System.IO.File.ReadAllLines(@"Text Files/settingPlace.txt");

            // Set up a list
            settingPlaceList = new List<string>();

            // Go through it to grab lines
            foreach (string line in lines)
            {
                // Process lines to an array
                settingPlaceList.Add(line);

            }

            // Count the number for the random generator later
            settingPlaceCount = settingPlaceList.Count;

            // SETTING TYPE LIST POPULATING

            // Read setting type txt file
            lines = System.IO.File.ReadAllLines(@"Text Files/settingType.txt");

            // Set up a list
            settingTypeList = new List<string>();

            // Go through it to grab lines
            foreach (string line in lines)
            {
                // Process lines to an array
                settingTypeList.Add(line);

            }

            // Count the number for the random generator later
            settingTypeCount = settingTypeList.Count;

            // TECH TYPE LIST POPULATING

            // Read tech type txt file
            lines = System.IO.File.ReadAllLines(@"Text Files/techType.txt");

            // Set up a list
            techTypeList = new List<string>();

            // Go through it to grab lines
            foreach (string line in lines)
            {
                // Process lines to an array
                techTypeList.Add(line);

            }

            // Count the number for the random generator later
            techTypeCount = techTypeList.Count;

            // TECH USEAGE LIST POPULATING

            // Read tech useage txt file
            lines = System.IO.File.ReadAllLines(@"Text Files/techUseage.txt");

            // Set up a list
            techUseageList = new List<string>();

            // Go through it to grab lines
            foreach (string line in lines)
            {
                // Process lines to an array
                techUseageList.Add(line);

            }

            // Count the number for the random generator later
            techUseageCount = techUseageList.Count;

            // THEME LIST POPULATING

            // Read theme txt file
            lines = System.IO.File.ReadAllLines(@"Text Files/theme.txt");

            // Set up a list
            themeList = new List<string>();

            // Go through it to grab lines
            foreach (string line in lines)
            {
                // Process lines to an array
                themeList.Add(line);

            }

            // Count the number for the random generator later
            themeCount = themeList.Count;
        }

        // Ignore me, this thing insists I exist?
        private void Form1_Load(object sender, EventArgs e)
        {

        }

        // Handle button press
        private void btnRandomize_Click(object sender, EventArgs e)
        {
            randomisePersonality();
            randomiseSetting();
            randomiseTech();
            randomiseTheme();
        }

        // Manages all personality randomisation and label changing
        private void randomisePersonality()
        {
            Random random = new Random(); // Create random generator

            int tempNumOne = random.Next(0, socialTypeCount); // Create first number pick

            int tempNumTwo = random.Next(0, collectInformationCount); // Create second number pick

            int tempNumThree = random.Next(0, decisionMakingCount); // Create first number pick

            int tempNumFour = random.Next(0, environmentOrgCount); // Create second number pick

            // Apply labels
            lblSocial.Text = socialTypes[tempNumOne];
            lblCollectInformation.Text = collectInformationList[tempNumTwo];
            lblDecisionMaking.Text = decisionMakingList[tempNumThree];
            lblEnvironmentOrg.Text = environmentOrgList[tempNumFour];
        }

        // Manages all personality randomisation and label changing
        private void randomiseSetting()
        {
            Random random = new Random(); // Create random generator

            int tempNumOne = random.Next(0, settingPlaceCount); // Create first number pick

            int tempNumTwo = random.Next(0, settingTypeCount); // Create second number pick

            // Apply labels
            lblPlace.Text = settingPlaceList[tempNumOne];
            lblType.Text = settingTypeList[tempNumTwo];
        }

        // Manages all tech randomisation and label changing
        private void randomiseTech()
        {
            Random random = new Random(); // Create random generator

            int tempNumOne = random.Next(0, techTypeCount); // Create first number pick

            int tempNumTwo = random.Next(0, techUseageCount); // Create second number pick

            // Apply labels
            lblTechType.Text = techTypeList[tempNumOne];
            lblTechUseage.Text = techUseageList[tempNumTwo];
        }

        // Manages all theme randomisation and label changing
        private void randomiseTheme()
        {
            Random random = new Random(); // Create random generator

            int tempNumOne = random.Next(0, themeCount); // Create first number pick

            // Apply labels
            lblTheming.Text = themeList[tempNumOne];
        }
    }
}
