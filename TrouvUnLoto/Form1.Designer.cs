namespace TrouvUnLoto
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.lbl_main_title = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.status_new = new System.Windows.Forms.RadioButton();
            this.status_used = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.txtb_take_back = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.radbtn_car_elect = new System.Windows.Forms.RadioButton();
            this.radbtn_car_gas = new System.Windows.Forms.RadioButton();
            this.radbtn_car_diesel = new System.Windows.Forms.RadioButton();
            this.numi_car_vr = new System.Windows.Forms.NumericUpDown();
            this.numi_car_monthly = new System.Windows.Forms.NumericUpDown();
            this.btn_add_car = new System.Windows.Forms.Button();
            this.txtb_car_name = new System.Windows.Forms.TextBox();
            this.listv_cars = new System.Windows.Forms.ListView();
            this.btn_gen_excel = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numi_car_vr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numi_car_monthly)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_main_title
            // 
            this.lbl_main_title.AutoSize = true;
            this.lbl_main_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 28.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_main_title.Location = new System.Drawing.Point(12, 9);
            this.lbl_main_title.Name = "lbl_main_title";
            this.lbl_main_title.Size = new System.Drawing.Size(181, 44);
            this.lbl_main_title.TabIndex = 0;
            this.lbl_main_title.Text = "Add a car";
            this.lbl_main_title.Click += new System.EventHandler(this.label1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Name";
            this.label1.Click += new System.EventHandler(this.label1_Click_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Monthly";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(22, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "VR";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 173);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(50, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Fuel type";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(3, 266);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Can take back";
            // 
            // status_new
            // 
            this.status_new.AutoSize = true;
            this.status_new.Location = new System.Drawing.Point(85, 14);
            this.status_new.Name = "status_new";
            this.status_new.Size = new System.Drawing.Size(47, 17);
            this.status_new.TabIndex = 7;
            this.status_new.TabStop = true;
            this.status_new.Text = "New";
            this.status_new.UseVisualStyleBackColor = true;
            this.status_new.CheckedChanged += new System.EventHandler(this.onChangeStatus);
            // 
            // status_used
            // 
            this.status_used.AutoSize = true;
            this.status_used.Location = new System.Drawing.Point(154, 14);
            this.status_used.Name = "status_used";
            this.status_used.Size = new System.Drawing.Size(50, 17);
            this.status_used.TabIndex = 8;
            this.status_used.TabStop = true;
            this.status_used.Text = "Used";
            this.status_used.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.status_new);
            this.groupBox1.Controls.Add(this.status_used);
            this.groupBox1.Location = new System.Drawing.Point(6, 118);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(204, 41);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 18);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(37, 13);
            this.label4.TabIndex = 15;
            this.label4.Text = "Status";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txtb_take_back);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.numi_car_vr);
            this.groupBox2.Controls.Add(this.numi_car_monthly);
            this.groupBox2.Controls.Add(this.btn_add_car);
            this.groupBox2.Controls.Add(this.txtb_car_name);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(20, 79);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(397, 311);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            // 
            // txtb_take_back
            // 
            this.txtb_take_back.Location = new System.Drawing.Point(110, 266);
            this.txtb_take_back.Name = "txtb_take_back";
            this.txtb_take_back.Size = new System.Drawing.Size(100, 20);
            this.txtb_take_back.TabIndex = 22;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.radbtn_car_elect);
            this.groupBox3.Controls.Add(this.radbtn_car_gas);
            this.groupBox3.Controls.Add(this.radbtn_car_diesel);
            this.groupBox3.Location = new System.Drawing.Point(110, 165);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(100, 85);
            this.groupBox3.TabIndex = 16;
            this.groupBox3.TabStop = false;
            // 
            // radbtn_car_elect
            // 
            this.radbtn_car_elect.AutoSize = true;
            this.radbtn_car_elect.Location = new System.Drawing.Point(16, 60);
            this.radbtn_car_elect.Name = "radbtn_car_elect";
            this.radbtn_car_elect.Size = new System.Drawing.Size(60, 17);
            this.radbtn_car_elect.TabIndex = 9;
            this.radbtn_car_elect.Text = "Electric";
            this.radbtn_car_elect.UseVisualStyleBackColor = true;
            this.radbtn_car_elect.CheckedChanged += new System.EventHandler(this.radioButton3_CheckedChanged);
            // 
            // radbtn_car_gas
            // 
            this.radbtn_car_gas.AutoSize = true;
            this.radbtn_car_gas.Checked = true;
            this.radbtn_car_gas.Location = new System.Drawing.Point(16, 14);
            this.radbtn_car_gas.Name = "radbtn_car_gas";
            this.radbtn_car_gas.Size = new System.Drawing.Size(44, 17);
            this.radbtn_car_gas.TabIndex = 7;
            this.radbtn_car_gas.TabStop = true;
            this.radbtn_car_gas.Text = "Gas";
            this.radbtn_car_gas.UseVisualStyleBackColor = true;
            // 
            // radbtn_car_diesel
            // 
            this.radbtn_car_diesel.AutoSize = true;
            this.radbtn_car_diesel.Location = new System.Drawing.Point(16, 37);
            this.radbtn_car_diesel.Name = "radbtn_car_diesel";
            this.radbtn_car_diesel.Size = new System.Drawing.Size(54, 17);
            this.radbtn_car_diesel.TabIndex = 8;
            this.radbtn_car_diesel.Text = "Diesel";
            this.radbtn_car_diesel.UseVisualStyleBackColor = true;
            // 
            // numi_car_vr
            // 
            this.numi_car_vr.Location = new System.Drawing.Point(110, 93);
            this.numi_car_vr.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numi_car_vr.Name = "numi_car_vr";
            this.numi_car_vr.Size = new System.Drawing.Size(100, 20);
            this.numi_car_vr.TabIndex = 21;
            // 
            // numi_car_monthly
            // 
            this.numi_car_monthly.Location = new System.Drawing.Point(110, 61);
            this.numi_car_monthly.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numi_car_monthly.Name = "numi_car_monthly";
            this.numi_car_monthly.Size = new System.Drawing.Size(100, 20);
            this.numi_car_monthly.TabIndex = 20;
            // 
            // btn_add_car
            // 
            this.btn_add_car.Location = new System.Drawing.Point(316, 26);
            this.btn_add_car.Name = "btn_add_car";
            this.btn_add_car.Size = new System.Drawing.Size(75, 269);
            this.btn_add_car.TabIndex = 15;
            this.btn_add_car.Text = "Add";
            this.btn_add_car.UseVisualStyleBackColor = true;
            this.btn_add_car.Click += new System.EventHandler(this.btn_add_car_Click);
            // 
            // txtb_car_name
            // 
            this.txtb_car_name.Location = new System.Drawing.Point(110, 26);
            this.txtb_car_name.Name = "txtb_car_name";
            this.txtb_car_name.Size = new System.Drawing.Size(100, 20);
            this.txtb_car_name.TabIndex = 10;
            // 
            // listv_cars
            // 
            this.listv_cars.FullRowSelect = true;
            this.listv_cars.Location = new System.Drawing.Point(438, 105);
            this.listv_cars.Name = "listv_cars";
            this.listv_cars.Size = new System.Drawing.Size(457, 253);
            this.listv_cars.TabIndex = 11;
            this.listv_cars.UseCompatibleStateImageBehavior = false;
            this.listv_cars.View = System.Windows.Forms.View.List;
            // 
            // btn_gen_excel
            // 
            this.btn_gen_excel.Location = new System.Drawing.Point(438, 365);
            this.btn_gen_excel.Name = "btn_gen_excel";
            this.btn_gen_excel.Size = new System.Drawing.Size(457, 23);
            this.btn_gen_excel.TabIndex = 18;
            this.btn_gen_excel.Text = "Generate Excel sheet";
            this.btn_gen_excel.UseVisualStyleBackColor = true;
            this.btn_gen_excel.Click += new System.EventHandler(this.btn_gen_excel_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(434, 82);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 20);
            this.label7.TabIndex = 18;
            this.label7.Text = "List of cars";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(907, 400);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btn_gen_excel);
            this.Controls.Add(this.listv_cars);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.lbl_main_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TrouvTonLoto";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numi_car_vr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numi_car_monthly)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_main_title;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RadioButton status_new;
        private System.Windows.Forms.RadioButton status_used;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.NumericUpDown numi_car_vr;
        private System.Windows.Forms.NumericUpDown numi_car_monthly;
        private System.Windows.Forms.Button btn_add_car;
        private System.Windows.Forms.TextBox txtb_car_name;
        private System.Windows.Forms.ListView listv_cars;
        private System.Windows.Forms.Button btn_gen_excel;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton radbtn_car_elect;
        private System.Windows.Forms.RadioButton radbtn_car_gas;
        private System.Windows.Forms.RadioButton radbtn_car_diesel;
        private System.Windows.Forms.TextBox txtb_take_back;
    }
}

