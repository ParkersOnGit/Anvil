using Anvil.Properties;
using System.Media;

namespace Anvil
{
    public partial class Main : Form
    {
        // rarity color array
        Color[] rarityColors = new Color[]
        {
            Color.DarkGray, // Common
            Color.YellowGreen, // Uncommon
            Color.DarkCyan, // Rare
            Color.MediumOrchid, // Epic
            Color.Goldenrod // Legendary
        };

        public Main()
        {
            InitializeComponent();
            // set up version number (Major.Minor.Patch.Build)
            VersionNum.Text = "v0.4.2.0";
            SetUpComboBoxs();
            SetUpToolTips();
            GenerateJSON();
            // set anvil image beacuse bug keeps happening with it
            Anvil.Image = Resources.Anvil_29_BE3;
        }

        private void SetUpToolTips()
        {
            ToolTip tt = new ToolTip();

            // set up the delays for the ToolTip
            tt.InitialDelay = 500;
            tt.ReshowDelay = 500;

            // force the ToolTip text to be displayed whether or not the form is active
            tt.ShowAlways = true;

            // set up left inputs
            tt.SetToolTip(BadInfection, "● Poison mobs on hit for 15 seconds");
            tt.SetToolTip(Stunning, "● Stops mobs in their track for 15 seconds");
            tt.SetToolTip(Vampire, "● Gain 1 health for every hit");
            tt.SetToolTip(Chomp, "● Summon a fang below the mob you hit");
            tt.SetToolTip(Assassin, "● Get speed and invisibility each hit");
            tt.SetToolTip(FlameSacrifice, "● Set fire below the mob when hit");
            tt.SetToolTip(ElectricBoogaloo, "● Summon lightning at a mob that can chain up to 3 times");

            // set up right inputs
            tt.SetToolTip(Rage, "● Gain strength for 15 seconds");
            tt.SetToolTip(ManaWard, "● Gain resistance for 15 seconds");
            tt.SetToolTip(Gassy, "● Summon a poison gas cloud");
            tt.SetToolTip(MultiHit, "● Attack a mob multiple times in front of you for 2 seconds");
            tt.SetToolTip(FiraBawl, "● Summon a fire ball that damages mobs for 2 seconds");
            tt.SetToolTip(HeartAttack, "● Gain strength 3 but a random chance to just die");
            tt.SetToolTip(PumpkinBlast, "● Shoot a pumpkin dealing 5 damage in 6 blocks");

            // set up full set bonus

            // version number
            tt.SetToolTip(VersionNum, "Major.Minor.Patch.Build");

            // panels
            if (LeftInputPanel.VerticalScroll.Visible)
                tt.SetToolTip(LeftInputPanel, "Scroll for more!");
            if (RightInputPanel.VerticalScroll.Visible)
                tt.SetToolTip(RightInputPanel, "Scroll for more!");
            if (FullSetBonusPanel.VerticalScroll.Visible)
                tt.SetToolTip(RightInputPanel, "Scroll for more!");
        }

        private void SetUpComboBoxs()
        {
            // set up rarity combo box draw mode
            RarityComboBox.DrawMode = DrawMode.OwnerDrawFixed;

            // clear pre existing items
            RarityComboBox.Items.Clear();

            // add items again to rarity
            RarityComboBox.Items.Add("Common");
            RarityComboBox.Items.Add("Uncommon");
            RarityComboBox.Items.Add("Rare");
            RarityComboBox.Items.Add("Epic");
            RarityComboBox.Items.Add("Legendary");

            // draw each item with different color
            RarityComboBox.DrawItem += (sender, e) =>
            {
                if (e.Index >= 0)
                    using (Brush textBrush = new SolidBrush(rarityColors[e.Index]))
                        e.Graphics.DrawString(RarityComboBox.Items[e.Index].ToString(), e.Font, textBrush, e.Bounds);
            };

            // set up rarity combo box first index (common)
            RarityComboBox.SelectedIndex = 0;

            // set up item combo box first index (iron_sword)
            ItemComboBox.SelectedIndex = 0;

            // set up slot combo box first index (head)
            SlotComboBox.SelectedIndex = 0;
        }

        private void GenerateJSON() // First of all before this code is viewed... I'd like to say sorry!
        {
            /// <summary>
            /// This is the code that generates the json string for the item. It is the main function and gets called on multiple times each time a new variable is changed--or at least it should.
            /// </summary>
            // Create the jsonString string. This is essential to making the code work. (actaully all of this is but you get the point)
            string jsonString = string.Empty;

            string rareColor = "white";
            switch (RarityComboBox.SelectedIndex)
            {
                case 0:
                    rareColor = "white";
                    break;
                case 1:
                    rareColor = "green";
                    break;
                case 2:
                    rareColor = "blue";
                    break;
                case 3:
                    rareColor = "light_purple";
                    break;
                case 4:
                    rareColor = "gold";
                    break;
            }
            Dictionary<string, string> armorPiece = new Dictionary<string, string>
            {
                { "helmet", "head" },
                { "chestplate", "chest" },
                { "leggings", "legs" },
                { "boots", "feet" }
            };
            List<string> armorItems = new List<string>()
            {
                "chainmail_helmet",
                "chainmail_chestplate",
                "chainmail_leggings",
                "chainmail_boots"
            };

            // set up starting
            jsonString = "{\r\n  \"type\": \"minecraft:entity\",\r\n  \"pools\": [\r\n    {\r\n      \"rolls\": 1,\r\n      \"entries\": [\r\n        {\r\n          \"type\": \"minecraft:item\",\r\n          \"name\": \"minecraft:" + ItemComboBox.SelectedItem + "\",\r\n          \"weight\": 1,\r\n          \"quality\": 1,\r\n          \"functions\": [\r\n            {\r\n              \"function\": \"minecraft:set_name\",\r\n              \"name\": {\r\n                \"text\": \"" + NameTextBox.Text + "\",\r\n                \"color\": \"" + rareColor + "\",\r\n                \"italic\": false\r\n              },\r\n              \"conditions\": []\r\n            },\r\n            {\r\n              \"function\": \"minecraft:set_lore\",\r\n              \"lore\": [\r\n                ";

            if (!string.IsNullOrWhiteSpace(DescriptionTextBox.Text))
            {
                jsonString += "{\r\n                  \"text\": \"● " + DescriptionTextBox.Text.Split(Environment.NewLine)[0] + "\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                ";
                for (int i = 1; i < DescriptionTextBox.Text.Split(Environment.NewLine).Length; i++)
                    jsonString += "{\r\n                  \"text\": \"  " + DescriptionTextBox.Text.Split(Environment.NewLine)[i] + "\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                ";
            }

            // check if at least one of the states is either greater than 0 or (for the case of checkbox) true
            if (StatsGroupBox.Controls.OfType<NumericUpDown>().Any(n => n.Value > 0) || PrestigedCheckBox.Checked || StatsGroupBox.Controls.OfType<NumericUpDown>().Any(n => n.Value < 0))
            {
                jsonString += "{\r\n                  \"text\": \"──\",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \" Stats \",\r\n                      \"extra\": [\r\n                        {\r\n                          \"text\": \"───────\",\r\n                          \"color\": \"gray\"\r\n                        }\r\n                      ],\r\n                      \"color\": \"white\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                ";

                // add each stat depending on if its greater than 0 or for casee of checkbox true --for EACH--
                // base damage
                if (DamageNumBox.Value > 0 || DamageNumBox.Value < 0)
                    jsonString += "{\r\n                  \"text\": \"⚔ \",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \"Base Damage: \",\r\n                      \"extra\": [\r\n                        {\r\n                          \"text\": \"" + DamageNumBox.Value + "\",\r\n                          \"color\": \"white\",\r\n                          \"italic\": false\r\n                        }\r\n                      ],\r\n                      \"color\": \"gray\",\r\n                      \"italic\": false\r\n                    }\r\n                  ],\r\n                  \"color\": \"yellow\",\r\n                  \"italic\": false\r\n                },\r\n                ";
                // attack speed
                if (AttackSpeedNumBox.Value > 0 || AttackSpeedNumBox.Value < 0)
                    jsonString += "{\r\n                  \"text\": \"⚔ \",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \"Attack Speed: \",\r\n                      \"extra\": [\r\n                        {\r\n                          \"text\": \"" + AttackSpeedNumBox.Value + "\",\r\n                          \"color\": \"white\",\r\n                          \"italic\": false\r\n                        }\r\n                      ],\r\n                      \"color\": \"gray\",\r\n                      \"italic\": false\r\n                    }\r\n                  ],\r\n                  \"color\": \"yellow\",\r\n                  \"italic\": false\r\n                },\r\n                ";
                // health
                if (HealthNumBox.Value > 0 || HealthNumBox.Value < 0)
                    jsonString += "{\r\n                  \"text\": \"❤ \",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \"Health: \",\r\n                      \"extra\": [\r\n                        {\r\n                          \"text\": \"" + HealthNumBox.Value + "\",\r\n                          \"color\": \"white\",\r\n                          \"italic\": false\r\n                        }\r\n                      ],\r\n                      \"color\": \"gray\",\r\n                      \"italic\": false\r\n                    }\r\n                  ],\r\n                  \"color\": \"red\",\r\n                  \"italic\": false\r\n                },\r\n                ";
                // health regen
                if (HealthRegenNumBox.Value > 0 || HealthRegenNumBox.Value < 0)
                    jsonString += "{\r\n                  \"text\": \"❣ \",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \"Health Regen: \",\r\n                      \"extra\": [\r\n                        {\r\n                          \"text\": \"" + HealthRegenNumBox.Value + "\",\r\n                          \"color\": \"white\",\r\n                          \"italic\": false\r\n                        }\r\n                      ],\r\n                      \"color\": \"gray\",\r\n                      \"italic\": false\r\n                    }\r\n                  ],\r\n                  \"color\": \"red\",\r\n                  \"italic\": false\r\n                },\r\n                ";
                // defense
                if (DefenseNumBox.Value > 0 || DefenseNumBox.Value < 0)
                    jsonString += "{\r\n                  \"text\": \"❈ \",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \"Defense: \",\r\n                      \"extra\": [\r\n                        {\r\n                          \"text\": \"" + DefenseNumBox.Value + "\",\r\n                          \"color\": \"white\",\r\n                          \"italic\": false\r\n                        }\r\n                      ],\r\n                      \"color\": \"gray\",\r\n                      \"italic\": false\r\n                    }\r\n                  ],\r\n                  \"color\": \"green\",\r\n                  \"italic\": false\r\n                },\r\n                ";
                // speed
                if (SpeedNumBox.Value > 0 || SpeedNumBox.Value < 0)
                    jsonString += "{\r\n                  \"text\": \"✦ \",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \"Speed: \",\r\n                      \"extra\": [\r\n                        {\r\n                          \"text\": \"" + SpeedNumBox.Value + "\",\r\n                          \"color\": \"white\",\r\n                          \"italic\": false\r\n                        }\r\n                      ],\r\n                      \"color\": \"gray\",\r\n                      \"italic\": false\r\n                    }\r\n                  ],\r\n                  \"color\": \"white\",\r\n                  \"italic\": false\r\n                },\r\n                ";
                // mana
                if (ManaNumBox.Value > 0 || ManaNumBox.Value < 0)
                    jsonString += "{\r\n                  \"text\": \"✎ \",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \"Mana: \",\r\n                      \"extra\": [\r\n                        {\r\n                          \"text\": \"" + ManaNumBox.Value + "\",\r\n                          \"color\": \"white\",\r\n                          \"italic\": false\r\n                        }\r\n                      ],\r\n                      \"color\": \"gray\",\r\n                      \"italic\": false\r\n                    }\r\n                  ],\r\n                  \"color\": \"aqua\",\r\n                  \"italic\": false\r\n                },\r\n                ";
                // mana regen
                if (ManaRegen.Value > 0 || ManaRegen.Value < 0)
                    jsonString += "{\r\n                  \"text\": \"✯ \",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \"Mana Regen: \",\r\n                      \"extra\": [\r\n                        {\r\n                          \"text\": \"" + ManaRegen.Value + "\",\r\n                          \"color\": \"white\",\r\n                          \"italic\": false\r\n                        }\r\n                      ],\r\n                      \"color\": \"gray\",\r\n                      \"italic\": false\r\n                    }\r\n                  ],\r\n                  \"color\": \"aqua\",\r\n                  \"italic\": false\r\n                },\r\n                ";
                // luck
                if (LuckNumBox.Value > 0 || LuckNumBox.Value < 0)
                    jsonString += "{\r\n                  \"text\": \"♣ \",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \"Luck: \",\r\n                      \"extra\": [\r\n                        {\r\n                          \"text\": \"" + LuckNumBox.Value + "\",\r\n                          \"color\": \"white\",\r\n                          \"italic\": false\r\n                        }\r\n                      ],\r\n                      \"color\": \"gray\",\r\n                      \"italic\": false\r\n                    }\r\n                  ],\r\n                  \"color\": \"light_purple\",\r\n                  \"italic\": false\r\n                },\r\n                ";
                // wisdom
                if (WisdomNumBox.Value > 0 || WisdomNumBox.Value < 0)
                    jsonString += "{\r\n                  \"text\": \"☯ \",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \"Wisdom: \",\r\n                      \"extra\": [\r\n                        {\r\n                          \"text\": \"" + WisdomNumBox.Value + "\",\r\n                          \"color\": \"white\",\r\n                          \"italic\": false\r\n                        }\r\n                      ],\r\n                      \"color\": \"gray\",\r\n                      \"italic\": false\r\n                    }\r\n                  ],\r\n                  \"color\": \"dark_aqua\",\r\n                  \"italic\": false\r\n                },\r\n                ";
                // presteige
                if (PrestigedCheckBox.Checked)
                    jsonString += "{\r\n                  \"text\": \"✧ \",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \"Prestiged\",\r\n                      \"extra\": [\r\n                        {\r\n                          \"text\": \" ✧\",\r\n                          \"color\": \"yellow\",\r\n                          \"italic\": false\r\n                        }\r\n                      ],\r\n                      \"color\": \"dark_red\",\r\n                      \"italic\": false\r\n                    }\r\n                  ],\r\n                  \"color\": \"yellow\",\r\n                  \"italic\": false\r\n                },\r\n                ";
            }

            // add the line differentiating either stats or just the description/name
            jsonString += "{\r\n                  \"text\": \"──────────────\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },";

            // add the left click effect
            string leftClickEffect = "null";
            if (BadInfection.Checked)
                leftClickEffect = "poison";
            if (Stunning.Checked)
                leftClickEffect = "stun";
            if (Vampire.Checked)
                leftClickEffect = "vampire";
            if (Chomp.Checked)
                leftClickEffect = "chomp";
            if (Assassin.Checked)
                leftClickEffect = "assassin";
            if (FlameSacrifice.Checked)
                leftClickEffect = "flame_sacrafice";
            if (ElectricBoogaloo.Checked)
                leftClickEffect = "lighting";

            if (BadInfection.Checked)
                jsonString += "\r\n                {\r\n                  \"text\": \"🔥Left Click:\",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \" Bad Infection\",\r\n                      \"color\": \"yellow\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"gold\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"● Poison mobs on hit for\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"   15 seconds\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                \"\",";
            if (Stunning.Checked)
                jsonString += "\r\n                {\r\n                  \"text\": \"🔥Left Click:\",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \" Stunning\",\r\n                      \"color\": \"yellow\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"gold\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"● Stops mobs in their\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"   track for 15 seconds\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                \"\",";
            if (Vampire.Checked)
                jsonString += "\r\n                {\r\n                  \"text\": \"🔥Left Click:\",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \" Vampire\",\r\n                      \"color\": \"yellow\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"gold\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"● Gain 1 health for\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"   every hit\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                \"\",";
            if (Chomp.Checked)
                jsonString += "\r\n                {\r\n                  \"text\": \"🔥Left Click:\",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \" Chomp\",\r\n                      \"color\": \"yellow\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"gold\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"● Summon a fang below\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"   the mob you hit\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                \"\",";
            if (Assassin.Checked)
                jsonString += "\r\n                {\r\n                  \"text\": \"🔥Left Click:\",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \" Assassin\",\r\n                      \"color\": \"yellow\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"gold\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"● Get speed and\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"   invisibility each hit\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                \"\",";
            if (FlameSacrifice.Checked)
                jsonString += "\r\n                {\r\n                  \"text\": \"🔥Left Click:\",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \" Flame Sacrifice\",\r\n                      \"color\": \"yellow\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"gold\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"● Set fire below the\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"   mob when hit\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                \"\",";
            if (ElectricBoogaloo.Checked)
                jsonString += "\r\n                {\r\n                  \"text\": \"🔥Left Click:\",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \" Electric Boogaloo\",\r\n                      \"color\": \"yellow\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"gold\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"● Summon lightning at a mob\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"   that can chain up to 3 times\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                \"\",";

            // add the right click effect 
            int rightClickEffect = 0;
            if (Rage.Checked)
                rightClickEffect = 1;
            if (ManaWard.Checked)
                rightClickEffect = 2;
            if (Gassy.Checked)
                rightClickEffect = 3;
            if (MultiHit.Checked)
                rightClickEffect = 4;
            if (FiraBawl.Checked)
                rightClickEffect = 5;
            if (HeartAttack.Checked)
                rightClickEffect = 6;
            if (PumpkinBlast.Checked)
                rightClickEffect = 7;

            if (Rage.Checked)
                jsonString += "\r\n                {\r\n                  \"text\": \"🔥Right Click:\",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \" Rage\",\r\n                      \"color\": \"yellow\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"gold\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"● Gain strength for 15\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"   seconds\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"Mana Cost: \",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \"15\",\r\n                      \"color\": \"aqua\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"dark_gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"Cooldown: \",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \"5s\",\r\n                      \"color\": \"green\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"dark_gray\",\r\n                  \"italic\": false\r\n                },\r\n                \"\",";
            if (ManaWard.Checked)
                jsonString += "\r\n                {\r\n                  \"text\": \"🔥Right Click:\",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \" Mana Ward\",\r\n                      \"color\": \"yellow\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"gold\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"● Gain resistance for 15\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"   seconds\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"Mana Cost: \",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \"31\",\r\n                      \"color\": \"aqua\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"dark_gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"Cooldown: \",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \"5s\",\r\n                      \"color\": \"green\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"dark_gray\",\r\n                  \"italic\": false\r\n                },\r\n                \"\",";
            if (Gassy.Checked)
                jsonString += "\r\n                {\r\n                  \"text\": \"🔥Right Click:\",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \" Gassy\",\r\n                      \"color\": \"yellow\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"gold\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"● Summon a poison gas\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"   cloud\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"Mana Cost: \",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \"22\",\r\n                      \"color\": \"aqua\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"dark_gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"Cooldown: \",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \"10s\",\r\n                      \"color\": \"green\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"dark_gray\",\r\n                  \"italic\": false\r\n                },\r\n                \"\",";
            if (MultiHit.Checked)
                jsonString += "\r\n                {\r\n                  \"text\": \"🔥Right Click:\",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \" Multi-hit\",\r\n                      \"color\": \"yellow\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"gold\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"● Attack a mob multiple times\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"   in front of you for 2 seconds\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"Mana Cost: \",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \"19\",\r\n                      \"color\": \"aqua\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"dark_gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"Cooldown: \",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \"12s\",\r\n                      \"color\": \"green\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"dark_gray\",\r\n                  \"italic\": false\r\n                },\r\n                \"\",";
            if (FiraBawl.Checked)
                jsonString += "\r\n                {\r\n                  \"text\": \"🔥Right Click:\",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \" ~FIRA BAWL\",\r\n                      \"color\": \"yellow\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"gold\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"● Summon a fire ball that\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"   damages mobs for 2 seconds\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"Mana Cost: \",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \"8\",\r\n                      \"color\": \"aqua\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"dark_gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"Cooldown: \",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \"4s\",\r\n                      \"color\": \"green\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"dark_gray\",\r\n                  \"italic\": false\r\n                },\r\n                \"\",";
            if (HeartAttack.Checked)
                jsonString += "\r\n                {\r\n                  \"text\": \"🔥Right Click:\",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \" Heart Attack\",\r\n                      \"color\": \"yellow\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"gold\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"● Gain strength 3 but\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"   a random chance to just die\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"Mana Cost: \",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \"13\",\r\n                      \"color\": \"aqua\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"dark_gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"Cooldown: \",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \"6s\",\r\n                      \"color\": \"green\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"dark_gray\",\r\n                  \"italic\": false\r\n                },\r\n                \"\",";
            if (PumpkinBlast.Checked)
                jsonString += "\r\n                {\r\n                  \"text\": \"🔥Right Click:\",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \" Pumpkin Blast\",\r\n                      \"color\": \"yellow\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"gold\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"● Shoot a pumpkin\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"   dealing 5 damage in 6 blocks\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"Mana Cost: \",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \"20\",\r\n                      \"color\": \"aqua\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"dark_gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"Cooldown: \",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \"8s\",\r\n                      \"color\": \"green\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"dark_gray\",\r\n                  \"italic\": false\r\n                },\r\n                \"\",";

            // add the full set bonus 
            if (HunterGrass.Checked)
                rightClickEffect = 1;

            if (HunterGrass.Checked)
                jsonString += "\r\n                {\r\n                  \"text\": \"🔥Full Set Bonus: \",\r\n                  \"extra\": [\r\n                    {\r\n                      \"text\": \"Hunter Grass\",\r\n                      \"color\": \"yellow\"\r\n                    }\r\n                  ],\r\n                  \"color\": \"gold\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"● Gain speed only when touching\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                {\r\n                  \"text\": \"   grass.... Scary!\",\r\n                  \"color\": \"gray\",\r\n                  \"italic\": false\r\n                },\r\n                \"\",";





            // finish it off and also have final rarity at bottom
            jsonString += "\r\n                {\r\n                  \"text\": \"" + RarityComboBox.SelectedItem + "\",\r\n                  \"color\": \"" + rareColor + "\",\r\n                  \"bold\": true,\r\n                  \"italic\": false\r\n                }\r\n              ],\r\n              \"mode\": \"insert\"\r\n            },\r\n            {\r\n              \"function\": \"minecraft:set_components\",\r\n              \"components\": {\r\n                \"minecraft:attribute_modifiers\": [\r\n                  {\r\n                    \"type\": \"minecraft:movement_speed\",\r\n                    \"id\": \"minecraft:\",\r\n                    \"amount\": " + SpeedNumBox.Value / 100 + ",\r\n                    \"operation\": \"add_value\"\r\n                  },\r\n                  {\r\n                    \"type\": \"minecraft:attack_damage\",\r\n                    \"id\": \"minecraft:\",\r\n                    \"amount\": " + DamageNumBox.Value + ",\r\n                    \"operation\": \"add_value\",\r\n                    \"slot\": \"mainhand\"\r\n                  },\r\n                  {\r\n                    \"type\": \"minecraft:attack_speed\",\r\n                    \"id\": \"minecraft:\",\r\n                    \"amount\": " + AttackSpeedNumBox.Value + ",\r\n                    \"operation\": \"add_value\",\r\n                    \"slot\": \"mainhand\"\r\n                  }\r\n                ]\r\n              }\r\n            },\r\n            {\r\n              \"function\": \"minecraft:toggle_tooltips\",\r\n              \"toggles\": {\r\n                \"minecraft:attribute_modifiers\": false\r\n              }\r\n            },\r\n            {\r\n              \"function\": \"minecraft:set_custom_data\",\r\n              \"tag\": {\r\n                \"Health\": " + HealthNumBox.Value + ",\r\n                \"Health Regen\": " + HealthRegenNumBox.Value + ",\r\n                \"Defense\": " + DefenseNumBox.Value + ",\r\n                \"Mana\": " + ManaNumBox.Value + ",\r\n                \"Mana Regen\": " + ManaRegen.Value + ",\r\n                \"Luck\": " + LuckNumBox.Value + ",\r\n                \"Wisdom\": " + WisdomNumBox.Value + ",\r\n                \"Ability\": " + rightClickEffect + "\r\n              }\r\n            },\r\n            {\r\n              \"function\": \"minecraft:set_components\",\r\n              \"components\": {\r\n                \"minecraft:item_model\": \"dungeon:custom_item/" + NameTextBox.Text.Replace(" ", "_").ToLower() + "\",";


            if (armorItems.Contains(ItemComboBox.SelectedItem))
                jsonString += "\r\n                \"minecraft:equippable\": {\r\n                  \"slot\": \"" + armorPiece[ItemComboBox.SelectedItem.ToString().Split('_')[1]] + "\",\r\n                  \"model\": \"dungeon:" + NameTextBox.Text.Replace(" ", "_").ToLower() + "\"\r\n                },\r\n                ";

            jsonString += "\r\n                \"minecraft:enchantments\": {\r\n                  \"levels\": {\r\n                    \"ability:" + leftClickEffect + "\": 1\r\n                  },\r\n                  \"show_in_tooltip\": false\r\n                },\r\n                \"minecraft:enchantment_glint_override\": false,\r\n                \"minecraft:unbreakable\": {\r\n                  \"show_in_tooltip\": false\r\n                }";

            if (RightInputPanel.Controls.OfType<CheckBox>().Any(cb => cb.Checked))
                jsonString += ",\r\n                \"minecraft:food\": {\r\n                  \"nutrition\": 0,\r\n                  \"saturation\": 0,\r\n                  \"can_always_eat\": true\r\n                },\r\n                \"minecraft:consumable\": {\r\n                  \"consume_seconds\": 9999\r\n                }";


            jsonString += "\r\n              },\r\n              \"conditions\": []\r\n            }\r\n          ],\r\n          \"conditions\": []\r\n        }\r\n      ],\r\n      \"functions\": [],\r\n      \"conditions\": []\r\n    }\r\n  ]\r\n}";











            // set json text box to json string
            JsonTextBox.Text = jsonString;

            // collect garbage to make sure program dont crash
            GC.Collect();
        }

        private void RarityComboBoxChanged(object sender, EventArgs e)
        {
            NameTextBox.ForeColor = rarityColors[RarityComboBox.SelectedIndex];
            GenerateJSON();
        }

        private async void CopyToClipboard(object sender, EventArgs e)
        {
            GenerateJSON();
            try
            {
                Clipboard.SetText(JsonTextBox.Text);
                CopyClipboardButton.Text = "Copied!";
                await Task.Delay(1000);
                CopyClipboardButton.Text = "Copy to Clipboard";
            }
            catch (Exception ex)
            {
                CopyClipboardButton.Text = "An Error has Occured..";
                await Task.Delay(3000);
                CopyClipboardButton.Text = "Copy to Clipboard";
            }
        }

        private async void SaveFile(object sender, EventArgs e)
        {
            GenerateJSON();
            string directory = FilePathTextBox.Text.TrimStart('\"').TrimEnd('\"');
            if (Directory.Exists(directory))
            {
                if (!File.Exists(directory + "\\" + NameTextBox.Text.Replace(" ", "_").ToLower() + ".json"))
                    File.WriteAllText(directory + "\\" + NameTextBox.Text.Replace(" ", "_").ToLower() + ".json", JsonTextBox.Text);
                else
                {
                    int endingAbreviation = 0;
                    if (File.Exists(directory + "\\" + NameTextBox.Text.Replace(" ", "_").ToLower() + " (" + endingAbreviation + ").json"))
                        while (File.Exists(directory + "\\" + NameTextBox.Text.Replace(" ", "_").ToLower() + " (" + endingAbreviation + ").json"))
                            endingAbreviation++;
                    File.WriteAllText(directory + "\\" + NameTextBox.Text.Replace(" ", "_").ToLower() + " (" + endingAbreviation + ").json", JsonTextBox.Text);
                }
                SaveButton.Text = "Saved!";
                await Task.Delay(3000);
                SaveButton.Text = "Save to File";
            }
            else
            {
                SaveButton.Text = "Directory Does Not Exist";
                await Task.Delay(3000);
                SaveButton.Text = "Save to File";
            }
        }

        private void DescriptionTextChanged(object sender, EventArgs e)
        {
            if (DescriptionTextBox.Lines.Count() > 5)
                DescriptionTextBox.ScrollBars = ScrollBars.Vertical;
            else
                DescriptionTextBox.ScrollBars = ScrollBars.None;
            GenerateJSON();
        }

        private void AbilitiesChanged(object sender, EventArgs e)
        {
            ///<summary>
            /// This function is used to hide and show the input boxes depending on the item selected.
            ///</summary>
            if (ItemComboBox.SelectedItem != "iron_sword" && ItemComboBox.SelectedItem != "stick")
            {
                LeftInputGroupBox.Visible = false;
                RightInputGroupBox.Visible = false;
                FullSetBonusGroupBox.Visible = true;
                LeftInputPanel.Controls.OfType<CheckBox>().Any(cb => cb.Checked = false);
                RightInputPanel.Controls.OfType<CheckBox>().Any(cb => cb.Checked = false);
            }
            else
            {
                LeftInputGroupBox.Visible = true;
                RightInputGroupBox.Visible = true;
                FullSetBonusGroupBox.Visible = false;
                FullSetBonusPanel.Controls.OfType<CheckBox>().Any(cb => cb.Checked = false);
            }
            if (ItemComboBox.SelectedItem == "carved_pumpkin")
                SlotGroupBox.Visible = true;
            else
                SlotGroupBox.Visible = false;
            GenerateJSON();
        }

        private void StatsValueChange(object sender, EventArgs e)
        {
            GenerateJSON();
        }

        private void AbilityChecks(object sender, EventArgs e)
        {
            /// <summary>
            /// Makes sure that there is no more than one ability selected at a time.
            /// </summary>
            if (((CheckBox)sender).Checked)
                foreach (Control ctrl in ((CheckBox)sender).Parent.Controls)
                    if (ctrl is CheckBox cb && cb.Name != ((CheckBox)sender).Name)
                        cb.Checked = false;
            GenerateJSON();
        }

        private void CheckNameStatus(object sender, EventArgs e)
        {
            /// <summary>
            /// Check for name if name is empty then replace textbox with item name.
            /// </summary>
            if (string.IsNullOrWhiteSpace(NameTextBox.Text))
                NameTextBox.Text = ItemComboBox.SelectedItem.ToString().Replace("_", " ");
            GenerateJSON();
        }

        int anvilBreakState = 3;
        private async void AnvilClickedSecret(object sender, EventArgs e)
        {
            /// <summary>
            /// plays the anvil craft sfx or (a 1/10 plays anvil break) when anvil clicked, just a fun little easter egg
            /// </summary>
            if (new Random().Next(0, 10) == 0) // .Next(0, 10) 0-9 or a 1/10 chance
            {
                // anvil break
                using (Stream str = new MemoryStream(Resources.Anvil_destroy))
                {
                    SoundPlayer snd = new SoundPlayer(str);
                    snd.Play();
                }
                anvilBreakState--;
            }
            else
            {
                // anvil craft
                using (Stream str = new MemoryStream(Resources.Anvil_use))
                {
                    SoundPlayer snd = new SoundPlayer(str);
                    snd.Play();
                }
            }
            await Task.Delay(800);
            // change anvil image
            switch (anvilBreakState)
            {
                case 3:
                    Anvil.Image = Resources.Anvil_29_BE3;
                    break;
                case 2:
                    Anvil.Image = Resources.Chipped_Anvil_29_JE3;
                    break;
                case 1:
                    Anvil.Image = Resources.Damaged_Anvil_29_BE2;
                    break;
                case 0:
                    Anvil.Image = null;
                    Anvil.Enabled = false;
                    break;
            }
        }
    }
}
