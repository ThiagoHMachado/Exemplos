namespace CleanArchitectureCQRS.DeskTop
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            fluentDesignFormContainer1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer();
            tclRedis = new DevExpress.XtraTab.XtraTabControl();
            pgRedis = new DevExpress.XtraTab.XtraTabPage();
            groupBox2 = new GroupBox();
            btnGet = new DevExpress.XtraEditors.SimpleButton();
            txtGetValor = new TextBox();
            label3 = new Label();
            txtGetChave = new TextBox();
            label4 = new Label();
            groupBox1 = new GroupBox();
            btnRemover = new DevExpress.XtraEditors.SimpleButton();
            btnSetar = new DevExpress.XtraEditors.SimpleButton();
            txtValor = new TextBox();
            label2 = new Label();
            txtChave = new TextBox();
            label1 = new Label();
            pgApi = new DevExpress.XtraTab.XtraTabPage();
            groupBox3 = new GroupBox();
            btnSwagger = new DevExpress.XtraEditors.SimpleButton();
            accordionControl1 = new DevExpress.XtraBars.Navigation.AccordionControl();
            accordionControlElement1 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            accordionControlElement2 = new DevExpress.XtraBars.Navigation.AccordionControlElement();
            fluentDesignFormControl1 = new DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl();
            barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            fluentFormDefaultManager1 = new DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager(components);
            fluentDesignFormContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)tclRedis).BeginInit();
            tclRedis.SuspendLayout();
            pgRedis.SuspendLayout();
            groupBox2.SuspendLayout();
            groupBox1.SuspendLayout();
            pgApi.SuspendLayout();
            groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)accordionControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).BeginInit();
            SuspendLayout();
            // 
            // fluentDesignFormContainer1
            // 
            fluentDesignFormContainer1.Controls.Add(tclRedis);
            fluentDesignFormContainer1.Dock = DockStyle.Fill;
            fluentDesignFormContainer1.Location = new Point(260, 31);
            fluentDesignFormContainer1.Name = "fluentDesignFormContainer1";
            fluentDesignFormContainer1.Size = new Size(503, 513);
            fluentDesignFormContainer1.TabIndex = 0;
            // 
            // tclRedis
            // 
            tclRedis.Dock = DockStyle.Fill;
            tclRedis.Location = new Point(0, 0);
            tclRedis.Name = "tclRedis";
            tclRedis.SelectedTabPage = pgRedis;
            tclRedis.Size = new Size(503, 513);
            tclRedis.TabIndex = 0;
            tclRedis.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] { pgRedis, pgApi });
            // 
            // pgRedis
            // 
            pgRedis.Controls.Add(groupBox2);
            pgRedis.Controls.Add(groupBox1);
            pgRedis.Name = "pgRedis";
            pgRedis.Size = new Size(501, 488);
            pgRedis.Text = "Redis";
            // 
            // groupBox2
            // 
            groupBox2.Controls.Add(btnGet);
            groupBox2.Controls.Add(txtGetValor);
            groupBox2.Controls.Add(label3);
            groupBox2.Controls.Add(txtGetChave);
            groupBox2.Controls.Add(label4);
            groupBox2.Dock = DockStyle.Top;
            groupBox2.Location = new Point(0, 215);
            groupBox2.Name = "groupBox2";
            groupBox2.Size = new Size(501, 215);
            groupBox2.TabIndex = 3;
            groupBox2.TabStop = false;
            groupBox2.Text = "Get";
            // 
            // btnGet
            // 
            btnGet.Location = new Point(150, 178);
            btnGet.Name = "btnGet";
            btnGet.Size = new Size(128, 23);
            btnGet.TabIndex = 6;
            btnGet.Text = "Pegar";
            btnGet.Click += btnGet_Click;
            // 
            // txtGetValor
            // 
            txtGetValor.Location = new Point(77, 45);
            txtGetValor.Multiline = true;
            txtGetValor.Name = "txtGetValor";
            txtGetValor.ReadOnly = true;
            txtGetValor.Size = new Size(341, 121);
            txtGetValor.TabIndex = 5;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(10, 48);
            label3.Name = "label3";
            label3.Size = new Size(31, 13);
            label3.TabIndex = 4;
            label3.Text = "Valor";
            // 
            // txtGetChave
            // 
            txtGetChave.Location = new Point(77, 18);
            txtGetChave.Name = "txtGetChave";
            txtGetChave.Size = new Size(341, 21);
            txtGetChave.TabIndex = 3;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(10, 21);
            label4.Name = "label4";
            label4.Size = new Size(68, 13);
            label4.TabIndex = 2;
            label4.Text = "Nome Chave";
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(btnRemover);
            groupBox1.Controls.Add(btnSetar);
            groupBox1.Controls.Add(txtValor);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(txtChave);
            groupBox1.Controls.Add(label1);
            groupBox1.Dock = DockStyle.Top;
            groupBox1.Location = new Point(0, 0);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(501, 215);
            groupBox1.TabIndex = 2;
            groupBox1.TabStop = false;
            groupBox1.Text = "Setar";
            // 
            // btnRemover
            // 
            btnRemover.Location = new Point(284, 176);
            btnRemover.Name = "btnRemover";
            btnRemover.Size = new Size(128, 23);
            btnRemover.TabIndex = 8;
            btnRemover.Text = "Remover";
            btnRemover.Click += btnRemover_Click;
            // 
            // btnSetar
            // 
            btnSetar.Location = new Point(88, 176);
            btnSetar.Name = "btnSetar";
            btnSetar.Size = new Size(128, 23);
            btnSetar.TabIndex = 7;
            btnSetar.Text = "Setar";
            btnSetar.Click += btnSetar_Click;
            // 
            // txtValor
            // 
            txtValor.Location = new Point(77, 45);
            txtValor.Multiline = true;
            txtValor.Name = "txtValor";
            txtValor.Size = new Size(341, 121);
            txtValor.TabIndex = 5;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(10, 48);
            label2.Name = "label2";
            label2.Size = new Size(31, 13);
            label2.TabIndex = 4;
            label2.Text = "Valor";
            // 
            // txtChave
            // 
            txtChave.Location = new Point(77, 18);
            txtChave.Name = "txtChave";
            txtChave.Size = new Size(341, 21);
            txtChave.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(10, 21);
            label1.Name = "label1";
            label1.Size = new Size(68, 13);
            label1.TabIndex = 2;
            label1.Text = "Nome Chave";
            // 
            // pgApi
            // 
            pgApi.Controls.Add(groupBox3);
            pgApi.Name = "pgApi";
            pgApi.Size = new Size(501, 488);
            pgApi.Text = "API";
            // 
            // groupBox3
            // 
            groupBox3.Controls.Add(btnSwagger);
            groupBox3.Dock = DockStyle.Top;
            groupBox3.Location = new Point(0, 0);
            groupBox3.Name = "groupBox3";
            groupBox3.Size = new Size(501, 215);
            groupBox3.TabIndex = 3;
            groupBox3.TabStop = false;
            groupBox3.Text = "Swagger";
            
            // 
            // btnSwagger
            // 
            btnSwagger.Location = new Point(59, 19);
            btnSwagger.Name = "btnSwagger";
            btnSwagger.Size = new Size(128, 23);
            btnSwagger.TabIndex = 7;
            btnSwagger.Text = "Swagger";
            btnSwagger.Click += btnSwagger_Click;
            // 
            // accordionControl1
            // 
            accordionControl1.Dock = DockStyle.Left;
            accordionControl1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElement1 });
            accordionControl1.Location = new Point(0, 31);
            accordionControl1.Name = "accordionControl1";
            accordionControl1.ScrollBarMode = DevExpress.XtraBars.Navigation.ScrollBarMode.Touch;
            accordionControl1.Size = new Size(260, 513);
            accordionControl1.TabIndex = 1;
            accordionControl1.ViewType = DevExpress.XtraBars.Navigation.AccordionControlViewType.HamburgerMenu;
            // 
            // accordionControlElement1
            // 
            accordionControlElement1.Elements.AddRange(new DevExpress.XtraBars.Navigation.AccordionControlElement[] { accordionControlElement2 });
            accordionControlElement1.Expanded = true;
            accordionControlElement1.Name = "accordionControlElement1";
            accordionControlElement1.Text = "Redis";
            // 
            // accordionControlElement2
            // 
            accordionControlElement2.Name = "accordionControlElement2";
            accordionControlElement2.Style = DevExpress.XtraBars.Navigation.ElementStyle.Item;
            accordionControlElement2.Text = "Testar";
            accordionControlElement2.Click += accordionControlElement2_Click;
            // 
            // fluentDesignFormControl1
            // 
            fluentDesignFormControl1.FluentDesignForm = this;
            fluentDesignFormControl1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItem1 });
            fluentDesignFormControl1.Location = new Point(0, 0);
            fluentDesignFormControl1.Manager = fluentFormDefaultManager1;
            fluentDesignFormControl1.Name = "fluentDesignFormControl1";
            fluentDesignFormControl1.Size = new Size(763, 31);
            fluentDesignFormControl1.TabIndex = 2;
            fluentDesignFormControl1.TabStop = false;
            // 
            // barButtonItem1
            // 
            barButtonItem1.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            barButtonItem1.Caption = "barButtonItem1";
            barButtonItem1.Id = 0;
            barButtonItem1.Name = "barButtonItem1";
            // 
            // fluentFormDefaultManager1
            // 
            fluentFormDefaultManager1.Form = this;
            fluentFormDefaultManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] { barButtonItem1 });
            fluentFormDefaultManager1.MaxItemId = 1;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(6F, 13F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(763, 544);
            ControlContainer = fluentDesignFormContainer1;
            Controls.Add(fluentDesignFormContainer1);
            Controls.Add(accordionControl1);
            Controls.Add(fluentDesignFormControl1);
            FluentDesignFormControl = fluentDesignFormControl1;
            Name = "MainForm";
            NavigationControl = accordionControl1;
            Text = "MainForm";
            fluentDesignFormContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)tclRedis).EndInit();
            tclRedis.ResumeLayout(false);
            pgRedis.ResumeLayout(false);
            groupBox2.ResumeLayout(false);
            groupBox2.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            pgApi.ResumeLayout(false);
            groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)accordionControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fluentDesignFormControl1).EndInit();
            ((System.ComponentModel.ISupportInitialize)fluentFormDefaultManager1).EndInit();
            ResumeLayout(false);

        }

        #endregion
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormContainer fluentDesignFormContainer1;
        private DevExpress.XtraBars.Navigation.AccordionControl accordionControl1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentDesignFormControl fluentDesignFormControl1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement1;
        private DevExpress.XtraBars.FluentDesignSystem.FluentFormDefaultManager fluentFormDefaultManager1;
        private DevExpress.XtraBars.Navigation.AccordionControlElement accordionControlElement2;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraTab.XtraTabControl tclRedis;
        private DevExpress.XtraTab.XtraTabPage pgRedis;
        private GroupBox groupBox1;
        private GroupBox groupBox2;
        private TextBox txtGetValor;
        private Label label3;
        private TextBox txtGetChave;
        private Label label4;
        private TextBox txtValor;
        private Label label2;
        private TextBox txtChave;
        private Label label1;
        private DevExpress.XtraEditors.SimpleButton btnGet;
        private DevExpress.XtraEditors.SimpleButton btnSetar;
        private DevExpress.XtraEditors.SimpleButton btnRemover;
        private DevExpress.XtraTab.XtraTabPage pgApi;
        private GroupBox groupBox3;
        private DevExpress.XtraEditors.SimpleButton btnSwagger;
    }
}