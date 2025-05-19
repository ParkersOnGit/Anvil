namespace Anvil
{
    partial class Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            Anvil = new PictureBox();
            InputGroupBox = new GroupBox();
            ItemGroupBox = new GroupBox();
            ItemComboBox = new ComboBox();
            DescriptionGroupBox = new GroupBox();
            DescriptionTextBox = new TextBox();
            StatsGroupBox = new GroupBox();
            Icon12 = new Label();
            Icon10 = new Label();
            Icon9 = new Label();
            Icon8 = new Label();
            Icon7 = new Label();
            Icon6 = new Label();
            Icon5 = new Label();
            Icon4 = new Label();
            Icon3 = new Label();
            Icon2 = new Label();
            WisdomTextLabel = new Label();
            HealthRegenTextLabel = new Label();
            LuckTextLabel = new Label();
            ManaRegenTextLabel = new Label();
            ManaTextLabel = new Label();
            SpeedTextLabel = new Label();
            DefenseTextLabel = new Label();
            HealthTextLabel = new Label();
            AttackSpeedTextLabel = new Label();
            Icon11 = new Label();
            Icon1 = new Label();
            DamageTextLabel = new Label();
            WisdomNumBox = new NumericUpDown();
            LuckNumBox = new NumericUpDown();
            ManaRegen = new NumericUpDown();
            ManaNumBox = new NumericUpDown();
            SpeedNumBox = new NumericUpDown();
            DefenseNumBox = new NumericUpDown();
            HealthRegenNumBox = new NumericUpDown();
            HealthNumBox = new NumericUpDown();
            AttackSpeedNumBox = new NumericUpDown();
            DamageNumBox = new NumericUpDown();
            PrestigedCheckBox = new CheckBox();
            NameGroupBox = new GroupBox();
            NameTextBox = new TextBox();
            RarityGroupBox = new GroupBox();
            RarityComboBox = new ComboBox();
            LeftInputGroupBox = new GroupBox();
            LeftInputPanel = new Panel();
            ElectricBoogaloo = new CheckBox();
            BadInfection = new CheckBox();
            Vampire = new CheckBox();
            Chomp = new CheckBox();
            Assassin = new CheckBox();
            Stunning = new CheckBox();
            FlameSacrifice = new CheckBox();
            Icon13 = new Label();
            FullSetBonusGroupBox = new GroupBox();
            FullSetBonusPanel = new Panel();
            SlotGroupBox = new GroupBox();
            SlotComboBox = new ComboBox();
            HunterGrass = new CheckBox();
            Icon15 = new Label();
            RightInputGroupBox = new GroupBox();
            RightInputPanel = new Panel();
            PumpkinBlast = new CheckBox();
            Rage = new CheckBox();
            HeartAttack = new CheckBox();
            Gassy = new CheckBox();
            ManaWard = new CheckBox();
            MultiHit = new CheckBox();
            FiraBawl = new CheckBox();
            Icon14 = new Label();
            ExportGroupBox = new GroupBox();
            FilePathTextBox = new TextBox();
            SeperationBar = new Panel();
            JsonTextBox = new TextBox();
            SaveButton = new Button();
            CopyClipboardButton = new Button();
            InfoGroupBox = new GroupBox();
            InfoTextLabel = new Label();
            CreditsTextLabel = new Label();
            VersionNum = new Label();
            ((System.ComponentModel.ISupportInitialize)Anvil).BeginInit();
            InputGroupBox.SuspendLayout();
            ItemGroupBox.SuspendLayout();
            DescriptionGroupBox.SuspendLayout();
            StatsGroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)WisdomNumBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)LuckNumBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ManaRegen).BeginInit();
            ((System.ComponentModel.ISupportInitialize)ManaNumBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)SpeedNumBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DefenseNumBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HealthRegenNumBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)HealthNumBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)AttackSpeedNumBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DamageNumBox).BeginInit();
            NameGroupBox.SuspendLayout();
            RarityGroupBox.SuspendLayout();
            LeftInputGroupBox.SuspendLayout();
            LeftInputPanel.SuspendLayout();
            FullSetBonusGroupBox.SuspendLayout();
            FullSetBonusPanel.SuspendLayout();
            SlotGroupBox.SuspendLayout();
            RightInputGroupBox.SuspendLayout();
            RightInputPanel.SuspendLayout();
            ExportGroupBox.SuspendLayout();
            InfoGroupBox.SuspendLayout();
            SuspendLayout();
            // 
            // Anvil
            // 
            Anvil.Cursor = Cursors.Hand;
            Anvil.Location = new Point(855, 590);
            Anvil.Name = "Anvil";
            Anvil.Size = new Size(75, 73);
            Anvil.SizeMode = PictureBoxSizeMode.Zoom;
            Anvil.TabIndex = 0;
            Anvil.TabStop = false;
            Anvil.Click += AnvilClickedSecret;
            // 
            // InputGroupBox
            // 
            InputGroupBox.Controls.Add(ItemGroupBox);
            InputGroupBox.Controls.Add(DescriptionGroupBox);
            InputGroupBox.Controls.Add(StatsGroupBox);
            InputGroupBox.Controls.Add(NameGroupBox);
            InputGroupBox.Controls.Add(RarityGroupBox);
            InputGroupBox.Controls.Add(LeftInputGroupBox);
            InputGroupBox.Controls.Add(FullSetBonusGroupBox);
            InputGroupBox.Controls.Add(RightInputGroupBox);
            InputGroupBox.Location = new Point(12, 12);
            InputGroupBox.Name = "InputGroupBox";
            InputGroupBox.Size = new Size(537, 651);
            InputGroupBox.TabIndex = 1;
            InputGroupBox.TabStop = false;
            InputGroupBox.Text = "Inputs:";
            // 
            // ItemGroupBox
            // 
            ItemGroupBox.Controls.Add(ItemComboBox);
            ItemGroupBox.Location = new Point(143, 89);
            ItemGroupBox.Name = "ItemGroupBox";
            ItemGroupBox.Size = new Size(145, 57);
            ItemGroupBox.TabIndex = 3;
            ItemGroupBox.TabStop = false;
            ItemGroupBox.Text = "Item:";
            // 
            // ItemComboBox
            // 
            ItemComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            ItemComboBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ItemComboBox.FormattingEnabled = true;
            ItemComboBox.Items.AddRange(new object[] { "iron_sword", "chainmail_helmet", "chainmail_chestplate", "chainmail_leggings", "chainmail_boots", "stick", "carved_pumpkin" });
            ItemComboBox.Location = new Point(6, 22);
            ItemComboBox.Name = "ItemComboBox";
            ItemComboBox.Size = new Size(133, 24);
            ItemComboBox.TabIndex = 0;
            ItemComboBox.SelectedIndexChanged += AbilitiesChanged;
            // 
            // DescriptionGroupBox
            // 
            DescriptionGroupBox.Controls.Add(DescriptionTextBox);
            DescriptionGroupBox.Location = new Point(6, 152);
            DescriptionGroupBox.Name = "DescriptionGroupBox";
            DescriptionGroupBox.Size = new Size(282, 123);
            DescriptionGroupBox.TabIndex = 4;
            DescriptionGroupBox.TabStop = false;
            DescriptionGroupBox.Text = "Description:";
            // 
            // DescriptionTextBox
            // 
            DescriptionTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DescriptionTextBox.Location = new Point(6, 22);
            DescriptionTextBox.Multiline = true;
            DescriptionTextBox.Name = "DescriptionTextBox";
            DescriptionTextBox.Size = new Size(270, 95);
            DescriptionTextBox.TabIndex = 0;
            DescriptionTextBox.WordWrap = false;
            DescriptionTextBox.TextChanged += DescriptionTextChanged;
            // 
            // StatsGroupBox
            // 
            StatsGroupBox.Controls.Add(Icon12);
            StatsGroupBox.Controls.Add(Icon10);
            StatsGroupBox.Controls.Add(Icon9);
            StatsGroupBox.Controls.Add(Icon8);
            StatsGroupBox.Controls.Add(Icon7);
            StatsGroupBox.Controls.Add(Icon6);
            StatsGroupBox.Controls.Add(Icon5);
            StatsGroupBox.Controls.Add(Icon4);
            StatsGroupBox.Controls.Add(Icon3);
            StatsGroupBox.Controls.Add(Icon2);
            StatsGroupBox.Controls.Add(WisdomTextLabel);
            StatsGroupBox.Controls.Add(HealthRegenTextLabel);
            StatsGroupBox.Controls.Add(LuckTextLabel);
            StatsGroupBox.Controls.Add(ManaRegenTextLabel);
            StatsGroupBox.Controls.Add(ManaTextLabel);
            StatsGroupBox.Controls.Add(SpeedTextLabel);
            StatsGroupBox.Controls.Add(DefenseTextLabel);
            StatsGroupBox.Controls.Add(HealthTextLabel);
            StatsGroupBox.Controls.Add(AttackSpeedTextLabel);
            StatsGroupBox.Controls.Add(Icon11);
            StatsGroupBox.Controls.Add(Icon1);
            StatsGroupBox.Controls.Add(DamageTextLabel);
            StatsGroupBox.Controls.Add(WisdomNumBox);
            StatsGroupBox.Controls.Add(LuckNumBox);
            StatsGroupBox.Controls.Add(ManaRegen);
            StatsGroupBox.Controls.Add(ManaNumBox);
            StatsGroupBox.Controls.Add(SpeedNumBox);
            StatsGroupBox.Controls.Add(DefenseNumBox);
            StatsGroupBox.Controls.Add(HealthRegenNumBox);
            StatsGroupBox.Controls.Add(HealthNumBox);
            StatsGroupBox.Controls.Add(AttackSpeedNumBox);
            StatsGroupBox.Controls.Add(DamageNumBox);
            StatsGroupBox.Controls.Add(PrestigedCheckBox);
            StatsGroupBox.Location = new Point(6, 281);
            StatsGroupBox.Name = "StatsGroupBox";
            StatsGroupBox.Size = new Size(282, 364);
            StatsGroupBox.TabIndex = 3;
            StatsGroupBox.TabStop = false;
            StatsGroupBox.Text = "Stats:";
            // 
            // Icon12
            // 
            Icon12.AutoSize = true;
            Icon12.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            Icon12.ForeColor = Color.Goldenrod;
            Icon12.Location = new Point(154, 319);
            Icon12.Name = "Icon12";
            Icon12.Size = new Size(34, 32);
            Icon12.TabIndex = 32;
            Icon12.Text = "✧";
            // 
            // Icon10
            // 
            Icon10.AutoSize = true;
            Icon10.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon10.ForeColor = Color.LightSeaGreen;
            Icon10.Location = new Point(13, 283);
            Icon10.Name = "Icon10";
            Icon10.Size = new Size(30, 20);
            Icon10.TabIndex = 31;
            Icon10.Text = "☯";
            // 
            // Icon9
            // 
            Icon9.AutoSize = true;
            Icon9.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon9.ForeColor = Color.MediumOrchid;
            Icon9.Location = new Point(14, 251);
            Icon9.Name = "Icon9";
            Icon9.Size = new Size(27, 30);
            Icon9.TabIndex = 30;
            Icon9.Text = "♣";
            // 
            // Icon8
            // 
            Icon8.AutoSize = true;
            Icon8.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon8.ForeColor = Color.Aqua;
            Icon8.Location = new Point(10, 222);
            Icon8.Name = "Icon8";
            Icon8.Size = new Size(36, 30);
            Icon8.TabIndex = 29;
            Icon8.Text = "✯ ";
            // 
            // Icon7
            // 
            Icon7.AutoSize = true;
            Icon7.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon7.ForeColor = Color.Aqua;
            Icon7.Location = new Point(6, 190);
            Icon7.Name = "Icon7";
            Icon7.Size = new Size(38, 32);
            Icon7.TabIndex = 28;
            Icon7.Text = "✎";
            // 
            // Icon6
            // 
            Icon6.AutoSize = true;
            Icon6.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon6.ForeColor = SystemColors.ButtonShadow;
            Icon6.Location = new Point(10, 160);
            Icon6.Name = "Icon6";
            Icon6.Size = new Size(34, 32);
            Icon6.TabIndex = 27;
            Icon6.Text = "✦";
            // 
            // Icon5
            // 
            Icon5.AutoSize = true;
            Icon5.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon5.ForeColor = Color.YellowGreen;
            Icon5.Location = new Point(15, 136);
            Icon5.Name = "Icon5";
            Icon5.Size = new Size(22, 20);
            Icon5.TabIndex = 26;
            Icon5.Text = "❈";
            // 
            // Icon4
            // 
            Icon4.AutoSize = true;
            Icon4.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon4.ForeColor = Color.IndianRed;
            Icon4.Location = new Point(11, 109);
            Icon4.Name = "Icon4";
            Icon4.Size = new Size(30, 20);
            Icon4.TabIndex = 25;
            Icon4.Text = "❣";
            // 
            // Icon3
            // 
            Icon3.AutoSize = true;
            Icon3.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon3.ForeColor = Color.IndianRed;
            Icon3.Location = new Point(11, 80);
            Icon3.Name = "Icon3";
            Icon3.Size = new Size(30, 20);
            Icon3.TabIndex = 24;
            Icon3.Text = "❤";
            // 
            // Icon2
            // 
            Icon2.AutoSize = true;
            Icon2.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon2.ForeColor = Color.Goldenrod;
            Icon2.Location = new Point(11, 51);
            Icon2.Name = "Icon2";
            Icon2.Size = new Size(30, 20);
            Icon2.TabIndex = 23;
            Icon2.Text = "⚔";
            // 
            // WisdomTextLabel
            // 
            WisdomTextLabel.AutoSize = true;
            WisdomTextLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            WisdomTextLabel.ForeColor = Color.LightSeaGreen;
            WisdomTextLabel.Location = new Point(173, 283);
            WisdomTextLabel.Name = "WisdomTextLabel";
            WisdomTextLabel.Size = new Size(67, 20);
            WisdomTextLabel.TabIndex = 22;
            WisdomTextLabel.Text = "Wisdom";
            // 
            // HealthRegenTextLabel
            // 
            HealthRegenTextLabel.AutoSize = true;
            HealthRegenTextLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HealthRegenTextLabel.ForeColor = Color.IndianRed;
            HealthRegenTextLabel.Location = new Point(173, 112);
            HealthRegenTextLabel.Name = "HealthRegenTextLabel";
            HealthRegenTextLabel.Size = new Size(103, 20);
            HealthRegenTextLabel.TabIndex = 21;
            HealthRegenTextLabel.Text = "Health Regen";
            // 
            // LuckTextLabel
            // 
            LuckTextLabel.AutoSize = true;
            LuckTextLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            LuckTextLabel.ForeColor = Color.MediumOrchid;
            LuckTextLabel.Location = new Point(173, 254);
            LuckTextLabel.Name = "LuckTextLabel";
            LuckTextLabel.Size = new Size(41, 20);
            LuckTextLabel.TabIndex = 20;
            LuckTextLabel.Text = "Luck";
            // 
            // ManaRegenTextLabel
            // 
            ManaRegenTextLabel.AutoSize = true;
            ManaRegenTextLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManaRegenTextLabel.ForeColor = Color.Aqua;
            ManaRegenTextLabel.Location = new Point(173, 225);
            ManaRegenTextLabel.Name = "ManaRegenTextLabel";
            ManaRegenTextLabel.Size = new Size(96, 20);
            ManaRegenTextLabel.TabIndex = 19;
            ManaRegenTextLabel.Text = "Mana Regen";
            // 
            // ManaTextLabel
            // 
            ManaTextLabel.AutoSize = true;
            ManaTextLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManaTextLabel.ForeColor = Color.Aqua;
            ManaTextLabel.Location = new Point(173, 197);
            ManaTextLabel.Name = "ManaTextLabel";
            ManaTextLabel.Size = new Size(48, 20);
            ManaTextLabel.TabIndex = 18;
            ManaTextLabel.Text = "Mana";
            // 
            // SpeedTextLabel
            // 
            SpeedTextLabel.AutoSize = true;
            SpeedTextLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SpeedTextLabel.ForeColor = SystemColors.ButtonShadow;
            SpeedTextLabel.Location = new Point(173, 167);
            SpeedTextLabel.Name = "SpeedTextLabel";
            SpeedTextLabel.Size = new Size(51, 20);
            SpeedTextLabel.TabIndex = 17;
            SpeedTextLabel.Text = "Speed";
            // 
            // DefenseTextLabel
            // 
            DefenseTextLabel.AutoSize = true;
            DefenseTextLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DefenseTextLabel.ForeColor = Color.YellowGreen;
            DefenseTextLabel.Location = new Point(173, 138);
            DefenseTextLabel.Name = "DefenseTextLabel";
            DefenseTextLabel.Size = new Size(66, 20);
            DefenseTextLabel.TabIndex = 16;
            DefenseTextLabel.Text = "Defense";
            // 
            // HealthTextLabel
            // 
            HealthTextLabel.AutoSize = true;
            HealthTextLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HealthTextLabel.ForeColor = Color.IndianRed;
            HealthTextLabel.Location = new Point(173, 83);
            HealthTextLabel.Name = "HealthTextLabel";
            HealthTextLabel.Size = new Size(55, 20);
            HealthTextLabel.TabIndex = 15;
            HealthTextLabel.Text = "Health";
            // 
            // AttackSpeedTextLabel
            // 
            AttackSpeedTextLabel.AutoSize = true;
            AttackSpeedTextLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            AttackSpeedTextLabel.ForeColor = Color.Goldenrod;
            AttackSpeedTextLabel.Location = new Point(173, 54);
            AttackSpeedTextLabel.Name = "AttackSpeedTextLabel";
            AttackSpeedTextLabel.Size = new Size(101, 20);
            AttackSpeedTextLabel.TabIndex = 14;
            AttackSpeedTextLabel.Text = "Attack Speed";
            // 
            // Icon11
            // 
            Icon11.AutoSize = true;
            Icon11.BackColor = Color.Transparent;
            Icon11.Font = new Font("Arial", 20.25F, FontStyle.Bold);
            Icon11.ForeColor = Color.Goldenrod;
            Icon11.Location = new Point(10, 316);
            Icon11.Name = "Icon11";
            Icon11.Size = new Size(34, 32);
            Icon11.TabIndex = 13;
            Icon11.Text = "✧";
            // 
            // Icon1
            // 
            Icon1.AutoSize = true;
            Icon1.Font = new Font("Segoe UI", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Icon1.ForeColor = Color.Goldenrod;
            Icon1.Location = new Point(11, 22);
            Icon1.Name = "Icon1";
            Icon1.Size = new Size(30, 20);
            Icon1.TabIndex = 12;
            Icon1.Text = "⚔";
            // 
            // DamageTextLabel
            // 
            DamageTextLabel.AutoSize = true;
            DamageTextLabel.Font = new Font("Segoe UI", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DamageTextLabel.ForeColor = Color.Goldenrod;
            DamageTextLabel.Location = new Point(173, 22);
            DamageTextLabel.Name = "DamageTextLabel";
            DamageTextLabel.Size = new Size(67, 20);
            DamageTextLabel.TabIndex = 11;
            DamageTextLabel.Text = "Damage";
            // 
            // WisdomNumBox
            // 
            WisdomNumBox.Location = new Point(47, 283);
            WisdomNumBox.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            WisdomNumBox.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            WisdomNumBox.Name = "WisdomNumBox";
            WisdomNumBox.Size = new Size(120, 23);
            WisdomNumBox.TabIndex = 10;
            WisdomNumBox.ThousandsSeparator = true;
            WisdomNumBox.ValueChanged += StatsValueChange;
            // 
            // LuckNumBox
            // 
            LuckNumBox.Location = new Point(47, 254);
            LuckNumBox.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            LuckNumBox.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            LuckNumBox.Name = "LuckNumBox";
            LuckNumBox.Size = new Size(120, 23);
            LuckNumBox.TabIndex = 9;
            LuckNumBox.ThousandsSeparator = true;
            LuckNumBox.ValueChanged += StatsValueChange;
            // 
            // ManaRegen
            // 
            ManaRegen.Location = new Point(47, 225);
            ManaRegen.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            ManaRegen.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            ManaRegen.Name = "ManaRegen";
            ManaRegen.Size = new Size(120, 23);
            ManaRegen.TabIndex = 8;
            ManaRegen.ThousandsSeparator = true;
            ManaRegen.ValueChanged += StatsValueChange;
            // 
            // ManaNumBox
            // 
            ManaNumBox.Location = new Point(47, 196);
            ManaNumBox.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            ManaNumBox.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            ManaNumBox.Name = "ManaNumBox";
            ManaNumBox.Size = new Size(120, 23);
            ManaNumBox.TabIndex = 7;
            ManaNumBox.ThousandsSeparator = true;
            ManaNumBox.ValueChanged += StatsValueChange;
            // 
            // SpeedNumBox
            // 
            SpeedNumBox.Location = new Point(47, 167);
            SpeedNumBox.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            SpeedNumBox.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            SpeedNumBox.Name = "SpeedNumBox";
            SpeedNumBox.Size = new Size(120, 23);
            SpeedNumBox.TabIndex = 6;
            SpeedNumBox.ThousandsSeparator = true;
            SpeedNumBox.ValueChanged += StatsValueChange;
            // 
            // DefenseNumBox
            // 
            DefenseNumBox.Location = new Point(47, 138);
            DefenseNumBox.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            DefenseNumBox.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            DefenseNumBox.Name = "DefenseNumBox";
            DefenseNumBox.Size = new Size(120, 23);
            DefenseNumBox.TabIndex = 5;
            DefenseNumBox.ThousandsSeparator = true;
            DefenseNumBox.ValueChanged += StatsValueChange;
            // 
            // HealthRegenNumBox
            // 
            HealthRegenNumBox.Location = new Point(47, 109);
            HealthRegenNumBox.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            HealthRegenNumBox.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            HealthRegenNumBox.Name = "HealthRegenNumBox";
            HealthRegenNumBox.Size = new Size(120, 23);
            HealthRegenNumBox.TabIndex = 4;
            HealthRegenNumBox.ThousandsSeparator = true;
            HealthRegenNumBox.ValueChanged += StatsValueChange;
            // 
            // HealthNumBox
            // 
            HealthNumBox.Location = new Point(47, 80);
            HealthNumBox.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            HealthNumBox.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            HealthNumBox.Name = "HealthNumBox";
            HealthNumBox.Size = new Size(120, 23);
            HealthNumBox.TabIndex = 3;
            HealthNumBox.ThousandsSeparator = true;
            HealthNumBox.ValueChanged += StatsValueChange;
            // 
            // AttackSpeedNumBox
            // 
            AttackSpeedNumBox.Location = new Point(47, 51);
            AttackSpeedNumBox.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            AttackSpeedNumBox.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            AttackSpeedNumBox.Name = "AttackSpeedNumBox";
            AttackSpeedNumBox.Size = new Size(120, 23);
            AttackSpeedNumBox.TabIndex = 2;
            AttackSpeedNumBox.ThousandsSeparator = true;
            AttackSpeedNumBox.ValueChanged += StatsValueChange;
            // 
            // DamageNumBox
            // 
            DamageNumBox.Location = new Point(47, 22);
            DamageNumBox.Maximum = new decimal(new int[] { 1000000, 0, 0, 0 });
            DamageNumBox.Minimum = new decimal(new int[] { 1000000, 0, 0, int.MinValue });
            DamageNumBox.Name = "DamageNumBox";
            DamageNumBox.Size = new Size(120, 23);
            DamageNumBox.TabIndex = 1;
            DamageNumBox.ThousandsSeparator = true;
            DamageNumBox.ValueChanged += StatsValueChange;
            // 
            // PrestigedCheckBox
            // 
            PrestigedCheckBox.AutoSize = true;
            PrestigedCheckBox.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PrestigedCheckBox.ForeColor = Color.Maroon;
            PrestigedCheckBox.Location = new Point(47, 319);
            PrestigedCheckBox.Name = "PrestigedCheckBox";
            PrestigedCheckBox.Size = new Size(115, 29);
            PrestigedCheckBox.TabIndex = 0;
            PrestigedCheckBox.Text = "Prestiged";
            PrestigedCheckBox.UseVisualStyleBackColor = true;
            PrestigedCheckBox.CheckedChanged += StatsValueChange;
            // 
            // NameGroupBox
            // 
            NameGroupBox.Controls.Add(NameTextBox);
            NameGroupBox.Location = new Point(6, 22);
            NameGroupBox.Name = "NameGroupBox";
            NameGroupBox.Size = new Size(525, 61);
            NameGroupBox.TabIndex = 3;
            NameGroupBox.TabStop = false;
            NameGroupBox.Text = "Name:";
            // 
            // NameTextBox
            // 
            NameTextBox.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            NameTextBox.Location = new Point(6, 22);
            NameTextBox.Name = "NameTextBox";
            NameTextBox.Size = new Size(513, 25);
            NameTextBox.TabIndex = 0;
            NameTextBox.Text = "Generic Item";
            NameTextBox.Leave += CheckNameStatus;
            // 
            // RarityGroupBox
            // 
            RarityGroupBox.Controls.Add(RarityComboBox);
            RarityGroupBox.Location = new Point(6, 89);
            RarityGroupBox.Name = "RarityGroupBox";
            RarityGroupBox.Size = new Size(131, 57);
            RarityGroupBox.TabIndex = 2;
            RarityGroupBox.TabStop = false;
            RarityGroupBox.Text = "Rarity:";
            // 
            // RarityComboBox
            // 
            RarityComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            RarityComboBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            RarityComboBox.FormattingEnabled = true;
            RarityComboBox.Items.AddRange(new object[] { "Common", "Uncommon", "Rare", "Epic", "Legendary" });
            RarityComboBox.Location = new Point(6, 22);
            RarityComboBox.Name = "RarityComboBox";
            RarityComboBox.Size = new Size(119, 24);
            RarityComboBox.TabIndex = 0;
            RarityComboBox.SelectedIndexChanged += RarityComboBoxChanged;
            // 
            // LeftInputGroupBox
            // 
            LeftInputGroupBox.Controls.Add(LeftInputPanel);
            LeftInputGroupBox.Controls.Add(Icon13);
            LeftInputGroupBox.Location = new Point(294, 89);
            LeftInputGroupBox.Name = "LeftInputGroupBox";
            LeftInputGroupBox.Size = new Size(237, 266);
            LeftInputGroupBox.TabIndex = 5;
            LeftInputGroupBox.TabStop = false;
            LeftInputGroupBox.Text = "     Left Input:";
            // 
            // LeftInputPanel
            // 
            LeftInputPanel.AutoScroll = true;
            LeftInputPanel.Controls.Add(ElectricBoogaloo);
            LeftInputPanel.Controls.Add(BadInfection);
            LeftInputPanel.Controls.Add(Vampire);
            LeftInputPanel.Controls.Add(Chomp);
            LeftInputPanel.Controls.Add(Assassin);
            LeftInputPanel.Controls.Add(Stunning);
            LeftInputPanel.Controls.Add(FlameSacrifice);
            LeftInputPanel.Dock = DockStyle.Fill;
            LeftInputPanel.Location = new Point(3, 19);
            LeftInputPanel.Name = "LeftInputPanel";
            LeftInputPanel.Size = new Size(231, 244);
            LeftInputPanel.TabIndex = 35;
            // 
            // ElectricBoogaloo
            // 
            ElectricBoogaloo.AutoSize = true;
            ElectricBoogaloo.BackColor = Color.Transparent;
            ElectricBoogaloo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ElectricBoogaloo.ForeColor = SystemColors.ActiveCaptionText;
            ElectricBoogaloo.Location = new Point(3, 158);
            ElectricBoogaloo.Name = "ElectricBoogaloo";
            ElectricBoogaloo.Size = new Size(186, 29);
            ElectricBoogaloo.TabIndex = 40;
            ElectricBoogaloo.Text = "Electric Boogaloo";
            ElectricBoogaloo.UseVisualStyleBackColor = false;
            ElectricBoogaloo.CheckedChanged += AbilityChecks;
            // 
            // BadInfection
            // 
            BadInfection.AutoSize = true;
            BadInfection.BackColor = Color.Transparent;
            BadInfection.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            BadInfection.ForeColor = SystemColors.ActiveCaptionText;
            BadInfection.Location = new Point(3, 4);
            BadInfection.Name = "BadInfection";
            BadInfection.Size = new Size(150, 29);
            BadInfection.TabIndex = 33;
            BadInfection.Text = "Bad Infection";
            BadInfection.UseVisualStyleBackColor = false;
            BadInfection.CheckedChanged += AbilityChecks;
            // 
            // Vampire
            // 
            Vampire.AutoSize = true;
            Vampire.BackColor = Color.Transparent;
            Vampire.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Vampire.ForeColor = SystemColors.ActiveCaptionText;
            Vampire.Location = new Point(3, 55);
            Vampire.Name = "Vampire";
            Vampire.Size = new Size(105, 29);
            Vampire.TabIndex = 36;
            Vampire.Text = "Vampire";
            Vampire.UseVisualStyleBackColor = false;
            Vampire.CheckedChanged += AbilityChecks;
            // 
            // Chomp
            // 
            Chomp.AutoSize = true;
            Chomp.BackColor = Color.Transparent;
            Chomp.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Chomp.ForeColor = SystemColors.ActiveCaptionText;
            Chomp.Location = new Point(3, 80);
            Chomp.Name = "Chomp";
            Chomp.Size = new Size(95, 29);
            Chomp.TabIndex = 37;
            Chomp.Text = "Chomp";
            Chomp.UseVisualStyleBackColor = false;
            Chomp.CheckedChanged += AbilityChecks;
            // 
            // Assassin
            // 
            Assassin.AutoSize = true;
            Assassin.BackColor = Color.Transparent;
            Assassin.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Assassin.ForeColor = SystemColors.ActiveCaptionText;
            Assassin.Location = new Point(3, 105);
            Assassin.Name = "Assassin";
            Assassin.Size = new Size(103, 29);
            Assassin.TabIndex = 39;
            Assassin.Text = "Assassin";
            Assassin.UseVisualStyleBackColor = false;
            Assassin.CheckedChanged += AbilityChecks;
            // 
            // Stunning
            // 
            Stunning.AutoSize = true;
            Stunning.BackColor = Color.Transparent;
            Stunning.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Stunning.ForeColor = SystemColors.ActiveCaptionText;
            Stunning.Location = new Point(3, 30);
            Stunning.Name = "Stunning";
            Stunning.Size = new Size(114, 29);
            Stunning.TabIndex = 34;
            Stunning.Text = "Stunning";
            Stunning.UseVisualStyleBackColor = false;
            Stunning.CheckedChanged += AbilityChecks;
            // 
            // FlameSacrifice
            // 
            FlameSacrifice.AutoSize = true;
            FlameSacrifice.BackColor = Color.Transparent;
            FlameSacrifice.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FlameSacrifice.ForeColor = SystemColors.ActiveCaptionText;
            FlameSacrifice.Location = new Point(3, 131);
            FlameSacrifice.Name = "FlameSacrifice";
            FlameSacrifice.Size = new Size(162, 29);
            FlameSacrifice.TabIndex = 38;
            FlameSacrifice.Text = "Flame Sacrifice";
            FlameSacrifice.UseVisualStyleBackColor = false;
            FlameSacrifice.CheckedChanged += AbilityChecks;
            // 
            // Icon13
            // 
            Icon13.AutoSize = true;
            Icon13.BackColor = Color.Transparent;
            Icon13.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon13.ForeColor = Color.Goldenrod;
            Icon13.Location = new Point(0, -3);
            Icon13.Name = "Icon13";
            Icon13.Size = new Size(33, 24);
            Icon13.TabIndex = 33;
            Icon13.Text = "🔥";
            // 
            // FullSetBonusGroupBox
            // 
            FullSetBonusGroupBox.Controls.Add(FullSetBonusPanel);
            FullSetBonusGroupBox.Controls.Add(Icon15);
            FullSetBonusGroupBox.Location = new Point(294, 89);
            FullSetBonusGroupBox.Name = "FullSetBonusGroupBox";
            FullSetBonusGroupBox.Size = new Size(237, 556);
            FullSetBonusGroupBox.TabIndex = 36;
            FullSetBonusGroupBox.TabStop = false;
            FullSetBonusGroupBox.Text = "     Full Set Bonus:";
            FullSetBonusGroupBox.Visible = false;
            // 
            // FullSetBonusPanel
            // 
            FullSetBonusPanel.AutoScroll = true;
            FullSetBonusPanel.Controls.Add(SlotGroupBox);
            FullSetBonusPanel.Controls.Add(HunterGrass);
            FullSetBonusPanel.Dock = DockStyle.Fill;
            FullSetBonusPanel.Location = new Point(3, 19);
            FullSetBonusPanel.Name = "FullSetBonusPanel";
            FullSetBonusPanel.Size = new Size(231, 534);
            FullSetBonusPanel.TabIndex = 35;
            // 
            // SlotGroupBox
            // 
            SlotGroupBox.Controls.Add(SlotComboBox);
            SlotGroupBox.Location = new Point(3, 477);
            SlotGroupBox.Name = "SlotGroupBox";
            SlotGroupBox.Size = new Size(225, 54);
            SlotGroupBox.TabIndex = 37;
            SlotGroupBox.TabStop = false;
            SlotGroupBox.Text = "Slot:";
            // 
            // SlotComboBox
            // 
            SlotComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            SlotComboBox.Font = new Font("Arial", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SlotComboBox.FormattingEnabled = true;
            SlotComboBox.Items.AddRange(new object[] { "head", "chest", "legs", "feet" });
            SlotComboBox.Location = new Point(6, 20);
            SlotComboBox.Name = "SlotComboBox";
            SlotComboBox.Size = new Size(213, 24);
            SlotComboBox.TabIndex = 1;
            SlotComboBox.SelectedIndexChanged += RarityComboBoxChanged;
            // 
            // HunterGrass
            // 
            HunterGrass.AutoSize = true;
            HunterGrass.BackColor = Color.Transparent;
            HunterGrass.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HunterGrass.ForeColor = SystemColors.ActiveCaptionText;
            HunterGrass.Location = new Point(3, 4);
            HunterGrass.Name = "HunterGrass";
            HunterGrass.Size = new Size(148, 29);
            HunterGrass.TabIndex = 33;
            HunterGrass.Text = "Hunter Grass";
            HunterGrass.UseVisualStyleBackColor = false;
            HunterGrass.CheckedChanged += AbilityChecks;
            // 
            // Icon15
            // 
            Icon15.AutoSize = true;
            Icon15.BackColor = Color.Transparent;
            Icon15.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon15.ForeColor = Color.Goldenrod;
            Icon15.Location = new Point(0, -3);
            Icon15.Name = "Icon15";
            Icon15.Size = new Size(33, 24);
            Icon15.TabIndex = 33;
            Icon15.Text = "🔥";
            // 
            // RightInputGroupBox
            // 
            RightInputGroupBox.Controls.Add(RightInputPanel);
            RightInputGroupBox.Controls.Add(Icon14);
            RightInputGroupBox.Location = new Point(294, 361);
            RightInputGroupBox.Name = "RightInputGroupBox";
            RightInputGroupBox.Size = new Size(237, 284);
            RightInputGroupBox.TabIndex = 6;
            RightInputGroupBox.TabStop = false;
            RightInputGroupBox.Text = "      Right Input:";
            // 
            // RightInputPanel
            // 
            RightInputPanel.AutoScroll = true;
            RightInputPanel.Controls.Add(PumpkinBlast);
            RightInputPanel.Controls.Add(Rage);
            RightInputPanel.Controls.Add(HeartAttack);
            RightInputPanel.Controls.Add(Gassy);
            RightInputPanel.Controls.Add(ManaWard);
            RightInputPanel.Controls.Add(MultiHit);
            RightInputPanel.Controls.Add(FiraBawl);
            RightInputPanel.Dock = DockStyle.Fill;
            RightInputPanel.Location = new Point(3, 19);
            RightInputPanel.Name = "RightInputPanel";
            RightInputPanel.Size = new Size(231, 262);
            RightInputPanel.TabIndex = 41;
            // 
            // PumpkinBlast
            // 
            PumpkinBlast.AutoSize = true;
            PumpkinBlast.BackColor = Color.Transparent;
            PumpkinBlast.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            PumpkinBlast.ForeColor = SystemColors.ActiveCaptionText;
            PumpkinBlast.Location = new Point(3, 157);
            PumpkinBlast.Name = "PumpkinBlast";
            PumpkinBlast.Size = new Size(159, 29);
            PumpkinBlast.TabIndex = 47;
            PumpkinBlast.Text = "Pumpkin Blast";
            PumpkinBlast.UseVisualStyleBackColor = false;
            PumpkinBlast.CheckedChanged += AbilityChecks;
            // 
            // Rage
            // 
            Rage.AutoSize = true;
            Rage.BackColor = Color.Transparent;
            Rage.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Rage.ForeColor = SystemColors.ActiveCaptionText;
            Rage.Location = new Point(3, 3);
            Rage.Name = "Rage";
            Rage.Size = new Size(75, 29);
            Rage.TabIndex = 41;
            Rage.Text = "Rage";
            Rage.UseVisualStyleBackColor = false;
            Rage.CheckedChanged += AbilityChecks;
            // 
            // HeartAttack
            // 
            HeartAttack.AutoSize = true;
            HeartAttack.BackColor = Color.Transparent;
            HeartAttack.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeartAttack.ForeColor = SystemColors.ActiveCaptionText;
            HeartAttack.Location = new Point(3, 130);
            HeartAttack.Name = "HeartAttack";
            HeartAttack.Size = new Size(144, 29);
            HeartAttack.TabIndex = 45;
            HeartAttack.Text = "Heart Attack";
            HeartAttack.UseVisualStyleBackColor = false;
            HeartAttack.CheckedChanged += AbilityChecks;
            // 
            // Gassy
            // 
            Gassy.AutoSize = true;
            Gassy.BackColor = Color.Transparent;
            Gassy.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Gassy.ForeColor = SystemColors.ActiveCaptionText;
            Gassy.Location = new Point(3, 54);
            Gassy.Name = "Gassy";
            Gassy.Size = new Size(81, 29);
            Gassy.TabIndex = 43;
            Gassy.Text = "Gassy";
            Gassy.UseVisualStyleBackColor = false;
            Gassy.CheckedChanged += AbilityChecks;
            // 
            // ManaWard
            // 
            ManaWard.AutoSize = true;
            ManaWard.BackColor = Color.Transparent;
            ManaWard.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            ManaWard.ForeColor = SystemColors.ActiveCaptionText;
            ManaWard.Location = new Point(3, 29);
            ManaWard.Name = "ManaWard";
            ManaWard.Size = new Size(134, 29);
            ManaWard.TabIndex = 42;
            ManaWard.Text = "Mana Ward";
            ManaWard.UseVisualStyleBackColor = false;
            ManaWard.CheckedChanged += AbilityChecks;
            // 
            // MultiHit
            // 
            MultiHit.AutoSize = true;
            MultiHit.BackColor = Color.Transparent;
            MultiHit.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            MultiHit.ForeColor = SystemColors.ActiveCaptionText;
            MultiHit.Location = new Point(3, 79);
            MultiHit.Name = "MultiHit";
            MultiHit.Size = new Size(109, 29);
            MultiHit.TabIndex = 44;
            MultiHit.Text = "Multi-hit";
            MultiHit.UseVisualStyleBackColor = false;
            MultiHit.CheckedChanged += AbilityChecks;
            // 
            // FiraBawl
            // 
            FiraBawl.AutoSize = true;
            FiraBawl.BackColor = Color.Transparent;
            FiraBawl.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            FiraBawl.ForeColor = Color.LightCoral;
            FiraBawl.Location = new Point(3, 104);
            FiraBawl.Name = "FiraBawl";
            FiraBawl.Size = new Size(143, 29);
            FiraBawl.TabIndex = 46;
            FiraBawl.Text = "~FIRA BAWL";
            FiraBawl.UseVisualStyleBackColor = false;
            FiraBawl.CheckedChanged += AbilityChecks;
            // 
            // Icon14
            // 
            Icon14.AutoSize = true;
            Icon14.BackColor = Color.Transparent;
            Icon14.Font = new Font("Arial", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Icon14.ForeColor = Color.Goldenrod;
            Icon14.Location = new Point(1, -3);
            Icon14.Name = "Icon14";
            Icon14.Size = new Size(33, 24);
            Icon14.TabIndex = 34;
            Icon14.Text = "🔥";
            // 
            // ExportGroupBox
            // 
            ExportGroupBox.Controls.Add(FilePathTextBox);
            ExportGroupBox.Controls.Add(SeperationBar);
            ExportGroupBox.Controls.Add(JsonTextBox);
            ExportGroupBox.Controls.Add(SaveButton);
            ExportGroupBox.Controls.Add(CopyClipboardButton);
            ExportGroupBox.Location = new Point(555, 12);
            ExportGroupBox.Name = "ExportGroupBox";
            ExportGroupBox.Size = new Size(375, 572);
            ExportGroupBox.TabIndex = 2;
            ExportGroupBox.TabStop = false;
            ExportGroupBox.Text = "Export:";
            // 
            // FilePathTextBox
            // 
            FilePathTextBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold);
            FilePathTextBox.Location = new Point(6, 31);
            FilePathTextBox.Name = "FilePathTextBox";
            FilePathTextBox.PlaceholderText = "(Full Directory Path) e.g. C:\\Users\\user\\OneDrive\\Desktop";
            FilePathTextBox.Size = new Size(363, 25);
            FilePathTextBox.TabIndex = 1;
            // 
            // SeperationBar
            // 
            SeperationBar.BackColor = SystemColors.ScrollBar;
            SeperationBar.Location = new Point(6, 143);
            SeperationBar.Name = "SeperationBar";
            SeperationBar.Size = new Size(363, 1);
            SeperationBar.TabIndex = 4;
            // 
            // JsonTextBox
            // 
            JsonTextBox.BackColor = Color.White;
            JsonTextBox.Font = new Font("Segoe UI Semibold", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            JsonTextBox.Location = new Point(6, 152);
            JsonTextBox.Multiline = true;
            JsonTextBox.Name = "JsonTextBox";
            JsonTextBox.PlaceholderText = "Generated json Goes Here";
            JsonTextBox.ReadOnly = true;
            JsonTextBox.ScrollBars = ScrollBars.Vertical;
            JsonTextBox.Size = new Size(363, 332);
            JsonTextBox.TabIndex = 1;
            JsonTextBox.WordWrap = false;
            // 
            // SaveButton
            // 
            SaveButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            SaveButton.Location = new Point(6, 62);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(363, 73);
            SaveButton.TabIndex = 1;
            SaveButton.Text = "Save to File";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveFile;
            // 
            // CopyClipboardButton
            // 
            CopyClipboardButton.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            CopyClipboardButton.Location = new Point(6, 490);
            CopyClipboardButton.Name = "CopyClipboardButton";
            CopyClipboardButton.Size = new Size(363, 73);
            CopyClipboardButton.TabIndex = 0;
            CopyClipboardButton.Text = "Copy to Clipboard";
            CopyClipboardButton.UseVisualStyleBackColor = true;
            CopyClipboardButton.Click += CopyToClipboard;
            // 
            // InfoGroupBox
            // 
            InfoGroupBox.Controls.Add(InfoTextLabel);
            InfoGroupBox.Location = new Point(555, 590);
            InfoGroupBox.Name = "InfoGroupBox";
            InfoGroupBox.Size = new Size(294, 73);
            InfoGroupBox.TabIndex = 3;
            InfoGroupBox.TabStop = false;
            InfoGroupBox.Text = "Info:";
            // 
            // InfoTextLabel
            // 
            InfoTextLabel.AutoSize = true;
            InfoTextLabel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            InfoTextLabel.Location = new Point(16, 22);
            InfoTextLabel.Name = "InfoTextLabel";
            InfoTextLabel.Size = new Size(262, 34);
            InfoTextLabel.TabIndex = 0;
            InfoTextLabel.Text = "An item generator for the dungeon \r\nrunner datapack! Exports in .json format!";
            // 
            // CreditsTextLabel
            // 
            CreditsTextLabel.AutoSize = true;
            CreditsTextLabel.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            CreditsTextLabel.Location = new Point(410, 663);
            CreditsTextLabel.Name = "CreditsTextLabel";
            CreditsTextLabel.Size = new Size(133, 21);
            CreditsTextLabel.TabIndex = 1;
            CreditsTextLabel.Text = "Made by: Parker";
            // 
            // VersionNum
            // 
            VersionNum.AutoSize = true;
            VersionNum.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            VersionNum.Location = new Point(12, 666);
            VersionNum.Name = "VersionNum";
            VersionNum.Size = new Size(55, 17);
            VersionNum.TabIndex = 4;
            VersionNum.Text = "v0.0.0.0";
            // 
            // Main
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(942, 689);
            Controls.Add(VersionNum);
            Controls.Add(CreditsTextLabel);
            Controls.Add(InfoGroupBox);
            Controls.Add(ExportGroupBox);
            Controls.Add(InputGroupBox);
            Controls.Add(Anvil);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Main";
            Text = "Anvil | Custom Item Gen";
            ((System.ComponentModel.ISupportInitialize)Anvil).EndInit();
            InputGroupBox.ResumeLayout(false);
            ItemGroupBox.ResumeLayout(false);
            DescriptionGroupBox.ResumeLayout(false);
            DescriptionGroupBox.PerformLayout();
            StatsGroupBox.ResumeLayout(false);
            StatsGroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)WisdomNumBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)LuckNumBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)ManaRegen).EndInit();
            ((System.ComponentModel.ISupportInitialize)ManaNumBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)SpeedNumBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DefenseNumBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)HealthRegenNumBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)HealthNumBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)AttackSpeedNumBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)DamageNumBox).EndInit();
            NameGroupBox.ResumeLayout(false);
            NameGroupBox.PerformLayout();
            RarityGroupBox.ResumeLayout(false);
            LeftInputGroupBox.ResumeLayout(false);
            LeftInputGroupBox.PerformLayout();
            LeftInputPanel.ResumeLayout(false);
            LeftInputPanel.PerformLayout();
            FullSetBonusGroupBox.ResumeLayout(false);
            FullSetBonusGroupBox.PerformLayout();
            FullSetBonusPanel.ResumeLayout(false);
            FullSetBonusPanel.PerformLayout();
            SlotGroupBox.ResumeLayout(false);
            RightInputGroupBox.ResumeLayout(false);
            RightInputGroupBox.PerformLayout();
            RightInputPanel.ResumeLayout(false);
            RightInputPanel.PerformLayout();
            ExportGroupBox.ResumeLayout(false);
            ExportGroupBox.PerformLayout();
            InfoGroupBox.ResumeLayout(false);
            InfoGroupBox.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox Anvil;
        private GroupBox InputGroupBox;
        private GroupBox ExportGroupBox;
        private GroupBox InfoGroupBox;
        private Label InfoTextLabel;
        private GroupBox RarityGroupBox;
        private ComboBox RarityComboBox;
        private GroupBox NameGroupBox;
        private TextBox NameTextBox;
        private GroupBox StatsGroupBox;
        private Button SaveButton;
        private Button CopyClipboardButton;
        private TextBox JsonTextBox;
        private NumericUpDown DamageNumBox;
        private CheckBox PrestigedCheckBox;
        private NumericUpDown WisdomNumBox;
        private NumericUpDown LuckNumBox;
        private NumericUpDown ManaRegen;
        private NumericUpDown ManaNumBox;
        private NumericUpDown SpeedNumBox;
        private NumericUpDown DefenseNumBox;
        private NumericUpDown HealthRegenNumBox;
        private NumericUpDown HealthNumBox;
        private NumericUpDown AttackSpeedNumBox;
        private Label DamageTextLabel;
        private Label Icon1;
        private Label Icon11;
        private Label WisdomTextLabel;
        private Label HealthRegenTextLabel;
        private Label LuckTextLabel;
        private Label ManaRegenTextLabel;
        private Label ManaTextLabel;
        private Label SpeedTextLabel;
        private Label DefenseTextLabel;
        private Label HealthTextLabel;
        private Label AttackSpeedTextLabel;
        private Label Icon10;
        private Label Icon9;
        private Label Icon8;
        private Label Icon7;
        private Label Icon6;
        private Label Icon5;
        private Label Icon4;
        private Label Icon3;
        private Label Icon2;
        private Label Icon12;
        private Panel SeperationBar;
        private GroupBox DescriptionGroupBox;
        private TextBox DescriptionTextBox;
        private GroupBox ItemGroupBox;
        private ComboBox ItemComboBox;
        private GroupBox RightInputGroupBox;
        private GroupBox LeftInputGroupBox;
        private TextBox FilePathTextBox;
        private Label CreditsTextLabel;
        private Label VersionNum;
        private Label Icon14;
        private Label Icon13;
        private CheckBox BadInfection;
        private CheckBox Stunning;
        private CheckBox Vampire;
        private CheckBox Assassin;
        private CheckBox FlameSacrifice;
        private CheckBox Chomp;
        private CheckBox ElectricBoogaloo;
        private Panel LeftInputPanel;
        private Panel RightInputPanel;
        private CheckBox PumpkinBlast;
        private CheckBox Rage;
        private CheckBox HeartAttack;
        private CheckBox Gassy;
        private CheckBox ManaWard;
        private CheckBox MultiHit;
        private CheckBox FiraBawl;
        private GroupBox FullSetBonusGroupBox;
        private Panel FullSetBonusPanel;
        private CheckBox HunterGrass;
        private Label Icon15;
        private GroupBox SlotGroupBox;
        private ComboBox SlotComboBox;
    }
}
