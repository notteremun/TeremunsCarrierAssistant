﻿using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;
using TeremunsCarrierAssistant.Events;
using TeremunsCarrierAssistant.FleetCarrier;

namespace TeremunsCarrierAssistant {
    public partial class Main : Form {
        private readonly FlightPlan plan = new FlightPlan();
        private bool flightPlanLoaded = false;
        
        private JournalHandler journalHandler;
        private readonly OpenFileDialog openFileDialog;
        private readonly string currentUserPath;
        
        private int currentIndex = 0;
        
        private Jump jump;
        //private Refuel refuel;
        
        private static DateTime targetTime;

        private bool onJourney, isJumping, isRefueled = false;
        private bool isReplotted = false;
        private bool refuelManually = true;


        public Main() {
            InitializeComponent();
            currentUserPath = Environment.GetFolderPath(Environment.SpecialFolder.UserProfile);
            
            // Register KeyInputs
            Keyboard vInput = new Keyboard();
            jump = new Jump(vInput, 7000);
            //refuel = new Refuel(vInput, textDebug, 1);
            
            UpdateJournal();
            textCurrentLocation.Text = @"Current Location: " + journalHandler.fsdJumpData.StarSystem;
            
            openFileDialog = selectCarrierRoute;
        }
        
        // Teremun Methods
        private async void Assistant() {
            await Task.Run(() => {
                onJourney = true;

                while (onJourney) {
                    UpdateJournal(); // Get Latest Journal
                
                    if (isPlayerInSystem()) currentIndex++;
                    textNextJump.Text = "... " + plan.SystemName[currentIndex];

                    //Check if the player is Jumping
                    if (!isJumping) {
                         /*
                         if (!isRefueled) {
                            if(!refuelManually) refuel.Perform();
                            else { 
                                refuel.Perform();
                            }
                            isRefueled = true;
                        }
                        */
                        textCurrentLocation.Text = "Current Location: " + journalHandler.locationData.StarSystem;
                        jump.Perform();

                        // Here it stops working
                        
                        UpdateJournal();
                        targetTime = journalHandler.carrierJumpRequestData.DepartureTime;
                        textDebug.Text = "Jump: " + targetTime.ToLongDateString() + " - Now: " + DateTime.Now.ToUniversalTime(); 
                        
                        // TODO: Check if Jump is longer than 25 minutes, if replot once otherwise keep!
                        // TODO: But this is something I want to have on a different release of this tool :)
                        
                        /*
                        if (checkIfJumpBugged() && !isReplotted) {
                            //REPLOT
                            textDebug.Text = "Jump taking to long replotting...";
                            countdown.Stop();
                            jump.Perform();
                            textDebug.Text = "Jump taking to long replotting, application will freeze till jump cooldown is completed...";
                            Thread.Sleep(50000); // Jump Cooldown
                            jump.Perform();
                            
                            targetTime = journalHandler.carrierJumpRequestData.DepartureTime;
                        
                            targetTime = targetTime.AddMinutes(4).AddSeconds(50); // Add the cooldown
                            textDebug.Text = "Jumping to " + journalHandler.carrierJumpRequestData.SystemName + "...";
                        
                            countdown.Start();

                            isReplotted = true;
                            
                            continue;
                        }
                        */

                        targetTime = targetTime.AddMinutes(4).AddSeconds(50); // Add the cooldown
                        textDebug.Text = "Jumping to " + journalHandler.carrierJumpRequestData.SystemName + "...";
                        
                        countdown.Start();
                        
                        isJumping = true;
                    } else {
                        textDebug.Text = "Jump: " + targetTime.ToLongDateString() + " - Now: " + DateTime.Now.ToUniversalTime(); 
                    }
                }
            });
            
        }
        
        private void Timer_Elapsed(object sender, ElapsedEventArgs e) {
            if (DateTime.Now.ToUniversalTime() < targetTime) return;
            
            countdown.Stop();
            currentIndex++;
            UpdateJournal();
                    
            Clipboard.SetText(plan.SystemName[currentIndex]);
                    
            listJumps.Items.Clear();
            for (int i = currentIndex; i < plan.SystemName.Count; i++) {
                listJumps.Items.Add(plan.SystemName[i]);
            }
                
            try {
                textNextJump.Text = plan.SystemName[currentIndex];
            } catch (Exception ex) {
                textNextJump.Text = ex.Message;
                btnStart.Visible = true;
                onJourney = false;
                // If out of bound then it is done basically, to lazy right now to add safe-checks. 
            }

            isReplotted = false;
            isRefueled = false;
            isJumping = false;
        }

        private bool isPlayerInSystem() => journalHandler.locationData.StarSystem.Equals(plan.SystemName[currentIndex]);
        private bool checkIfJumpBugged() => targetTime > DateTime.UtcNow.AddMinutes(25).AddSeconds(30);

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

        private void UpdateCarrierOperations() {
            jump = new Jump(jump.keyboard, (int)numUpDownGalaxyBuffer.Value);
          //  refuel = new Refuel(refuel.keyboard, textDebug, (int)tritiumItemSlot.Value, 0);
        }
        
        // Form Event Handlers
        private void btnOpenFileDialog_Click(object sender, EventArgs e) {
            try {
                openFileDialog.ShowDialog(this);
                plan.ConvertFlightPlan(openFileDialog);

                foreach (string system in plan.SystemName.ToArray()) listJumps.Items.Add(system);

                textDebug.Text = "Waiting for activating the assistant...";
                textNextJump.Text = "... " + plan.SystemName[currentIndex];
                flightPlanLoaded = true;
            } catch (Exception) {
                //ignore
            }
            
        }
        private void btnStart_Click(object sender, EventArgs e) {
            if (flightPlanLoaded) {
                btnStart.Visible = false;
                Clipboard.SetText(plan.SystemName[currentIndex]);
                Assistant();
            }
        }
        private void btnUpdateLocation_Click(object sender, EventArgs e) {
            UpdateJournal();

            textCurrentLocation.Text = "Current Location: " + journalHandler.locationData.StarSystem;
            if (isPlayerInSystem()) currentIndex++;
            textNextJump.Text = "... " + plan.SystemName[currentIndex];
            
            
            listJumps.Items.Clear();
            for (int i = currentIndex; i < plan.SystemName.Count; i++) {
                listJumps.Items.Add(plan.SystemName[i]);
            }
            
            Clipboard.SetText(plan.SystemName[currentIndex]);
        }
        private void btnJourneySwitch_Click(object sender, EventArgs e) {
            isJumping = true;
            countdown.Start();
            btnStart.Visible = false;
            Clipboard.SetText(plan.SystemName[currentIndex]);
            Assistant();
        }
        
        private void galaxyBuffer_ValueChanged(object sender, EventArgs e) => UpdateCarrierOperations();
        private void tritiumItemSlot_ValueChanged(object sender, EventArgs e) => UpdateCarrierOperations();
        private void checkRefuelMan_CheckedChanged(object sender, EventArgs e) {
            refuelManually = checkRefuelMan.Checked;
        }
    }
}
