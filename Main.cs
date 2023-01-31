using System;
using System.IO;
using System.Linq;
using System.Timers;
using System.Windows.Forms;
using TeremunsCarrierAssistant.Events;
using TeremunsCarrierAssistant.FleetCarrier;
using Timer = System.Timers.Timer;

namespace TeremunsCarrierAssistant {
    public partial class Main : Form {
        private readonly FlightPlan plan = new FlightPlan();
        private bool flightPlanLoaded = false;
        
        private JournalHandler journalHandler;
        private readonly OpenFileDialog openFileDialog;
        private readonly string currentUserPath;
        
        private int currentIndex = 0;
        private readonly Jump jump;
        private readonly Refuel refuel;

        private static Timer timer;
        private static DateTime targetTime;

        private bool onJourney, isJumping, isRefueled = false;


        public Main() {
            InitializeComponent();
            currentUserPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            
            // Register KeyInputs
            Keyboard vInput = new Keyboard();
            jump = new Jump(vInput, textDebug);
            refuel = new Refuel(vInput, textDebug);
            
            UpdateJournal();
            textCurrentLocation.Text = @"Current Location: " + journalHandler.fsdJumpData.StarSystem;
            
            openFileDialog = selectCarrierRoute;
        }
        
        // Teremun Methods
        private void Assistant() {
            btnStart.Enabled = false;
            onJourney = true;
            UpdateJournal(); // Get Latest Journal
            
            if (isPlayerInSystem()) currentIndex++;
            Clipboard.SetText(plan.SystemName[currentIndex]);

            refuel.Perform();
            isRefueled = true;
            
            while (onJourney) {
                //Check if the player is Jumping
                if (!isJumping) {
                    if (!isRefueled) {
                        refuel.Perform();
                        isRefueled = true;
                    }
                    
                    jump.Perform();

                    targetTime = journalHandler.carrierJumpRequestData.DepartureTime;
                    // TODO: Check if Jump is longer than 25 minutes, if replot once otherwise keep!
                    // TODO: But this is something I want to have on a different release of this tool :)
                    targetTime = targetTime.AddMinutes(4).AddSeconds(30); // Add the cooldown
                    textDebug.Text = "Jumping to " + journalHandler.carrierJumpRequestData.SystemName + "...";
                    
                    timer = new Timer(1000);
                    timer.Elapsed += Timer_Elapsed;
                    timer.Start();
                    
                    isJumping = true;
                }
            }
        }
        
        private void Timer_Elapsed(object sender, ElapsedEventArgs e) {
            if (DateTime.Now.ToUniversalTime() >= targetTime) {
                timer.Stop();

                currentIndex++;
                UpdateJournal();
                Clipboard.SetText(plan.SystemName[currentIndex]);

                try {
                    textNextJump.Text = plan.SystemName[currentIndex];
                } catch (Exception exception) {
                    textNextJump.Text = "";
                    onJourney = false;
                    // If out of bound then it is done basically, to lazy right now to add safe-checks. 
                }
                
                isRefueled = false;
                isJumping = false;
            }
        }

        private bool isPlayerInSystem() => journalHandler.locationData.StarSystem.Equals(plan.SystemName[currentIndex]);

        private void UpdateJournal() {
            DirectoryInfo dirInfo = new DirectoryInfo($"{currentUserPath}\\Saved Games\\Frontier Developments\\Elite Dangerous\\");
            FileInfo file = (from f in dirInfo.GetFiles("*.log") orderby f.LastWriteTime descending select f).First();

            string original = $"{currentUserPath}\\Saved Games\\Frontier Developments\\Elite Dangerous\\" + file;
            string copy = $"{currentUserPath}\\Saved Games\\Frontier Developments\\Elite Dangerous\\logCopy.teremun";
            
            try {  
                File.Copy(original, copy, true);  
            } catch (IOException) { 
                // Ignore
            }

            journalHandler = new JournalHandler(copy);
        }
        
        // Form Event Handlers
        private void btnOpenFileDialog_Click(object sender, EventArgs e) {
            try {
                openFileDialog.ShowDialog(this);
                plan.ConvertFlightPlan(openFileDialog);

                foreach (string system in plan.SystemName.ToArray()) listJumps.Items.Add(system);

                textDebug.Text = "Waiting for activating the assistent...";
                flightPlanLoaded = true;
            } catch (Exception) {
                //ignore
            }
            
        }
        
        private void btnStart_Click(object sender, EventArgs e) {
            if(flightPlanLoaded) Assistant();
        }
    }
}
