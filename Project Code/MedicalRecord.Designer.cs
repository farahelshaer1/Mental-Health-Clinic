
namespace WindowsFormsApp4
{
    partial class MedicalRecord
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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.prevmedCB = new System.Windows.Forms.ComboBox();
            this.prevdiagnosisCB = new System.Windows.Forms.ComboBox();
            this.painKillers = new System.Windows.Forms.CheckBox();
            this.cocaine = new System.Windows.Forms.CheckBox();
            this.herion = new System.Windows.Forms.CheckBox();
            this.marijuana = new System.Windows.Forms.CheckBox();
            this.tobacco = new System.Windows.Forms.CheckBox();
            this.alcohol = new System.Windows.Forms.CheckBox();
            this.Fatigue = new System.Windows.Forms.CheckBox();
            this.Avoidance = new System.Windows.Forms.CheckBox();
            this.Panic = new System.Windows.Forms.CheckBox();
            this.Appetite = new System.Windows.Forms.CheckBox();
            this.Sleep = new System.Windows.Forms.CheckBox();
            this.Loss = new System.Windows.Forms.CheckBox();
            this.Depression = new System.Windows.Forms.CheckBox();
            this.Anxiety = new System.Windows.Forms.CheckBox();
            this.noprevsuffer = new System.Windows.Forms.RadioButton();
            this.prevsuffer = new System.Windows.Forms.RadioButton();
            this.currmedtxt = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label30 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.ComplaintTxt = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.NationalCB = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button5 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.motherbad = new System.Windows.Forms.RadioButton();
            this.MotherTerms = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.fatherbad = new System.Windows.Forms.RadioButton();
            this.FatherTerms = new System.Windows.Forms.RadioButton();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.notdivorce = new System.Windows.Forms.RadioButton();
            this.divorce = new System.Windows.Forms.RadioButton();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.other = new System.Windows.Forms.RadioButton();
            this.both = new System.Windows.Forms.RadioButton();
            this.mother = new System.Windows.Forms.RadioButton();
            this.father = new System.Windows.Forms.RadioButton();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.notAdopted = new System.Windows.Forms.RadioButton();
            this.adopted = new System.Windows.Forms.RadioButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.notmarried = new System.Windows.Forms.RadioButton();
            this.married = new System.Windows.Forms.RadioButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // prevmedCB
            // 
            this.prevmedCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.prevmedCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.prevmedCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevmedCB.FormattingEnabled = true;
            this.prevmedCB.Items.AddRange(new object[] {
            "Antidepressants",
            "Anti-anxiety medications",
            "Mood-stabilizing medications",
            "Antipsychotic medications",
            "Other",
            "None"});
            this.prevmedCB.Location = new System.Drawing.Point(805, 680);
            this.prevmedCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prevmedCB.Name = "prevmedCB";
            this.prevmedCB.Size = new System.Drawing.Size(274, 28);
            this.prevmedCB.TabIndex = 184;
            this.prevmedCB.SelectedIndexChanged += new System.EventHandler(this.prevmedCB_SelectedIndexChanged);
            // 
            // prevdiagnosisCB
            // 
            this.prevdiagnosisCB.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.prevdiagnosisCB.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.prevdiagnosisCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevdiagnosisCB.FormattingEnabled = true;
            this.prevdiagnosisCB.Items.AddRange(new object[] {
            "Depression",
            "Anxiety",
            "Bipolar Affective Disorder (BAD)",
            "Borderline Personality Disorder (BPD)",
            "Schizophrenia",
            "Feeding and eating disorders",
            "Sleep-wake disorders",
            "Neurocognitive disorders",
            "Other mental disorders",
            "None"});
            this.prevdiagnosisCB.Location = new System.Drawing.Point(421, 680);
            this.prevdiagnosisCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.prevdiagnosisCB.Name = "prevdiagnosisCB";
            this.prevdiagnosisCB.Size = new System.Drawing.Size(274, 28);
            this.prevdiagnosisCB.TabIndex = 183;
            this.prevdiagnosisCB.SelectedIndexChanged += new System.EventHandler(this.prevdiagnosisCB_SelectedIndexChanged);
            // 
            // painKillers
            // 
            this.painKillers.AutoSize = true;
            this.painKillers.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.painKillers.Location = new System.Drawing.Point(748, 806);
            this.painKillers.Name = "painKillers";
            this.painKillers.Size = new System.Drawing.Size(116, 24);
            this.painKillers.TabIndex = 180;
            this.painKillers.Text = "Pain Killers";
            this.painKillers.UseVisualStyleBackColor = true;
            this.painKillers.CheckedChanged += new System.EventHandler(this.painKillers_CheckedChanged);
            // 
            // cocaine
            // 
            this.cocaine.AutoSize = true;
            this.cocaine.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cocaine.Location = new System.Drawing.Point(751, 768);
            this.cocaine.Name = "cocaine";
            this.cocaine.Size = new System.Drawing.Size(92, 24);
            this.cocaine.TabIndex = 179;
            this.cocaine.Text = "Cocaine";
            this.cocaine.UseVisualStyleBackColor = true;
            this.cocaine.CheckedChanged += new System.EventHandler(this.cocaine_CheckedChanged);
            // 
            // herion
            // 
            this.herion.AutoSize = true;
            this.herion.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.herion.Location = new System.Drawing.Point(531, 806);
            this.herion.Name = "herion";
            this.herion.Size = new System.Drawing.Size(81, 24);
            this.herion.TabIndex = 178;
            this.herion.Text = "Herion";
            this.herion.UseVisualStyleBackColor = true;
            this.herion.CheckedChanged += new System.EventHandler(this.herion_CheckedChanged);
            // 
            // marijuana
            // 
            this.marijuana.AutoSize = true;
            this.marijuana.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marijuana.Location = new System.Drawing.Point(531, 768);
            this.marijuana.Name = "marijuana";
            this.marijuana.Size = new System.Drawing.Size(104, 24);
            this.marijuana.TabIndex = 177;
            this.marijuana.Text = "Marijuana";
            this.marijuana.UseVisualStyleBackColor = true;
            this.marijuana.CheckedChanged += new System.EventHandler(this.marijuana_CheckedChanged);
            // 
            // tobacco
            // 
            this.tobacco.AutoSize = true;
            this.tobacco.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tobacco.Location = new System.Drawing.Point(343, 806);
            this.tobacco.Name = "tobacco";
            this.tobacco.Size = new System.Drawing.Size(90, 24);
            this.tobacco.TabIndex = 176;
            this.tobacco.Text = "tobacco";
            this.tobacco.UseVisualStyleBackColor = true;
            this.tobacco.CheckedChanged += new System.EventHandler(this.tobacco_CheckedChanged);
            // 
            // alcohol
            // 
            this.alcohol.AutoSize = true;
            this.alcohol.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.alcohol.Location = new System.Drawing.Point(343, 768);
            this.alcohol.Name = "alcohol";
            this.alcohol.Size = new System.Drawing.Size(86, 24);
            this.alcohol.TabIndex = 175;
            this.alcohol.Text = "Alcohol";
            this.alcohol.UseVisualStyleBackColor = true;
            this.alcohol.CheckedChanged += new System.EventHandler(this.alcohol_CheckedChanged);
            // 
            // Fatigue
            // 
            this.Fatigue.AutoSize = true;
            this.Fatigue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fatigue.Location = new System.Drawing.Point(836, 313);
            this.Fatigue.Name = "Fatigue";
            this.Fatigue.Size = new System.Drawing.Size(86, 24);
            this.Fatigue.TabIndex = 164;
            this.Fatigue.Text = "Fatigue";
            this.Fatigue.UseVisualStyleBackColor = true;
            this.Fatigue.CheckedChanged += new System.EventHandler(this.Fatigue_CheckedChanged);
            // 
            // Avoidance
            // 
            this.Avoidance.AutoSize = true;
            this.Avoidance.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Avoidance.Location = new System.Drawing.Point(836, 275);
            this.Avoidance.Name = "Avoidance";
            this.Avoidance.Size = new System.Drawing.Size(108, 24);
            this.Avoidance.TabIndex = 163;
            this.Avoidance.Text = "Avoidance";
            this.Avoidance.UseVisualStyleBackColor = true;
            this.Avoidance.CheckedChanged += new System.EventHandler(this.Avoidance_CheckedChanged);
            // 
            // Panic
            // 
            this.Panic.AutoSize = true;
            this.Panic.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Panic.Location = new System.Drawing.Point(617, 313);
            this.Panic.Name = "Panic";
            this.Panic.Size = new System.Drawing.Size(134, 24);
            this.Panic.TabIndex = 162;
            this.Panic.Text = "Panic Attacks";
            this.Panic.UseVisualStyleBackColor = true;
            this.Panic.CheckedChanged += new System.EventHandler(this.Panic_CheckedChanged);
            // 
            // Appetite
            // 
            this.Appetite.AutoSize = true;
            this.Appetite.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Appetite.Location = new System.Drawing.Point(620, 275);
            this.Appetite.Name = "Appetite";
            this.Appetite.Size = new System.Drawing.Size(146, 24);
            this.Appetite.TabIndex = 161;
            this.Appetite.Text = "Appetite Issues";
            this.Appetite.UseVisualStyleBackColor = true;
            this.Appetite.CheckedChanged += new System.EventHandler(this.Appetite_CheckedChanged);
            // 
            // Sleep
            // 
            this.Sleep.AutoSize = true;
            this.Sleep.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Sleep.Location = new System.Drawing.Point(384, 313);
            this.Sleep.Name = "Sleep";
            this.Sleep.Size = new System.Drawing.Size(144, 24);
            this.Sleep.TabIndex = 160;
            this.Sleep.Text = "Sleep Changes";
            this.Sleep.UseVisualStyleBackColor = true;
            this.Sleep.CheckedChanged += new System.EventHandler(this.Sleep_CheckedChanged);
            // 
            // Loss
            // 
            this.Loss.AutoSize = true;
            this.Loss.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loss.Location = new System.Drawing.Point(384, 275);
            this.Loss.Name = "Loss";
            this.Loss.Size = new System.Drawing.Size(148, 24);
            this.Loss.TabIndex = 159;
            this.Loss.Text = "Loss of interest";
            this.Loss.UseVisualStyleBackColor = true;
            this.Loss.CheckedChanged += new System.EventHandler(this.Loss_CheckedChanged);
            // 
            // Depression
            // 
            this.Depression.AutoSize = true;
            this.Depression.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Depression.Location = new System.Drawing.Point(196, 313);
            this.Depression.Name = "Depression";
            this.Depression.Size = new System.Drawing.Size(117, 24);
            this.Depression.TabIndex = 158;
            this.Depression.Text = "Depression";
            this.Depression.UseVisualStyleBackColor = true;
            this.Depression.CheckedChanged += new System.EventHandler(this.Depression_CheckedChanged);
            // 
            // Anxiety
            // 
            this.Anxiety.AutoSize = true;
            this.Anxiety.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Anxiety.Location = new System.Drawing.Point(196, 275);
            this.Anxiety.Name = "Anxiety";
            this.Anxiety.Size = new System.Drawing.Size(85, 24);
            this.Anxiety.TabIndex = 157;
            this.Anxiety.Text = "Anxiety";
            this.Anxiety.UseVisualStyleBackColor = true;
            // 
            // noprevsuffer
            // 
            this.noprevsuffer.AutoSize = true;
            this.noprevsuffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noprevsuffer.Location = new System.Drawing.Point(1066, 174);
            this.noprevsuffer.Name = "noprevsuffer";
            this.noprevsuffer.Size = new System.Drawing.Size(51, 24);
            this.noprevsuffer.TabIndex = 155;
            this.noprevsuffer.TabStop = true;
            this.noprevsuffer.Text = "No";
            this.noprevsuffer.UseVisualStyleBackColor = true;
            // 
            // prevsuffer
            // 
            this.prevsuffer.AutoSize = true;
            this.prevsuffer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prevsuffer.Location = new System.Drawing.Point(996, 174);
            this.prevsuffer.Name = "prevsuffer";
            this.prevsuffer.Size = new System.Drawing.Size(58, 24);
            this.prevsuffer.TabIndex = 154;
            this.prevsuffer.TabStop = true;
            this.prevsuffer.Text = "Yes";
            this.prevsuffer.UseVisualStyleBackColor = true;
            // 
            // currmedtxt
            // 
            this.currmedtxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.currmedtxt.Location = new System.Drawing.Point(46, 682);
            this.currmedtxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.currmedtxt.Name = "currmedtxt";
            this.currmedtxt.Size = new System.Drawing.Size(274, 27);
            this.currmedtxt.TabIndex = 149;
            this.currmedtxt.TextChanged += new System.EventHandler(this.currmedtxt_TextChanged);
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.Location = new System.Drawing.Point(805, 657);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(174, 20);
            this.label31.TabIndex = 148;
            this.label31.Text = "Previous medications:";
            this.label31.Click += new System.EventHandler(this.label31_Click_1);
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.Location = new System.Drawing.Point(417, 657);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(336, 20);
            this.label30.TabIndex = 147;
            this.label30.Text = "Previous diagnosis/mental health treatment:";
            this.label30.Click += new System.EventHandler(this.label30_Click);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(38, 657);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(327, 20);
            this.label29.TabIndex = 146;
            this.label29.Text = "What medications are you currently using?";
            this.label29.Click += new System.EventHandler(this.label29_Click);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.Location = new System.Drawing.Point(18, 421);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(134, 20);
            this.label27.TabIndex = 145;
            this.label27.Text = "Who rasied you?";
            this.label27.Click += new System.EventHandler(this.label27_Click);
            // 
            // ComplaintTxt
            // 
            this.ComplaintTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ComplaintTxt.Location = new System.Drawing.Point(307, 169);
            this.ComplaintTxt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ComplaintTxt.Name = "ComplaintTxt";
            this.ComplaintTxt.Size = new System.Drawing.Size(159, 27);
            this.ComplaintTxt.TabIndex = 144;
            this.ComplaintTxt.TextChanged += new System.EventHandler(this.ComplaintTxt_TextChanged);
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.Location = new System.Drawing.Point(345, 516);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(201, 20);
            this.label25.TabIndex = 141;
            this.label25.Text = "Did your parents divorce?";
            this.label25.Click += new System.EventHandler(this.label25_Click_1);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.Location = new System.Drawing.Point(38, 516);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(204, 20);
            this.label22.TabIndex = 139;
            this.label22.Text = "Are your parents married?";
            this.label22.Click += new System.EventHandler(this.label22_Click_1);
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.Location = new System.Drawing.Point(728, 421);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(318, 20);
            this.label20.TabIndex = 138;
            this.label20.Text = "How is your relationship with your father?";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(345, 421);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(327, 20);
            this.label19.TabIndex = 137;
            this.label19.Text = "How is your relationship with your mother?";
            // 
            // NationalCB
            // 
            this.NationalCB.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NationalCB.FormattingEnabled = true;
            this.NationalCB.Location = new System.Drawing.Point(499, 65);
            this.NationalCB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.NationalCB.Name = "NationalCB";
            this.NationalCB.Size = new System.Drawing.Size(170, 28);
            this.NationalCB.TabIndex = 135;
            this.NationalCB.SelectedIndexChanged += new System.EventHandler(this.NationalCB_SelectedIndexChanged);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(757, 516);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(162, 20);
            this.label17.TabIndex = 134;
            this.label17.Text = "Where you adopted?";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(562, 176);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(382, 20);
            this.label14.TabIndex = 133;
            this.label14.Text = "Have you previously suffered from this complaint?";
            this.label14.Click += new System.EventHandler(this.label14_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(45, 172);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(236, 20);
            this.label12.TabIndex = 131;
            this.label12.Text = "What is your major complaint?";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(528, 127);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(93, 20);
            this.label11.TabIndex = 130;
            this.label11.Text = "Complaint";
            this.label11.Click += new System.EventHandler(this.label11_Click_1);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(396, 68);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(83, 20);
            this.label10.TabIndex = 129;
            this.label10.Text = "Patient ID";
            this.label10.Click += new System.EventHandler(this.label10_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(406, 727);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(478, 20);
            this.label5.TabIndex = 128;
            this.label5.Text = "Have you ever tried the following? (check all that apply)";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(508, 379);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(131, 20);
            this.label4.TabIndex = 127;
            this.label4.Text = "Family History";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 237);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(351, 20);
            this.label3.TabIndex = 126;
            this.label3.Text = "Current Symptoms (Check all that apply)";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(519, 625);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(141, 20);
            this.label2.TabIndex = 125;
            this.label2.Text = "Medical History";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Malgun Gothic", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(481, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 23);
            this.label1.TabIndex = 124;
            this.label1.Text = "Personal Information";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button5.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))));
            this.button5.Location = new System.Drawing.Point(1009, 816);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(124, 53);
            this.button5.TabIndex = 185;
            this.button5.Text = "Save";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.button1.Font = new System.Drawing.Font("Tahoma", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(100)))), ((int)(((byte)(250)))));
            this.button1.Location = new System.Drawing.Point(46, 816);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 53);
            this.button1.TabIndex = 190;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.motherbad);
            this.groupBox1.Controls.Add(this.MotherTerms);
            this.groupBox1.Location = new System.Drawing.Point(343, 444);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(329, 66);
            this.groupBox1.TabIndex = 191;
            this.groupBox1.TabStop = false;
            // 
            // motherbad
            // 
            this.motherbad.AutoSize = true;
            this.motherbad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.motherbad.Location = new System.Drawing.Point(7, 31);
            this.motherbad.Name = "motherbad";
            this.motherbad.Size = new System.Drawing.Size(132, 24);
            this.motherbad.TabIndex = 189;
            this.motherbad.TabStop = true;
            this.motherbad.Text = "On bad terms";
            this.motherbad.UseVisualStyleBackColor = true;
            // 
            // MotherTerms
            // 
            this.MotherTerms.AutoSize = true;
            this.MotherTerms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MotherTerms.Location = new System.Drawing.Point(6, 1);
            this.MotherTerms.Name = "MotherTerms";
            this.MotherTerms.Size = new System.Drawing.Size(141, 24);
            this.MotherTerms.TabIndex = 188;
            this.MotherTerms.TabStop = true;
            this.MotherTerms.Text = "On good terms";
            this.MotherTerms.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.fatherbad);
            this.groupBox2.Controls.Add(this.FatherTerms);
            this.groupBox2.Location = new System.Drawing.Point(725, 444);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(329, 70);
            this.groupBox2.TabIndex = 192;
            this.groupBox2.TabStop = false;
            // 
            // fatherbad
            // 
            this.fatherbad.AutoSize = true;
            this.fatherbad.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fatherbad.Location = new System.Drawing.Point(6, 33);
            this.fatherbad.Name = "fatherbad";
            this.fatherbad.Size = new System.Drawing.Size(132, 24);
            this.fatherbad.TabIndex = 191;
            this.fatherbad.TabStop = true;
            this.fatherbad.Text = "On bad terms";
            this.fatherbad.UseVisualStyleBackColor = true;
            // 
            // FatherTerms
            // 
            this.FatherTerms.AutoSize = true;
            this.FatherTerms.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FatherTerms.Location = new System.Drawing.Point(5, 3);
            this.FatherTerms.Name = "FatherTerms";
            this.FatherTerms.Size = new System.Drawing.Size(141, 24);
            this.FatherTerms.TabIndex = 190;
            this.FatherTerms.TabStop = true;
            this.FatherTerms.Text = "On good terms";
            this.FatherTerms.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.notdivorce);
            this.groupBox3.Controls.Add(this.divorce);
            this.groupBox3.Location = new System.Drawing.Point(343, 534);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(284, 51);
            this.groupBox3.TabIndex = 192;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // notdivorce
            // 
            this.notdivorce.AutoSize = true;
            this.notdivorce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notdivorce.Location = new System.Drawing.Point(181, 21);
            this.notdivorce.Name = "notdivorce";
            this.notdivorce.Size = new System.Drawing.Size(51, 24);
            this.notdivorce.TabIndex = 172;
            this.notdivorce.TabStop = true;
            this.notdivorce.Text = "No";
            this.notdivorce.UseVisualStyleBackColor = true;
            // 
            // divorce
            // 
            this.divorce.AutoSize = true;
            this.divorce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divorce.Location = new System.Drawing.Point(52, 21);
            this.divorce.Name = "divorce";
            this.divorce.Size = new System.Drawing.Size(58, 24);
            this.divorce.TabIndex = 171;
            this.divorce.TabStop = true;
            this.divorce.Text = "Yes";
            this.divorce.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.other);
            this.groupBox4.Controls.Add(this.both);
            this.groupBox4.Controls.Add(this.mother);
            this.groupBox4.Controls.Add(this.father);
            this.groupBox4.Location = new System.Drawing.Point(12, 443);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(284, 71);
            this.groupBox4.TabIndex = 193;
            this.groupBox4.TabStop = false;
            // 
            // other
            // 
            this.other.AutoSize = true;
            this.other.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.other.Location = new System.Drawing.Point(124, 35);
            this.other.Name = "other";
            this.other.Size = new System.Drawing.Size(72, 24);
            this.other.TabIndex = 178;
            this.other.TabStop = true;
            this.other.Text = "Other";
            this.other.UseVisualStyleBackColor = true;
            // 
            // both
            // 
            this.both.AutoSize = true;
            this.both.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.both.Location = new System.Drawing.Point(124, 8);
            this.both.Name = "both";
            this.both.Size = new System.Drawing.Size(65, 24);
            this.both.TabIndex = 177;
            this.both.TabStop = true;
            this.both.Text = "Both";
            this.both.UseVisualStyleBackColor = true;
            // 
            // mother
            // 
            this.mother.AutoSize = true;
            this.mother.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mother.Location = new System.Drawing.Point(32, 35);
            this.mother.Name = "mother";
            this.mother.Size = new System.Drawing.Size(82, 24);
            this.mother.TabIndex = 176;
            this.mother.TabStop = true;
            this.mother.Text = "Mother";
            this.mother.UseVisualStyleBackColor = true;
            // 
            // father
            // 
            this.father.AutoSize = true;
            this.father.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.father.Location = new System.Drawing.Point(32, 8);
            this.father.Name = "father";
            this.father.Size = new System.Drawing.Size(78, 24);
            this.father.TabIndex = 175;
            this.father.TabStop = true;
            this.father.Text = "Father";
            this.father.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.notAdopted);
            this.groupBox5.Controls.Add(this.adopted);
            this.groupBox5.Location = new System.Drawing.Point(725, 534);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(284, 51);
            this.groupBox5.TabIndex = 193;
            this.groupBox5.TabStop = false;
            this.groupBox5.Enter += new System.EventHandler(this.groupBox5_Enter);
            // 
            // notAdopted
            // 
            this.notAdopted.AutoSize = true;
            this.notAdopted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notAdopted.Location = new System.Drawing.Point(165, 11);
            this.notAdopted.Name = "notAdopted";
            this.notAdopted.Size = new System.Drawing.Size(51, 24);
            this.notAdopted.TabIndex = 168;
            this.notAdopted.TabStop = true;
            this.notAdopted.Text = "No";
            this.notAdopted.UseVisualStyleBackColor = true;
            // 
            // adopted
            // 
            this.adopted.AutoSize = true;
            this.adopted.Enabled = false;
            this.adopted.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adopted.Location = new System.Drawing.Point(36, 11);
            this.adopted.Name = "adopted";
            this.adopted.Size = new System.Drawing.Size(58, 24);
            this.adopted.TabIndex = 167;
            this.adopted.TabStop = true;
            this.adopted.Text = "Yes";
            this.adopted.UseVisualStyleBackColor = true;
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.notmarried);
            this.groupBox7.Controls.Add(this.married);
            this.groupBox7.Location = new System.Drawing.Point(12, 534);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(284, 51);
            this.groupBox7.TabIndex = 194;
            this.groupBox7.TabStop = false;
            this.groupBox7.Enter += new System.EventHandler(this.groupBox7_Enter);
            // 
            // notmarried
            // 
            this.notmarried.AutoSize = true;
            this.notmarried.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.notmarried.Location = new System.Drawing.Point(165, 21);
            this.notmarried.Name = "notmarried";
            this.notmarried.Size = new System.Drawing.Size(51, 24);
            this.notmarried.TabIndex = 170;
            this.notmarried.TabStop = true;
            this.notmarried.Text = "No";
            this.notmarried.UseVisualStyleBackColor = true;
            // 
            // married
            // 
            this.married.AutoSize = true;
            this.married.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.married.Location = new System.Drawing.Point(37, 21);
            this.married.Name = "married";
            this.married.Size = new System.Drawing.Size(58, 24);
            this.married.TabIndex = 169;
            this.married.TabStop = true;
            this.married.Text = "Yes";
            this.married.UseVisualStyleBackColor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.icons8_close_50;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(1106, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(38, 34);
            this.pictureBox2.TabIndex = 69;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseHover += new System.EventHandler(this.pictureBox2_MouseHover);
            // 
            // MedicalRecord
            // 
            this.AccessibleName = "";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1156, 882);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.prevmedCB);
            this.Controls.Add(this.prevdiagnosisCB);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.painKillers);
            this.Controls.Add(this.cocaine);
            this.Controls.Add(this.herion);
            this.Controls.Add(this.marijuana);
            this.Controls.Add(this.tobacco);
            this.Controls.Add(this.alcohol);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.Fatigue);
            this.Controls.Add(this.Avoidance);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.Panic);
            this.Controls.Add(this.Appetite);
            this.Controls.Add(this.Sleep);
            this.Controls.Add(this.Loss);
            this.Controls.Add(this.Depression);
            this.Controls.Add(this.Anxiety);
            this.Controls.Add(this.noprevsuffer);
            this.Controls.Add(this.prevsuffer);
            this.Controls.Add(this.currmedtxt);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.ComplaintTxt);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.NationalCB);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MedicalRecord";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MedicalRecord";
            this.Load += new System.EventHandler(this.MedicalRecord_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.ComboBox prevmedCB;
        private System.Windows.Forms.ComboBox prevdiagnosisCB;
        private System.Windows.Forms.CheckBox painKillers;
        private System.Windows.Forms.CheckBox cocaine;
        private System.Windows.Forms.CheckBox herion;
        private System.Windows.Forms.CheckBox marijuana;
        private System.Windows.Forms.CheckBox tobacco;
        private System.Windows.Forms.CheckBox alcohol;
        private System.Windows.Forms.CheckBox Fatigue;
        private System.Windows.Forms.CheckBox Avoidance;
        private System.Windows.Forms.CheckBox Panic;
        private System.Windows.Forms.CheckBox Appetite;
        private System.Windows.Forms.CheckBox Sleep;
        private System.Windows.Forms.CheckBox Loss;
        private System.Windows.Forms.CheckBox Depression;
        private System.Windows.Forms.CheckBox Anxiety;
        private System.Windows.Forms.RadioButton noprevsuffer;
        private System.Windows.Forms.RadioButton prevsuffer;
        private System.Windows.Forms.TextBox currmedtxt;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.TextBox ComplaintTxt;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox NationalCB;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.RadioButton motherbad;
        private System.Windows.Forms.RadioButton MotherTerms;
        private System.Windows.Forms.RadioButton fatherbad;
        private System.Windows.Forms.RadioButton FatherTerms;
        private System.Windows.Forms.RadioButton notdivorce;
        private System.Windows.Forms.RadioButton divorce;
        private System.Windows.Forms.RadioButton other;
        private System.Windows.Forms.RadioButton both;
        private System.Windows.Forms.RadioButton mother;
        private System.Windows.Forms.RadioButton father;
        private System.Windows.Forms.RadioButton notAdopted;
        private System.Windows.Forms.RadioButton adopted;
        private System.Windows.Forms.RadioButton notmarried;
        private System.Windows.Forms.RadioButton married;
    }
}